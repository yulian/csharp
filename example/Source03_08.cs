using System;

class MainClass
{
  public static void Main(string[] args)
  {
    // 불리언 변수 선언 및 초기화
    bool A, B;
    A = true;
    B = false;

    // 논리곱
    Console.WriteLine(A && A);
    Console.WriteLine(A && B);

    // 논리합
    Console.WriteLine(A || B);
    Console.WriteLine(B || B);

    // 논리 부정
    Console.WriteLine(!A);
    Console.WriteLine(!B);
  }
}