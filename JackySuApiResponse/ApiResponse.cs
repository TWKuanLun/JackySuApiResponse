namespace JackySuApiResponse
{
    public class ApiResponse<T>
    {
        public ApiResponse(string status, T result = default(T))
        {
            Result = result;
            Status = status;
        }
        public T Result { get; set; }
        public string Status { get; set; }
    }
}
