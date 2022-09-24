using System;

class MainClass
{
  public static void Main(string[] args)
  {
    // 연산에 필요한 변수 정의 및 초기화
    bool result;
    int num1, num2;
    num1 = 3;
    num2 = 5;

    // > 연산 및 출력 결과
    result = num1 > num2;
    Console.WriteLine(result);

    // < 연산 및 출력 결과
    result = num1 < num2;
    Console.WriteLine(result);

    // >= 연산 및 출력 결과
    result = num1 >= num2;
    Console.WriteLine(result);

    // <= 연산 및 출력 결과
    result = num1 <= num2;
    Console.WriteLine(result);

    // == 연산 및 출력 결과
    result = num1 == num1;
    Console.WriteLine(result);

    // != 연산 및 출력 결과
    result = num1 != num1;
    Console.WriteLine(result);
  }
}