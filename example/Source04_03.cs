using System;

class Cat {
  public string Name = null;

  // 매개변수를 추가한 생성자 구현
  public Cat(string name) {
    Name = name;
    Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
  }
}
class MainClass {
  public static void Main(string[] args) {
    // 인스턴스화 과정에서 매개변수로 이름 초기화
    Cat coco = new Cat("코코");
    Cat moly = new Cat("몰리");
  }
}