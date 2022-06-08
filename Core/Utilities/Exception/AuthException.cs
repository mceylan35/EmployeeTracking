
using System.Security.Authentication;

namespace Core.Utilities.Exception
{
    public class AuthException: AuthenticationException
    {
        public string MessageId { get; set; }
        public AuthException(string message, string messageId) : base(message)
        {
            MessageId = messageId;
        }
    }
}
