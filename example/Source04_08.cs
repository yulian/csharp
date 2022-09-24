using System;

class Cat {
  private string name = null;

  // 세터 - 멤버 변수의 값을 수정하는 메서드
  public void SetName(string name) {
    this.name = name;
  }

  // 게터 - 멤버 변수의 값을 가져오는 메서드
  public string GetName() {
    return this.name;
  }
}

class MainClass {
  public static void Main(string[] args) {
    Cat coco = new Cat();
    coco.SetName("코코");
    Console.WriteLine("고양이의 이름은 " + coco.GetName() + "입니다.");
  }
}