using System.Reflection;

namespace JackySuApiResponse
{
    public class ApiResponseFactory<TResult>
    {
        public ApiResponse<TResult> Send<TStatus>(TStatus status, TResult result = default(TResult))
        {
            MemberInfo[] memberInfo = status.GetType().GetMember(status.ToString());
            var statusMessage = string.Empty;
            if (memberInfo != null && memberInfo.Length > 0)
            {
                var attributes = memberInfo[0].GetCustomAttributes(typeof(StatusMessageAttribute), false);
                if (attributes != null && attributes.Length > 0)
                {
                    var attribute = attributes[0] as StatusMessageAttribute;
                    statusMessage = attribute == null ? status.ToString() : attribute.Message;
                }
            }
            return new ApiResponse<TResult>(statusMessage, result);
        }
    }
}
