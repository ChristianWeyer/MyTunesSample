using Owin;
using System.Web.Http;

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