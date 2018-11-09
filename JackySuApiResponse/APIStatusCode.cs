namespace JackySuApiResponse.DefaultStatusCode
{
    public enum APIStatusCode
    {
        [StatusMessage("Ok")]
        Ok,
        [StatusMessage("Not found")]
        NotFound,
        [StatusMessage("Request secret invalid")]
        RequestSecretInvalid,
        [StatusMessage("Bad request")]
        BadRequest,
        [StatusMessage("IP invalid")]
        IPInvalid,
        [StatusMessage("Environment invalid")]
        EnvironmentInvalid
    }
}
