namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Radiuss { get; set; }

    public Sphere (Circle size)
    {
      Radiuss = size;
    }
     
    public int GetVolume()
    {
    int Radius = Radiuss.Length;
    return 4/3*3.14(Radius * Radius * Radius);
    }

    // public int GetSurfaceArea()
    // {
    // int length = Radius.Length;// Sphere is not correct or done.
    // return (length * length) * 6;
    // }
    
    
  }
}