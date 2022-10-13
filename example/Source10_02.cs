using System;
class MainClass {
  public static void Main(string[] args) {
    int[] intValues = { 1, 2, 3 };
    double[] doubleValues = { 1.1, 2.2, 3.3 };
    PrintValue(intValues);
    PrintValue(doubleValues);
  }
  
  static void PrintValue(int[] values) {
    foreach(int i in values) {
      Console.WriteLine(i);
    }
  }
  
  static void PrintValue(double[] values) {
    foreach(double i in values) {
      Console.WriteLine(i);
    }
  }
}
