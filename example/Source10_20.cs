using System;
using System.Threading.Tasks;

class MainClass {
  public static async Task Main(string[] args) {
    Task t = AsyncFunc();
    Console.WriteLine("1");
    await t;
    Console.WriteLine("2");
    Console.Read();
  }
  
  public static async Task AsyncFunc() {
    await Task.Delay(2000);
    Console.WriteLine("3");
  }
}
