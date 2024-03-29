using System;

public class Person {
  public string Name {
    get => name;
    set => name = (!string.IsNullOrWhiteSpace(value)) ?
      value : throw new ArgumentException("name must not be blank");
  }
  private string name;
}

class MainClass {
  public static void Main(string[] args) {
    Person p = new Person();
    p.Name = "";
    Console.WriteLine(p.Name);
  }
}
