using System;

class MainClass {
  public static void Main(string[] args) {
    Console.Write("나눌 숫자를 입력하세요 : ");
    int divider = int.Parse(Console.ReadLine());
    
    // try, catch문으로 예외 처리하기
    try {
      Console.WriteLine(10 / divider);
    } catch {
      Console.WriteLine("0으로 나눌 수 없습니다.");
    }
  }
}
