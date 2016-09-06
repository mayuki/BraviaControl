using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace BraviaControl
{
    public partial class BraviaControlClient :
        BraviaControlClient.ISystem,
        BraviaControlClient.IAvContent,
        BraviaControlClient.IAccessControl,
        BraviaControlClient.IEncryption,
        BraviaControlClient.IRecording,
        BraviaControlClient.IBrowser,
        BraviaControlClient.IAppControl,
        BraviaControlClient.IAudio,
        BraviaControlClient.IGuide,
        BraviaControlClient.ICec,
        BraviaControlClient.IBroadcastLink,
        BraviaControlClient.IVideoScreen
    {
        #region Implementation
        #region ISystem
        Task<System.String> ISystem.GetCurrentTimeAsync() { return InvokeAsync<System.String>("system", "getCurrentTime", 1, "1.0", new object[] { }); }
        Task<GetDeviceModeResponse> ISystem.GetDeviceModeAsync(GetDeviceModeRequest @arg0) { return InvokeAsync<GetDeviceModeResponse>("system", "getDeviceMode", 1, "1.0", new object[] { @arg0 }); }
        Task<GetDeviceModeResponse> ISystem.GetDeviceModeAsync(System.String value) { return ((ISystem)this).GetDeviceModeAsync(new GetDeviceModeRequest(value)); }
        Task<GetInterfaceInformationResponse> ISystem.GetInterfaceInformationAsync() { return InvokeAsync<GetInterfaceInformationResponse>("system", "getInterfaceInformation", 1, "1.0", new object[] { }); }
        Task<GetLEDIndicatorStatusResponse> ISystem.GetLEDIndicatorStatusAsync() { return InvokeAsync<GetLEDIndicatorStatusResponse>("system", "getLEDIndicatorStatus", 1, "1.0", new object[] { }); }
        Task<GetNetworkSettingsResponse[]> ISystem.GetNetworkSettingsAsync(GetNetworkSettingsRequest @arg0) { return InvokeAsync<GetNetworkSettingsResponse[]>("system", "getNetworkSettings", 1, "1.0", new object[] { @arg0 }); }
        Task<GetNetworkSettingsResponse[]> ISystem.GetNetworkSettingsAsync(System.String netif) { return ((ISystem)this).GetNetworkSettingsAsync(new GetNetworkSettingsRequest(netif)); }
        Task<GetPowerSavingModeResponse> ISystem.GetPowerSavingModeAsync() { return InvokeAsync<GetPowerSavingModeResponse>("system", "getPowerSavingMode", 1, "1.0", new object[] { }); }
        Task<GetPowerStatusResponse> ISystem.GetPowerStatusAsync() { return InvokeAsync<GetPowerStatusResponse>("system", "getPowerStatus", 1, "1.0", new object[] { }); }
        Task<GetRemoteControllerInfoCompositeResponse> ISystem.GetRemoteControllerInfoAsync() { return InvokeAsync<GetRemoteControllerInfoCompositeResponse>("system", "getRemoteControllerInfo", 1, "1.0", new object[] { }); }
        Task<GetRemoteDeviceSettingsResponse[]> ISystem.GetRemoteDeviceSettingsAsync(GetRemoteDeviceSettingsRequest @arg0) { return InvokeAsync<GetRemoteDeviceSettingsResponse[]>("system", "getRemoteDeviceSettings", 1, "1.0", new object[] { @arg0 }); }
        Task<GetRemoteDeviceSettingsResponse[]> ISystem.GetRemoteDeviceSettingsAsync(System.String target) { return ((ISystem)this).GetRemoteDeviceSettingsAsync(new GetRemoteDeviceSettingsRequest(target)); }
        Task<GetSystemInformationResponse> ISystem.GetSystemInformationAsync() { return InvokeAsync<GetSystemInformationResponse>("system", "getSystemInformation", 1, "1.0", new object[] { }); }
        Task<GetSystemSupportedFunctionResponse[]> ISystem.GetSystemSupportedFunctionAsync() { return InvokeAsync<GetSystemSupportedFunctionResponse[]>("system", "getSystemSupportedFunction", 1, "1.0", new object[] { }); }
        Task<GetWolModeResponse> ISystem.GetWolModeAsync() { return InvokeAsync<GetWolModeResponse>("system", "getWolMode", 1, "1.0", new object[] { }); }
        Task ISystem.RequestRebootAsync() { return InvokeAsync("system", "requestReboot", 1, "1.0", new object[] { }); }
        Task ISystem.SetDeviceModeAsync(SetDeviceModeRequest @arg0) { return InvokeAsync("system", "setDeviceMode", 1, "1.0", new object[] { @arg0 }); }
        Task ISystem.SetDeviceModeAsync(System.String value, System.Boolean isOn) { return ((ISystem)this).SetDeviceModeAsync(new SetDeviceModeRequest(value, isOn)); }
        Task ISystem.SetLanguageAsync(SetLanguageRequest @arg0) { return InvokeAsync("system", "setLanguage", 1, "1.0", new object[] { @arg0 }); }
        Task ISystem.SetLanguageAsync(System.String language) { return ((ISystem)this).SetLanguageAsync(new SetLanguageRequest(language)); }
        Task ISystem.SetPowerSavingModeAsync(SetPowerSavingModeRequest @arg0) { return InvokeAsync("system", "setPowerSavingMode", 1, "1.0", new object[] { @arg0 }); }
        Task ISystem.SetPowerSavingModeAsync(System.String mode) { return ((ISystem)this).SetPowerSavingModeAsync(new SetPowerSavingModeRequest(mode)); }
        Task ISystem.SetPowerStatusAsync(SetPowerStatusRequest @arg0) { return InvokeAsync("system", "setPowerStatus", 1, "1.0", new object[] { @arg0 }); }
        Task ISystem.SetPowerStatusAsync(System.Boolean status) { return ((ISystem)this).SetPowerStatusAsync(new SetPowerStatusRequest(status)); }
        Task ISystem.SetWolModeAsync(SetWolModeRequest @arg0) { return InvokeAsync("system", "setWolMode", 1, "1.0", new object[] { @arg0 }); }
        Task ISystem.SetWolModeAsync(System.Boolean enabled) { return ((ISystem)this).SetWolModeAsync(new SetWolModeRequest(enabled)); }
        Task<System.String[]> ISystem.GetVersionsAsync() { return InvokeAsync<System.String[]>("system", "getVersions", 1, "1.0", new object[] { }); }
        //Task<GetCurrentTimeResponse> ISystem.GetCurrentTimeAsync() { return InvokeAsync<GetCurrentTimeResponse>("system", "getCurrentTime", 1, "1.1", new object[] { }); }
        Task ISystem.SetLEDIndicatorStatusAsync(SetLEDIndicatorStatusRequest @arg0) { return InvokeAsync("system", "setLEDIndicatorStatus", 1, "1.1", new object[] { @arg0 }); }
        Task ISystem.SetLEDIndicatorStatusAsync(System.String mode, System.String status) { return ((ISystem)this).SetLEDIndicatorStatusAsync(new SetLEDIndicatorStatusRequest(mode, status)); }

        public interface ISystem
        {
            Task<System.String> GetCurrentTimeAsync();
            Task<GetDeviceModeResponse> GetDeviceModeAsync(GetDeviceModeRequest @arg0);
            Task<GetDeviceModeResponse> GetDeviceModeAsync(System.String @value);
            Task<GetInterfaceInformationResponse> GetInterfaceInformationAsync();
            Task<GetLEDIndicatorStatusResponse> GetLEDIndicatorStatusAsync();
            Task<GetNetworkSettingsResponse[]> GetNetworkSettingsAsync(GetNetworkSettingsRequest @arg0);
            Task<GetNetworkSettingsResponse[]> GetNetworkSettingsAsync(System.String @netif);
            Task<GetPowerSavingModeResponse> GetPowerSavingModeAsync();
            Task<GetPowerStatusResponse> GetPowerStatusAsync();
            Task<GetRemoteControllerInfoCompositeResponse> GetRemoteControllerInfoAsync();
            Task<GetRemoteDeviceSettingsResponse[]> GetRemoteDeviceSettingsAsync(GetRemoteDeviceSettingsRequest @arg0);
            Task<GetRemoteDeviceSettingsResponse[]> GetRemoteDeviceSettingsAsync(System.String @target);
            Task<GetSystemInformationResponse> GetSystemInformationAsync();
            Task<GetSystemSupportedFunctionResponse[]> GetSystemSupportedFunctionAsync();
            Task<GetWolModeResponse> GetWolModeAsync();
            Task RequestRebootAsync();
            Task SetDeviceModeAsync(SetDeviceModeRequest @arg0);
            Task SetDeviceModeAsync(System.String @value, System.Boolean @isOn);
            Task SetLanguageAsync(SetLanguageRequest @arg0);
            Task SetLanguageAsync(System.String @language);
            Task SetPowerSavingModeAsync(SetPowerSavingModeRequest @arg0);
            Task SetPowerSavingModeAsync(System.String @mode);
            Task SetPowerStatusAsync(SetPowerStatusRequest @arg0);
            Task SetPowerStatusAsync(System.Boolean @status);
            Task SetWolModeAsync(SetWolModeRequest @arg0);
            Task SetWolModeAsync(System.Boolean @enabled);
            Task<System.String[]> GetVersionsAsync();
            //Task<GetCurrentTimeResponse> GetCurrentTimeAsync();
            Task SetLEDIndicatorStatusAsync(SetLEDIndicatorStatusRequest @arg0);
            Task SetLEDIndicatorStatusAsync(System.String @mode, System.String @status);
        }

        public class GetDeviceModeRequest
        {
            [JsonProperty("value")]
            public System.String Value { get; set; }
            public GetDeviceModeRequest() { }
            public GetDeviceModeRequest(System.String @value)
            {
                this.Value = @value;
            }
        }
        public class GetDeviceModeResponse
        {
            [JsonProperty("isOn")]
            public System.Boolean IsOn { get; set; }
            public GetDeviceModeResponse() { }
            public GetDeviceModeResponse(System.Boolean @isOn)
            {
                this.IsOn = @isOn;
            }
        }
        public class GetInterfaceInformationResponse
        {
            [JsonProperty("productCategory")]
            public System.String ProductCategory { get; set; }
            [JsonProperty("productName")]
            public System.String ProductName { get; set; }
            [JsonProperty("modelName")]
            public System.String ModelName { get; set; }
            [JsonProperty("serverName")]
            public System.String ServerName { get; set; }
            [JsonProperty("interfaceVersion")]
            public System.String InterfaceVersion { get; set; }
            public GetInterfaceInformationResponse() { }
            public GetInterfaceInformationResponse(System.String @productCategory, System.String @productName, System.String @modelName, System.String @serverName, System.String @interfaceVersion)
            {
                this.ProductCategory = @productCategory;
                this.ProductName = @productName;
                this.ModelName = @modelName;
                this.ServerName = @serverName;
                this.InterfaceVersion = @interfaceVersion;
            }
        }
        public class GetLEDIndicatorStatusResponse
        {
            [JsonProperty("mode")]
            public System.String Mode { get; set; }
            [JsonProperty("status")]
            public System.String Status { get; set; }
            public GetLEDIndicatorStatusResponse() { }
            public GetLEDIndicatorStatusResponse(System.String @mode, System.String @status)
            {
                this.Mode = @mode;
                this.Status = @status;
            }
        }
        public class GetNetworkSettingsRequest
        {
            [JsonProperty("netif")]
            public System.String Netif { get; set; }
            public GetNetworkSettingsRequest() { }
            public GetNetworkSettingsRequest(System.String @netif)
            {
                this.Netif = @netif;
            }
        }
        public class GetNetworkSettingsResponse
        {
            [JsonProperty("netif")]
            public System.String Netif { get; set; }
            [JsonProperty("hwAddr")]
            public System.String HwAddr { get; set; }
            [JsonProperty("ipAddrV4")]
            public System.String IpAddrV4 { get; set; }
            [JsonProperty("ipAddrV6")]
            public System.String IpAddrV6 { get; set; }
            [JsonProperty("netmask")]
            public System.String Netmask { get; set; }
            [JsonProperty("gateway")]
            public System.String Gateway { get; set; }
            [JsonProperty("dns")]
            public System.String[] Dns { get; set; }
            public GetNetworkSettingsResponse() { }
            public GetNetworkSettingsResponse(System.String @netif, System.String @hwAddr, System.String @ipAddrV4, System.String @ipAddrV6, System.String @netmask, System.String @gateway, System.String[] @dns)
            {
                this.Netif = @netif;
                this.HwAddr = @hwAddr;
                this.IpAddrV4 = @ipAddrV4;
                this.IpAddrV6 = @ipAddrV6;
                this.Netmask = @netmask;
                this.Gateway = @gateway;
                this.Dns = @dns;
            }
        }
        public class GetPowerSavingModeResponse
        {
            [JsonProperty("mode")]
            public System.String Mode { get; set; }
            public GetPowerSavingModeResponse() { }
            public GetPowerSavingModeResponse(System.String @mode)
            {
                this.Mode = @mode;
            }
        }
        public class GetPowerStatusResponse
        {
            [JsonProperty("status")]
            public System.String Status { get; set; }
            public GetPowerStatusResponse() { }
            public GetPowerStatusResponse(System.String @status)
            {
                this.Status = @status;
            }
        }
        public class GetRemoteControllerInfoResponse
        {
            [JsonProperty("bundled")]
            public System.Boolean Bundled { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            public GetRemoteControllerInfoResponse() { }
            public GetRemoteControllerInfoResponse(System.Boolean @bundled, System.String @type)
            {
                this.Bundled = @bundled;
                this.Type = @type;
            }
        }
        public class GetRemoteControllerInfo1Response
        {
            [JsonProperty("name")]
            public System.String Name { get; set; }
            [JsonProperty("value")]
            public System.String Value { get; set; }
            public GetRemoteControllerInfo1Response() { }
            public GetRemoteControllerInfo1Response(System.String @name, System.String @value)
            {
                this.Name = @name;
                this.Value = @value;
            }
        }
        public class GetRemoteDeviceSettingsRequest
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            public GetRemoteDeviceSettingsRequest() { }
            public GetRemoteDeviceSettingsRequest(System.String @target)
            {
                this.Target = @target;
            }
        }
        public class GetRemoteDeviceSettingsResponse
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            [JsonProperty("currentValue")]
            public System.String CurrentValue { get; set; }
            [JsonProperty("deviceUIInfo")]
            public System.String DeviceUIInfo { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("titleTextID")]
            public System.String TitleTextID { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("isAvailable")]
            public System.Boolean IsAvailable { get; set; }
            [JsonProperty("candidate")]
            public System.Object[] Candidate { get; set; }
            public GetRemoteDeviceSettingsResponse() { }
            public GetRemoteDeviceSettingsResponse(System.String @target, System.String @currentValue, System.String @deviceUIInfo, System.String @title, System.String @titleTextID, System.String @type, System.Boolean @isAvailable, System.Object[] @candidate)
            {
                this.Target = @target;
                this.CurrentValue = @currentValue;
                this.DeviceUIInfo = @deviceUIInfo;
                this.Title = @title;
                this.TitleTextID = @titleTextID;
                this.Type = @type;
                this.IsAvailable = @isAvailable;
                this.Candidate = @candidate;
            }
        }
        public class GetSystemInformationResponse
        {
            [JsonProperty("product")]
            public System.String Product { get; set; }
            [JsonProperty("region")]
            public System.String Region { get; set; }
            [JsonProperty("language")]
            public System.String Language { get; set; }
            [JsonProperty("model")]
            public System.String Model { get; set; }
            [JsonProperty("serial")]
            public System.String Serial { get; set; }
            [JsonProperty("macAddr")]
            public System.String MacAddr { get; set; }
            [JsonProperty("name")]
            public System.String Name { get; set; }
            [JsonProperty("generation")]
            public System.String Generation { get; set; }
            [JsonProperty("area")]
            public System.String Area { get; set; }
            [JsonProperty("cid")]
            public System.String Cid { get; set; }
            public GetSystemInformationResponse() { }
            public GetSystemInformationResponse(System.String @product, System.String @region, System.String @language, System.String @model, System.String @serial, System.String @macAddr, System.String @name, System.String @generation, System.String @area, System.String @cid)
            {
                this.Product = @product;
                this.Region = @region;
                this.Language = @language;
                this.Model = @model;
                this.Serial = @serial;
                this.MacAddr = @macAddr;
                this.Name = @name;
                this.Generation = @generation;
                this.Area = @area;
                this.Cid = @cid;
            }
        }
        public class GetSystemSupportedFunctionResponse
        {
            [JsonProperty("option")]
            public System.String Option { get; set; }
            [JsonProperty("value")]
            public System.String Value { get; set; }
            public GetSystemSupportedFunctionResponse() { }
            public GetSystemSupportedFunctionResponse(System.String @option, System.String @value)
            {
                this.Option = @option;
                this.Value = @value;
            }
        }
        public class GetWolModeResponse
        {
            [JsonProperty("enabled")]
            public System.Boolean Enabled { get; set; }
            public GetWolModeResponse() { }
            public GetWolModeResponse(System.Boolean @enabled)
            {
                this.Enabled = @enabled;
            }
        }
        public class SetDeviceModeRequest
        {
            [JsonProperty("value")]
            public System.String Value { get; set; }
            [JsonProperty("isOn")]
            public System.Boolean IsOn { get; set; }
            public SetDeviceModeRequest() { }
            public SetDeviceModeRequest(System.String @value, System.Boolean @isOn)
            {
                this.Value = @value;
                this.IsOn = @isOn;
            }
        }
        public class SetLanguageRequest
        {
            [JsonProperty("language")]
            public System.String Language { get; set; }
            public SetLanguageRequest() { }
            public SetLanguageRequest(System.String @language)
            {
                this.Language = @language;
            }
        }
        public class SetPowerSavingModeRequest
        {
            [JsonProperty("mode")]
            public System.String Mode { get; set; }
            public SetPowerSavingModeRequest() { }
            public SetPowerSavingModeRequest(System.String @mode)
            {
                this.Mode = @mode;
            }
        }
        public class SetPowerStatusRequest
        {
            [JsonProperty("status")]
            public System.Boolean Status { get; set; }
            public SetPowerStatusRequest() { }
            public SetPowerStatusRequest(System.Boolean @status)
            {
                this.Status = @status;
            }
        }
        public class SetWolModeRequest
        {
            [JsonProperty("enabled")]
            public System.Boolean Enabled { get; set; }
            public SetWolModeRequest() { }
            public SetWolModeRequest(System.Boolean @enabled)
            {
                this.Enabled = @enabled;
            }
        }
        public class GetCurrentTimeResponse
        {
            [JsonProperty("dateTime")]
            public System.String DateTime { get; set; }
            [JsonProperty("timeZoneOffsetMinute")]
            public System.Int32 TimeZoneOffsetMinute { get; set; }
            [JsonProperty("dstOffsetMinute")]
            public System.Int32 DstOffsetMinute { get; set; }
            public GetCurrentTimeResponse() { }
            public GetCurrentTimeResponse(System.String @dateTime, System.Int32 @timeZoneOffsetMinute, System.Int32 @dstOffsetMinute)
            {
                this.DateTime = @dateTime;
                this.TimeZoneOffsetMinute = @timeZoneOffsetMinute;
                this.DstOffsetMinute = @dstOffsetMinute;
            }
        }
        public class SetLEDIndicatorStatusRequest
        {
            [JsonProperty("mode")]
            public System.String Mode { get; set; }
            [JsonProperty("status")]
            public System.String Status { get; set; }
            public SetLEDIndicatorStatusRequest() { }
            public SetLEDIndicatorStatusRequest(System.String @mode, System.String @status)
            {
                this.Mode = @mode;
                this.Status = @status;
            }
        }

        public class GetRemoteControllerInfoCompositeResponse : ICompositeResponse
        {
            public GetRemoteControllerInfoResponse Item0 { get; set; }
            public GetRemoteControllerInfo1Response[] Item1 { get; set; }
            public void ReadFromJson(JArray values)
            {
                this.Item0 = ((JToken)values[0])?.ToObject<GetRemoteControllerInfoResponse>();
                this.Item1 = ((JToken)values[1])?.ToObject<GetRemoteControllerInfo1Response[]>();
            }
        }
        #endregion
        #region IAvContent
        Task IAvContent.DeleteContentAsync(DeleteContentRequest @arg0) { return InvokeAsync("avContent", "deleteContent", 1, "1.0", new object[] { @arg0 }); }
        Task IAvContent.DeleteContentAsync(System.String uri) { return ((IAvContent)this).DeleteContentAsync(new DeleteContentRequest(uri)); }
        Task<GetContentCountResponse> IAvContent.GetContentCountAsync(GetContentCountRequest @arg0) { return InvokeAsync<GetContentCountResponse>("avContent", "getContentCount", 1, "1.0", new object[] { @arg0 }); }
        Task<GetContentCountResponse> IAvContent.GetContentCountAsync(System.String source, System.String type) { return ((IAvContent)this).GetContentCountAsync(new GetContentCountRequest(source, type)); }
        Task<GetContentListResponse[]> IAvContent.GetContentListAsync(GetContentListRequest @arg0) { return InvokeAsync<GetContentListResponse[]>("avContent", "getContentList", 1, "1.0", new object[] { @arg0 }); }
        Task<GetContentListResponse[]> IAvContent.GetContentListAsync(System.String source, System.Int32 stIdx, System.Int32 cnt, System.String type) { return ((IAvContent)this).GetContentListAsync(new GetContentListRequest(source, stIdx, cnt, type)); }
        Task<GetCurrentExternalInputsStatusResponse[]> IAvContent.GetCurrentExternalInputsStatusAsync() { return InvokeAsync<GetCurrentExternalInputsStatusResponse[]>("avContent", "getCurrentExternalInputsStatus", 1, "1.0", new object[] { }); }
        Task<GetParentalRatingSettingsResponse> IAvContent.GetParentalRatingSettingsAsync() { return InvokeAsync<GetParentalRatingSettingsResponse>("avContent", "getParentalRatingSettings", 1, "1.0", new object[] { }); }
        Task<GetPlayingContentInfoResponse> IAvContent.GetPlayingContentInfoAsync() { return InvokeAsync<GetPlayingContentInfoResponse>("avContent", "getPlayingContentInfo", 1, "1.0", new object[] { }); }
        Task<GetSchemeListResponse[]> IAvContent.GetSchemeListAsync() { return InvokeAsync<GetSchemeListResponse[]>("avContent", "getSchemeList", 1, "1.0", new object[] { }); }
        Task<GetSourceListResponse[]> IAvContent.GetSourceListAsync(GetSourceListRequest @arg0) { return InvokeAsync<GetSourceListResponse[]>("avContent", "getSourceList", 1, "1.0", new object[] { @arg0 }); }
        Task<GetSourceListResponse[]> IAvContent.GetSourceListAsync(System.String scheme) { return ((IAvContent)this).GetSourceListAsync(new GetSourceListRequest(scheme)); }
        Task IAvContent.SetDeleteProtectionAsync(SetDeleteProtectionRequest @arg0) { return InvokeAsync("avContent", "setDeleteProtection", 1, "1.0", new object[] { @arg0 }); }
        Task IAvContent.SetDeleteProtectionAsync(System.String uri, System.Boolean isProtected) { return ((IAvContent)this).SetDeleteProtectionAsync(new SetDeleteProtectionRequest(uri, isProtected)); }
        Task IAvContent.SetFavoriteContentListAsync(SetFavoriteContentListRequest @arg0) { return InvokeAsync("avContent", "setFavoriteContentList", 1, "1.0", new object[] { @arg0 }); }
        Task IAvContent.SetFavoriteContentListAsync(System.String favSource, System.String[] contents) { return ((IAvContent)this).SetFavoriteContentListAsync(new SetFavoriteContentListRequest(favSource, contents)); }
        Task IAvContent.SetPlayContentAsync(SetPlayContentRequest @arg0) { return InvokeAsync("avContent", "setPlayContent", 1, "1.0", new object[] { @arg0 }); }
        Task IAvContent.SetPlayContentAsync(System.String uri) { return ((IAvContent)this).SetPlayContentAsync(new SetPlayContentRequest(uri)); }
        Task IAvContent.SetPlayTvContentAsync(SetPlayTvContentRequest @arg0) { return InvokeAsync("avContent", "setPlayTvContent", 1, "1.0", new object[] { @arg0 }); }
        Task IAvContent.SetPlayTvContentAsync(System.String channel) { return ((IAvContent)this).SetPlayTvContentAsync(new SetPlayTvContentRequest(channel)); }
        Task IAvContent.SetTvContentVisibilityAsync(SetTvContentVisibilityRequest[] @arg0) { return InvokeAsync("avContent", "setTvContentVisibility", 1, "1.0", new object[] { @arg0 }); }
        Task<System.String[]> IAvContent.GetVersionsAsync() { return InvokeAsync<System.String[]>("avContent", "getVersions", 1, "1.0", new object[] { }); }
        Task<GetContentCountResponseV1_1> IAvContent.GetContentCountAsync(GetContentCountRequestV1_1 @arg0) { return InvokeAsync<GetContentCountResponseV1_1>("avContent", "getContentCount", 1, "1.1", new object[] { @arg0 }); }
        Task<GetContentCountResponseV1_1> IAvContent.GetContentCountAsync(System.String source, System.String type, System.String target) { return ((IAvContent)this).GetContentCountAsync(new GetContentCountRequestV1_1(source, type, target)); }
        Task<GetCurrentExternalInputsStatusResponseV1_1[]> IAvContent.GetCurrentExternalInputsStatusV1_1Async() { return InvokeAsync<GetCurrentExternalInputsStatusResponseV1_1[]>("avContent", "getCurrentExternalInputsStatus", 1, "1.1", new object[] { }); }
        Task IAvContent.SetPlayTvContentAsync(SetPlayTvContentRequestV1_1 @arg0) { return InvokeAsync("avContent", "setPlayTvContent", 1, "1.1", new object[] { @arg0 }); }
        Task IAvContent.SetPlayTvContentAsync(System.Object channel, System.String source, System.String sourceType, System.String broadcastFreqName, System.Boolean ignoreVisibilitySettings) { return ((IAvContent)this).SetPlayTvContentAsync(new SetPlayTvContentRequestV1_1(channel, source, sourceType, broadcastFreqName, ignoreVisibilitySettings)); }
        Task<GetContentListResponseV1_2[]> IAvContent.GetContentListAsync(GetContentListRequestV1_2 @arg0) { return InvokeAsync<GetContentListResponseV1_2[]>("avContent", "getContentList", 1, "1.2", new object[] { @arg0 }); }
        Task<GetContentListResponseV1_2[]> IAvContent.GetContentListAsync(System.String source, System.Int32 stIdx, System.Int32 cnt, System.String type, System.String target) { return ((IAvContent)this).GetContentListAsync(new GetContentListRequestV1_2(source, stIdx, cnt, type, target)); }

        public interface IAvContent
        {
            Task DeleteContentAsync(DeleteContentRequest @arg0);
            Task DeleteContentAsync(System.String @uri);
            Task<GetContentCountResponse> GetContentCountAsync(GetContentCountRequest @arg0);
            Task<GetContentCountResponse> GetContentCountAsync(System.String @source, System.String @type);
            Task<GetContentListResponse[]> GetContentListAsync(GetContentListRequest @arg0);
            Task<GetContentListResponse[]> GetContentListAsync(System.String @source, System.Int32 @stIdx, System.Int32 @cnt, System.String @type);
            Task<GetCurrentExternalInputsStatusResponse[]> GetCurrentExternalInputsStatusAsync();
            Task<GetParentalRatingSettingsResponse> GetParentalRatingSettingsAsync();
            Task<GetPlayingContentInfoResponse> GetPlayingContentInfoAsync();
            Task<GetSchemeListResponse[]> GetSchemeListAsync();
            Task<GetSourceListResponse[]> GetSourceListAsync(GetSourceListRequest @arg0);
            Task<GetSourceListResponse[]> GetSourceListAsync(System.String @scheme);
            Task SetDeleteProtectionAsync(SetDeleteProtectionRequest @arg0);
            Task SetDeleteProtectionAsync(System.String @uri, System.Boolean @isProtected);
            Task SetFavoriteContentListAsync(SetFavoriteContentListRequest @arg0);
            Task SetFavoriteContentListAsync(System.String @favSource, System.String[] @contents);
            Task SetPlayContentAsync(SetPlayContentRequest @arg0);
            Task SetPlayContentAsync(System.String @uri);
            Task SetPlayTvContentAsync(SetPlayTvContentRequest @arg0);
            Task SetPlayTvContentAsync(System.String @channel);
            Task SetTvContentVisibilityAsync(SetTvContentVisibilityRequest[] @arg0);
            Task<System.String[]> GetVersionsAsync();
            Task<GetContentCountResponseV1_1> GetContentCountAsync(GetContentCountRequestV1_1 @arg0);
            Task<GetContentCountResponseV1_1> GetContentCountAsync(System.String @source, System.String @type, System.String @target);
            Task<GetCurrentExternalInputsStatusResponseV1_1[]> GetCurrentExternalInputsStatusV1_1Async();
            Task SetPlayTvContentAsync(SetPlayTvContentRequestV1_1 @arg0);
            Task SetPlayTvContentAsync(System.Object @channel, System.String @source, System.String @sourceType, System.String @broadcastFreqName, System.Boolean @ignoreVisibilitySettings);
            Task<GetContentListResponseV1_2[]> GetContentListAsync(GetContentListRequestV1_2 @arg0);
            Task<GetContentListResponseV1_2[]> GetContentListAsync(System.String @source, System.Int32 @stIdx, System.Int32 @cnt, System.String @type, System.String @target);
        }

        public class DeleteContentRequest
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            public DeleteContentRequest() { }
            public DeleteContentRequest(System.String @uri)
            {
                this.Uri = @uri;
            }
        }
        public class GetContentCountRequest
        {
            [JsonProperty("source")]
            public System.String Source { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            public GetContentCountRequest() { }
            public GetContentCountRequest(System.String @source, System.String @type)
            {
                this.Source = @source;
                this.Type = @type;
            }
        }
        public class GetContentCountResponse
        {
            [JsonProperty("count")]
            public System.Int32 Count { get; set; }
            public GetContentCountResponse() { }
            public GetContentCountResponse(System.Int32 @count)
            {
                this.Count = @count;
            }
        }
        public class GetContentListRequest
        {
            [JsonProperty("source")]
            public System.String Source { get; set; }
            [JsonProperty("stIdx")]
            public System.Int32 StIdx { get; set; }
            [JsonProperty("cnt")]
            public System.Int32 Cnt { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            public GetContentListRequest() { }
            public GetContentListRequest(System.String @source, System.Int32 @stIdx, System.Int32 @cnt, System.String @type)
            {
                this.Source = @source;
                this.StIdx = @stIdx;
                this.Cnt = @cnt;
                this.Type = @type;
            }
        }
        public class GetContentListResponse
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("index")]
            public System.Int32 Index { get; set; }
            [JsonProperty("dispNum")]
            public System.String DispNum { get; set; }
            [JsonProperty("originalDispNum")]
            public System.String OriginalDispNum { get; set; }
            [JsonProperty("tripletStr")]
            public System.String TripletStr { get; set; }
            [JsonProperty("programNum")]
            public System.Int32 ProgramNum { get; set; }
            [JsonProperty("programMediaType")]
            public System.String ProgramMediaType { get; set; }
            [JsonProperty("directRemoteNum")]
            public System.Int32 DirectRemoteNum { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("channelName")]
            public System.String ChannelName { get; set; }
            [JsonProperty("fileSizeByte")]
            public System.Int32 FileSizeByte { get; set; }
            [JsonProperty("isProtected")]
            public System.Boolean IsProtected { get; set; }
            [JsonProperty("isAlreadyPlayed")]
            public System.Boolean IsAlreadyPlayed { get; set; }
            public GetContentListResponse() { }
            public GetContentListResponse(System.String @uri, System.String @title, System.Int32 @index, System.String @dispNum, System.String @originalDispNum, System.String @tripletStr, System.Int32 @programNum, System.String @programMediaType, System.Int32 @directRemoteNum, System.String @startDateTime, System.Int32 @durationSec, System.String @channelName, System.Int32 @fileSizeByte, System.Boolean @isProtected, System.Boolean @isAlreadyPlayed)
            {
                this.Uri = @uri;
                this.Title = @title;
                this.Index = @index;
                this.DispNum = @dispNum;
                this.OriginalDispNum = @originalDispNum;
                this.TripletStr = @tripletStr;
                this.ProgramNum = @programNum;
                this.ProgramMediaType = @programMediaType;
                this.DirectRemoteNum = @directRemoteNum;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.ChannelName = @channelName;
                this.FileSizeByte = @fileSizeByte;
                this.IsProtected = @isProtected;
                this.IsAlreadyPlayed = @isAlreadyPlayed;
            }
        }
        public class GetCurrentExternalInputsStatusResponse
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("connection")]
            public System.Boolean Connection { get; set; }
            [JsonProperty("label")]
            public System.String Label { get; set; }
            [JsonProperty("icon")]
            public System.String Icon { get; set; }
            public GetCurrentExternalInputsStatusResponse() { }
            public GetCurrentExternalInputsStatusResponse(System.String @uri, System.String @title, System.Boolean @connection, System.String @label, System.String @icon)
            {
                this.Uri = @uri;
                this.Title = @title;
                this.Connection = @connection;
                this.Label = @label;
                this.Icon = @icon;
            }
        }
        public class GetParentalRatingSettingsResponse
        {
            [JsonProperty("ratingTypeAge")]
            public System.Int32 RatingTypeAge { get; set; }
            [JsonProperty("ratingTypeSony")]
            public System.String RatingTypeSony { get; set; }
            [JsonProperty("ratingCountry")]
            public System.String RatingCountry { get; set; }
            [JsonProperty("ratingCustomTypeTV")]
            public System.String[] RatingCustomTypeTV { get; set; }
            [JsonProperty("ratingCustomTypeMpaa")]
            public System.String RatingCustomTypeMpaa { get; set; }
            [JsonProperty("ratingCustomTypeCaEnglish")]
            public System.String RatingCustomTypeCaEnglish { get; set; }
            [JsonProperty("ratingCustomTypeCaFrench")]
            public System.String RatingCustomTypeCaFrench { get; set; }
            [JsonProperty("unratedLock")]
            public System.Boolean UnratedLock { get; set; }
            public GetParentalRatingSettingsResponse() { }
            public GetParentalRatingSettingsResponse(System.Int32 @ratingTypeAge, System.String @ratingTypeSony, System.String @ratingCountry, System.String[] @ratingCustomTypeTV, System.String @ratingCustomTypeMpaa, System.String @ratingCustomTypeCaEnglish, System.String @ratingCustomTypeCaFrench, System.Boolean @unratedLock)
            {
                this.RatingTypeAge = @ratingTypeAge;
                this.RatingTypeSony = @ratingTypeSony;
                this.RatingCountry = @ratingCountry;
                this.RatingCustomTypeTV = @ratingCustomTypeTV;
                this.RatingCustomTypeMpaa = @ratingCustomTypeMpaa;
                this.RatingCustomTypeCaEnglish = @ratingCustomTypeCaEnglish;
                this.RatingCustomTypeCaFrench = @ratingCustomTypeCaFrench;
                this.UnratedLock = @unratedLock;
            }
        }
        public class GetPlayingContentInfoResponse
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("source")]
            public System.String Source { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("dispNum")]
            public System.String DispNum { get; set; }
            [JsonProperty("originalDispNum")]
            public System.String OriginalDispNum { get; set; }
            [JsonProperty("tripletStr")]
            public System.String TripletStr { get; set; }
            [JsonProperty("programNum")]
            public System.Int32 ProgramNum { get; set; }
            [JsonProperty("programTitle")]
            public System.String ProgramTitle { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("mediaType")]
            public System.String MediaType { get; set; }
            [JsonProperty("playSpeed")]
            public System.String PlaySpeed { get; set; }
            [JsonProperty("bivl_serviceId")]
            public System.String Bivl_serviceId { get; set; }
            [JsonProperty("bivl_assetId")]
            public System.String Bivl_assetId { get; set; }
            [JsonProperty("bivl_provider")]
            public System.String Bivl_provider { get; set; }
            public GetPlayingContentInfoResponse() { }
            public GetPlayingContentInfoResponse(System.String @uri, System.String @source, System.String @title, System.String @dispNum, System.String @originalDispNum, System.String @tripletStr, System.Int32 @programNum, System.String @programTitle, System.String @startDateTime, System.Int32 @durationSec, System.String @mediaType, System.String @playSpeed, System.String @bivl_serviceId, System.String @bivl_assetId, System.String @bivl_provider)
            {
                this.Uri = @uri;
                this.Source = @source;
                this.Title = @title;
                this.DispNum = @dispNum;
                this.OriginalDispNum = @originalDispNum;
                this.TripletStr = @tripletStr;
                this.ProgramNum = @programNum;
                this.ProgramTitle = @programTitle;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.MediaType = @mediaType;
                this.PlaySpeed = @playSpeed;
                this.Bivl_serviceId = @bivl_serviceId;
                this.Bivl_assetId = @bivl_assetId;
                this.Bivl_provider = @bivl_provider;
            }
        }
        public class GetSchemeListResponse
        {
            [JsonProperty("scheme")]
            public System.String Scheme { get; set; }
            public GetSchemeListResponse() { }
            public GetSchemeListResponse(System.String @scheme)
            {
                this.Scheme = @scheme;
            }
        }
        public class GetSourceListRequest
        {
            [JsonProperty("scheme")]
            public System.String Scheme { get; set; }
            public GetSourceListRequest() { }
            public GetSourceListRequest(System.String @scheme)
            {
                this.Scheme = @scheme;
            }
        }
        public class GetSourceListResponse
        {
            [JsonProperty("source")]
            public System.String Source { get; set; }
            public GetSourceListResponse() { }
            public GetSourceListResponse(System.String @source)
            {
                this.Source = @source;
            }
        }
        public class SetDeleteProtectionRequest
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("isProtected")]
            public System.Boolean IsProtected { get; set; }
            public SetDeleteProtectionRequest() { }
            public SetDeleteProtectionRequest(System.String @uri, System.Boolean @isProtected)
            {
                this.Uri = @uri;
                this.IsProtected = @isProtected;
            }
        }
        public class SetFavoriteContentListRequest
        {
            [JsonProperty("favSource")]
            public System.String FavSource { get; set; }
            [JsonProperty("contents")]
            public System.String[] Contents { get; set; }
            public SetFavoriteContentListRequest() { }
            public SetFavoriteContentListRequest(System.String @favSource, System.String[] @contents)
            {
                this.FavSource = @favSource;
                this.Contents = @contents;
            }
        }
        public class SetPlayContentRequest
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            public SetPlayContentRequest() { }
            public SetPlayContentRequest(System.String @uri)
            {
                this.Uri = @uri;
            }
        }
        public class SetPlayTvContentRequest
        {
            [JsonProperty("channel")]
            public System.String Channel { get; set; }
            public SetPlayTvContentRequest() { }
            public SetPlayTvContentRequest(System.String @channel)
            {
                this.Channel = @channel;
            }
        }
        public class SetTvContentVisibilityRequest
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("epgVisibility")]
            public System.String EpgVisibility { get; set; }
            [JsonProperty("channelSurfingVisibility")]
            public System.String ChannelSurfingVisibility { get; set; }
            [JsonProperty("visibility")]
            public System.String Visibility { get; set; }
            public SetTvContentVisibilityRequest() { }
            public SetTvContentVisibilityRequest(System.String @uri, System.String @epgVisibility, System.String @channelSurfingVisibility, System.String @visibility)
            {
                this.Uri = @uri;
                this.EpgVisibility = @epgVisibility;
                this.ChannelSurfingVisibility = @channelSurfingVisibility;
                this.Visibility = @visibility;
            }
        }
        public class GetContentCountRequestV1_1
        {
            [JsonProperty("source")]
            public System.String Source { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("target")]
            public System.String Target { get; set; }
            public GetContentCountRequestV1_1() { }
            public GetContentCountRequestV1_1(System.String @source, System.String @type, System.String @target)
            {
                this.Source = @source;
                this.Type = @type;
                this.Target = @target;
            }
        }
        public class GetContentCountResponseV1_1
        {
            [JsonProperty("count")]
            public System.Int32 Count { get; set; }
            public GetContentCountResponseV1_1() { }
            public GetContentCountResponseV1_1(System.Int32 @count)
            {
                this.Count = @count;
            }
        }
        public class GetCurrentExternalInputsStatusResponseV1_1
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("connection")]
            public System.Boolean Connection { get; set; }
            [JsonProperty("label")]
            public System.String Label { get; set; }
            [JsonProperty("icon")]
            public System.String Icon { get; set; }
            [JsonProperty("status")]
            public System.String Status { get; set; }
            public GetCurrentExternalInputsStatusResponseV1_1() { }
            public GetCurrentExternalInputsStatusResponseV1_1(System.String @uri, System.String @title, System.Boolean @connection, System.String @label, System.String @icon, System.String @status)
            {
                this.Uri = @uri;
                this.Title = @title;
                this.Connection = @connection;
                this.Label = @label;
                this.Icon = @icon;
                this.Status = @status;
            }
        }
        public class SetPlayTvContentRequestV1_1
        {
            [JsonProperty("channel")]
            public System.Object Channel { get; set; }
            [JsonProperty("source")]
            public System.String Source { get; set; }
            [JsonProperty("sourceType")]
            public System.String SourceType { get; set; }
            [JsonProperty("broadcastFreqName")]
            public System.String BroadcastFreqName { get; set; }
            [JsonProperty("ignoreVisibilitySettings")]
            public System.Boolean IgnoreVisibilitySettings { get; set; }
            public SetPlayTvContentRequestV1_1() { }
            public SetPlayTvContentRequestV1_1(System.Object @channel, System.String @source, System.String @sourceType, System.String @broadcastFreqName, System.Boolean @ignoreVisibilitySettings)
            {
                this.Channel = @channel;
                this.Source = @source;
                this.SourceType = @sourceType;
                this.BroadcastFreqName = @broadcastFreqName;
                this.IgnoreVisibilitySettings = @ignoreVisibilitySettings;
            }
        }
        public class GetContentListRequestV1_2
        {
            [JsonProperty("source")]
            public System.String Source { get; set; }
            [JsonProperty("stIdx")]
            public System.Int32 StIdx { get; set; }
            [JsonProperty("cnt")]
            public System.Int32 Cnt { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("target")]
            public System.String Target { get; set; }
            public GetContentListRequestV1_2() { }
            public GetContentListRequestV1_2(System.String @source, System.Int32 @stIdx, System.Int32 @cnt, System.String @type, System.String @target)
            {
                this.Source = @source;
                this.StIdx = @stIdx;
                this.Cnt = @cnt;
                this.Type = @type;
                this.Target = @target;
            }
        }
        public class GetContentListResponseV1_2
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("index")]
            public System.Int32 Index { get; set; }
            [JsonProperty("dispNum")]
            public System.String DispNum { get; set; }
            [JsonProperty("originalDispNum")]
            public System.String OriginalDispNum { get; set; }
            [JsonProperty("tripletStr")]
            public System.String TripletStr { get; set; }
            [JsonProperty("programNum")]
            public System.Int32 ProgramNum { get; set; }
            [JsonProperty("programMediaType")]
            public System.String ProgramMediaType { get; set; }
            [JsonProperty("directRemoteNum")]
            public System.Int32 DirectRemoteNum { get; set; }
            [JsonProperty("epgVisibility")]
            public System.String EpgVisibility { get; set; }
            [JsonProperty("channelSurfingVisibility")]
            public System.String ChannelSurfingVisibility { get; set; }
            [JsonProperty("visibility")]
            public System.String Visibility { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("channelName")]
            public System.String ChannelName { get; set; }
            [JsonProperty("fileSizeByte")]
            public System.Int32 FileSizeByte { get; set; }
            [JsonProperty("isProtected")]
            public System.Boolean IsProtected { get; set; }
            [JsonProperty("isAlreadyPlayed")]
            public System.Boolean IsAlreadyPlayed { get; set; }
            [JsonProperty("productID")]
            public System.String ProductID { get; set; }
            [JsonProperty("contentType")]
            public System.String ContentType { get; set; }
            [JsonProperty("storageUri")]
            public System.String StorageUri { get; set; }
            [JsonProperty("videoCodec")]
            public System.String VideoCodec { get; set; }
            [JsonProperty("chapterCount")]
            public System.Int32 ChapterCount { get; set; }
            [JsonProperty("durationSec")]
            public System.Double DurationSec { get; set; }
            [JsonProperty("audioCodec")]
            public System.String[] AudioCodec { get; set; }
            [JsonProperty("audioFrequency")]
            public System.String[] AudioFrequency { get; set; }
            [JsonProperty("audioChannel")]
            public System.String[] AudioChannel { get; set; }
            [JsonProperty("subtitleLanguage")]
            public System.String[] SubtitleLanguage { get; set; }
            [JsonProperty("subtitleTitle")]
            public System.String[] SubtitleTitle { get; set; }
            [JsonProperty("parentalRating")]
            public System.String[] ParentalRating { get; set; }
            [JsonProperty("parentalSystem")]
            public System.String[] ParentalSystem { get; set; }
            [JsonProperty("parentalCountry")]
            public System.String[] ParentalCountry { get; set; }
            [JsonProperty("sizeMB")]
            public System.Int32 SizeMB { get; set; }
            [JsonProperty("createdTime")]
            public System.String CreatedTime { get; set; }
            [JsonProperty("userContentFlag")]
            public System.Boolean UserContentFlag { get; set; }
            public GetContentListResponseV1_2() { }
            public GetContentListResponseV1_2(System.String @uri, System.String @title, System.Int32 @index, System.String @dispNum, System.String @originalDispNum, System.String @tripletStr, System.Int32 @programNum, System.String @programMediaType, System.Int32 @directRemoteNum, System.String @epgVisibility, System.String @channelSurfingVisibility, System.String @visibility, System.String @startDateTime, System.String @channelName, System.Int32 @fileSizeByte, System.Boolean @isProtected, System.Boolean @isAlreadyPlayed, System.String @productID, System.String @contentType, System.String @storageUri, System.String @videoCodec, System.Int32 @chapterCount, System.Double @durationSec, System.String[] @audioCodec, System.String[] @audioFrequency, System.String[] @audioChannel, System.String[] @subtitleLanguage, System.String[] @subtitleTitle, System.String[] @parentalRating, System.String[] @parentalSystem, System.String[] @parentalCountry, System.Int32 @sizeMB, System.String @createdTime, System.Boolean @userContentFlag)
            {
                this.Uri = @uri;
                this.Title = @title;
                this.Index = @index;
                this.DispNum = @dispNum;
                this.OriginalDispNum = @originalDispNum;
                this.TripletStr = @tripletStr;
                this.ProgramNum = @programNum;
                this.ProgramMediaType = @programMediaType;
                this.DirectRemoteNum = @directRemoteNum;
                this.EpgVisibility = @epgVisibility;
                this.ChannelSurfingVisibility = @channelSurfingVisibility;
                this.Visibility = @visibility;
                this.StartDateTime = @startDateTime;
                this.ChannelName = @channelName;
                this.FileSizeByte = @fileSizeByte;
                this.IsProtected = @isProtected;
                this.IsAlreadyPlayed = @isAlreadyPlayed;
                this.ProductID = @productID;
                this.ContentType = @contentType;
                this.StorageUri = @storageUri;
                this.VideoCodec = @videoCodec;
                this.ChapterCount = @chapterCount;
                this.DurationSec = @durationSec;
                this.AudioCodec = @audioCodec;
                this.AudioFrequency = @audioFrequency;
                this.AudioChannel = @audioChannel;
                this.SubtitleLanguage = @subtitleLanguage;
                this.SubtitleTitle = @subtitleTitle;
                this.ParentalRating = @parentalRating;
                this.ParentalSystem = @parentalSystem;
                this.ParentalCountry = @parentalCountry;
                this.SizeMB = @sizeMB;
                this.CreatedTime = @createdTime;
                this.UserContentFlag = @userContentFlag;
            }
        }

        #endregion
        #region IEncryption
        Task<GetPublicKeyResponse> IEncryption.GetPublicKeyAsync() { return InvokeAsync<GetPublicKeyResponse>("encryption", "getPublicKey", 1, "1.0", new object[] { }); }
        Task<System.String[]> IEncryption.GetVersionsAsync() { return InvokeAsync<System.String[]>("encryption", "getVersions", 1, "1.0", new object[] { }); }

        public interface IEncryption
        {
            Task<GetPublicKeyResponse> GetPublicKeyAsync();
            Task<System.String[]> GetVersionsAsync();
        }

        public class GetPublicKeyResponse
        {
            [JsonProperty("publicKey")]
            public System.String PublicKey { get; set; }
            public GetPublicKeyResponse() { }
            public GetPublicKeyResponse(System.String @publicKey)
            {
                this.PublicKey = @publicKey;
            }
        }

        #endregion
        #region IBrowser
        Task<System.Int32> IBrowser.ActBrowserControlAsync(ActBrowserControlRequest @arg0) { return InvokeAsync<System.Int32>("browser", "actBrowserControl", 1, "1.0", new object[] { @arg0 }); }
        Task<System.Int32> IBrowser.ActBrowserControlAsync(System.String control) { return ((IBrowser)this).ActBrowserControlAsync(new ActBrowserControlRequest(control)); }
        Task<GetTextUrlResponse> IBrowser.GetTextUrlAsync() { return InvokeAsync<GetTextUrlResponse>("browser", "getTextUrl", 1, "1.0", new object[] { }); }
        Task<System.Int32> IBrowser.SetTextUrlAsync(SetTextUrlRequest @arg0) { return InvokeAsync<System.Int32>("browser", "setTextUrl", 1, "1.0", new object[] { @arg0 }); }
        Task<System.Int32> IBrowser.SetTextUrlAsync(System.String url, System.String title, System.String type, System.String favicon) { return ((IBrowser)this).SetTextUrlAsync(new SetTextUrlRequest(url, title, type, favicon)); }
        Task<System.String[]> IBrowser.GetVersionsAsync() { return InvokeAsync<System.String[]>("browser", "getVersions", 1, "1.0", new object[] { }); }

        public interface IBrowser
        {
            Task<System.Int32> ActBrowserControlAsync(ActBrowserControlRequest @arg0);
            Task<System.Int32> ActBrowserControlAsync(System.String @control);
            Task<GetTextUrlResponse> GetTextUrlAsync();
            Task<System.Int32> SetTextUrlAsync(SetTextUrlRequest @arg0);
            Task<System.Int32> SetTextUrlAsync(System.String @url, System.String @title, System.String @type, System.String @favicon);
            Task<System.String[]> GetVersionsAsync();
        }

        public class ActBrowserControlRequest
        {
            [JsonProperty("control")]
            public System.String Control { get; set; }
            public ActBrowserControlRequest() { }
            public ActBrowserControlRequest(System.String @control)
            {
                this.Control = @control;
            }
        }
        public class GetTextUrlResponse
        {
            [JsonProperty("url")]
            public System.String Url { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("favicon")]
            public System.String Favicon { get; set; }
            public GetTextUrlResponse() { }
            public GetTextUrlResponse(System.String @url, System.String @title, System.String @type, System.String @favicon)
            {
                this.Url = @url;
                this.Title = @title;
                this.Type = @type;
                this.Favicon = @favicon;
            }
        }
        public class SetTextUrlRequest
        {
            [JsonProperty("url")]
            public System.String Url { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("favicon")]
            public System.String Favicon { get; set; }
            public SetTextUrlRequest() { }
            public SetTextUrlRequest(System.String @url, System.String @title, System.String @type, System.String @favicon)
            {
                this.Url = @url;
                this.Title = @title;
                this.Type = @type;
                this.Favicon = @favicon;
            }
        }

        #endregion
        #region IAccessControl
        Task IAccessControl.ActRegisterAsync(ActRegisterRequest @arg0, ActRegister1Request[] @arg1) { return InvokeAsync("accessControl", "actRegister", 1, "1.0", new object[] { @arg0, @arg1 }); }
        Task<System.String[]> IAccessControl.GetVersionsAsync() { return InvokeAsync<System.String[]>("accessControl", "getVersions", 1, "1.0", new object[] { }); }

        public interface IAccessControl
        {
            Task ActRegisterAsync(ActRegisterRequest @arg0, ActRegister1Request[] @arg1);
            Task<System.String[]> GetVersionsAsync();
        }

        public class ActRegisterRequest
        {
            [JsonProperty("clientid")]
            public System.String Clientid { get; set; }
            [JsonProperty("nickname")]
            public System.String Nickname { get; set; }
            [JsonProperty("level")]
            public System.String Level { get; set; }
            public ActRegisterRequest() { }
            public ActRegisterRequest(System.String @clientid, System.String @nickname, System.String @level)
            {
                this.Clientid = @clientid;
                this.Nickname = @nickname;
                this.Level = @level;
            }
        }
        public class ActRegister1Request
        {
            [JsonProperty("function")]
            public System.String Function { get; set; }
            [JsonProperty("value")]
            public System.String Value { get; set; }
            public ActRegister1Request() { }
            public ActRegister1Request(System.String @function, System.String @value)
            {
                this.Function = @function;
                this.Value = @value;
            }
        }

        #endregion
        #region IAppControl
        Task<GetApplicationListResponse[]> IAppControl.GetApplicationListAsync() { return InvokeAsync<GetApplicationListResponse[]>("appControl", "getApplicationList", 1, "1.0", new object[] { }); }
        Task<GetApplicationStatusListResponse[]> IAppControl.GetApplicationStatusListAsync() { return InvokeAsync<GetApplicationStatusListResponse[]>("appControl", "getApplicationStatusList", 1, "1.0", new object[] { }); }
        Task<GetWebAppStatusResponse> IAppControl.GetWebAppStatusAsync() { return InvokeAsync<GetWebAppStatusResponse>("appControl", "getWebAppStatus", 1, "1.0", new object[] { }); }
        Task IAppControl.SetActiveAppAsync(SetActiveAppRequest @arg0) { return InvokeAsync("appControl", "setActiveApp", 1, "1.0", new object[] { @arg0 }); }
        Task IAppControl.SetActiveAppAsync(System.String uri, System.String data) { return ((IAppControl)this).SetActiveAppAsync(new SetActiveAppRequest(uri, data)); }
        Task<System.Int32> IAppControl.SetTextFormAsync(System.String @arg0) { return InvokeAsync<System.Int32>("appControl", "setTextForm", 1, "1.0", new object[] { @arg0 }); }
        Task IAppControl.TerminateAppsAsync() { return InvokeAsync("appControl", "terminateApps", 1, "1.0", new object[] { }); }
        Task<System.String[]> IAppControl.GetVersionsAsync() { return InvokeAsync<System.String[]>("appControl", "getVersions", 1, "1.0", new object[] { }); }
        Task<GetTextFormResponse> IAppControl.GetTextFormAsync(GetTextFormRequest @arg0) { return InvokeAsync<GetTextFormResponse>("appControl", "getTextForm", 1, "1.1", new object[] { @arg0 }); }
        Task<GetTextFormResponse> IAppControl.GetTextFormAsync(System.String encKey) { return ((IAppControl)this).GetTextFormAsync(new GetTextFormRequest(encKey)); }
        Task IAppControl.SetTextFormAsync(SetTextFormRequest @arg0) { return InvokeAsync("appControl", "setTextForm", 1, "1.1", new object[] { @arg0 }); }
        Task IAppControl.SetTextFormAsync(System.String encKey, System.String text) { return ((IAppControl)this).SetTextFormAsync(new SetTextFormRequest(encKey, text)); }

        public interface IAppControl
        {
            Task<GetApplicationListResponse[]> GetApplicationListAsync();
            Task<GetApplicationStatusListResponse[]> GetApplicationStatusListAsync();
            Task<GetWebAppStatusResponse> GetWebAppStatusAsync();
            Task SetActiveAppAsync(SetActiveAppRequest @arg0);
            Task SetActiveAppAsync(System.String @uri, System.String @data);
            Task<System.Int32> SetTextFormAsync(System.String @arg0);
            Task TerminateAppsAsync();
            Task<System.String[]> GetVersionsAsync();
            Task<GetTextFormResponse> GetTextFormAsync(GetTextFormRequest @arg0);
            Task<GetTextFormResponse> GetTextFormAsync(System.String @encKey);
            Task SetTextFormAsync(SetTextFormRequest @arg0);
            Task SetTextFormAsync(System.String @encKey, System.String @text);
        }

        public class GetApplicationListResponse
        {
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("icon")]
            public System.String Icon { get; set; }
            [JsonProperty("data")]
            public System.String Data { get; set; }
            public GetApplicationListResponse() { }
            public GetApplicationListResponse(System.String @title, System.String @uri, System.String @icon, System.String @data)
            {
                this.Title = @title;
                this.Uri = @uri;
                this.Icon = @icon;
                this.Data = @data;
            }
        }
        public class GetApplicationStatusListResponse
        {
            [JsonProperty("name")]
            public System.String Name { get; set; }
            [JsonProperty("status")]
            public System.String Status { get; set; }
            public GetApplicationStatusListResponse() { }
            public GetApplicationStatusListResponse(System.String @name, System.String @status)
            {
                this.Name = @name;
                this.Status = @status;
            }
        }
        public class GetWebAppStatusResponse
        {
            [JsonProperty("active")]
            public System.Boolean Active { get; set; }
            [JsonProperty("url")]
            public System.String Url { get; set; }
            public GetWebAppStatusResponse() { }
            public GetWebAppStatusResponse(System.Boolean @active, System.String @url)
            {
                this.Active = @active;
                this.Url = @url;
            }
        }
        public class SetActiveAppRequest
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("data")]
            public System.String Data { get; set; }
            public SetActiveAppRequest() { }
            public SetActiveAppRequest(System.String @uri, System.String @data)
            {
                this.Uri = @uri;
                this.Data = @data;
            }
        }
        public class GetTextFormRequest
        {
            [JsonProperty("encKey")]
            public System.String EncKey { get; set; }
            public GetTextFormRequest() { }
            public GetTextFormRequest(System.String @encKey)
            {
                this.EncKey = @encKey;
            }
        }
        public class GetTextFormResponse
        {
            [JsonProperty("text")]
            public System.String Text { get; set; }
            public GetTextFormResponse() { }
            public GetTextFormResponse(System.String @text)
            {
                this.Text = @text;
            }
        }
        public class SetTextFormRequest
        {
            [JsonProperty("encKey")]
            public System.String EncKey { get; set; }
            [JsonProperty("text")]
            public System.String Text { get; set; }
            public SetTextFormRequest() { }
            public SetTextFormRequest(System.String @encKey, System.String @text)
            {
                this.EncKey = @encKey;
                this.Text = @text;
            }
        }

        #endregion
        #region IRecording
        Task<AddScheduleResponse> IRecording.AddScheduleAsync(AddScheduleRequest @arg0) { return InvokeAsync<AddScheduleResponse>("recording", "addSchedule", 1, "1.0", new object[] { @arg0 }); }
        Task<AddScheduleResponse> IRecording.AddScheduleAsync(System.String type, System.String uri, System.String title, System.String startDateTime, System.Int32 durationSec, System.String repeatType, System.String quality) { return ((IRecording)this).AddScheduleAsync(new AddScheduleRequest(type, uri, title, startDateTime, durationSec, repeatType, quality)); }
        Task IRecording.DeleteScheduleAsync(DeleteScheduleRequest @arg0) { return InvokeAsync("recording", "deleteSchedule", 1, "1.0", new object[] { @arg0 }); }
        Task IRecording.DeleteScheduleAsync(System.String id, System.String type, System.String uri, System.String title, System.String startDateTime, System.Int32 durationSec) { return ((IRecording)this).DeleteScheduleAsync(new DeleteScheduleRequest(id, type, uri, title, startDateTime, durationSec)); }
        Task<GetConflictScheduleListResponse[]> IRecording.GetConflictScheduleListAsync(GetConflictScheduleListRequest @arg0) { return InvokeAsync<GetConflictScheduleListResponse[]>("recording", "getConflictScheduleList", 1, "1.0", new object[] { @arg0 }); }
        Task<GetConflictScheduleListResponse[]> IRecording.GetConflictScheduleListAsync(System.String uri, System.String title, System.String startDateTime, System.Int32 durationSec, System.String repeatType) { return ((IRecording)this).GetConflictScheduleListAsync(new GetConflictScheduleListRequest(uri, title, startDateTime, durationSec, repeatType)); }
        Task<GetHistoryListResponse[]> IRecording.GetHistoryListAsync(GetHistoryListRequest @arg0) { return InvokeAsync<GetHistoryListResponse[]>("recording", "getHistoryList", 1, "1.0", new object[] { @arg0 }); }
        Task<GetHistoryListResponse[]> IRecording.GetHistoryListAsync(System.Int32 stIdx, System.Int32 cnt) { return ((IRecording)this).GetHistoryListAsync(new GetHistoryListRequest(stIdx, cnt)); }
        Task<GetRecordingStatusResponse> IRecording.GetRecordingStatusAsync() { return InvokeAsync<GetRecordingStatusResponse>("recording", "getRecordingStatus", 1, "1.0", new object[] { }); }
        Task<GetScheduleListResponse[]> IRecording.GetScheduleListAsync(GetScheduleListRequest @arg0) { return InvokeAsync<GetScheduleListResponse[]>("recording", "getScheduleList", 1, "1.0", new object[] { @arg0 }); }
        Task<GetScheduleListResponse[]> IRecording.GetScheduleListAsync(System.Int32 stIdx, System.Int32 cnt) { return ((IRecording)this).GetScheduleListAsync(new GetScheduleListRequest(stIdx, cnt)); }
        Task<System.String[]> IRecording.GetSupportedRepeatTypeAsync() { return InvokeAsync<System.String[]>("recording", "getSupportedRepeatType", 1, "1.0", new object[] { }); }
        Task<System.String[]> IRecording.GetVersionsAsync() { return InvokeAsync<System.String[]>("recording", "getVersions", 1, "1.0", new object[] { }); }
        Task<AddScheduleResponseV1_1> IRecording.AddScheduleAsync(AddScheduleRequestV1_1 @arg0) { return InvokeAsync<AddScheduleResponseV1_1>("recording", "addSchedule", 1, "1.1", new object[] { @arg0 }); }
        Task<AddScheduleResponseV1_1> IRecording.AddScheduleAsync(System.String type, System.String uri, System.String title, System.String startDateTime, System.Int32 durationSec, System.String repeatType, System.String quality, System.String eventId) { return ((IRecording)this).AddScheduleAsync(new AddScheduleRequestV1_1(type, uri, title, startDateTime, durationSec, repeatType, quality, eventId)); }
        Task<GetScheduleListResponseV1_1[]> IRecording.GetScheduleListAsync(GetScheduleListRequestV1_1 @arg0) { return InvokeAsync<GetScheduleListResponseV1_1[]>("recording", "getScheduleList", 1, "1.1", new object[] { @arg0 }); }
        //Task<GetScheduleListResponseV1_1[]> IRecording.GetScheduleListAsync(System.Int32 stIdx, System.Int32 cnt) { return ((IRecording)this).GetScheduleListAsync(new GetScheduleListRequestV1_1(stIdx, cnt)); }
        Task<AddScheduleResponseV1_2> IRecording.AddScheduleAsync(AddScheduleRequestV1_2 @arg0) { return InvokeAsync<AddScheduleResponseV1_2>("recording", "addSchedule", 1, "1.2", new object[] { @arg0 }); }
        Task<AddScheduleResponseV1_2> IRecording.AddScheduleAsync(System.String type, System.String uri, System.String title, System.String startDateTime, System.Int32 durationSec, System.String repeatType, System.String quality, System.String eventId, System.String id, System.String avoidDoubleRecording, System.String mode, System.String priority, System.String storageUri, System.String @override, System.String autoTransfer, System.String trackedTitle, System.Int32 videoIndex, System.Int32 audioIndex, System.Int32 subtitleIndex, System.String groupId, System.String recordItemWithParentalLock) { return ((IRecording)this).AddScheduleAsync(new AddScheduleRequestV1_2(type, uri, title, startDateTime, durationSec, repeatType, quality, eventId, id, avoidDoubleRecording, mode, priority, storageUri, @override, autoTransfer, trackedTitle, videoIndex, audioIndex, subtitleIndex, groupId, recordItemWithParentalLock)); }

        public interface IRecording
        {
            Task<AddScheduleResponse> AddScheduleAsync(AddScheduleRequest @arg0);
            Task<AddScheduleResponse> AddScheduleAsync(System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @quality);
            Task DeleteScheduleAsync(DeleteScheduleRequest @arg0);
            Task DeleteScheduleAsync(System.String @id, System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec);
            Task<GetConflictScheduleListResponse[]> GetConflictScheduleListAsync(GetConflictScheduleListRequest @arg0);
            Task<GetConflictScheduleListResponse[]> GetConflictScheduleListAsync(System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType);
            Task<GetHistoryListResponse[]> GetHistoryListAsync(GetHistoryListRequest @arg0);
            Task<GetHistoryListResponse[]> GetHistoryListAsync(System.Int32 @stIdx, System.Int32 @cnt);
            Task<GetRecordingStatusResponse> GetRecordingStatusAsync();
            Task<GetScheduleListResponse[]> GetScheduleListAsync(GetScheduleListRequest @arg0);
            Task<GetScheduleListResponse[]> GetScheduleListAsync(System.Int32 @stIdx, System.Int32 @cnt);
            Task<System.String[]> GetSupportedRepeatTypeAsync();
            Task<System.String[]> GetVersionsAsync();
            Task<AddScheduleResponseV1_1> AddScheduleAsync(AddScheduleRequestV1_1 @arg0);
            Task<AddScheduleResponseV1_1> AddScheduleAsync(System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @quality, System.String @eventId);
            Task<GetScheduleListResponseV1_1[]> GetScheduleListAsync(GetScheduleListRequestV1_1 @arg0);
            //Task<GetScheduleListResponseV1_1[]> GetScheduleListAsync(System.Int32 @stIdx, System.Int32 @cnt);
            Task<AddScheduleResponseV1_2> AddScheduleAsync(AddScheduleRequestV1_2 @arg0);
            Task<AddScheduleResponseV1_2> AddScheduleAsync(System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @quality, System.String @eventId, System.String @id, System.String @avoidDoubleRecording, System.String @mode, System.String @priority, System.String @storageUri, System.String @override, System.String @autoTransfer, System.String @trackedTitle, System.Int32 @videoIndex, System.Int32 @audioIndex, System.Int32 @subtitleIndex, System.String @groupId, System.String @recordItemWithParentalLock);
        }

        public class AddScheduleRequest
        {
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("repeatType")]
            public System.String RepeatType { get; set; }
            [JsonProperty("quality")]
            public System.String Quality { get; set; }
            public AddScheduleRequest() { }
            public AddScheduleRequest(System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @quality)
            {
                this.Type = @type;
                this.Uri = @uri;
                this.Title = @title;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.RepeatType = @repeatType;
                this.Quality = @quality;
            }
        }
        public class AddScheduleResponse
        {
            [JsonProperty("annotation")]
            public System.Int32 Annotation { get; set; }
            public AddScheduleResponse() { }
            public AddScheduleResponse(System.Int32 @annotation)
            {
                this.Annotation = @annotation;
            }
        }
        public class DeleteScheduleRequest
        {
            [JsonProperty("id")]
            public System.String Id { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            public DeleteScheduleRequest() { }
            public DeleteScheduleRequest(System.String @id, System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec)
            {
                this.Id = @id;
                this.Type = @type;
                this.Uri = @uri;
                this.Title = @title;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
            }
        }
        public class GetConflictScheduleListRequest
        {
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("repeatType")]
            public System.String RepeatType { get; set; }
            public GetConflictScheduleListRequest() { }
            public GetConflictScheduleListRequest(System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType)
            {
                this.Uri = @uri;
                this.Title = @title;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.RepeatType = @repeatType;
            }
        }
        public class GetConflictScheduleListResponse
        {
            [JsonProperty("id")]
            public System.String Id { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("repeatType")]
            public System.String RepeatType { get; set; }
            public GetConflictScheduleListResponse() { }
            public GetConflictScheduleListResponse(System.String @id, System.String @title, System.String @type, System.String @uri, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType)
            {
                this.Id = @id;
                this.Title = @title;
                this.Type = @type;
                this.Uri = @uri;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.RepeatType = @repeatType;
            }
        }
        public class GetHistoryListRequest
        {
            [JsonProperty("stIdx")]
            public System.Int32 StIdx { get; set; }
            [JsonProperty("cnt")]
            public System.Int32 Cnt { get; set; }
            public GetHistoryListRequest() { }
            public GetHistoryListRequest(System.Int32 @stIdx, System.Int32 @cnt)
            {
                this.StIdx = @stIdx;
                this.Cnt = @cnt;
            }
        }
        public class GetHistoryListResponse
        {
            [JsonProperty("id")]
            public System.String Id { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("channelName")]
            public System.String ChannelName { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("reasonId")]
            public System.Int32 ReasonId { get; set; }
            [JsonProperty("reasonMsg")]
            public System.String ReasonMsg { get; set; }
            public GetHistoryListResponse() { }
            public GetHistoryListResponse(System.String @id, System.String @title, System.String @channelName, System.String @startDateTime, System.Int32 @durationSec, System.Int32 @reasonId, System.String @reasonMsg)
            {
                this.Id = @id;
                this.Title = @title;
                this.ChannelName = @channelName;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.ReasonId = @reasonId;
                this.ReasonMsg = @reasonMsg;
            }
        }
        public class GetRecordingStatusResponse
        {
            [JsonProperty("status")]
            public System.String Status { get; set; }
            public GetRecordingStatusResponse() { }
            public GetRecordingStatusResponse(System.String @status)
            {
                this.Status = @status;
            }
        }
        public class GetScheduleListRequest
        {
            [JsonProperty("stIdx")]
            public System.Int32 StIdx { get; set; }
            [JsonProperty("cnt")]
            public System.Int32 Cnt { get; set; }
            public GetScheduleListRequest() { }
            public GetScheduleListRequest(System.Int32 @stIdx, System.Int32 @cnt)
            {
                this.StIdx = @stIdx;
                this.Cnt = @cnt;
            }
        }
        public class GetScheduleListResponse
        {
            [JsonProperty("id")]
            public System.String Id { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("channelName")]
            public System.String ChannelName { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("repeatType")]
            public System.String RepeatType { get; set; }
            [JsonProperty("overlapStatus")]
            public System.String OverlapStatus { get; set; }
            [JsonProperty("recordingStatus")]
            public System.String RecordingStatus { get; set; }
            [JsonProperty("quality")]
            public System.String Quality { get; set; }
            public GetScheduleListResponse() { }
            public GetScheduleListResponse(System.String @id, System.String @type, System.String @uri, System.String @title, System.String @channelName, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @overlapStatus, System.String @recordingStatus, System.String @quality)
            {
                this.Id = @id;
                this.Type = @type;
                this.Uri = @uri;
                this.Title = @title;
                this.ChannelName = @channelName;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.RepeatType = @repeatType;
                this.OverlapStatus = @overlapStatus;
                this.RecordingStatus = @recordingStatus;
                this.Quality = @quality;
            }
        }
        public class AddScheduleRequestV1_1
        {
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("repeatType")]
            public System.String RepeatType { get; set; }
            [JsonProperty("quality")]
            public System.String Quality { get; set; }
            [JsonProperty("eventId")]
            public System.String EventId { get; set; }
            public AddScheduleRequestV1_1() { }
            public AddScheduleRequestV1_1(System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @quality, System.String @eventId)
            {
                this.Type = @type;
                this.Uri = @uri;
                this.Title = @title;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.RepeatType = @repeatType;
                this.Quality = @quality;
                this.EventId = @eventId;
            }
        }
        public class AddScheduleResponseV1_1
        {
            [JsonProperty("annotation")]
            public System.Int32 Annotation { get; set; }
            public AddScheduleResponseV1_1() { }
            public AddScheduleResponseV1_1(System.Int32 @annotation)
            {
                this.Annotation = @annotation;
            }
        }
        public class GetScheduleListRequestV1_1
        {
            [JsonProperty("stIdx")]
            public System.Int32 StIdx { get; set; }
            [JsonProperty("cnt")]
            public System.Int32 Cnt { get; set; }
            public GetScheduleListRequestV1_1() { }
            public GetScheduleListRequestV1_1(System.Int32 @stIdx, System.Int32 @cnt)
            {
                this.StIdx = @stIdx;
                this.Cnt = @cnt;
            }
        }
        public class GetScheduleListResponseV1_1
        {
            [JsonProperty("id")]
            public System.String Id { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("channelName")]
            public System.String ChannelName { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("repeatType")]
            public System.String RepeatType { get; set; }
            [JsonProperty("overlapStatus")]
            public System.String OverlapStatus { get; set; }
            [JsonProperty("recordingStatus")]
            public System.String RecordingStatus { get; set; }
            [JsonProperty("quality")]
            public System.String Quality { get; set; }
            [JsonProperty("eventId")]
            public System.String EventId { get; set; }
            public GetScheduleListResponseV1_1() { }
            public GetScheduleListResponseV1_1(System.String @id, System.String @type, System.String @uri, System.String @title, System.String @channelName, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @overlapStatus, System.String @recordingStatus, System.String @quality, System.String @eventId)
            {
                this.Id = @id;
                this.Type = @type;
                this.Uri = @uri;
                this.Title = @title;
                this.ChannelName = @channelName;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.RepeatType = @repeatType;
                this.OverlapStatus = @overlapStatus;
                this.RecordingStatus = @recordingStatus;
                this.Quality = @quality;
                this.EventId = @eventId;
            }
        }
        public class AddScheduleRequestV1_2
        {
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("uri")]
            public System.String Uri { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("startDateTime")]
            public System.String StartDateTime { get; set; }
            [JsonProperty("durationSec")]
            public System.Int32 DurationSec { get; set; }
            [JsonProperty("repeatType")]
            public System.String RepeatType { get; set; }
            [JsonProperty("quality")]
            public System.String Quality { get; set; }
            [JsonProperty("eventId")]
            public System.String EventId { get; set; }
            [JsonProperty("id")]
            public System.String Id { get; set; }
            [JsonProperty("avoidDoubleRecording")]
            public System.String AvoidDoubleRecording { get; set; }
            [JsonProperty("mode")]
            public System.String Mode { get; set; }
            [JsonProperty("priority")]
            public System.String Priority { get; set; }
            [JsonProperty("storageUri")]
            public System.String StorageUri { get; set; }
            [JsonProperty("override")]
            public System.String Override { get; set; }
            [JsonProperty("autoTransfer")]
            public System.String AutoTransfer { get; set; }
            [JsonProperty("trackedTitle")]
            public System.String TrackedTitle { get; set; }
            [JsonProperty("videoIndex")]
            public System.Int32 VideoIndex { get; set; }
            [JsonProperty("audioIndex")]
            public System.Int32 AudioIndex { get; set; }
            [JsonProperty("subtitleIndex")]
            public System.Int32 SubtitleIndex { get; set; }
            [JsonProperty("groupId")]
            public System.String GroupId { get; set; }
            [JsonProperty("recordItemWithParentalLock")]
            public System.String RecordItemWithParentalLock { get; set; }
            public AddScheduleRequestV1_2() { }
            public AddScheduleRequestV1_2(System.String @type, System.String @uri, System.String @title, System.String @startDateTime, System.Int32 @durationSec, System.String @repeatType, System.String @quality, System.String @eventId, System.String @id, System.String @avoidDoubleRecording, System.String @mode, System.String @priority, System.String @storageUri, System.String @override, System.String @autoTransfer, System.String @trackedTitle, System.Int32 @videoIndex, System.Int32 @audioIndex, System.Int32 @subtitleIndex, System.String @groupId, System.String @recordItemWithParentalLock)
            {
                this.Type = @type;
                this.Uri = @uri;
                this.Title = @title;
                this.StartDateTime = @startDateTime;
                this.DurationSec = @durationSec;
                this.RepeatType = @repeatType;
                this.Quality = @quality;
                this.EventId = @eventId;
                this.Id = @id;
                this.AvoidDoubleRecording = @avoidDoubleRecording;
                this.Mode = @mode;
                this.Priority = @priority;
                this.StorageUri = @storageUri;
                this.Override = @override;
                this.AutoTransfer = @autoTransfer;
                this.TrackedTitle = @trackedTitle;
                this.VideoIndex = @videoIndex;
                this.AudioIndex = @audioIndex;
                this.SubtitleIndex = @subtitleIndex;
                this.GroupId = @groupId;
                this.RecordItemWithParentalLock = @recordItemWithParentalLock;
            }
        }
        public class AddScheduleResponseV1_2
        {
            [JsonProperty("annotation")]
            public System.Int32 Annotation { get; set; }
            [JsonProperty("conflict")]
            public System.Object[] Conflict { get; set; }
            public AddScheduleResponseV1_2() { }
            public AddScheduleResponseV1_2(System.Int32 @annotation, System.Object[] @conflict)
            {
                this.Annotation = @annotation;
                this.Conflict = @conflict;
            }
        }

        #endregion
        #region IAudio
        Task<GetSpeakerSettingsResponse[]> IAudio.GetSpeakerSettingsAsync(GetSpeakerSettingsRequest @arg0) { return InvokeAsync<GetSpeakerSettingsResponse[]>("audio", "getSpeakerSettings", 1, "1.0", new object[] { @arg0 }); }
        Task<GetSpeakerSettingsResponse[]> IAudio.GetSpeakerSettingsAsync(System.String @target) { return ((IAudio)this).GetSpeakerSettingsAsync(new GetSpeakerSettingsRequest(@target)); }
        Task<GetVolumeInformationResponse[]> IAudio.GetVolumeInformationAsync() { return InvokeAsync<GetVolumeInformationResponse[]>("audio", "getVolumeInformation", 1, "1.0", new object[] { }); }
        Task<System.Int32> IAudio.SetAudioMuteAsync(SetAudioMuteRequest @arg0) { return InvokeAsync<System.Int32>("audio", "setAudioMute", 1, "1.0", new object[] { @arg0 }); }
        Task<System.Int32> IAudio.SetAudioMuteAsync(System.Boolean @status) { return ((IAudio)this).SetAudioMuteAsync(new SetAudioMuteRequest(@status)); }
        Task<System.Int32> IAudio.SetAudioVolumeAsync(SetAudioVolumeRequest @arg0) { return InvokeAsync<System.Int32>("audio", "setAudioVolume", 1, "1.0", new object[] { @arg0 }); }
        Task<System.Int32> IAudio.SetAudioVolumeAsync(System.String @target, System.String @volume) { return ((IAudio)this).SetAudioVolumeAsync(new SetAudioVolumeRequest(@target, @volume)); }
        Task IAudio.SetSpeakerSettingsAsync(SetSpeakerSettingsRequest @arg0) { return InvokeAsync("audio", "setSpeakerSettings", 1, "1.0", new object[] { @arg0 }); }
        Task IAudio.SetSpeakerSettingsAsync(System.Object[] @settings) { return ((IAudio)this).SetSpeakerSettingsAsync(new SetSpeakerSettingsRequest(@settings)); }
        Task<System.String[]> IAudio.GetVersionsAsync() { return InvokeAsync<System.String[]>("audio", "getVersions", 1, "1.0", new object[] { }); }
        Task<GetSoundSettingsResponse[]> IAudio.GetSoundSettingsAsync(GetSoundSettingsRequest @arg0) { return InvokeAsync<GetSoundSettingsResponse[]>("audio", "getSoundSettings", 1, "1.1", new object[] { @arg0 }); }
        Task<GetSoundSettingsResponse[]> IAudio.GetSoundSettingsAsync(System.String @target) { return ((IAudio)this).GetSoundSettingsAsync(new GetSoundSettingsRequest(@target)); }
        Task IAudio.SetSoundSettingsAsync(SetSoundSettingsRequest @arg0) { return InvokeAsync("audio", "setSoundSettings", 1, "1.1", new object[] { @arg0 }); }
        Task IAudio.SetSoundSettingsAsync(System.Object[] @settings) { return ((IAudio)this).SetSoundSettingsAsync(new SetSoundSettingsRequest(@settings)); }

        public interface IAudio
        {
            Task<GetSpeakerSettingsResponse[]> GetSpeakerSettingsAsync(GetSpeakerSettingsRequest @arg0);
            Task<GetSpeakerSettingsResponse[]> GetSpeakerSettingsAsync(System.String @target);
            Task<GetVolumeInformationResponse[]> GetVolumeInformationAsync();
            Task<System.Int32> SetAudioMuteAsync(SetAudioMuteRequest @arg0);
            Task<System.Int32> SetAudioMuteAsync(System.Boolean @status);
            Task<System.Int32> SetAudioVolumeAsync(SetAudioVolumeRequest @arg0);
            Task<System.Int32> SetAudioVolumeAsync(System.String @target, System.String @volume);
            Task SetSpeakerSettingsAsync(SetSpeakerSettingsRequest @arg0);
            Task SetSpeakerSettingsAsync(System.Object[] @settings);
            Task<System.String[]> GetVersionsAsync();
            Task<GetSoundSettingsResponse[]> GetSoundSettingsAsync(GetSoundSettingsRequest @arg0);
            Task<GetSoundSettingsResponse[]> GetSoundSettingsAsync(System.String @target);
            Task SetSoundSettingsAsync(SetSoundSettingsRequest @arg0);
            Task SetSoundSettingsAsync(System.Object[] @settings);
        }

        public class GetSpeakerSettingsRequest
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            public GetSpeakerSettingsRequest() { }
            public GetSpeakerSettingsRequest(System.String @target)
            {
                this.Target = @target;
            }
        }
        public class GetSpeakerSettingsResponse
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            [JsonProperty("currentValue")]
            public System.String CurrentValue { get; set; }
            [JsonProperty("deviceUIInfo")]
            public System.String DeviceUIInfo { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("titleTextID")]
            public System.String TitleTextID { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("isAvailable")]
            public System.Boolean IsAvailable { get; set; }
            [JsonProperty("candidate")]
            public System.Object[] Candidate { get; set; }
            public GetSpeakerSettingsResponse() { }
            public GetSpeakerSettingsResponse(System.String @target, System.String @currentValue, System.String @deviceUIInfo, System.String @title, System.String @titleTextID, System.String @type, System.Boolean @isAvailable, System.Object[] @candidate)
            {
                this.Target = @target;
                this.CurrentValue = @currentValue;
                this.DeviceUIInfo = @deviceUIInfo;
                this.Title = @title;
                this.TitleTextID = @titleTextID;
                this.Type = @type;
                this.IsAvailable = @isAvailable;
                this.Candidate = @candidate;
            }
        }
        public class GetVolumeInformationResponse
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            [JsonProperty("volume")]
            public System.Int32 Volume { get; set; }
            [JsonProperty("mute")]
            public System.Boolean Mute { get; set; }
            [JsonProperty("maxVolume")]
            public System.Int32 MaxVolume { get; set; }
            [JsonProperty("minVolume")]
            public System.Int32 MinVolume { get; set; }
            public GetVolumeInformationResponse() { }
            public GetVolumeInformationResponse(System.String @target, System.Int32 @volume, System.Boolean @mute, System.Int32 @maxVolume, System.Int32 @minVolume)
            {
                this.Target = @target;
                this.Volume = @volume;
                this.Mute = @mute;
                this.MaxVolume = @maxVolume;
                this.MinVolume = @minVolume;
            }
        }
        public class SetAudioMuteRequest
        {
            [JsonProperty("status")]
            public System.Boolean Status { get; set; }
            public SetAudioMuteRequest() { }
            public SetAudioMuteRequest(System.Boolean @status)
            {
                this.Status = @status;
            }
        }
        public class SetAudioVolumeRequest
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            [JsonProperty("volume")]
            public System.String Volume { get; set; }
            public SetAudioVolumeRequest() { }
            public SetAudioVolumeRequest(System.String @target, System.String @volume)
            {
                this.Target = @target;
                this.Volume = @volume;
            }
        }
        public class SetSpeakerSettingsRequest
        {
            [JsonProperty("settings")]
            public System.Object[] Settings { get; set; }
            public SetSpeakerSettingsRequest() { }
            public SetSpeakerSettingsRequest(System.Object[] @settings)
            {
                this.Settings = @settings;
            }
        }
        public class GetSoundSettingsRequest
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            public GetSoundSettingsRequest() { }
            public GetSoundSettingsRequest(System.String @target)
            {
                this.Target = @target;
            }
        }
        public class GetSoundSettingsResponse
        {
            [JsonProperty("target")]
            public System.String Target { get; set; }
            [JsonProperty("currentValue")]
            public System.String CurrentValue { get; set; }
            [JsonProperty("deviceUIInfo")]
            public System.String DeviceUIInfo { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("titleTextID")]
            public System.String TitleTextID { get; set; }
            [JsonProperty("type")]
            public System.String Type { get; set; }
            [JsonProperty("isAvailable")]
            public System.Boolean IsAvailable { get; set; }
            [JsonProperty("candidate")]
            public System.Object[] Candidate { get; set; }
            public GetSoundSettingsResponse() { }
            public GetSoundSettingsResponse(System.String @target, System.String @currentValue, System.String @deviceUIInfo, System.String @title, System.String @titleTextID, System.String @type, System.Boolean @isAvailable, System.Object[] @candidate)
            {
                this.Target = @target;
                this.CurrentValue = @currentValue;
                this.DeviceUIInfo = @deviceUIInfo;
                this.Title = @title;
                this.TitleTextID = @titleTextID;
                this.Type = @type;
                this.IsAvailable = @isAvailable;
                this.Candidate = @candidate;
            }
        }
        public class SetSoundSettingsRequest
        {
            [JsonProperty("settings")]
            public System.Object[] Settings { get; set; }
            public SetSoundSettingsRequest() { }
            public SetSoundSettingsRequest(System.Object[] @settings)
            {
                this.Settings = @settings;
            }
        }

        #endregion
        #region IGuide
        Task<GetServiceProtocolsCompositeResponse> IGuide.GetServiceProtocolsAsync() { return InvokeAsync<GetServiceProtocolsCompositeResponse>("guide", "getServiceProtocols", 1, "1.0", new object[] { }); }
        Task<GetSupportedApiInfoResponse[]> IGuide.GetSupportedApiInfoAsync(GetSupportedApiInfoRequest @arg0) { return InvokeAsync<GetSupportedApiInfoResponse[]>("guide", "getSupportedApiInfo", 1, "1.0", new object[] { @arg0 }); }
        Task<GetSupportedApiInfoResponse[]> IGuide.GetSupportedApiInfoAsync(System.String[] @services) { return ((IGuide)this).GetSupportedApiInfoAsync(new GetSupportedApiInfoRequest(@services)); }
        Task<System.String[]> IGuide.GetVersionsAsync() { return InvokeAsync<System.String[]>("guide", "getVersions", 1, "1.0", new object[] { }); }

        public interface IGuide
        {
            Task<GetServiceProtocolsCompositeResponse> GetServiceProtocolsAsync();
            Task<GetSupportedApiInfoResponse[]> GetSupportedApiInfoAsync(GetSupportedApiInfoRequest @arg0);
            Task<GetSupportedApiInfoResponse[]> GetSupportedApiInfoAsync(System.String[] @services);
            Task<System.String[]> GetVersionsAsync();
        }

        public class GetSupportedApiInfoRequest
        {
            [JsonProperty("services")]
            public System.String[] Services { get; set; }
            public GetSupportedApiInfoRequest() { }
            public GetSupportedApiInfoRequest(System.String[] @services)
            {
                this.Services = @services;
            }
        }
        public class GetSupportedApiInfoResponse
        {
            [JsonProperty("service")]
            public System.String Service { get; set; }
            [JsonProperty("protocols")]
            public System.String[] Protocols { get; set; }
            [JsonProperty("apis")]
            public System.Object[] Apis { get; set; }
            public GetSupportedApiInfoResponse() { }
            public GetSupportedApiInfoResponse(System.String @service, System.String[] @protocols, System.Object[] @apis)
            {
                this.Service = @service;
                this.Protocols = @protocols;
                this.Apis = @apis;
            }
        }

        public class GetServiceProtocolsCompositeResponse : ICompositeResponse
        {
            public System.String Item0 { get; set; }
            public System.String[] Item1 { get; set; }
            public void ReadFromJson(JArray values)
            {
                this.Item0 = ((JToken)values[0])?.ToObject<System.String>();
                this.Item1 = ((JToken)values[1])?.ToObject<System.String[]>();
            }
        }
        #endregion
        #region ICec
        Task ICec.SetCecControlModeAsync(SetCecControlModeRequest @arg0) { return InvokeAsync("cec", "setCecControlMode", 1, "1.0", new object[] { @arg0 }); }
        Task ICec.SetCecControlModeAsync(System.Boolean @enabled) { return ((ICec)this).SetCecControlModeAsync(new SetCecControlModeRequest(@enabled)); }
        Task ICec.SetMhlAutoInputChangeModeAsync(SetMhlAutoInputChangeModeRequest @arg0) { return InvokeAsync("cec", "setMhlAutoInputChangeMode", 1, "1.0", new object[] { @arg0 }); }
        Task ICec.SetMhlAutoInputChangeModeAsync(System.Boolean @enabled) { return ((ICec)this).SetMhlAutoInputChangeModeAsync(new SetMhlAutoInputChangeModeRequest(@enabled)); }
        Task ICec.SetMhlPowerFeedModeAsync(SetMhlPowerFeedModeRequest @arg0) { return InvokeAsync("cec", "setMhlPowerFeedMode", 1, "1.0", new object[] { @arg0 }); }
        Task ICec.SetMhlPowerFeedModeAsync(System.Boolean @enabled) { return ((ICec)this).SetMhlPowerFeedModeAsync(new SetMhlPowerFeedModeRequest(@enabled)); }
        Task ICec.SetPowerSyncModeAsync(SetPowerSyncModeRequest @arg0) { return InvokeAsync("cec", "setPowerSyncMode", 1, "1.0", new object[] { @arg0 }); }
        Task ICec.SetPowerSyncModeAsync(System.Boolean @sinkPowerOffSync, System.Boolean @sourcePowerOnSync) { return ((ICec)this).SetPowerSyncModeAsync(new SetPowerSyncModeRequest(@sinkPowerOffSync, @sourcePowerOnSync)); }
        Task<System.String[]> ICec.GetVersionsAsync() { return InvokeAsync<System.String[]>("cec", "getVersions", 1, "1.0", new object[] { }); }

        public interface ICec
        {
            Task SetCecControlModeAsync(SetCecControlModeRequest @arg0);
            Task SetCecControlModeAsync(System.Boolean @enabled);
            Task SetMhlAutoInputChangeModeAsync(SetMhlAutoInputChangeModeRequest @arg0);
            Task SetMhlAutoInputChangeModeAsync(System.Boolean @enabled);
            Task SetMhlPowerFeedModeAsync(SetMhlPowerFeedModeRequest @arg0);
            Task SetMhlPowerFeedModeAsync(System.Boolean @enabled);
            Task SetPowerSyncModeAsync(SetPowerSyncModeRequest @arg0);
            Task SetPowerSyncModeAsync(System.Boolean @sinkPowerOffSync, System.Boolean @sourcePowerOnSync);
            Task<System.String[]> GetVersionsAsync();
        }

        public class SetCecControlModeRequest
        {
            [JsonProperty("enabled")]
            public System.Boolean Enabled { get; set; }
            public SetCecControlModeRequest() { }
            public SetCecControlModeRequest(System.Boolean @enabled)
            {
                this.Enabled = @enabled;
            }
        }
        public class SetMhlAutoInputChangeModeRequest
        {
            [JsonProperty("enabled")]
            public System.Boolean Enabled { get; set; }
            public SetMhlAutoInputChangeModeRequest() { }
            public SetMhlAutoInputChangeModeRequest(System.Boolean @enabled)
            {
                this.Enabled = @enabled;
            }
        }
        public class SetMhlPowerFeedModeRequest
        {
            [JsonProperty("enabled")]
            public System.Boolean Enabled { get; set; }
            public SetMhlPowerFeedModeRequest() { }
            public SetMhlPowerFeedModeRequest(System.Boolean @enabled)
            {
                this.Enabled = @enabled;
            }
        }
        public class SetPowerSyncModeRequest
        {
            [JsonProperty("sinkPowerOffSync")]
            public System.Boolean SinkPowerOffSync { get; set; }
            [JsonProperty("sourcePowerOnSync")]
            public System.Boolean SourcePowerOnSync { get; set; }
            public SetPowerSyncModeRequest() { }
            public SetPowerSyncModeRequest(System.Boolean @sinkPowerOffSync, System.Boolean @sourcePowerOnSync)
            {
                this.SinkPowerOffSync = @sinkPowerOffSync;
                this.SourcePowerOnSync = @sourcePowerOnSync;
            }
        }

        #endregion
        #region IVideoScreen
        Task<GetAudioSourceScreenResponse> IVideoScreen.GetAudioSourceScreenAsync() { return InvokeAsync<GetAudioSourceScreenResponse>("videoScreen", "getAudioSourceScreen", 1, "1.0", new object[] { }); }
        Task<GetBannerModeResponse> IVideoScreen.GetBannerModeAsync() { return InvokeAsync<GetBannerModeResponse>("videoScreen", "getBannerMode", 1, "1.0", new object[] { }); }
        Task<GetPipSubScreenPositionResponse> IVideoScreen.GetPipSubScreenPositionAsync() { return InvokeAsync<GetPipSubScreenPositionResponse>("videoScreen", "getPipSubScreenPosition", 1, "1.0", new object[] { }); }
        Task<GetSceneSettingResponse> IVideoScreen.GetSceneSettingAsync() { return InvokeAsync<GetSceneSettingResponse>("videoScreen", "getSceneSetting", 1, "1.0", new object[] { }); }
        Task IVideoScreen.SetAudioSourceScreenAsync(SetAudioSourceScreenRequest @arg0) { return InvokeAsync("videoScreen", "setAudioSourceScreen", 1, "1.0", new object[] { @arg0 }); }
        Task IVideoScreen.SetAudioSourceScreenAsync(System.String @screen) { return ((IVideoScreen)this).SetAudioSourceScreenAsync(new SetAudioSourceScreenRequest(@screen)); }
        Task IVideoScreen.SetBannerModeAsync(SetBannerModeRequest @arg0) { return InvokeAsync("videoScreen", "setBannerMode", 1, "1.0", new object[] { @arg0 }); }
        Task IVideoScreen.SetBannerModeAsync(System.String @value) { return ((IVideoScreen)this).SetBannerModeAsync(new SetBannerModeRequest(@value)); }
        Task IVideoScreen.SetMultiScreenModeAsync(SetMultiScreenModeRequest @arg0) { return InvokeAsync("videoScreen", "setMultiScreenMode", 1, "1.0", new object[] { @arg0 }); }
        Task IVideoScreen.SetMultiScreenModeAsync(System.String @mode, System.Object @option) { return ((IVideoScreen)this).SetMultiScreenModeAsync(new SetMultiScreenModeRequest(@mode, @option)); }
        Task IVideoScreen.SetPapScreenSizeAsync(SetPapScreenSizeRequest @arg0) { return InvokeAsync("videoScreen", "setPapScreenSize", 1, "1.0", new object[] { @arg0 }); }
        Task IVideoScreen.SetPapScreenSizeAsync(System.String @screen, System.String @size) { return ((IVideoScreen)this).SetPapScreenSizeAsync(new SetPapScreenSizeRequest(@screen, @size)); }
        Task IVideoScreen.SetPipSubScreenPositionAsync(SetPipSubScreenPositionRequest @arg0) { return InvokeAsync("videoScreen", "setPipSubScreenPosition", 1, "1.0", new object[] { @arg0 }); }
        Task IVideoScreen.SetPipSubScreenPositionAsync(System.String @position) { return ((IVideoScreen)this).SetPipSubScreenPositionAsync(new SetPipSubScreenPositionRequest(@position)); }
        Task IVideoScreen.SetSceneSettingAsync(SetSceneSettingRequest @arg0) { return InvokeAsync("videoScreen", "setSceneSetting", 1, "1.0", new object[] { @arg0 }); }
        Task IVideoScreen.SetSceneSettingAsync(System.String @value) { return ((IVideoScreen)this).SetSceneSettingAsync(new SetSceneSettingRequest(@value)); }
        Task<System.String[]> IVideoScreen.GetVersionsAsync() { return InvokeAsync<System.String[]>("videoScreen", "getVersions", 1, "1.0", new object[] { }); }
        Task<GetMultiScreenModeResponse> IVideoScreen.GetMultiScreenModeAsync() { return InvokeAsync<GetMultiScreenModeResponse>("videoScreen", "getMultiScreenMode", 1, "1.1", new object[] { }); }
        Task<RequestToNotifyScreenStateResponse> IVideoScreen.RequestToNotifyScreenStateAsync(RequestToNotifyScreenStateRequest @arg0) { return InvokeAsync<RequestToNotifyScreenStateResponse>("videoScreen", "requestToNotifyScreenState", 1, "1.1", new object[] { @arg0 }); }
        Task<RequestToNotifyScreenStateResponse> IVideoScreen.RequestToNotifyScreenStateAsync(System.String @multiScreenMode, System.String @pipSubScreenPosition, System.String @audioSourceScreen, System.Object @option) { return ((IVideoScreen)this).RequestToNotifyScreenStateAsync(new RequestToNotifyScreenStateRequest(@multiScreenMode, @pipSubScreenPosition, @audioSourceScreen, @option)); }

        public interface IVideoScreen
        {
            Task<GetAudioSourceScreenResponse> GetAudioSourceScreenAsync();
            Task<GetBannerModeResponse> GetBannerModeAsync();
            Task<GetPipSubScreenPositionResponse> GetPipSubScreenPositionAsync();
            Task<GetSceneSettingResponse> GetSceneSettingAsync();
            Task SetAudioSourceScreenAsync(SetAudioSourceScreenRequest @arg0);
            Task SetAudioSourceScreenAsync(System.String @screen);
            Task SetBannerModeAsync(SetBannerModeRequest @arg0);
            Task SetBannerModeAsync(System.String @value);
            Task SetMultiScreenModeAsync(SetMultiScreenModeRequest @arg0);
            Task SetMultiScreenModeAsync(System.String @mode, System.Object @option);
            Task SetPapScreenSizeAsync(SetPapScreenSizeRequest @arg0);
            Task SetPapScreenSizeAsync(System.String @screen, System.String @size);
            Task SetPipSubScreenPositionAsync(SetPipSubScreenPositionRequest @arg0);
            Task SetPipSubScreenPositionAsync(System.String @position);
            Task SetSceneSettingAsync(SetSceneSettingRequest @arg0);
            Task SetSceneSettingAsync(System.String @value);
            Task<System.String[]> GetVersionsAsync();
            Task<GetMultiScreenModeResponse> GetMultiScreenModeAsync();
            Task<RequestToNotifyScreenStateResponse> RequestToNotifyScreenStateAsync(RequestToNotifyScreenStateRequest @arg0);
            Task<RequestToNotifyScreenStateResponse> RequestToNotifyScreenStateAsync(System.String @multiScreenMode, System.String @pipSubScreenPosition, System.String @audioSourceScreen, System.Object @option);
        }

        public class GetAudioSourceScreenResponse
        {
            [JsonProperty("screen")]
            public System.String Screen { get; set; }
            public GetAudioSourceScreenResponse() { }
            public GetAudioSourceScreenResponse(System.String @screen)
            {
                this.Screen = @screen;
            }
        }
        public class GetBannerModeResponse
        {
            [JsonProperty("currentValue")]
            public System.String CurrentValue { get; set; }
            [JsonProperty("candidate")]
            public System.Object[] Candidate { get; set; }
            public GetBannerModeResponse() { }
            public GetBannerModeResponse(System.String @currentValue, System.Object[] @candidate)
            {
                this.CurrentValue = @currentValue;
                this.Candidate = @candidate;
            }
        }
        public class GetPipSubScreenPositionResponse
        {
            [JsonProperty("position")]
            public System.String Position { get; set; }
            public GetPipSubScreenPositionResponse() { }
            public GetPipSubScreenPositionResponse(System.String @position)
            {
                this.Position = @position;
            }
        }
        public class GetSceneSettingResponse
        {
            [JsonProperty("currentValue")]
            public System.String CurrentValue { get; set; }
            [JsonProperty("candidate")]
            public System.Object[] Candidate { get; set; }
            public GetSceneSettingResponse() { }
            public GetSceneSettingResponse(System.String @currentValue, System.Object[] @candidate)
            {
                this.CurrentValue = @currentValue;
                this.Candidate = @candidate;
            }
        }
        public class SetAudioSourceScreenRequest
        {
            [JsonProperty("screen")]
            public System.String Screen { get; set; }
            public SetAudioSourceScreenRequest() { }
            public SetAudioSourceScreenRequest(System.String @screen)
            {
                this.Screen = @screen;
            }
        }
        public class SetBannerModeRequest
        {
            [JsonProperty("value")]
            public System.String Value { get; set; }
            public SetBannerModeRequest() { }
            public SetBannerModeRequest(System.String @value)
            {
                this.Value = @value;
            }
        }
        public class SetMultiScreenModeRequest
        {
            [JsonProperty("mode")]
            public System.String Mode { get; set; }
            [JsonProperty("option")]
            public System.Object Option { get; set; }
            public SetMultiScreenModeRequest() { }
            public SetMultiScreenModeRequest(System.String @mode, System.Object @option)
            {
                this.Mode = @mode;
                this.Option = @option;
            }
        }
        public class SetPapScreenSizeRequest
        {
            [JsonProperty("screen")]
            public System.String Screen { get; set; }
            [JsonProperty("size")]
            public System.String Size { get; set; }
            public SetPapScreenSizeRequest() { }
            public SetPapScreenSizeRequest(System.String @screen, System.String @size)
            {
                this.Screen = @screen;
                this.Size = @size;
            }
        }
        public class SetPipSubScreenPositionRequest
        {
            [JsonProperty("position")]
            public System.String Position { get; set; }
            public SetPipSubScreenPositionRequest() { }
            public SetPipSubScreenPositionRequest(System.String @position)
            {
                this.Position = @position;
            }
        }
        public class SetSceneSettingRequest
        {
            [JsonProperty("value")]
            public System.String Value { get; set; }
            public SetSceneSettingRequest() { }
            public SetSceneSettingRequest(System.String @value)
            {
                this.Value = @value;
            }
        }
        public class GetMultiScreenModeResponse
        {
            [JsonProperty("mode")]
            public System.String Mode { get; set; }
            [JsonProperty("option")]
            public System.Object Option { get; set; }
            public GetMultiScreenModeResponse() { }
            public GetMultiScreenModeResponse(System.String @mode, System.Object @option)
            {
                this.Mode = @mode;
                this.Option = @option;
            }
        }
        public class RequestToNotifyScreenStateRequest
        {
            [JsonProperty("multiScreenMode")]
            public System.String MultiScreenMode { get; set; }
            [JsonProperty("pipSubScreenPosition")]
            public System.String PipSubScreenPosition { get; set; }
            [JsonProperty("audioSourceScreen")]
            public System.String AudioSourceScreen { get; set; }
            [JsonProperty("option")]
            public System.Object Option { get; set; }
            public RequestToNotifyScreenStateRequest() { }
            public RequestToNotifyScreenStateRequest(System.String @multiScreenMode, System.String @pipSubScreenPosition, System.String @audioSourceScreen, System.Object @option)
            {
                this.MultiScreenMode = @multiScreenMode;
                this.PipSubScreenPosition = @pipSubScreenPosition;
                this.AudioSourceScreen = @audioSourceScreen;
                this.Option = @option;
            }
        }
        public class RequestToNotifyScreenStateResponse
        {
            [JsonProperty("multiScreenMode")]
            public System.String MultiScreenMode { get; set; }
            [JsonProperty("pipSubScreenPosition")]
            public System.String PipSubScreenPosition { get; set; }
            [JsonProperty("audioSourceScreen")]
            public System.String AudioSourceScreen { get; set; }
            [JsonProperty("option")]
            public System.Object Option { get; set; }
            public RequestToNotifyScreenStateResponse() { }
            public RequestToNotifyScreenStateResponse(System.String @multiScreenMode, System.String @pipSubScreenPosition, System.String @audioSourceScreen, System.Object @option)
            {
                this.MultiScreenMode = @multiScreenMode;
                this.PipSubScreenPosition = @pipSubScreenPosition;
                this.AudioSourceScreen = @audioSourceScreen;
                this.Option = @option;
            }
        }

        #endregion
        #region IBroadcastLink
        Task<GetBroadcastLinkServerInfoResponse> IBroadcastLink.GetBroadcastLinkServerInfoAsync() { return InvokeAsync<GetBroadcastLinkServerInfoResponse>("broadcastLink", "getBroadcastLinkServerInfo", 1, "1.0", new object[] { }); }
        Task<RequestToNotifyEventResponse> IBroadcastLink.RequestToNotifyEventAsync(RequestToNotifyEventRequest @arg0) { return InvokeAsync<RequestToNotifyEventResponse>("broadcastLink", "requestToNotifyEvent", 1, "1.0", new object[] { @arg0 }); }
        Task<RequestToNotifyEventResponse> IBroadcastLink.RequestToNotifyEventAsync(System.String @uuid) { return ((IBroadcastLink)this).RequestToNotifyEventAsync(new RequestToNotifyEventRequest(@uuid)); }
        Task IBroadcastLink.SendMessageAsync(SendMessageRequest @arg0) { return InvokeAsync("broadcastLink", "sendMessage", 1, "1.0", new object[] { @arg0 }); }
        Task IBroadcastLink.SendMessageAsync(System.String @uuid, System.String @message) { return ((IBroadcastLink)this).SendMessageAsync(new SendMessageRequest(@uuid, @message)); }
        Task<SetConnectionModeResponse> IBroadcastLink.SetConnectionModeAsync(SetConnectionModeRequest @arg0) { return InvokeAsync<SetConnectionModeResponse>("broadcastLink", "setConnectionMode", 1, "1.0", new object[] { @arg0 }); }
        Task<SetConnectionModeResponse> IBroadcastLink.SetConnectionModeAsync(System.Boolean @connection, System.String @uuid) { return ((IBroadcastLink)this).SetConnectionModeAsync(new SetConnectionModeRequest(@connection, @uuid)); }
        Task<System.String[]> IBroadcastLink.GetVersionsAsync() { return InvokeAsync<System.String[]>("broadcastLink", "getVersions", 1, "1.0", new object[] { }); }

        public interface IBroadcastLink
        {
            Task<GetBroadcastLinkServerInfoResponse> GetBroadcastLinkServerInfoAsync();
            Task<RequestToNotifyEventResponse> RequestToNotifyEventAsync(RequestToNotifyEventRequest @arg0);
            Task<RequestToNotifyEventResponse> RequestToNotifyEventAsync(System.String @uuid);
            Task SendMessageAsync(SendMessageRequest @arg0);
            Task SendMessageAsync(System.String @uuid, System.String @message);
            Task<SetConnectionModeResponse> SetConnectionModeAsync(SetConnectionModeRequest @arg0);
            Task<SetConnectionModeResponse> SetConnectionModeAsync(System.Boolean @connection, System.String @uuid);
            Task<System.String[]> GetVersionsAsync();
        }

        public class GetBroadcastLinkServerInfoResponse
        {
            [JsonProperty("broadcastType")]
            public System.String BroadcastType { get; set; }
            [JsonProperty("specVersion")]
            public System.String SpecVersion { get; set; }
            public GetBroadcastLinkServerInfoResponse() { }
            public GetBroadcastLinkServerInfoResponse(System.String @broadcastType, System.String @specVersion)
            {
                this.BroadcastType = @broadcastType;
                this.SpecVersion = @specVersion;
            }
        }
        public class RequestToNotifyEventRequest
        {
            [JsonProperty("uuid")]
            public System.String Uuid { get; set; }
            public RequestToNotifyEventRequest() { }
            public RequestToNotifyEventRequest(System.String @uuid)
            {
                this.Uuid = @uuid;
            }
        }
        public class RequestToNotifyEventResponse
        {
            [JsonProperty("eventName")]
            public System.String EventName { get; set; }
            [JsonProperty("url")]
            public System.String Url { get; set; }
            [JsonProperty("title")]
            public System.String Title { get; set; }
            [JsonProperty("desc")]
            public System.String Desc { get; set; }
            [JsonProperty("isAutoOpen")]
            public System.Boolean IsAutoOpen { get; set; }
            [JsonProperty("message")]
            public System.String Message { get; set; }
            public RequestToNotifyEventResponse() { }
            public RequestToNotifyEventResponse(System.String @eventName, System.String @url, System.String @title, System.String @desc, System.Boolean @isAutoOpen, System.String @message)
            {
                this.EventName = @eventName;
                this.Url = @url;
                this.Title = @title;
                this.Desc = @desc;
                this.IsAutoOpen = @isAutoOpen;
                this.Message = @message;
            }
        }
        public class SendMessageRequest
        {
            [JsonProperty("uuid")]
            public System.String Uuid { get; set; }
            [JsonProperty("message")]
            public System.String Message { get; set; }
            public SendMessageRequest() { }
            public SendMessageRequest(System.String @uuid, System.String @message)
            {
                this.Uuid = @uuid;
                this.Message = @message;
            }
        }
        public class SetConnectionModeRequest
        {
            [JsonProperty("connection")]
            public System.Boolean Connection { get; set; }
            [JsonProperty("uuid")]
            public System.String Uuid { get; set; }
            public SetConnectionModeRequest() { }
            public SetConnectionModeRequest(System.Boolean @connection, System.String @uuid)
            {
                this.Connection = @connection;
                this.Uuid = @uuid;
            }
        }
        public class SetConnectionModeResponse
        {
            [JsonProperty("timeoutSec")]
            public System.Int32 TimeoutSec { get; set; }
            public SetConnectionModeResponse() { }
            public SetConnectionModeResponse(System.Int32 @timeoutSec)
            {
                this.TimeoutSec = @timeoutSec;
            }
        }

        #endregion
        #endregion
    }
}
