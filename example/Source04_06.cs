using System;

// 부모 클래스(Robot)
class Robot {
  public void Move() {
    Console.WriteLine("로봇이 움직입니다.");
  }
}

// 자식 클래스(CleanRobot)
class CleanRobot: Robot {
  public void Clean() {
    Console.WriteLine("청소를 시작합니다.");
  }
}

class MainClass {
  public static void Main(string[] args) {
    CleanRobot cleanRobot = new CleanRobot();

    // 상속으로 자식 클래스에는 없는 메서드 호출
    cleanRobot.Move();

    // 자식 클래스에만 있는 메서드 호출
    cleanRobot.Clean();
  }
}