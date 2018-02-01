using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an interactive console window
            //prompt user to choose what to do with the fridge
            //Call methods on fridge object to do what the user wants

            Fridge userFridge = new Fridge(70, "deluxe dispenser", false, true)

            int userChoice;
                Console.WriteLine("Hello, welcome to the fridge app.");
            do
            {
                Console.WriteLine("What would you like to do with your fridge?");
                Console.WriteLine("To dispense water, type 1");
                Console.WriteLine("To change the lightbulbs, type 2");
                Console.WriteLine("To clean, type 3");
                Console.WriteLine("To take food, type 4");
                Console.WriteLine("To check food supplies, type 5");
                Console.WriteLine("To see all fridge details, type 6");
                Console.WriteLine("To restart, type 7");
                Console.WriteLine("To quit, type 8");

                userChoice = int.Parse(Console.ReadLine());

                

                switch (userChoice)
                {
                    case 1:
                        userFridge.DispenseWater();
                        Console.WriteLine("");
                        break;

                    case 2:
                        Console.WriteLine(userFridge.ChangeBulbs());
                        Console.WriteLine("");
                        break;
                    case 3:
                        Console.WriteLine(userFridge.Clean());
                        Console.WriteLine("");
                        break;
                    case 4:
                        Console.WriteLine("How much food do you want to remove? Please type a whole number");
                        int foodNumber = int.Parse(Console.ReadLine());
                        userFridge.RemoveFood(foodNumber);
                        Console.WriteLine("");
                        break;
                    case 5:
                        Console.WriteLine(userFridge.CheckSupplies());
                        Console.WriteLine("");
                        break;
                    case 6:
                        Console.WriteLine("It is {0} that the fridge is clean. \nThe water dispenser is a {1}. \nThe food amount is {2}. \nIt is {3} that the blulbs work.", userFridge.IsClean, userFridge.DispenserType, userFridge.FoodAmount, userFridge.BulbsWork);
                        Console.WriteLine("\n");
                        break;


                }

            } while (userChoice != 8);
            Console.WriteLine("\nThank you for using the Fridge App. Have a great day.");



        }
    }
}
