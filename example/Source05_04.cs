using System;

class MainClass {
  public static void Main(string[] args) {
    // 배열을 초기화하는 세 번째 방법
    int[] array3 = { 4, 5, 6 };
    
    // foreach 문으로 배열에 담긴 값 출력
    foreach(int item in array3) {
      Console.WriteLine(item);
    }
  }
}
