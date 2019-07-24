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
      Circle newCircle = new Circle(0, 5);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      int result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, 523);
    }

    //   [TestMethod]
    // public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    // {
    //   // Arrange
    //   Circle newCircle = new Circle(4, 4);
    //   Sphere newSphere = new Sphere(newCircle);
    //   // Act
    //   int result = newSphere.GetSurfaceArea();
    //   // Assert
    //   Assert.AreEqual(result, 96);
    // }

  }  
}