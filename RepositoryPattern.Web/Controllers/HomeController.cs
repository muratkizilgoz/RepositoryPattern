using System;
using System.Linq;
using System.Web.Mvc;
using RepositoryPattern.Business;
using RepositoryPattern.Business.Domain;

namespace RepositoryPattern.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public HomeController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public ActionResult Index()
        {
            var products = _unitOfWork.Products.GetAll();

            return View(products);
        }
        [HttpPost]
        public ActionResult AddProduct()
        {
            _unitOfWork.Products.Add(new Product()
            {
                Name = RandomString(10),
                CategoryId = random.Next(1,4)
            });

            _unitOfWork.Commit();
            return RedirectToAction("Index");
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

    }
}