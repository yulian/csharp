using System;
using static System.Math;
using static System.Console;

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
      return 2 * Radius * PI;
    }
  }
  public double Area {
    get {
      return PI * Pow(Radius, 2);
    }
  }
}

class MainClass {
  public static void Main(string[] args) {
    Circle c = new Circle(3);
    WriteLine(c.Diameter);
    WriteLine(c.Circumference);
    WriteLine(c.Area);
  }
}
