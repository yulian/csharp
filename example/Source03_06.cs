using System;
class MainClass
{
  public static void Main(string[] args)
  {
    // 정수 변수 초기화
    int num = 0;

    Console.WriteLine(num++);   // num 변숫값 출력 후 1증가
    Console.WriteLine(num);     // num 변숫값 출력
    Console.WriteLine(--num);   // num 변숫값 1감소 후 num 출력
    Console.WriteLine(num);     // num 변숫값 출력
  }
}