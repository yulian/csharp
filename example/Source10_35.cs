using System;

class MainClass {
  public static void Main(string[] args) {
    var t = ("우체국", 3.6);
    (string destination, double distance) = t;
    Console.WriteLine($"{destination}까지 거리는 {distance}킬로미터입니다.");
  }
}
