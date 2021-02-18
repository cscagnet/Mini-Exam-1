using System;

class MainClass {
  public static void Main (string[] args) {
  
  for (int counter=1; counter<=10; counter++)
  {
    Console.WriteLine ("Name?");
    Console.ReadLine();

    Console.WriteLine ("Height in inches?");
    double height = Convert.ToDouble (Console.ReadLine());

    Console.WriteLine ("Weight in pounds?");
    double weight = Convert.ToDouble (Console.ReadLine());

    double bmi = (703 * weight) / (height * height);
    Console.WriteLine ("BMI is " + bmi);
  
    if (bmi < 18.5)
    {
      Console.WriteLine ("You are Underweight");
    }
    else if (bmi >= 18.5 && bmi <= 24.9)
    {
      Console.WriteLine ("You are Normal or Healthy Weight");
    
    }
    else if (bmi >= 25 && bmi <= 29.9)
    {
      Console.WriteLine ("You are Overweight");
    }
    else if (bmi >=30)
    {
      Console.WriteLine ("You are Obese");
    }

  }

  
  }
}