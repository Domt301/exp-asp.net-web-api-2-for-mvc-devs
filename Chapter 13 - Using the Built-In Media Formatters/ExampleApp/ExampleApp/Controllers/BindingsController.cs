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
        public int SumNumbers(Numbers calc, Operation op )
        {
            int result = op.Add ? calc.First + calc.Second : calc.First - calc.Second;
            return op.Double ? result * 2 : result;
        }
    }
}
