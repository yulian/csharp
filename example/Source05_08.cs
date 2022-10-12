using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    Queue qu = new Queue();
    
    // Enqueue() 메서드로 큐에 아이템 추가
    qu.Enqueue(1);
    qu.Enqueue(2);
    qu.Enqueue(3);
    
    // Dequeue() 메서드로 큐에서 아이템 제거
    while (qu.Count > 0) {
      Console.WriteLine(qu.Dequeue());
    }
  }
}
