using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    // 회문 여부를 확인하는 불린형 변수 초기화
    bool isPalindrome = true;

    // 사용자로부터 단어를 입력 받기
    Console.Write("입력: ");
    string word = Console.ReadLine();

    // 단어를 구성하는 문자를 각각 큐와 스택에 저장
    // 큐와 스택은 입력과 출력이 반대이므로, 출력값이 같으면 회문
    Stack st = new Stack();
    Queue qu = new Queue();
    foreach(char item in word) {
      st.Push(item);
      qu.Enqueue(item);
    }

    // 스택과 큐는 동일한 문장을 저장하므로 같은 크기임
    // 스택과 큐에서 한 문자씩 가져와 비교해 한 문자라도 다르면 회문이 아님
    while (qu.Count > 0) {
      char a = (char) qu.Dequeue();
      char b = (char) st.Pop();

      if (a != b) {
        isPalindrome = false;
        break;
      }
    }

    // 회문 여부를 출력
    if (isPalindrome)
      Console.WriteLine("참(True)");
    else
      Console.WriteLine("거짓(False)");
  }
}
