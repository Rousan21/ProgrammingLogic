using System;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: print numbers 1 to 10
        Console.WriteLine("Problem 1: Numbers 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        // Problem 2: even numbers from 1 to 20
        Console.WriteLine("\nProblem 2: Even numbers from 1 to 20");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        // Problem 3: countdown using while loop
        Console.WriteLine("\nProblem 3: Countdown from 5 to 1");
        int count = 5;
        while (count > 0)
        {
            Console.WriteLine(count);
            count--;
        }

        // Problem 4: print multiples of 10 up to 1000
        Console.WriteLine("\nProblem 4: Multiples of 10 up to 1000");
        int num = 10;
        while (num <= 1000)
        {
            Console.WriteLine(num);
            num += 10;
        }

        // Problem 5: list the seasons
        Console.WriteLine("\nProblem 5: Seasons of the year");
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string s in seasons)
        {
            Console.WriteLine(s);
        }

        // Problem 6: user picks a day of the week
        Console.WriteLine("\nProblem 6: Day of the week");
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number from 1 to 7: ");
        string input = Console.ReadLine();
        int choice;
        if (int.TryParse(input, out choice) && choice >= 1 && choice <= 7)
        {
            Console.WriteLine($"You picked: {days[choice - 1]}");
        }
        else
        {
            Console.WriteLine("That's not a valid number between 1 and 7.");
        }

        // Problem 7: favorite books and authors
        Console.WriteLine("\nProblem 7: Favorite books and authors");
        string[] books = { "The Hunger Games", "Percy Jackson", "Harry Potter" };
        string[] authors = { "Suzanne Collins", "Rick Riordan", "J.K. Rowling" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");
        }

        // Problem 8: temperatures sorted
        Console.WriteLine("\nProblem 8: Temperatures sorted");
        int[] temps = { 68, 72, 59, 80, 75 };
        Array.Sort(temps);
        Console.WriteLine("Sorted temps:");
        foreach (int t in temps)
        {
            Console.WriteLine(t);
        }
        Console.WriteLine($"Lowest: {temps[0]}");
        Console.WriteLine($"Highest: {temps[temps.Length - 1]}");

        // Problem 9: reverse countdown
        Console.WriteLine("\nProblem 9: Reverse countdown");
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.WriteLine(countdown[i]);
        }
    }
}
