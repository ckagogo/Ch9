using System;

namespace Debug1
{
    class Program
    {
        static void Main(string[] args)
        {

            Car myCar = new Car(32000, "red");
            Car yourCar = new Car(14000);
            Car theirCar = new Car();
            Console.WriteLine("My {0} car cost {1}", myCar.Color, myCar.Price.ToString("c2"));
            Console.WriteLine("Your {0} car cost {1}", yourCar.Color, yourCar.Price.ToString("c2"));
            Console.WriteLine("Their {0} car cost {1}", theirCar.Color, theirCar.Price.ToString("c2"));
        }
    }




    class Car
    {
        private string color;
        private int price;
        public Car() : this(10000, "black")
        {
        }
        public Car(int price) : this()
        {
        }
        public Car(int price, string color)
        {
            Price = price;
            Color = color;
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Price
        {
            get
            {
                return Price;
            }
            set
            {
                price = value;
            }
        }
    }

}
  