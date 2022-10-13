using System;

class Human {
  private string name;
  private int age;
  
  public void SetName(string name) {
    this.name = name;
  }
  
  public string GetName() {
    return this.name;
  }
  
  public void SetAge(int age) {
    this.age = age;
  }
  
  public int GetAge() {
    return this.age;
  }
}

class MainClass {
  public static void Main(string[] args) {
    Human h1 = new Human();
    h1.SetName("미솔");
    h1.SetAge(7);
    
    Console.WriteLine(h1.GetName());
    Console.WriteLine(h1.GetAge());
  }
}
