using System;

class Person {
  private string name;
  private int age;
  private string gender;
  
  public Person(string name, int age, string gender) {
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
    Person y = new Person(name: "영희", age: 20, gender: "여");
    y.PrintPerson();
    
    Person c = new Person(gender: "남", name: "철수", age: 20);
    c.PrintPerson();
  }
}
