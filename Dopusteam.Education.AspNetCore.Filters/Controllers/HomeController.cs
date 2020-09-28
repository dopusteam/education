using Dopusteam.Education.AspNetCore.Filters.Infrastructure.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Dopusteam.Education.AspNetCore.Filters.Controllers
{
    public class HomeController : Controller
    {
        [EarlyReturnResourceFilter]
        public IActionResult Index()
        {
            return this.Content("Этого никто не увидит");
        }
    }
}
