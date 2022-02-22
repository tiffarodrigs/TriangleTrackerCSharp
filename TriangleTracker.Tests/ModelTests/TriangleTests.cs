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
    public void TriangleEquilateral()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsEqualateral(4,4,4));
    }

    [TestMethod]
    public void TriangleIsosceles()
    {
      Triangle testTriangle = new Triangle();
      Assert.AreEqual(true, testTriangle.IsIsosceles(4,4,3));
    }

  }
}