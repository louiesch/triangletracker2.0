namespace Triangle.Models
{
  public class TriangleTracker
  {
    public int Side1 {get; set;}
    public int Side2 {get; set;}
    public int Side3 {get; set;}

    public TriangleTracker(int side1, int side2, int side3)
    {
      Side1 = side1;
      Side2 = side2;
      Side3 = side3;
    }

    public string IsTriangle()
    {
      if (Side1 > (Side2 + Side3) || Side2 > (Side1 + Side3) || Side3 > (Side1 + Side2))
      {
        return "not a triangle";
      }
      else if (Side1 != Side2 && Side2 != Side3 && Side3 != Side1)
      {
        return "scalene triangle";
      }
      else if (Side1 == Side2 && Side2 == Side3)
      {
        return "equilateral triangle";
      }
      else
      {
        return "isosceles triangle";
      }
    }
  }
}