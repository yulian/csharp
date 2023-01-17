using System;

class Car {
  private string name = null;
  private int speed = 0;

  public Car(string name, int speed) {
    this.name = name;
    this.speed = speed;
  }

  public string getName() {
    return this.name;
  }

  public int getSpeed() {
    return this.speed;
  }

  public void MovingForward() {
    Console.WriteLine("자동차가 전진합니다.");
  }

  public void MovingBackward() {
    Console.WriteLine("자동차가 후진합니다.");
  }

  public void StopMoving() {
    Console.WriteLine("자동차가 멈춥니다.");
  }
}

class MainClass {
  public static void Main(string[] args) {
    Car myCar = new Car("소나타", 80);
    Console.WriteLine("자동차의 이름은 " + myCar.getName() + "입니다.");
    myCar.MovingForward();
    Console.WriteLine("자동차의 속도는 " + myCar.getSpeed() + "km입니다.");
    myCar.MovingBackward();
    myCar.StopMoving();
  }
}
