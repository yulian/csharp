using System;

public class Person {
  public string Name {
    get { return name; }
    set { name = value; }
  }
  private string name;
}

class MainClass {
  public static void Main(string[] args) {
    Person p = new Person();
    p.Name = "홍길동";
    Console.WriteLine(p.Name);
  }
}
