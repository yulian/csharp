using System;
class MainClass {
  public static void Main(string[] args) {
    var fruits = new string[] {
      "apple",  // 0 ^4
      "banana", // 1 ^3
      "orange", // 2 ^2
      "cherry", // 3 ^1
    };
    
    PrintArray(fruits[..]);     // 전체 항목 출력
    PrintArray(fruits[1..3]);   // 인덱스 1~2(3-1)까지 출력
    PrintArray(fruits[..2]);    // 처음부터 인덱스 1(2-1)까지 출력
    PrintArray(fruits[1..]);    // 인덱스 1부터 끝까지 출력
    
    void PrintArray(string[] array) {
      foreach(var i in array) {
        Console.Write(i + " ");
      }
      Console.WriteLine();
    }
  }
}
