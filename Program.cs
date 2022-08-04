using System;

namespace MyFirstApp
{
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Hello World!");

      //Var type for text
      string name = "Bernardo"; 

      Console.Write($"My name is {name},");

      // Number variable type with 32bits
      int age = 21;

      Console.WriteLine($" and my age is {age}.");
      
      //Double precision point number
      double height = 1.70; 
      Console.WriteLine($"I'm {height} tall.");
      int heightToInteger = (int)height;


      Console.WriteLine($"Studying numbers");
      
      Console.WriteLine($"Testing the double type.");
      double doubleTypeTest = 7 / 5 ;
      Console.WriteLine($"Without dots it returns a int: {doubleTypeTest}.");
      doubleTypeTest = 7.0 / 5.0;
      Console.WriteLine($"After using dots it returns a double: {doubleTypeTest}.");

      // Number variable type with 64bits
      long x = 2000000000000000000; 

      // Number variable type with 16bits
      short y = 15000;

      //Single precision point number
      float z = 1.62f;
     

     Console.WriteLine($"Studying characters and text");

     Console.WriteLine($"Char variables must be single-quoted");
     char letter = 'a';
     Console.WriteLine(letter);
       
     letter = (char)65;
     Console.WriteLine(letter);

     letter = (char)(65+1);
     Console.WriteLine(letter);

     letter = (char)(86+1);
     Console.WriteLine(letter);  
    }
  }
}