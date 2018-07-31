using VSFeatures.Models;
using Xunit;

namespace VSFeatures.Tests
{
    public class ProductTests
    {
        [Fact]
        public void ChangeName()
        {
            //Arrange
            var product = new Product{ Name="Test" , Price=10m};

            //Act
            product.Name = "Test2";

            //Assert
            Assert.Equal("Test2", product.Name);
        }

        [Fact]
        public void ChangePrice()
        {
            //Arrange
            var p = new Product{ Name="Test", Price=10m};

            //Act
            p.Price = 20m;

            //Assert
            Assert.Equal(20m, p.Price);
        }
    }
}
