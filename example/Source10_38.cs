using System;

class MainClass {
  public static void Main(string[] args) {
    var fruits = new string[] {
                // 시작 인덱스  끝 인덱스
      "apple",  // 0            ^4
      "banana", // 1            ^3
      "orange", // 2            ^2
      "cherry", // 3            ^1
    };
    
    Console.WriteLine(fruits[0]);
    Console.WriteLine(fruits[1]);
    Console.WriteLine(fruits[2]);
    Console.WriteLine(fruits[3]);
    
    Console.WriteLine(fruits[^1]);
    Console.WriteLine(fruits[^2]);
    Console.WriteLine(fruits[^3]);
    Console.WriteLine(fruits[^4]);
  }
}
