using System;

namespace JackySuApiResponse
{
    [AttributeUsage(AttributeTargets.Field)]
    public class StatusMessageAttribute : Attribute
    {
        public string Message;
        public StatusMessageAttribute(string message)
        {
            Message = message;
        }
    }
}
