using System;

class MainClass {
  public static void Main(string[] args) {
    (double, int) t1 = (4.5, 3);
    Console.WriteLine($"튜플 내 항목은 {t1.Item1}과 {t1.Item2}입니다.");
    
    (double Sum, int Count) t2 = (4.5, 3);
    Console.WriteLine($"Count: {t2.Count}, Sum: {t2.Sum}");
  }
}
