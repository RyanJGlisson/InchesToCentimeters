using System;

class Program {
  public static void Main (string[] args) {
    //Establish
    const double centInInch = 2.54;
    double inches;
    double centimeters;
    
    
    //Unit test 1
    inches = 5;
    centimeters = inches * centInInch;
    Console.WriteLine(inches +" inches is " + centimeters +" centimeters");

    //Unit test 2
    inches = 50;
    centimeters = inches * centInInch;
    Console.WriteLine(inches +" inches is " + centimeters +" centimeters");

    //Unit test 3
    inches = -15;
    centimeters = inches * centInInch;
    Console.WriteLine(inches +" inches is " + centimeters +" centimeters");

    //Unit test 4
    inches = 15994;
    centimeters = inches * centInInch;
    Console.WriteLine(inches +" inches is " + centimeters +" centimeters");
    
  }
}