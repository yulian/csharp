using System;

class MainClass
{
  public static void Main(string[] args)
  {
    // 정수형 변수인 점수 초기화
    int score = 85;

    // 논리 연산자를 사용하지 않은 경우
    if (score > 80)
      if (score <= 100)
        Console.WriteLine("A");

    // 논리 연산자를 사용한 경우
    if (score > 80 && score <= 100)
      Console.WriteLine("A");
  }
}