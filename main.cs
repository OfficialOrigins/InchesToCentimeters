using System;

class Program 
{
    public static void Main (string[] args) 
    {
      double finalResult; 
      const double InchToCm = 2.54;
      int inch = 5;

      finalResult = inch * InchToCm;

      Console.WriteLine("The amount of inches: {0}", inch);
      Console.WriteLine("Conversion to centimeters: {0}", finalResult);
    }
}