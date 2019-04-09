using System;
using Microsoft.Owin.Hosting;

namespace SelfHosting
{
    public class WebServer
    {
        private IDisposable _webApp;

        public bool Start()
        {
            _webApp = WebApp.Start<Startup>("http://localhost:8081");
            return true;
        }

        public bool Stop()
        {
            _webApp.Dispose();
            return true;
        }
    }
}
