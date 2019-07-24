using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CircleTests
  {

    [TestMethod]
    public void Circle_GetDiameter_DiameterOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(5,0);
      // Act
      double result = newCircle.GetDiameter();
      // Assert
      Assert.AreEqual(result, 10);
    }

     [TestMethod]
    public void Circle_GetCircumference_CircumferenceOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(0,9);
      // Act
      double result = newCircle.GetCircumference();
      // Assert
      Assert.AreEqual(result, 28.26);
    }

    [TestMethod]
    public void Circle_IsCircle_True()
    {
      // Arrange
      Circle newCircle = new Circle(2,4);
      // Act
      bool result = newCircle.IsCircle();
      // Assert
      Assert.AreEqual(result, true);
    }

    [TestMethod]
    public void Circle_IsCircle_False()
    {
      // Arrange
      Circle newCircle = new Circle(4,5);
      // Act
      bool result = newCircle.IsCircle();
      // Assert
      Assert.AreEqual(result, false);
    }

  }
}