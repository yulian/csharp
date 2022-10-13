using System;

class Person {
  private string name;
  private int age;
  private string gender;
  
  public Person(string name, int age = 0, string gender = "없음") {
    this.name = name;
    this.age = age;
    this.gender = gender;
  }
  
  public void PrintPerson() {
    Console.WriteLine("이름 : " + this.name);
    Console.WriteLine("나이 : " + this.age);
    Console.WriteLine("성별 : " + this.gender);
  }
}

class MainClass {
  public static void Main(string[] args) {
    Person y = new Person("영희");
    y.PrintPerson();
    
    Person c = new Person("철수", 20);
    c.PrintPerson();
  }
}
