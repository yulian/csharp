using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    Hashtable ht = new Hashtable();
    
    // 키와 값 형태로 Hashtable에 아이템 추가
    ht["apple"] = "사과";
    ht["banana"] = "바나나";
    ht["orange"] = "오렌지";
    
    // Hashtable에 저장된 키에 해당하는 값 출력
    Console.WriteLine(ht["apple"]);
    Console.WriteLine(ht["banana"]);
    Console.WriteLine(ht["orange"]);
  }
}
