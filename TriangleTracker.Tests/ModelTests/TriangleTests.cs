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
    public void IsEquilateral_CheckIfTriangleIsEquilateral()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsEqualateral(4,4,4));
    }

    [TestMethod]
    public void IsIsosceles_CheckIfTriangleIsIsoceles()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsIsosceles(4,4,3));
    }

    [TestMethod]
    public void IsScalene_CheckIfTrianlgeIsScalene_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsScalene(5,6,4));
    }

[TestMethod]
    public void IsNotATriangle_CheckIfNotATriangle_True()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsNotATriangle(5,6,15));
    }

  }
}