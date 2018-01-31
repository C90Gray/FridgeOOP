using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeOOP
{
    public class Fridge
    {
        //fields

        private bool isClean;
        private bool bulbsWork;
        private string dispenserType;
        private int foodAmount;

        //Properties

        public bool IsClean
        {
            get { return this.isClean; }
            set { this.isClean = value; }
        }

        public string DispenserType
        {
            get { return this.dispenserType; }
        }

        public int FoodAmount
        {
            get { return this.foodAmount; }
            set { this.foodAmount = value; }
        }

        public bool BulbsWork
        {
            get { return this.bulbsWork; }
            set { this.bulbsWork = value; }
        }

        //Constructors

        public Fridge()
        {
            this.dispenserType = "basic water dispenser";
        }

        public Fridge(string dispenserType)
        {
            this.dispenserType = dispenserType;
        }
           
        public Fridge(int foodAmount, string dispenserType, bool isClean, bool bulbsWork)
        {
            this.foodAmount = foodAmount;
            this.dispenserType = dispenserType;
            this.isClean = isClean;
            this.bulbsWork = bulbsWork;
        }
        //Methods()

        //I need to dispense water

        public void DispenseWater()
        {
            if (dispenserType== "basic water dispenser")
            {
                Console.WriteLine("Here's some lukewarm water!");
            }
            else if (dispenserType == "deluxe dispenser")
            {
                Console.WriteLine("Enjoy your perfectly chilled water");
            }
            else
            {
                Console.WriteLine("What's gonna come out? \nIt's a surprise!");
            }
        }

        public string ChangeBulbs()
        {
            if (bulbsWork == false)
            {
                bulbsWork = true;
                return "The bulbs have been changed";
            }
            else
            {
                return "The bulbs don't have to be changed.";
            }
        }

        public void RemoveFood( int foodRemoved)
        {
            foodAmount -= foodRemoved;
        }

        public string CheckSupplies()
        {
            if (foodAmount >= 80)
            {
                return " Fully stocked";
            }
            else if (foodAmount > 40)
            {
                return "Getting low";
            }
            else
            {
                return "Time to grocery shop";
            }
        }

        public string Clean()
        {
            if (isClean)
            {
                isClean = true;
                return "I cleaned the fridge";
            }
            else
            {
                return "The friedge is alredy clean.";
            }
        }
    }
}
