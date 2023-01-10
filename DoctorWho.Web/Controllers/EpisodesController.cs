using Microsoft.AspNetCore.Mvc;

namespace DoctorWho.Web.Controllers
{
    public class EpisodesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
