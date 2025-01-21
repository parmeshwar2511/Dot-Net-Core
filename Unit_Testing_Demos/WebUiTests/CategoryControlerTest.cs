using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WebUi.Controllers;
using Xunit;
using System.Web.Mvc;

namespace WebUiTests
{
    public class CategoryControlerTest
    {
        [Fact]
        public void Index_Method_Positive()
        {

            // arrange 
            ApplicationDbContext context = new ApplicationDbContext();
            ICategoryRepository repo = new CategoryRepository(context);
            ICategoryService svc = new CategoryService(repo);
            CategoryController ctrl = new CategoryController(svc);
            List<Category> expected = new List<Category>()
            { 
             new Category(){ Name = "mens wear", Rating = 5 },
             new Category(){ Name = "kids wear", Rating = 4 }

            };
            // act

          ActionResult result  =   ctrl.Index();
            ViewResult view = (ViewResult)result;
            List<Category> cats = view.Model as List<Category>;


            // Assert
            Assert.Equal(expected.Count, cats.Count);

        }
    }
}
