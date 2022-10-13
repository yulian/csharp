public class Circle {
  public Circle(double radius) {
    Radius = radius;
  }
  
  public double Radius { get; set; }
  
  public void PrintDiameter() {
    Console.WriteLine(2 * Radius);
  }
}
