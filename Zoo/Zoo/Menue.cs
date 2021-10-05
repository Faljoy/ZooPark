using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo
{
    class Menue
    {

        public string NumOfStartMenue()
        {
            Console.WriteLine("Chose a menue?");
            Console.WriteLine("1 - Sell a ticket.\n" +
                "2 - kick all visitor.\n" +
                "3 - see my doooooooolllllarrrrrrrrrrs\n" +
                "4 - add new animals");
            return Console.ReadLine();
        }

        public Animal AddAAnimalsInZoo()
        {
            Console.WriteLine(" -------------------");
            Console.WriteLine("|input name animals:|");
            Console.WriteLine(" -------------------");
            string name = Console.ReadLine();
            bool check = true;
            string inputCost;
            double cost = 0;
            do
            {
                Console.WriteLine(" -------------------");
                Console.WriteLine("|input cost animals:|");
                Console.WriteLine(" -------------------");

                inputCost = Console.ReadLine();
                check = double.TryParse(inputCost, out cost);
                if (!check) Console.WriteLine("|False|");
            } while (!check);
            Console.WriteLine(" ----------------");
            Console.WriteLine("|Animai is Scary?|\n" +
                              "1 - yes          |\n" +
                              "any - no         |");
            Console.WriteLine(" ---------------- ");

            string chose = Console.ReadLine();
            bool scary;
            switch (chose)
            {
                case "1":
                    scary = true;
                    break;
                default:
                    scary = false;
                    break;
            }
            Animal animal = new Animal(name, cost, scary);
            return animal;
        }

        public void ShowInvalidMenuePoinText()
        {
            Console.WriteLine("|False, input try|");
        }

        public double ATreat()
        {
            double sumATreap = 0;
            Console.WriteLine(" -----------------");
            Console.WriteLine("|Buy a treat 100$?|\n" +
                              "|1 - yes          |\n" +
                              "|any - no         |");
            Console.WriteLine(" -----------------");
            string choseATreat = Console.ReadLine();
            switch (choseATreat)
            {
                case "1":
                    sumATreap += 100;
                    break;
                default:
                    Console.WriteLine(" --------------------------- ");
                    Console.WriteLine("|you left the animals hungry|");
                    Console.WriteLine(" --------------------------- ");
                    break;
            }
            return sumATreap;
        }

        public double VisitorChoseAAnimal(List<Animal> NameOfAnimal)
        {
            int index = 1;
            double FinishCost = 0.0;
            bool check = true;
            Zoo zoo = new Zoo();

            do
            {
                index = 1;
                foreach (Animal value in NameOfAnimal)
                {
                    Console.WriteLine($"{index++} - {value.NameOfAnumals}, {value.CostOfAnimal} ");
                }

                check = true;
                string InputAnimals;
                do
                {
                    InputAnimals = Console.ReadLine();
                    if (InputAnimals == "") Console.WriteLine("False input");
                } while (InputAnimals == "");
                string[] wrld = InputAnimals.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);//del ' '
                int NumberOfAnimals = 0;
                FinishCost = 0;

                for (int i = 0; i < wrld.Length; i++)
                {
                    int count = 0;
                    check = int.TryParse(wrld[i], out NumberOfAnimals);
                    if (!check || NumberOfAnimals > NameOfAnimal.Count || NumberOfAnimals < 1 || wrld[i] == "")
                    {
                        Console.WriteLine( " -------------");
                        Console.WriteLine($"|False input {wrld[i]}|");
                        Console.WriteLine(" -------------");
                        Console.WriteLine(" -----------------------");
                        Console.WriteLine("|enter new or skip this?|");
                        Console.WriteLine(" -----------------------");
                        Console.WriteLine("|1 - skip               |\n" +
                                          "|any - new input        |");
                        Console.WriteLine(" ----------------------- ");
                        string choseOfVisitor = Console.ReadLine();
                        switch (choseOfVisitor)
                        {
                            case "1":
                                count++;
                                check = true;
                                continue;
                            default:
                                Console.WriteLine(" ---------- ");
                                Console.WriteLine("|New Input:|");
                                Console.WriteLine(" ---------- ");
                                check = false;
                                break;
                        }
                        Console.Clear();
                        if (choseOfVisitor != "1" || count == wrld.Length)
                        {
                            Console.WriteLine(" ---------------");
                            Console.WriteLine("|Try again input|");
                            Console.WriteLine(" ---------------");
                            break;
                        }
                    }
                    FinishCost += NameOfAnimal[NumberOfAnimals - 1].CostOfAnimal;
                }
            } while (!check);
            double treat = ATreat();
            FinishCost += treat;
            Console.WriteLine(FinishCost);
            return FinishCost;
        }

        public int VisitorAge()
        {
            int number;
            string rezultNumber;
            bool check = true;
            do
            {
                Console.WriteLine(" ---------------------");
                Console.WriteLine("|Input age of Visitor:|");
                Console.WriteLine(" ---------------------");
                rezultNumber = Console.ReadLine();
                check = int.TryParse(rezultNumber, out number);
                if (!check || number < 0 || number > 130) Console.WriteLine("|False|");
            } while (!check || number < 0 || number > 130);
            return number;
        }

    }
}
