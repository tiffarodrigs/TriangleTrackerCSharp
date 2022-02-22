namespace TriangleTracker
{
  public class Triangle
  {
    
    public string CheckTriangle(int length1, int length2, int length3)
    {
      if((length1 > (length2 + length3)) || (length2 > (length1 + length3)) || (length3 > (length1 + length2)))
      {
        return "IsNotATriangle";
      }
      else if (length1 != length2 && length1 != length3 && length2 != length3)
      {
        return "IsScalene";
      }
      else if (length1 == length2 && length1 == length3)
      {
        return "IsEquilateral";
      }
      else
      {
        return "IsIsoceles";
      }
    }

  }
  
}
