using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Zoo
    {
        public Zoo()
        {
        }

        public List<Animal> ListOfAnimal = new List<Animal>()
        {
            new Animal("Tiger", 600, true),
            new Animal("Parrot", 50, false),
            new Animal("Snake", 500, true),
            new Animal("Monkey", 100, false),
            new Animal("Cat", 10000, false),
            new Animal("Wolf", 400, true),
            new Animal("Deer", 300, false),
            new Animal("Bears", 800, true),
            new Animal("Penguins", 350, false),
            new Animal("Shark", 600000, true),
        };

        public List<Animal> ListOfSafeAnimal = new List<Animal>()
        {
            new Animal("Parrot", 50, false),
            new Animal("Monkey", 100, false),
            new Animal("Cat", 10000, false),
            new Animal("Deer", 300, false),
            new Animal("Penguins", 350, false),
        };

        public void AddAnimal(Animal animal,bool isScary)
        {
            if(isScary == true)
            {
                ListOfAnimal.Add(animal);
            }
            else
            {
                ListOfAnimal.Add(animal);
                ListOfSafeAnimal.Add(animal);
            }
        }
    }
}
