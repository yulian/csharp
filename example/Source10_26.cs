using System;

class Person {
  public string name { get; } = "Default Name";
}

class MainClass {
  public static void Main(string[] args) {
    Person p = new Person();
    p.name = "New Name";
    Console.WriteLine(p.name);
  }
}
