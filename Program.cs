using System;

namespace MyFirstApp
{
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");


      string name = "Bernardo"; 

      Console.Write($"My name is {name},");
      int age = 21;

      Console.WriteLine($" and my age is {age}.");
      
      double height = 1.70; 
      Console.WriteLine($"I'm {height} tall.");
      int heightToInteger = (int)height;

      Console.WriteLine($"Testing the double type.");
      double doubleTypeTest = 7 / 5 ;
      Console.WriteLine($"Without dots it returns a int: {doubleTypeTest}.");
      doubleTypeTest = 7.0 / 5.0;
      Console.WriteLine($"After using dots it returns a double: {doubleTypeTest}.");


      long x = 2000000000000000000; 

      short y = 15000;

      float z = 1.62f;
     
    }
  }
}