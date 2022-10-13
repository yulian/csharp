using System;

public class Person {
  public string Name {
    get => name;
    set {
      if (string.IsNullOrWhiteSpace(value))
        throw new ArgumentException("Name must not be blank");
      name = value;
    }
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
