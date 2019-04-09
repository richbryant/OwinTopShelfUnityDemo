using System.Collections;
using System.Web.Http;

namespace SelfHosting.Controllers
{
    public class HelloController : ApiController
    {
        public IEnumerable Get()
        {
            return new[] {"Hello", "World"};
        }

        public string Get(string name)
        {
            return $"Hello {name}!";
        }
    }
}
