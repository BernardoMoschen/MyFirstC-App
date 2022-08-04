using System;

namespace MyFirstApp
{
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");


      string name;
      name = "Bernardo"; 

      Console.Write($"My name is {name},");
      int age;
      age = 21;

      Console.WriteLine($" and my age is {age}.");
      
      double height;
      height = 1.70; 
      Console.WriteLine($"I'm {height} tall.");

      Console.WriteLine($"Testing the double type.");
      double doubleTypeTest; 
      doubleTypeTest = 7 / 5 ;
      Console.WriteLine($"Without dots it returns a int: {doubleTypeTest}.");
      doubleTypeTest = 7.0 / 5.0;
      Console.WriteLine($"After using dots it returns a double/float: {doubleTypeTest}.");
    }
  }
}