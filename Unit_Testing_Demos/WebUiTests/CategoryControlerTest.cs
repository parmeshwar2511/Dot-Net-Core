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
using Moq;
using System.Web.UI.WebControls;


namespace WebUiTests
{
    public class CategoryControlerTest
    {
        [Fact]
        public void Index_ReturnViewResult_WithCategories()
        {
            //arrange

            Mock<ICategoryService> mockService = new Mock<ICategoryService>();
            CategoryController controller =
              new CategoryController(mockService.Object);

            var categories = new List<Category>()
            {
             new Category() { ID = 1 , Name = "Eletronics", Rating = 5  },
              new Category() { ID = 1, Name = "Mobiles", Rating = 5 }
            };

            mockService.Setup(s => s.GetAll()).Returns(categories);

            // act
            var result = controller.Index() as ViewResult;

            //aasert

            Assert.NotNull(result);
            Assert.IsType<ViewResult>(result);
            Assert.IsAssignableFrom<IEnumerable<Category>>(result.Model);

            var model = result.Model as IEnumerable<Category>;
            Assert.Equal(2, model.Count());

        }

        [Fact]
        public void Create_ReturnsViewResult()
        {
            // arrange
            Mock<ICategoryService> mockService =
                new Mock<ICategoryService>();
            CategoryController controller =
                new CategoryController(mockService.Object);

            // act
            var result = controller.Create() as ViewResult;

            Assert.NotNull(result);

            Assert.IsType<ViewResult>(result);

            // Assert.Equal("Create",result.ViewName);
        }


        [Fact]
        public void Create_ValidModel_RedirectsToIndex()
        {
             // arrange
             Mock<ICategoryService> mockService =
                new Mock<ICategoryService>();

            CategoryController controller = new CategoryController(mockService.Object);

            Category category = new Category() { ID = 1, Name = "mens wear", Rating = 5 };
            controller.ModelState.Clear();

            var result = controller.Create(category) as RedirectToRouteResult;

            Assert.NotNull(result);

            Assert.Equal("Index", result.RouteValues["action"]);

        }


        [Fact]
        public void Create_InValidModel_ReturnsViewResultWithModel()
        {
            // arrange
            Mock<ICategoryService> mockService =
               new Mock<ICategoryService>();

            CategoryController controller = new CategoryController(mockService.Object);

            Category category = new Category();

            controller.ModelState.AddModelError("Name","Name is required");

          
            var result = controller.Create(category) as ViewResult ;

            Assert.NotNull(result);

            Assert.Equal(category,result.Model);

        }

        [Fact]
        public void Details_ZeroId_RedirectsToIndex()
        { 
           // arrange

            Mock<ICategoryService> mockService = new Mock <ICategoryService>();
            CategoryController controller = new CategoryController(mockService.Object);

            // act
           var result = controller.Details(0) as RedirectToRouteResult;

            // Assert

            Assert.NotNull (result);

            Assert.Equal("Index", result.RouteValues["action"]);


        }


        [Fact]
        public void Details_ValidExistingId_ReturnViewWithMode()
        {
            // arrange

            Mock<ICategoryService> mockService = new Mock<ICategoryService>();
            CategoryController controller = new CategoryController(mockService.Object);

            Category category = new Category() { ID= 1, Name = "mobiles", Rating = 5 };


            mockService.Setup(s => s.GetById(1)).Returns(category);
            // act
            var result = controller.Details(1) as ViewResult;

            // Assert

            Assert.NotNull(result);

            var model = result.Model as Category;
            Assert.Equal("mobiles", model.Name);


        }


        [Fact]
        public void Details_NonExistingId_ReturnsHttpNotFound()
        {
            // arrange

            Mock<ICategoryService> mockService = new Mock<ICategoryService>();
            CategoryController controller = new CategoryController(mockService.Object);

            Category category = null;

            mockService.Setup(s => s.GetById(1)).Returns(category);
            // act
            var result = controller.Details(1) as HttpNotFoundResult;

            // Assert

            Assert.NotNull(result);

            Assert.IsType<HttpNotFoundResult>(result);


        }
    }
}
