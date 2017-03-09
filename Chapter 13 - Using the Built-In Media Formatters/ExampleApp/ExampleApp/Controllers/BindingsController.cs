using System.Web.Http;
using ExampleApp.Models;

namespace ExampleApp.Controllers
{
    public class BindingsController : ApiController
    {
        private IRepository repo;

        public BindingsController(IRepository repoArg)
        {
            repo = repoArg;
        }

        [HttpGet]
        [HttpPost]
        public int SumNumbers(Numbers calc)
        {
            return calc.First + calc.Second;
        }
    }
}
