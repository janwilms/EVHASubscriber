using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
using System.Windows.Forms;
using Microsoft.Owin.Hosting;

namespace EvhaBulbs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var url = string.Format("http://0.0.0.0:{0}", ConfigurationManager.AppSettings["portnumber"]);
            var config = new HttpSelfHostConfiguration(url);

            config.Routes.MapHttpRoute(
                "API Default", "api/{controller}");

            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new EvhaBulbs());
            }
        }
    }
}
