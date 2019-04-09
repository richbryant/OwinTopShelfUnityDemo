using System;
using System.Threading.Tasks;
using Microsoft.Owin;

namespace SelfHosting
{
    public class HostMiddleWare : OwinMiddleware
    {
        public HostMiddleWare(OwinMiddleware next) : base(next)
        {

        }

        public override async Task Invoke(IOwinContext context)
        {
            context.Response.Headers["MachineName"] = Environment.MachineName;

            await Next.Invoke(context);
        }
    }
}
