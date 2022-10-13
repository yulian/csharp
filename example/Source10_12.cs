using System;
using System.Collections;

class MainClass {
  public static void Main(string[] args) {
    ArrayList al = new ArrayList();
    al.Add(1);
    al.Add("Hi");
    al.Add(true);
    
    foreach(var item in al) {
      Console.WriteLine(item);
    }
  }
}
