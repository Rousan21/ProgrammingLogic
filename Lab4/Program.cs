using System;

class Car
{
    public string model;
    public string color;
    public int year;

    // Prints that the car is starting
    public void Start()
    {
        Console.WriteLine("The car is starting.");
    }

    // Prints how many miles the car drove
    public void Drive(int miles)
    {
        Console.WriteLine("The car drove " + miles + " miles.");
    }

    // Returns a description using the car's info
    public string GetDescription()
    {
        return year + " " + color + " " + model;
    }

    // Changes the color of the car and prints it
    public void Repaint(string newColor)
    {
        color = newColor;
        Console.WriteLine("The car has been repainted to " + newColor + ".");
    }

    public void Display()
    {
        Console.WriteLine("Car Details:");
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Color: " + color);
        Console.WriteLine("Year: " + year);
    }
}

class Program
{
    static void Main()
    {
        // Create a car and set values
        Car myCar = new Car();
        myCar.model = "Camry";
        myCar.color = "Black";
        myCar.year = 2015;

        myCar.Display();
        myCar.Start();              // Starting the car
        myCar.Drive(80);            // Driving 80 miles

        // Get and print car description
        string info = myCar.GetDescription();
        Console.WriteLine(info);

        // Repaint the car and show new color
        myCar.Repaint("Orange");
        myCar.Display();
    }
}
