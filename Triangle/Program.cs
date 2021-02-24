using System;
using Triangle.Models;

namespace Triangle
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter the length of side 1");
      string stringSide1 = Console.ReadLine();
      int side1 = int.Parse(stringSide1);

      Console.WriteLine("Enter the length of side 2");
      string stringSide2 = Console.ReadLine();
      int side2 = int.Parse(stringSide2);

      Console.WriteLine("Enter the length of side 3");
      string stringSide3 = Console.ReadLine();
      int side3 = int.Parse(stringSide3);

      TriangleTracker triangle = new TriangleTracker(side1, side2, side3);

      Console.WriteLine(triangle.IsTriangle());
    }
  }
}