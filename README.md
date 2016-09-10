# BraviaControl
Sony BRAVIA remote control API client for .NET

# Supported Device
- Sony BRAVIA 4K (2015) / Android TV

# Client Requirement
- .NET Framework 4.6

# Install
```
Install-Package BraviaControl
```

# Samples
- Console Application: Src/BraviaControl/BraviaControl.Sample
- LINQPad: https://gist.github.com/mayuki/457213f17be04f2fa5e2c7005906880a

# Usage
## 1. Create a API client.
```csharp
var client = new BraviaControlClient(
        "Your TV IP Address",
        "ClientID (ex. GUID)",
        $"{Environment.MachineName} (LINQPad)", // specify friendly "display" name on Television
        "" // AuthKey. If the client isn't authorized, you can pass empty string.
    );
```

## 2. Register your client to Television: Request PIN code
```csharp
await client.RequestPinAsync();
```

## 3. Register your client to Television: Input and send PIN code
```csharp
var pinCode = Console.ReadLine();
var authKey = await client.RegisterAsync(pinCode); // You can store AuthKey for next time use.
```

## 4. Send IRCC (Keycode)
```csharp
await client.SendIrccAsync(RemoteControllerKeys.TvPower); // TV Power Button (On/Off)
await client.SendIrccAsync(RemoteControllerKeys.VolumeUp); // Volume Up
await client.SendIrccAsync(RemoteControllerKeys.Confirm); // Same as "Enter Button"
await client.SendIrccAsync(RemoteControllerKeys.Return); // Same as "Back Button"
```

## 5. Get the television's information
```csharp
// Power status
await client.System.GetPowerStatusAsync();

// ISDBT Channels
await client.AvContent.GetContentListAsync("tv:isdbt", 0, 100, "");
await client.AvContent.SetPlayContentAsync(x.Uri); // select a channel.

// Android applications
await client.AppControl.GetApplicationListAsync();
await client.AppControl.SetActiveAppAsync(x.Uri, x.Data); // open a application.
```
