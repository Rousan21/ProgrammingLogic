using System;

// Step 1 - Base class
class Animal
{
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
}

// Step 2 - Derived class: Cat
class Cat : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The cat says: meow");
    }
}

// Step 2 - Derived class: Dog
class Dog : Animal
{
    public override void animalSound()
    {
        Console.WriteLine("The dog says: bow wow");
    }
}

// Step 3 - Test in Main
class Program
{
    static void Main()
    {
        Animal myAnimal = new Animal(); // Base class object
        Animal myCat = new Cat();       // Derived class object (Cat)
        Animal myDog = new Dog();       // Derived class object (Dog)

        myAnimal.animalSound(); // Calls Animal's version
        myCat.animalSound();    // Calls Cat's overridden version
        myDog.animalSound();    // Calls Dog's overridden version
    }
}
