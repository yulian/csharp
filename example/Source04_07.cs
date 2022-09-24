using System;

// 부모 클래스(Robot)
class Robot {
  public void Move() {
    Console.WriteLine("로봇이 움직입니다.");
  }
}

// 부모 클래스를 상속 받는 자식 클래스(CleanRobot)
class CleanRobot: Robot {
  public void Move() {
    Console.WriteLine("청소 로봇이 움직입니다.");
  }
}

// 부모 클래스를 상속 받는 자식 클래스(RescueRobot)
class RescueRobot: Robot {
  public void Move() {
    Console.WriteLine("구조 로봇이 이동합니다.");
  }
}

class MainClass {
  public static void Main(string[] args) {
    CleanRobot cleanRobot = new CleanRobot();
    RescueRobot rescueRobot = new RescueRobot();

    // 메서드 오버라이딩으로 부모 클래스가 아닌 자식 클래스의 메서드 호출
    cleanRobot.Move();
    rescueRobot.Move();
  }
}