using System;

namespace HW7
{
    public class SalesTransactionDemo
    {
        string name;
        double salesAmount;
        double commision;
        double rate;
        
        // constructor 1
        public SalesTransactionDemo(string name, double salesAmount, double commision)
        {
            this.name = name;
            this.salesAmount = salesAmount;
            this.commision = commision;
            Calculate();
        }
        // constructor 2
        public SalesTransactionDemo(string name, double salesAmount)
        {
            this.name = name;
            this.salesAmount = salesAmount;
            this.commision = commision;
            Calculate();
        }
        // constructor 3
        public SalesTransactionDemo(string name)
        {
            this.name = name;
            this.salesAmount = salesAmount;
            this.commision = commision;
            Calculate();
        }
        private void Calculate()
        {
            //calculating rate based on salesamount and commision.
            this.rate = salesAmount * commision / 100;
        }
        public void Print()
        {
            //printing in demanded format.
            Console.WriteLine(name + " had a sale totaling $" + salesAmount + ", Commission rate was " + commision / 100 + ";");
            Console.WriteLine("Commission Value was $" + rate);
            
        }
        static void Main(string[] args)
        {
            // making 3 objects with parameters as demanded.
            
            SalesTransactionDemo Transaction1 = new SalesTransactionDemo("Abbott", 2000, 20);
            
            SalesTransactionDemo Transaction2 = new SalesTransactionDemo("Bendor", 4000);
            
            SalesTransactionDemo Transaction3 = new SalesTransactionDemo("Carter");
            // print the information of each transaction.
            Transaction1.Print();
            Transaction2.Print();
            Transaction3.Print();
        }
    }

   

}
