using System;

delegate void myEventHandler();

class Publisher {
  public static event myEventHandler myEvent;
  public void RunEvent() {
    myEvent();
  }
}

class Subscriber {
  public Subscriber() {
    Publisher.myEvent += TestMethod;
  }
  public void TestMethod() {
    Console.WriteLine("이벤트 메서드 호출!!");
  }
}

class MainClass {
  public static void Main(string[] args) {
    Publisher pub = new Publisher();
    Subscriber sub = new Subscriber();
    pub.RunEvent();
  }
}
