using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Animal
    {
        public string NameOfAnumals;
        public double CostOfAnimal;
        public bool AnimalIsScary;

        public Animal(string NameOfAnumals, double CostOfAnimal, bool AnimalIsScary)
        {
            this.NameOfAnumals = NameOfAnumals;
            this.CostOfAnimal = CostOfAnimal;
            this.AnimalIsScary = AnimalIsScary;
        }
    }
}
