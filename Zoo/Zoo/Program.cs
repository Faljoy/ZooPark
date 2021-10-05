using System;
using System.Collections.Generic;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {

            Menue menue = new Menue();
            Zoo zoo = new Zoo();
            double myDollars = 0.0;
            int countOfVisitor = 0;
            do
            {
                Console.Clear();
                Console.WriteLine( " --------------------- ");
                Console.WriteLine($"|Welcome in $ZooPark$ |" +
                                  $"\n|Number of visitors: {countOfVisitor}|");
                Console.WriteLine(" --------------------- ");
                string choseOfStartMenue = menue.NumOfStartMenue();
                switch (choseOfStartMenue)
                {
                    case "1":
                        Console.Clear();
                        if (countOfVisitor < 5)
                        {
                            double costAVisit;
                            int ageOfVisitor = menue.VisitorAge();
                            Visitor visitor = new Visitor(ageOfVisitor);
                            Console.WriteLine($"Visitor money: {visitor.MoneyOfVisitor}");
                            if (ageOfVisitor >= 18)
                            {
                                Console.WriteLine("Cost a visit:");
                                costAVisit = menue.VisitorChoseAAnimal(zoo.ListOfAnimal);
                                Console.WriteLine($"Visitor money: {visitor.MoneyOfVisitor}");

                            }
                            else costAVisit = menue.VisitorChoseAAnimal(zoo.ListOfSafeAnimal);

                            if (costAVisit > visitor.MoneyOfVisitor)
                            {
                                Console.WriteLine("not enough money.");
                                break;
                            }
                            else Console.WriteLine("Ticked sold out");
                            countOfVisitor++;
                            myDollars += costAVisit;
                        }
                        else Console.WriteLine("$ZooPark$ full, sorry");
                        break;
                    case "2":
                        Console.WriteLine("Kick all visitor?(Close $ZooPark$)");
                        Console.WriteLine("y - kick all\nany symbol - not to kick");
                        string chose = Console.ReadLine();
                        switch (chose)
                        {
                            case "y":
                                Console.WriteLine(" -----------");
                                Console.WriteLine("|kick to all|");
                                Console.WriteLine(" -----------");
                                countOfVisitor = 0;
                                break;
                            default:
                                Console.WriteLine(" -----------");
                                Console.WriteLine("|not to kick|");
                                Console.WriteLine(" -----------");
                                break;
                        }
                        break;
                    case "3":
                        if (myDollars == 0) Console.WriteLine("I haven`t money TT_TT");
                        else Console.WriteLine($"My dollars: {myDollars}");
                        break;
                    case "4":
                        Animal newAnimal = menue.AddAAnimalsInZoo();
                        zoo.AddAnimal(newAnimal, newAnimal.AnimalIsScary);
                        break;
                    default:
                        menue.ShowInvalidMenuePoinText();
                        break;
                }
                Console.WriteLine(" ---------------------------------------------");
                Console.WriteLine("|Press any Key for continue work about program|\n|Esc - for exit\t\t\t\t      |");
                Console.WriteLine(" ---------------------------------------------");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }
    }
}
