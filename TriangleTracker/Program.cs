using System;
using TriangleTracker;
namespace TriangleProgram
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the length of side 1: ");
      int length1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the length of side 2: ");
      int length2 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the length of side 3: ");
      int length3 = int.Parse(Console.ReadLine());

      Triangle triangleObject = new Triangle();

      Console.WriteLine(triangleObject.CheckTriangle(length1,length2,length3));
    }
  }
}

