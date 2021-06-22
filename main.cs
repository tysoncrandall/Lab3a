using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Enter temperature in celsius");
    var input_celsius = Console.ReadLine();
    
    double celsius = Convert.ToDouble(input_celsius);

    double fahrenheit = (celsius * 9/5) + 32;

    Console.WriteLine("Fahrenheit equivalent for " + celsius + " celsius is " + fahrenheit);

    if (fahrenheit < 32)
    {
      Console.WriteLine("This temperature is below freezing of 32 degree Fahrenheit");
    }
    if (fahrenheit > 212)
    {
      Console.WriteLine("This temperature is above boiling point of 212 degree Fahrenheit");
    }
    else
    {
      Console.WriteLine("");
    }
  }
}