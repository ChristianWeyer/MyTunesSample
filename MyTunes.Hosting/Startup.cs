using System.Web.Http;
using Owin;

namespace MyTunes.Hosting
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            WebApiConfig.Configuration(config);

            app.UseWebApi(config);
        }
    }
}