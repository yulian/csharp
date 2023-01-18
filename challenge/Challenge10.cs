using System;

class MainClass {
  public static void Main(string[] args) {
    // 정수 배열 초기화
    int[] intValues = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

    // 실수 배열 초기화
    double[] doubleValues = {5.3, 1.2, 3.3};
    
    // 일반화 프로그래밍으로 배열의 합계 출력
    Console.WriteLine(Sum < int > (intValues));
    Console.WriteLine(Sum < double > (doubleValues));
  }
  
  // 일반화 프로그래밍으로 배열의 합을 구하는 함수
  static public T Sum < T > (T[] arrValues) {
    dynamic sum = default (T);
    for (int i = 0; i < arrValues.Length; i++) {
      sum += arrValues[i];
    }
    return sum;
  }
}
