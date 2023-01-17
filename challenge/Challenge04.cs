using System;

// 자동차 클래스
class Car {
  
  // 자동차의 이름과 속도를 결정할 속성 정의
  private string name = null;
  private int speed = 0;
  
  // 자동차 클래스의 생성자
  public Car(string name, int speed) {
    this.name = name;
    this.speed = speed;
  }

  // 자동차의 이름을 가져오는 메서드
  public string getName() {
    return this.name;
  }

  // 자동차의 속도를 가져오는 메서드
  public int getSpeed() {
    return this.speed;
  }

  // 자동차의 전진, 후진, 정지 기능을 담당하는 메서드
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
    // 자동차 클래스로 인스턴스 변수 초기화
    Car myCar = new Car("소나타", 80);
    
    // myCar 인스턴스 변수로 속성과 메서드 호출
    Console.WriteLine("자동차의 이름은 " + myCar.getName() + "입니다.");
    myCar.MovingForward();
    Console.WriteLine("자동차의 속도는 " + myCar.getSpeed() + "km입니다.");
    myCar.MovingBackward();
    myCar.StopMoving();
  }
}
