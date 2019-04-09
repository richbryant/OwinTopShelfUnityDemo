using Topshelf;
using Topshelf.Unity;
using Unity;

namespace SelfHosting
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTopShelf();
        }

        static void RunTopShelf()
        {
            var container = new UnityContainer();
            container.RegisterType<WebServer>();
            HostFactory.Run(c =>
            {
                c.UseUnityContainer(container);
                c.Service<WebServer>(s =>
                {
                    s.ConstructUsingUnityContainer();
                    s.WhenStarted((service, control) => service.Start());
                    s.WhenStopped((service, control) => service.Stop());
                });
                c.RunAsLocalSystem();

                c.SetDescription("Demo WindowsAccountType service hosting WebApi");
                c.SetDisplayName("Demo.SelfHost");
                c.SetServiceName("SelfHostDemo");

            });
        }
    }
}
