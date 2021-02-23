using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_AnySideLongerThanOtherTwoCombined_NotATriangle() //NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("not a triangle", testTriangle.IsTriangle(2, 2, 8));
    }

    [TestMethod]
    public void IsTriangle_IsTriangleScalene_IsScalene()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("scalene triangle", testTriangle.IsTriangle(2, 3, 4));
    }

    [TestMethod]
    public void IsTriangle_IsTriangleIsosceles_IsIsosceles()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("isosceles triangle", testTriangle.IsTriangle(3, 3, 2));
    }
  }
}