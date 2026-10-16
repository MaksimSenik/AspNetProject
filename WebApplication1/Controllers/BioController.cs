using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;

namespace WebApplication1.Controllers
{
    public class BioController : Controller
    {
        public IActionResult Bio() 
        {
            BioRepasitory.GetBios();

            return View(BioRepasitory.bios);
        }
    }
}
