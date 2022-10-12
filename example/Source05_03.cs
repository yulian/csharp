using System;

class MainClass {
  public static void Main(string[] args) {
    // 배열을 초기화하는 두 번째 방법
    int[] array2 = new int[] { 1, 2, 3 };
    
    // for 반복문으로 배열의 인덱스 접근과 값 출력
    for (int i = 0; i < 3; i++) {
      Console.WriteLine(array2[i]);
    }
  }
}
