using System;

class MainClass {
  public static void Main(string[] args) {
    ExampleClass ec = new ExampleClass();
    Console.WriteLine(ec.exampleMethod(10));
    Console.WriteLine(ec.exampleMethod("value"));
    
    ec.tag = "SampleTag";
    Console.WriteLine(ec.tag);
    
    ec.tag = 11.23;
    Console.WriteLine(ec.tag);
  }
}

class ExampleClass {
  public dynamic tag { get; set; }
  
  public dynamic exampleMethod(dynamic d) {
    dynamic local = "LocalVariable";
    int number = 7;
    if (d is int) {
      return local;
    } else {
      return number;
    }
  }
}
