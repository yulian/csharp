using System;

class Person {
  public string name { get; set; } = "Default Name";
}

class MainClass {
  public static void Main(string[] args) {
    Person p = new Person();
    Console.WriteLine(p.name);
  }
}
