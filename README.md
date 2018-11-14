# JackySuApiResponse
My Api Response Format

Using namespace
```csharp
using JackySuApiResponse;
using JackySuApiResponse.DefaultStatusCode;//optional
```

In your controller
```csharp
[HttpGet]
public ApiResponse<YourModel> Get()
{
    var factory = new ApiResponseFactory<YourModel>();
    var yourData = new YourModel();
    return factory.Send(APIStatusCode.Ok, yourData);
}
```
Or some error
```csharp
[HttpGet]
public ApiResponse<YourModel> Get()
{
    var factory = new ApiResponseFactory<YourModel>();
    //
    //Some verification
    //
    return factory.Send(APIStatusCode.NotFound);
}
```

Call api then you will get
```javascript
{
    Result: null,
    Status: "Not found"
}
```

You can customize your StatusCode, use StatusMessageAttribute show some message.
```csharp
using JackySuApiResponse;
public enum MyStatusCode
{
    [StatusMessage("Ok")]
    Ok,
    [StatusMessage("Your request has expired")]
    Expired
}
```
Then use your status code
```csharp
[HttpGet]
public ApiResponse<YourModel> Get()
{
    var factory = new ApiResponseFactory<YourModel>();
    //
    //Some verification
    //
    return factory.Send(MyStatusCode.Expired);
}
```
Response
```javascript
{
    Result: null,
    Status: "Your request has expired"
}
```