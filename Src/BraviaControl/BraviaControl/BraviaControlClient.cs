using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BraviaControl
{
    public partial class BraviaControlClient
    {
        private CookieContainer _cookieContainer = new CookieContainer();
        private string _deviceHostName;
        private string _clientId;
        private string _nickname;

        public ISystem System => this;
        public IAvContent AvContent => this;
        public IAccessControl AccessControl => this;
        public IEncryption Encryption => this;
        public IRecording Recording => this;
        public IBrowser Browser => this;
        public IAppControl AppControl => this;
        public IAudio Audio => this;
        public IGuide Guide => this;
        public ICec Cec => this;
        public IBroadcastLink BroadcastLink => this;
        public IVideoScreen VideoScreen => this;

        public BraviaControlClient(string deviceHostName, string clientId, string nickname, string authKey)
        {
            if (String.IsNullOrWhiteSpace(deviceHostName)) throw new ArgumentNullException(nameof(deviceHostName));
            if (String.IsNullOrWhiteSpace(clientId)) throw new ArgumentNullException(nameof(clientId));
            if (String.IsNullOrWhiteSpace(nickname)) throw new ArgumentNullException(nameof(nickname));

            _deviceHostName = deviceHostName;
            _clientId = clientId;
            _nickname = nickname;

            _cookieContainer.Add(new Cookie("auth", authKey, "/sony", deviceHostName));
        }

        /// <summary>
        /// Request PIN code on the host device.
        /// </summary>
        /// <returns></returns>
        public async Task<bool> RequestPinAsync()
        {
            try
            {
                await AccessControl
                    .ActRegisterAsync(new ActRegisterRequest(_clientId, _nickname, "private"),
                        new[] {new ActRegister1Request("WOL", "yes")})
                    .ConfigureAwait(false);
            }
            catch (BraviaApiException ex)
            {
                if (ex.ErrorId == 401)
                {
                    return true;
                }
                else
                {
                    throw;
                }
            }
            return false;
        }

        /// <summary>
        /// Register a client to the host device.
        /// </summary>
        /// <param name="pinCode"></param>
        /// <returns></returns>
        public async Task<string> RegisterAsync(string pinCode)
        {
            using (var httpClient = CreateHttpClient())
            {
                httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(new UTF8Encoding().GetBytes(":" + pinCode)));

                await InvokeAsync(httpClient,
                    "accessControl", "actRegister", 1, "1.0",
                    new object[]
                    {
                        new ActRegisterRequest(_clientId, _nickname, "private"),
                        new [] { new ActRegister1Request("WOL", "yes") }
                    })
                    .ConfigureAwait(false);

                var authKey = _cookieContainer
                        .GetCookies(new Uri($"http://{_deviceHostName}/sony/"))
                        .OfType<Cookie>()
                        .First(x => x.Name == "auth")
                        .Value;

                _cookieContainer = new CookieContainer();
                _cookieContainer.Add(new Cookie("auth", authKey, "/sony", _deviceHostName));

                return authKey;
            }
        }

        /// <summary>
        /// Renew auth cookie for the client.
        /// </summary>
        /// <returns></returns>
        public async Task<string> RenewAuthKeyAsync()
        {
            return await RegisterAsync("").ConfigureAwait(false);
        }

        /// <summary>
        /// Send IRCC Command
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public async Task SendIrccAsync(string code)
        {
            using (var httpClient = CreateHttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("SOAPACTION", "\"urn:schemas-sony-com:service:IRCC:1#X_SendIRCC\"");

                var endpointUrl = $"http://{_deviceHostName}/sony/IRCC";
                var response = await httpClient.PostAsync(endpointUrl, new StringContent(
    $@"<?xml version=""1.0""?>
<s:Envelope xmlns:s=""http://schemas.xmlsoap.org/soap/envelope/"" s:encodingStyle=""http://schemas.xmlsoap.org/soap/encoding/"">
  <s:Body>
    <u:X_SendIRCC xmlns:u=""urn:schemas-sony-com:service:IRCC:1"">
      <IRCCCode>{code}</IRCCCode>
    </u:X_SendIRCC>
  </s:Body>
</s:Envelope>")).ConfigureAwait(false);
            }
        }

        protected virtual HttpClient CreateHttpClient()
        {
            return new HttpClient(new HttpClientHandler() { CookieContainer = _cookieContainer, UseCookies = true });
        }

        protected async Task InvokeAsync(string path, string method, int id, string version, object[] args)
        {
            using (var httpClient = CreateHttpClient())
            {
                await InvokeAsync(httpClient, path, method, id, version, args).ConfigureAwait(false);
            }
        }

        protected async Task InvokeAsync(HttpClient httpClient, string path, string method, int id, string version, object[] args)
        {
            var jsonData = JsonConvert.SerializeObject(new
            {
                @method = method,
                @params = args,
                @id = id,
                @version = version,
            });

            var endpointUrl = $"http://{_deviceHostName}/sony/{path}";
            var response = await httpClient.PostAsync(endpointUrl, new StringContent(jsonData)).ConfigureAwait(false);
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var responseData = (JObject)JsonConvert.DeserializeObject(responseBody);

            var error = responseData.GetValue("error");
            if (error != null)
            {
                throw new BraviaApiException((int)error[0], (string)error[1]);
            }
        }

        protected async Task<TResponse> InvokeAsync<TResponse>(string path, string method, int id, string version, object[] args)
        {
            using (var httpClient = CreateHttpClient())
            {
                return await InvokeAsync<TResponse>(httpClient, path, method, id, version, args).ConfigureAwait(false);
            }
        }

        protected async Task<TResponse> InvokeAsync<TResponse>(HttpClient httpClient, string path, string method, int id, string version, object[] args)
        {
            var jsonData = JsonConvert.SerializeObject(new
            {
                @method = method,
                @params = args,
                @id = id,
                @version = version,
            });

            var endpointUrl = $"http://{_deviceHostName}/sony/{path}";
            var response = await httpClient.PostAsync(endpointUrl, new StringContent(jsonData)).ConfigureAwait(false);
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            var responseData = (JObject)JsonConvert.DeserializeObject(responseBody);

            var error = responseData.GetValue("error");
            if (error != null)
            {
                throw new BraviaApiException((int)error[0], (string)error[1]);
            }

            var results = responseData.GetValue("results");
            if (results != null)
            {
                return (TResponse)results.ToObject(typeof(TResponse));
            }
            else
            {
                if (typeof(ICompositeResponse).IsAssignableFrom(typeof(TResponse)))
                {
                    var obj = Activator.CreateInstance<TResponse>() as ICompositeResponse;
                    obj.ReadFromJson((JArray)responseData.GetValue("result"));
                    return (TResponse)obj;
                }
                else
                {
                    return (TResponse)responseData.GetValue("result").First().ToObject(typeof(TResponse));
                }
            }
        }
    }
}
