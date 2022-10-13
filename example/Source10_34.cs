using System;

class MainClass {
  public static void Main(string[] args) {
    (int, double) t1 = (17, 3.14);
    (double First, double Second) t2 = (0.0, 1.0);
    (double A, double B) t3 = (2.0, 3.0);
    
    t2 = t1;
    Console.WriteLine($"{t2.First}, {t2.Second}");
    
    t3 = t2;
    Console.WriteLine($"{t3.A}, {t3.B}");
  }
}
