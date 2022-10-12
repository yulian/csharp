using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    Stack st = new Stack();
    
    // Push() 메서드로 스택에 아이템 추가
    st.Push(1);
    st.Push(2);
    st.Push(3);
    
    // Pop() 메서드로 스택에서 아이템 제거
    while (st.Count > 0) {
      Console.WriteLine(st.Pop());
    }
  }
}
