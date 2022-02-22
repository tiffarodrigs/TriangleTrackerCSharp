using Microsoft.VisualStudio.TestTools.UnitTesting;
using TriangleTracker;

namespace TriangleTracker.Tests
{
  [TestClass]
  public class TriangleTests
  {
    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   // any necessary logic to prep for test; instantiating new classes, etc.
    //   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
    // }

    [TestMethod]
    public void CheckTriangle_CheckIfTriangleIsEquilateral_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("IsEquilateral", testTriangle.CheckTriangle(4,4,4));
    }

    [TestMethod]
    public void CheckTriangle_CheckIfTriangleIsIsoceles_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("IsIsoceles", testTriangle.CheckTriangle(4,4,3));
    }

    [TestMethod]
    public void CheckTriangle_CheckIfTrianlgeIsScalene_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("IsScalene", testTriangle.CheckTriangle(5,6,4));
    }

[TestMethod]
    public void CheckTriangle_CheckIsNotATriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual("IsNotATriangle", testTriangle.CheckTriangle(5,6,15));
    }

  }
}