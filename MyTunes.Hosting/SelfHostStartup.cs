using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;

namespace MyTunes.Hosting
{
    public class SelfHostStartup
    {
        public void Configuration(IAppBuilder app)
        {
            // TODO: Files...
            var options = new FileServerOptions
            {
                RequestPath = new PathString("/app"),
                FileSystem = new PhysicalFileSystem("app")
            };

            app.UseFileServer(options);

            var startup = new Startup();
            startup.Configuration(app);
        }
    }
}
