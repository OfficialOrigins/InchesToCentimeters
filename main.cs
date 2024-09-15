//Module 2 excercise 2.1 
// using System;

// class Program 
// {
//     public static void Main (string[] args) 
//     {
//       double finalResult; 
//       const double InchToCm = 2.54;
//       int inch = 5;

//       finalResult = inch * InchToCm;

//       Console.WriteLine("The amount of inches: {0}", inch);
//       Console.WriteLine("Conversion to centimeters: {0}", finalResult);
//     }
// }

//Module 2 excercise 2.1.1
// using System;

// class Program 
// {
//     public static void Main (string[] args) 
//     {
//       double finalResult; 
//       const double Conversion = 2.54; 
      
//       Console.WriteLine("Enter the amount of inches: "); 
//       int inch = Convert.ToInt32(Console.ReadLine());
      
//       Console.WriteLine(" ");
      
//       finalResult = inch * Conversion; 
  
//       Console.WriteLine("The amount of inches: {0}", inch);
//       Console.WriteLine("Conversion to centimeters: {0}", finalResult);
//     }
// }

//Module 2 excercise 2.1.2
using System;

class Program 
{
    public static void Main (string[] args) 
    {
      double finalResult; 
      const double Conversion = 2.54; 

      Console.WriteLine("Enter the amount of inches: "); 
      int inch = Convert.ToInt32(Console.ReadLine());

      Console.WriteLine(" ");

      finalResult = inch * Conversion; 

      Console.WriteLine("The amount of inches: {0}", inch);
      Console.WriteLine("Conversion to centimeters: {0}", finalResult);
    }
}