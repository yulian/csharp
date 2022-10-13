using System;

delegate int Add(int a, int b);

class MainClass {
  public static void Main(string[] args) {
    Add add = (a, b) => a + b;
    Console.WriteLine(add(1, 2));
  }
}
