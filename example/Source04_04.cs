using System;

class Cat {
  // 멤버 변수 초기화
  public string Name = null;
  public int Weight = 0;

  // 이름을 초기화 하는 생성자 구현
  public Cat(string name) {
    Name = name;
    Console.WriteLine("고양이의 이름은 " + Name + "입니다.");
  }

  // 이름과 몸무게를 초기화하는 생성자 구현
  public Cat(string name, int weight) {
    Name = name;
    Weight = weight;
    Console.WriteLine("고양이의 이름은 " + Name + "이며, 몸무게는 " + Weight + "kg입니다.");
  }
}

class MainClass {
  public static void Main(string[] args) {
    Cat coco = new Cat("코코");
    Cat moly = new Cat("몰리", 3);
  }
}