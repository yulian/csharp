using System;

class MainClass {
  public static void Main(string[] args) {
    Console.Write("나눌 숫자를 입력하세요 : ");
    int divider = int.Parse(Console.ReadLine());
    
    // catch문에 Exception 클래스로 예외 메시지 출력
    try {
      Console.WriteLine(10 / divider);
    } catch (Exception e) {
      Console.WriteLine("예외 상황 : " + e.Message);
    }
  }
}
