using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class TriangleTrackerTests
  {
    [TestMethod]
    public void IsTriangle_AnySideLongerThanOtherTwoCombined_False() //NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("not a triangle", testTriangle.IsTriangle(2, 2, 8));
    }

    [TestMethod]
    public void IsTriangle_CanMakeTriangle_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("is a triangle", testTriangle.IsTriangle(2, 2, 3));
    }
  }
}