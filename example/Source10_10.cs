using System;

class MainClass {
  public static void Main(string[] args) {
    Func < int, int > square = x => x * x;
    Console.WriteLine(square(5));
  }
}
