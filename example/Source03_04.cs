using System;

class MainClass
{
  public static void Main(string[] args)
  {
    int i = 1;                  // 반복할 변수 초기화
    while (i < 11)              // while 반복문의 조건식
      Console.WriteLine(i++);   // 반복하는 문장
  }
}