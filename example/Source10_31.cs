using System;

class Person {
  public string Name { get; set; } = "홍길동";
  public void PrintName() => Console.WriteLine(Name);
}

class MainClass {
  public static void Main(string[] args) {
    Person p = new Person();
    p.PrintName();
  }
}
