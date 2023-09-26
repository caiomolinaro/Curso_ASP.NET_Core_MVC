using Microsoft.AspNetCore.Mvc;

namespace LanchesCM.Controllers
{
    public class TesteController : Controller
    {
        public string Index()
        {
            return $"Testeeeeee {DateTime.Now}";
        }
    }
}
