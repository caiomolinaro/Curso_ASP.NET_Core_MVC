using Microsoft.AspNetCore.Mvc;

namespace LanchesCM.Controllers
{
    public class AdminController : Controller
    {
        public string Index()
        {
            return $"Testeeeeee adm {DateTime.Now}";
        }

        public string Demo()
        {
            return $"Testeeeeee adm demo {DateTime.Now}";
        }
    }
}
