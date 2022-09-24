using System;

class MainClass
{
  public static void Main(string[] args)
  {
    // -128 ~ 127의 범위를 갖는 sbyte형 초기화
    sbyte value1 = 64;
    sbyte value2 = 64;

    // 명시적 형 변환(sbyte -> int)을 통해 오류 해결
    int value3 = (int) value1 + value2;
    Console.WriteLine(value3);
  }
}