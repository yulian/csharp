using System;

class MainClass {
  public static void Main(string[] args) {
    Action < string > greet = name => {
      string greeting = "Hello " + name;
      Console.WriteLine(greeting);
    };
    
    greet("World");
  }
}
