using System;

namespace Ex3
{
    public class Sale
    {
        //declare Sale class variable
        private double amount;
        private double tax;
        private string inventoryNumber;

        //get and set for inventoryNumber variable
        public string InventoryNumber
        {
            get { return inventoryNumber; }
            set { inventoryNumber = value; }

        }

        //get and set for amount variable
        public double Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;

            }
        }

        //get for tax variable
        public double Tax
        {
            get
            {
                return tax;
            }
        }


        //method for calculating to tax
        public void CalculateTax()
        {
            //if amount is less than 100
            if (amount <= 100)
                //tax will be 8% of amount
                tax = amount * 0.08;
            //amount is greater than 100
            else
                //tax will be 8% for the first 100 amount and 6% for the remaining amount
                tax = 100 * 0.08 + (amount - 100) * 0.06;

        }
    }


    class SalesTaxDemo
    {
        //main function --- the execution starts from here
        static void Main()
        {
            string inventoryNumber;
            double amount;
            //create array of Sale object
            Sale[] obj = new Sale[10];
            //for all the 10 objects
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter inventory number #" + (i + 1) + ">>");
                //take inventoryNumber input from user
                inventoryNumber = Console.ReadLine();

                Console.Write("Enter amount of sale >>");
                //take amount input from user and convert it to double
                amount = Convert.ToDouble(Console.ReadLine());

                //initialize the array object
                obj[i] = new Sale();

                //set inventoryNumber value
                obj[i].InventoryNumber = inventoryNumber;

                //set amount variable
                obj[i].Amount = amount;

                //calculate the tax
                obj[i].CalculateTax();
            }

            //show the details of all the 10 object
            for (int i = 0; i < 10; i++)
            {
                //String.Format("{0:0,0.00}",obj[i].Amount) will format the double to string in the format 0,0.00
                Console.WriteLine("Sale # " + (i + 1) + " Amount: " + obj[i].InventoryNumber + " Sale $" + String.Format("{0:0,0.00}", obj[i].Amount));
                Console.WriteLine("Tax is $" + String.Format("{0:0,0.00}", obj[i].Tax));

            }


        }
    }
}
