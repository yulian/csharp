using System;

class Cat {
  // 멤버 변수 초기화
  public string Name = null;

  // 생성자 구현
  public Cat(string name) {
    Name = name;
    Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
  }

  // 소멸자 구현
  ~Cat() {
    Console.WriteLine(Name + "가 사라집니다.");
  }
}

class MainClass {
  public static void Main(string[] args) {
    Cat coco = new Cat("코코");
    Cat moly = new Cat("몰리");
  }
}