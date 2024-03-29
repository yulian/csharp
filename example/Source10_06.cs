using System;

class MainClass {
  public static void Main(string[] args) {
    int ? var1 = 10;
    int var2 = 15;
    
    Console.WriteLine(IsOfNullableType(var1));
    Console.WriteLine(IsOfNullableType(var2));
  }
  
  static bool IsOfNullableType < T > (T o) {
    var type = typeof (T);
    return Nullable.GetUnderlyingType(type) != null;
  }
}
