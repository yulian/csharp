using System;

class MainClass
{
  public static void Main(string[] args)
  {
    // 변수 num 초기화
    int num = 0;

    // 조건문으로 변숫값에 따른 출력 결정
    if (num > 0)
      Console.WriteLine("양수");
    else if (num < 0)
      Console.WriteLine("음수");
    else
      Console.WriteLine("영");
  }
}