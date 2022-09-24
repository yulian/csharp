using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    ArrayList al = new ArrayList();

    // Add() 메서드로 ArrayList에 아이템 추가
    al.Add(1);
    al.Add("Hello");
    al.Add(3.3);
    al.Add(true);

    foreach(var item in al) {
      Console.WriteLine(item);
    }

    // 아이템 삭제 전과 후를 비교하기 위한 줄바꿈 출력
    Console.WriteLine();

    // Remove() 메서드로 ArrayList에서 아이템 삭제
    al.Remove("Hello");
    foreach(var item in al) {
      Console.WriteLine(item);
    }
  }
}