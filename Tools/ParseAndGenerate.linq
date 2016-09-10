<Query Kind="Program">
  <Reference>&lt;RuntimeDirectory&gt;\System.Net.Http.dll</Reference>
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>Newtonsoft.Json.Linq</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Net</Namespace>
</Query>

async Task Main()
{
    var deviceHost = Util.GetPassword("home.x8500c.address");
    var authKey = "";//Util.GetPassword("home.x8500c.authkey");

    var categories = new[]
    {
        "system",
        "avContent",
        "encryption",
        "browser",
        "accessControl",
        "appControl",
        "recording",
        "audio",
        "guide",
        "broadcastLink",
        "cec",
        //"contentshare",
        "videoScreen",
    };
    var writer = new StringWriter();
    writer.WriteLine("#region Implementation");
    foreach (var category in categories)
    {
        await GenerateFromServerAsync(writer, category, deviceHost, authKey);
    }
    writer.WriteLine("#endregion");
    writer.ToString().Dump();
}

async Task GenerateFromServerAsync(TextWriter writer, string category, string deviceHost, string authKey)
{
    var cookieContainer = new CookieContainer();
    //cookieContainer.Add(new Cookie("auth", authKey, "/sony", deviceHost));

    var endpointUrl = $"http://{deviceHost}/sony/{category}";
    var data = new
    {
        @method = "getMethodTypes",
        @params = new object[]
        {
        ""
        },
        @id = 4,
        @version = "1.0"
    };

    using (var httpHandler = new HttpClientHandler() { CookieContainer = cookieContainer, UseCookies = true })
    using (var httpClient = new HttpClient(httpHandler))
    {
        var response = await httpClient.PostAsync(endpointUrl, new StringContent(JsonConvert.SerializeObject(data)));
        var responseBody = await response.Content.ReadAsStringAsync();
        endpointUrl.Dump();
        
        CreateMehods(writer, category, responseBody);
    }
}

void CreateMehods(TextWriter writer, string category, string json)
{
    dynamic data = JsonConvert.DeserializeObject(json);
    json.Dump();
    
    var categoryInterface = "I" + ToPascalCase(category);
    
    var ctx = new ApiParseContext();

    ((JArray)data.results).Select(method =>
    {
        var name = (string)method[0];
        var version = (string)method[3];
        var parameters = (JArray)method[1];
        var retVal = (JArray)method[2];
    
        return new
        {
            Name = name,
            Parameters = parameters,
            Response = retVal,
            Version = version
        };
    }).Dump();
    
    var methods = ((JArray)data.results).Select(method =>
    {
        var name = (string)method[0];
        var version = (string)method[3];
        
        var parameters = ToParameters(ctx, name, version, (JArray)method[1]);
        var retVal = ToResponses(ctx, name, version, (JArray)method[2]);
    
        return new
        {
            Name = name,
            Parameters = parameters,
            Response = retVal,
            Version = version
        };
    }).Where(x => x.Name != "getMethodTypes").Dump();
    
    ctx.Types.Dump();

    writer.WriteLine($"#region {categoryInterface}");
    foreach (var method in methods)
    {
        var returnType = method.Response.Any()
            ? method.Response.Count() > 1
                ? ToPascalCase(method.Name) + "CompositeResponse"
                : method.Response.First()
            : "void";
        var @params = String.Join(", ", method.Parameters.Select((x, i) => $"{x} @arg" + i));
        var @paramsInner = String.Join(", ", method.Parameters.Select((x, i) => $"@arg" + i));
        if (returnType == "void")
        {
            writer.WriteLine($@"Task {categoryInterface}.{ToPascalCase(method.Name)}Async({@params}) {{ return _InvokeAsync(""{category}"", ""{method.Name}"", 1, ""{method.Version}"", new object[] {{ {paramsInner} }}); }}");
        }
        else
        {
            writer.WriteLine($@"Task<{returnType}> {categoryInterface}.{ToPascalCase(method.Name)}Async({@params}) {{ return _InvokeAsync<{returnType}>(""{category}"", ""{method.Name}"", 1, ""{method.Version}"", new object[] {{ {paramsInner} }}); }}");
        }

        if (method.Parameters.Length == 1)
        {
            var firstParam = method.Parameters.First();
            if (ctx.Types.ContainsKey(firstParam))
            {
                var requestType = ctx.Types[method.Parameters.First()];
                var expandedParams = String.Join(", ", requestType.Properties.Select(x => $"{x.Type} @{ToCamelCase(x.Name)}"));
                var ctorArgs = String.Join(", ", requestType.Properties.Select(x => $"@{ToCamelCase(x.Name)}"));
                if (returnType == "void")
                {
                    writer.WriteLine($@"Task {categoryInterface}.{ToPascalCase(method.Name)}Async({expandedParams}) {{ return (({categoryInterface})this).{ToPascalCase(method.Name)}Async(new {requestType.Name}({ctorArgs})); }}");
                }
                else
                {
                    writer.WriteLine($@"Task<{returnType}> {categoryInterface}.{ToPascalCase(method.Name)}Async({expandedParams}) {{ return (({categoryInterface})this).{ToPascalCase(method.Name)}Async(new {requestType.Name}({ctorArgs})); }}");
                }
            }
        }
    }
    writer.WriteLine();

    writer.WriteLine($@"public interface {categoryInterface}");
    writer.WriteLine($@"{{");
    foreach (var method in methods)
    {
        var returnType = method.Response.Any()
            ? method.Response.Count() > 1
                ? ToPascalCase(method.Name) + "CompositeResponse"
                : method.Response.First()
            : "void";
        var @params = String.Join(", ", method.Parameters.Select((x, i) => $"{x} @arg" + i));
        var @paramsInner = String.Join(", ", method.Parameters.Select((x, i) => $"@arg" + i));
        if (returnType == "void")
        {
            writer.WriteLine($@"    Task {ToPascalCase(method.Name)}Async({@params});");
        }
        else
        {
            writer.WriteLine($@"    Task<{returnType}> {ToPascalCase(method.Name)}Async({@params});");
        }
        if (method.Parameters.Length == 1)
        {
            var firstParam = method.Parameters.First();
            if (ctx.Types.ContainsKey(firstParam))
            {
                var requestType = ctx.Types[firstParam];
                var expandedParams = String.Join(", ", requestType.Properties.Select(x => $"{x.Type} @{ToCamelCase(x.Name)}"));
                if (returnType == "void")
                {
                    writer.WriteLine($@"    Task {ToPascalCase(method.Name)}Async({expandedParams});");
                }
                else
                {
                    writer.WriteLine($@"    Task<{returnType}> {ToPascalCase(method.Name)}Async({expandedParams});");
                }
            }
        }
    }
    writer.WriteLine($@"}}");

    writer.WriteLine();

    foreach (var type in ctx.Types.Values)
    {
        var expandedParams = String.Join(", ", type.Properties.Select(x => $"{x.Type} @{ToCamelCase(x.Name)}"));
        writer.WriteLine($@"public class {type.Name}");
        writer.WriteLine($@"{{");
        foreach (var prop in type.Properties)
        {
            writer.WriteLine($@"    [JsonProperty(""{prop.ParamName}"")]");
            writer.WriteLine($@"    public {prop.Type} {prop.Name} {{ get; set; }}");
        }
        writer.WriteLine($@"    public {type.Name}() {{}}");
        writer.WriteLine($@"    public {type.Name}({expandedParams})");
        writer.WriteLine($@"    {{");
        foreach (var prop in type.Properties)
        {
            writer.WriteLine($@"        this.{prop.Name} = @{ToCamelCase(prop.Name)};");
        }
        writer.WriteLine($@"    }}");

        //writer.WriteLine($@"    public void ReadFromJson(JArray values)");
        //writer.WriteLine($@"    {{");
        //foreach (var prop in type.Properties)
        //{
        //    writer.WriteLine($@"        this.{prop.Name} = values.Count >= {prop.Index+1} ? ((JObject)values[0]).Property(""{prop.ParamName}"")?.ToObject<{prop.Type}>() : default({prop.Type});");
        //}
        //writer.WriteLine($@"    }}");
        writer.WriteLine($@"}}");
    }
    writer.WriteLine();

    foreach (var method in methods)
    {
        if (method.Response.Count() > 1)
        {
            writer.WriteLine($@"public class {ToPascalCase(method.Name)}CompositeResponse : ICompositeResponse");
            writer.WriteLine($@"{{");
            foreach (var response in method.Response.Select((x, i) => new { Index = i, Name = x }))
            {
                writer.WriteLine($@"    public {response.Name} Item{response.Index} {{ get; set; }}");
            }
            writer.WriteLine($@"    public void ReadFromJson(JArray values)");
            writer.WriteLine($@"    {{");
            foreach (var response in method.Response.Select((x, i) => new { Index = i, Name = x }))
            {
                writer.WriteLine($@"        this.Item{response.Index} = ((JToken)values[{response.Index}])?.ToObject<{response.Name}>();");
            }
            writer.WriteLine($@"    }}");
            writer.WriteLine($@"}}");
        }
    }
    writer.WriteLine($"#endregion");
}

// Define other methods and classes here

class ApiTypeDef
{
    public string Name { get; set; }
    public string Version { get; set; }
    public ApiPropertyDef[] Properties { get; set; }
}

class ApiPropertyDef
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Index { get; set; }
    public string ParamName { get; set; }
}

class ApiParseContext
{
    public Dictionary<string, ApiTypeDef> Types { get; } = new Dictionary<string, UserQuery.ApiTypeDef>();
}

string ToPascalCase(string value) => value.Substring(0, 1).ToUpper() + value.Substring(1);
string ToCamelCase(string value) => value.Substring(0, 1).ToLower() + value.Substring(1);

string[] ToParameters(ApiParseContext ctx, string parentTypeName, string version, JArray @params)
{
    return @params.Select((x, i) => ParseType(ctx, (string)x, parentTypeName + (i == 0 ? "" : i.ToString()) + "Request", version)).ToArray();
}
string[] ToResponses(ApiParseContext ctx, string parentTypeName, string version, JArray @results)
{
    return @results.Select((x, i) => ParseType(ctx, (string)x, parentTypeName + (i == 0 ? "" : i.ToString()) + "Response", version)).ToArray();
}

ApiTypeDef CreateType(ApiParseContext ctx, string name, string version, JObject typeObj)
{
    return new ApiTypeDef
    {
        Name = name,
        Version = version,
        Properties = typeObj
            .Properties()
            .Select((x, i) => new ApiPropertyDef
            {
                Index = i,
                Name = ToPascalCase(x.Name),
                ParamName = x.Name,
                Type = ParseType(ctx, (string)x.Value, name, version)
            })
            .ToArray()
    };
}


string ParseType(ApiParseContext ctx, string jsonTypeDef, string parentTypeName, string version)
{
    var suffix = jsonTypeDef.EndsWith("*") || jsonTypeDef.EndsWith("[]") ? "[]" : "";
    return ParseTypeCore(ctx, Regex.Replace(jsonTypeDef, @"(\*|\[\])$", ""), parentTypeName, version) + suffix;
}
string ParseTypeCore(ApiParseContext ctx, string jsonTypeDef, string parentTypeName, string version)
{
    if (jsonTypeDef.StartsWith("{"))
    {
        var typeName = ToPascalCase(parentTypeName);
        typeName = RegisterType(ctx, typeName, version, (JObject)JsonConvert.DeserializeObject(jsonTypeDef));
        return typeName;
    }
    else
    {
        return ConvertToClrType(jsonTypeDef);
    }
}

string RegisterType(ApiParseContext ctx, string typeFullName, string version, JObject obj)
{
    if (ctx.Types.ContainsKey(typeFullName) && ctx.Types[typeFullName].Version != version)
    {
        typeFullName += "V" + version.Replace('.', '_');
    }
    ctx.Types[typeFullName] = CreateType(ctx, typeFullName, version, obj);
    
    return typeFullName;
}

string ConvertToClrType(string jsonType)
{
    var suffix = jsonType.EndsWith("*") || jsonType.EndsWith("[]") ? "[]" : "";
    return ConvertToClrTypeCore(jsonType.Replace("*", "").Replace("[]", "")) + suffix;
}
string ConvertToClrTypeCore(string jsonType)
{
    switch (jsonType)
    {
        case "string": return "System.String";
        case "int": return "System.Int32";
        case "bool": return "System.Boolean";
        case "double": return "System.Double";
        //default: throw new ArgumentException($"Unknown Type: {jsonType}", "jsonType");
        default: return "System.Object";
    }
}