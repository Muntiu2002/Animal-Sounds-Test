using System;
using System.Collections.Generic;

namespace Animal_sounds
{
    public static class AnimalFactory
    {
        public static IAnimal CreateAnimal(string type)
        {
            switch (type)
            {
                case "Dog": return new Dog();
                case "Cat": return new Cat();
                case "Cow": return new Cow();
                case "Horse": return new Horse();
                case "Chicken": return new Chicken();
                case "Elephant": return new Elephant();
                case "Snake": return new Snake();
                case "Sheep": return new Sheep();
                default: throw new ArgumentException("Unknown animal type");
            }
        }

        public static List<IAnimal> CreateAllAnimals()
        {
            return new List<IAnimal>
            {
                CreateAnimal("Dog"),
                CreateAnimal("Cat"),
                CreateAnimal("Cow"),
                CreateAnimal("Horse"),
                CreateAnimal("Chicken"),
                CreateAnimal("Elephant"),
                CreateAnimal("Snake"),
                CreateAnimal("Sheep")
            };
        }
    }
}
