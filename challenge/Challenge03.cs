using System;

class MainClass
{
  public static void Main (string[] args)
  {
    // 섭씨 온도 초기화
    int celsius = 27;
    
    // 섭씨 온도를 화씨 온도로 변환
    double fahrenheit = (celsius*1.8)+32;
    
    // 변환된 화씨 온도값 출력
    Console.WriteLine("섭씨 온도 "+celsius+"도는 화씨 온도 "+fahrenheit+"입니다.");
  }
}
