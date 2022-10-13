using System;

class MainClass {
  public static void Main(string[] args) {
    int num1 = 3;
    int num2 = 5;
    
    // + 연산자를 활용한 문자열 연산
    Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
    
    // String.Format() 메서드를 활용한 문자열 연산
    Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
    
    // 문자열 보간을 활용한 문자열 연산
    Console.WriteLine($"{num1} + {num2} = {num1+num2}");
  }
}
