using System;

class Cat {
  public string Name = null;

  // Cat 클래스의 생성자 구현
  public Cat() {
    Console.WriteLine("생성자가 호출되었습니다.");
  }
}

class MainClass {
  public static void Main(string[] args) {
    // 클래스를 인스턴스로 만드는 과정에서 생성자를 자동으로 호출
    Cat myCat = new Cat();
  }
}