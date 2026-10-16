using Microsoft.AspNetCore.Mvc;
using WebApplication1.Controllers;

namespace WebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Menu()
        {
            ProductRepasitory.GetProducts();

            return View(ProductRepasitory.products);
        }
    }
}
