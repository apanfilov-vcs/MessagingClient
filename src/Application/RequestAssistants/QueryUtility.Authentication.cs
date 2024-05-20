using System.Collections.Specialized;
using System.Web;

namespace Application.RequestAssistants
{
    public partial class QueryUtility
    {
        public class Authentication
        {
            public static string CreateAuthenticationQuery(string requestUrl, string username, string password)
            {
                var queryParameters = new NameValueCollection
                {
                    { "name", username },
                    { "password", password }
                };

                var queryString = HttpUtility.ParseQueryString(string.Empty);
                queryString.Add(queryParameters);

                var urlWithParameters = requestUrl + queryString;

                return urlWithParameters;
            }
        }
    }
}