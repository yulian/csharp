using System;

class MainClass {
  public static void Main(string[] args) {
    int ? var1 = 10;
    int ? var2 = null;
    
    Console.WriteLine(var1 + var2);
    Console.WriteLine(var1 * var2);
    Console.WriteLine(var1 == var2);
    Console.WriteLine(var1 > var2);
    Console.WriteLine(var2 == var2);
  }
}
