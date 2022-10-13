using System;

public class Circle {
  public Circle(double radius) {
    Radius = radius;
  }
  
  public double Radius { get; set; }
  public double Diameter {
    get {
      return 2 * Radius;
    }
  }
  
  public double Circumference {
    get {
      return 2 * Radius * Math.PI;
    }
  }
  
  public double Area {
    get {
      return Math.PI * Math.Pow(Radius, 2);
    }
  }
}

class MainClass {
  public static void Main(string[] args) {
    Circle c = new Circle(3);
    Console.WriteLine(c.Diameter);
    Console.WriteLine(c.Circumference);
    Console.WriteLine(c.Area);
  }
}
