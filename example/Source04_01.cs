using System;

class Person {
  // 속성 변수의 값을 null로 초기화
  public string Name = null;
  public string Birthday = null;
  public string Gender = null;

  // 메서드 구현
  public void Eat() {
    Console.WriteLine(Name + "이(가) 아침을 먹습니다.");
  }
  public void Walk() {
    Console.WriteLine(Name + "이(가) 걷습니다.");
  }
  public void Run() {
    Console.WriteLine(Name + "이(가) 뜁니다.");
  }
}

class MainClass {
  public static void Main(string[] args) {
    // 인스턴스 변수 선언 및 초기화
    Person p1;
    p1 = new Person();

    // 인스턴스 변수를 통해 속성과 메서드 호출
    p1.Name = "서준";
    p1.Eat();
  }
}