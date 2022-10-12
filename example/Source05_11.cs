using System;

class MainClass {
  public static void Main(string[] args) {
    // ReadLine() 메서드로 사용자 입력 받기
    Console.Write("나눌 숫자를 입력하세요 : ");
    int divider = int.Parse(Console.ReadLine());
    
    // 숫자 10을 사용자 입력한 숫자로 나눈 몫을 출력
    Console.WriteLine(10 / divider);
  }
}
