using Microsoft.AspNetCore.Mvc;
using SalesWebMvcApp.Services;


namespace SalesWebMvcApp.Controllers
{
    public class SellersController : Controller
    {
        private readonly SellerService _sellerService;

        public SellersController(SellerService sellerService)
        {
            _sellerService = sellerService;
        }

        public IActionResult Index()
        {
            var list = _sellerService.findAll();
            return View(list);
        }
    }
}
