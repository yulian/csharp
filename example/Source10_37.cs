using System;

class MainClass {
  public static void Main(string[] args) {
    int number1 = -10;
    int number2 = 5;
    Console.WriteLine(AbsoulteValue(number1));
    Console.WriteLine(AbsoulteValue(number2));
    
    int AbsoulteValue(int n) {
      if (n >= 0)
        return n;
      return -n;
    }
  }
}
