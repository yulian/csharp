using System;

class MainClass
{
  public static void Main(string[] args)
  {
    // -128 ~ 127의 범위를 갖는 sbyte형 초기화
    sbyte value1 = 64;
    sbyte value2 = 64;

    // 연산 과정에서 sbyte형의 범위를 초과
    sbyte value3 = value1 + value2;
    Console.WriteLine(value3);
  }
}