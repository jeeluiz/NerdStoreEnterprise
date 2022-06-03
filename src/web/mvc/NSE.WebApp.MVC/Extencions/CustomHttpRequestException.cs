using System.Net;

namespace NSE.WebApp.MVC.Extencions
{
    public class CustomHttpRequestException : Exception
    {
        public HttpStatusCode StatusCode;

        public CustomHttpRequestException()
        {

        }

        public CustomHttpRequestException(string message,Exception innerExption)
            :base(message, innerExption)
        {

        }

        public CustomHttpRequestException(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }
    }
}
