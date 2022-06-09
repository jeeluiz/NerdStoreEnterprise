using NSE.WebApp.MVC.Extensions;
using System.Net.Http.Headers;

namespace NSE.WebApp.MVC.Services.Handler
{
    public class HttpClientAuthorizationDelegatingHandler : DelegatingHandler
    {
        private readonly IUser _user;

        public HttpClientAuthorizationDelegatingHandler(IUser user)
        {
            _user = user;
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var authorizationHandler = _user.ObterHttpContext().Request.Headers["Authorization"];

            if (!string.IsNullOrEmpty(authorizationHandler))
            {
                request.Headers.Add("Authorization", new List<string>() { authorizationHandler });
            }

            var token = _user.ObterUserToken();
            
            if(token != null)
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(scheme:"Bearer", parameter:token);
            }
            return base.SendAsync(request, cancellationToken);
        }
    }
}
