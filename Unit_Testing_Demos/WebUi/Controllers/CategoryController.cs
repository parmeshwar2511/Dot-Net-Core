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

        [HttpGet]
        // GET: Category
        public ActionResult Index()
        {
            var categories = _service.GetAll();

            return View(categories);
        }
       
        [HttpGet]
        public ActionResult Create() 
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Category category)
        {

            if (ModelState.IsValid)
            {
                _service.Create(category);
                return RedirectToAction("Index");
            }
            return View(category);

         }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id > 0)
            {
               Category category = _service.GetById(id);
                if (category != null)
                {
                    return View(category);
                }
                return HttpNotFound();
            }
            return RedirectToAction("Index");
        }

    }
}