using System.Net.Http.Formatting;
using System.Web.Http;

namespace MyTunes.Hosting
{
    public class WebApiConfig
    {
        public static void Configuration(HttpConfiguration config)
        {
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            config.Routes.MapHttpRoute("DefaultWebApi", "{controller}");
        }
    }
}