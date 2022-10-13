using System;
using System.Runtime.CompilerServices;

class MainClass {
  public static void Main(string[] args) {
    TraceMessage("메서드 호출");
  }
  
  public static void TraceMessage(string message,
    [CallerMemberName] string memberName = "",
    [CallerFilePath] string sourceFilePath = "",
    [CallerLineNumber] int sourceLineNumber = 0) {
    Console.WriteLine("메시지: " + message);
    Console.WriteLine("메서드 이름: " + memberName);
    Console.WriteLine("파일의 경로: " + sourceFilePath);
    Console.WriteLine("줄 번호: " + sourceLineNumber);
  }
}
