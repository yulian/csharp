using System;
class MainClass {
  public static void Main(string[] args) {
    int[] intValues = { 1, 2, 3 };
    double[] doubleValues = { 1.1, 2.2, 3.3 };
    PrintValue < int > (intValues);
    PrintValue < double > (doubleValues);
  }
  
  static void PrintValue < T > (T[] values) {
    foreach(var i in values) {
      Console.WriteLine(i);
    }
  }
}
