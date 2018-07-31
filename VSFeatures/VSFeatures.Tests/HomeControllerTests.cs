using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VSFeatures.Controllers;
using VSFeatures.Models;
using Xunit;
using System.Linq;
using Moq;

namespace VSFeatures.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void IndexActionModelIsComplete()
        {
            //Arrange
            var controller = new HomeController();

            //Act
            var model = (controller.Index() as ViewResult)?.Model as IEnumerable<Product>;

            //Assert
            Assert.Equal(model, ProductsRepository.GetRepository.GetProducts.Where(p => p?.Price < 50));
        }

        //[Theory]
        //[ClassData(typeof(ProductTestData))]
        //public void IndexActionMockTest(Product[] products)
        //{
        //    // Arrange
        //    var mock = new Mock<IRepository>();
        //    mock.SetupGet(m => m.GetProducts).Returns(products);
        //    var controller = new HomeController { repository = mock.Object };
        //    // Act
        //    var model = (controller.Index() as ViewResult)?.ViewData.Model
        //    as IEnumerable<Product>;
        //    // Assert
        //    Assert.Equal(controller.repository.GetProducts, model,
        //    Comparer.Get<Product>((p1, p2) => p1.Name == p2.Name
        //    && p1.Price == p2.Price));
        //}
    }
}
