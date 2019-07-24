using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfSphere()
    {
      // Arrange
      Circle newCircle = new Circle(5, 0);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, 523);
    }

      [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
      // Arrange
      Circle newCircle = new Circle(5, 0);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 314);
    }

  }  
}