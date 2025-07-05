using System;

/*
Name: [Adam Al-Rousan]
Title: IT-1050 - Lab 1
*/

class Program
{
    static void Main(string[] args)
    {
        // Step 2: Basic Output
        Console.WriteLine("Name: Adam Al-Rousan");
        Console.WriteLine("Course: IT-1050 - Lab 1");

        // Step 3: Declare and Use Variables
        int favoriteNumber = 21;
        string favoriteLanguage = "Python";
        double programsWritten = 2;
        bool hasExperience = "No";

        Console.WriteLine("Favorite Number: " + favoriteNumber);
        Console.WriteLine("Favorite Language: " + favoriteLanguage);
        Console.WriteLine("Programs Written: " + programsWritten);
        Console.WriteLine("Has Experience: " + hasExperience);

        // Step 4: Use Constants
        const string schoolName = "Cuyahoga Community College";
        Console.WriteLine("School Name: " + schoolName);

        // Step 5: Type Casting
        double originalDouble = 9.78;
        int castedInt = (int)originalDouble;
        string intToString = Convert.ToString(favoriteNumber);
        string boolToString = Convert.ToString(hasExperience);

        Console.WriteLine("Original double: " + originalDouble);
        Console.WriteLine("Casted int: " + castedInt);
        Console.WriteLine("Int to string: " + intToString);
        Console.WriteLine("Bool to string: " + boolToString);

        // Step 6: User Input and Type Conversion
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int userAge = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello, " + userName + "! You are " + userAge + " years old.");

        // Step 7: Arithmetic Operators
        int num1 = 8;
        int num2 = 4;

        Console.WriteLine("Addition: " + (num1 + 10));
        Console.WriteLine("Subtraction: " + (num1 - 2));
        Console.WriteLine("Multiplication: " + (num1 * 3));
        Console.WriteLine("Division: " + (num1 / 2));
        Console.WriteLine("Modulus: " + (num1 % 2));

        // Step 8: Floating Point Precision
        float floatVal = 1.123456789;
        double doubleVal = 1.123456789;

        Console.WriteLine("Float Value: " + floatVal);
        Console.WriteLine("Double Value: " + doubleVal);

        // Step 9: Increment and Decrement
        int counter = 10;

        counter++;
        Console.WriteLine("After Increment: " + counter);

        counter--;
        Console.WriteLine("After Decrement: " + counter);
    }
}
