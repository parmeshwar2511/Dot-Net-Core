using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebUi.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService _service;

        public CategoryController(ICategoryService service)
        {
            _service = service;
        } 

        // GET: Category
        public ActionResult Index()
        {
            var categories = _service.GetAll();

            return View(categories);
        }
    }
}