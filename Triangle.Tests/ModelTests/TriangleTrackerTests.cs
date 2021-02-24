using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle.Models;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_AnySideLongerThanOtherTwoCombined_NotATriangle() //NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      TriangleTracker testTriangle = new TriangleTracker(2, 2, 8);
      Assert.AreEqual("not a triangle", testTriangle.IsTriangle());
    }

    [TestMethod]
    public void IsTriangle_IsTriangleScalene_IsScalene()
    {
      TriangleTracker testTriangle = new TriangleTracker(2, 3, 4);
      Assert.AreEqual("scalene triangle", testTriangle.IsTriangle());
    }

    [TestMethod]
    public void IsTriangle_IsTriangleIsosceles_IsIsosceles()
    {
      TriangleTracker testTriangle = new TriangleTracker(3, 3, 2);
      Assert.AreEqual("isosceles triangle", testTriangle.IsTriangle());
    }

    [TestMethod]
    public void IsTriangle_IsTriangleEquilateral_IsEquilateral()
    {
      TriangleTracker testTriangle = new TriangleTracker(3, 3, 3);
      Assert.AreEqual("equilateral triangle", testTriangle.IsTriangle());
    }
  }
}