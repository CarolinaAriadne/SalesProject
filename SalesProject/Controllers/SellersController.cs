using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalesProject.Models;
using SalesProject.Services;


using Microsoft.AspNetCore.Mvc;

namespace SalesProject.Controllers
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

            var list = _sellerService.FindAll();
            return View(list);
        }
    }
}
