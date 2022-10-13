using System;
using System.Threading.Tasks;

class MainClass {
  public static void Main(string[] args) {
    AsyncFunc();
    Console.WriteLine("메인 메서드 종료");
    Console.Read();
  }
  
  public static async void AsyncFunc() {
    await Task.Delay(2000);
    Console.WriteLine("비동기 메서드 종료");
  }
}
