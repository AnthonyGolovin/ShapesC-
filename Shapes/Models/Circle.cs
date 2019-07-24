namespace Shapes.Models
{
  public class Circle
  {
    public const double PI = 3.14159265358979;

    public int Radius { get; set; }
    public int Diameter { get; set; }
    public int Circumference { get; set; }
    

    public Circle(int sizeRadius, int sizeDiameter, int sizeCircumference)
    {
      Radius = sizeRadius;
      Diameter = sizeDiameter;
      Circumference = sizeCircumference;
      
    }

    public double GetCircumference()
    {
      return 3.14 * Diameter;
    }

      public double GetDiameter()
    {
      return Radius * 2;
    }

    public bool IsCircle()
    {
      if(Radius * 2 == Diameter)
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