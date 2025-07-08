using System;
using System.Collections.Generic;

namespace Animal_sounds
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> animals = new List<IAnimal>
            {
                new Dog(),
                new Cat(),
                new Cow(),
                new Horse(),
                new Chicken(),
                new Elephant(),
                new Snake(),
                new Sheep()
            };

            while (true)
            {
                Console.WriteLine("Select an animal to hear its sound:");
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {animals[i].GetTypeName()}");
                }
                Console.WriteLine("0. Exit");

                Console.Write("Enter number: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice))
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("Goodbye!");
                        break;
                    }
                    else if (choice >= 1 && choice <= animals.Count)
                    {
                        var selectedAnimal = animals[choice - 1];
                        Console.WriteLine($"{selectedAnimal.GetTypeName()} makes sound: {selectedAnimal.MakeSound()}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.");
                }

                Console.WriteLine();
            }
        }
    }
}
