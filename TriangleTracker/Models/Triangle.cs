namespace TriangleTracker
{
  public class Triangle
  {
    // properties, constructors, methods, etc. go here
    public bool IsEqualateral(int length1,int length2,int length3)
    {
      if(length1 == length2 && length1 == length3 && length2 == length3)
      {
        return true;
      }
      else{
        return false;
      }
    }

    public bool IsIsosceles(int length1, int length2, int length3)
    {
      if(length1 == length2 || length1 == length3 || length2 == length3)
      {
        return true;
      }
      else
      {
        return false;
      }
      
    }

    public bool IsScalene(int length1, int length2, int length3)
    {
      if(length1 != length2 && length1 != length3 && length2 != length3)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}