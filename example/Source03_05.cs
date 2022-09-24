using System;

class MainClass
{
  public static void Main(string[] args)
  {
    // 연산에 필요한 변수 정의
    int result, num1, num2;

    // 덧셈 출력
    result = 3 + 1;
    Console.WriteLine(result);

    // 뺄셈 출력
    result = 3 - 1;
    Console.WriteLine(result);

    // 곱셈 출력
    num1 = 2;
    result = 5 * num1;
    Console.WriteLine(result);

    // 나눗셈 출력
    num2 = 10;
    result = num2 / 3;
    Console.WriteLine(result);

    // 나눗셈에서 나머지 출력
    result = 10 % 2;
    Console.WriteLine(result);
  }
}