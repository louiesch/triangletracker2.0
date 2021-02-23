namespace Triangle
{
  public class TriangleTracker
  {
    public string IsTriangle(int side1, int side2, int side3)
    {
      if (side1 > (side2 + side3) || side2 > (side1 + side3) || side3 > (side1 + side2))
      {
        return "not a triangle";
      }
      else
      {
        return "scalene triangle";
      }
    }
  }
}