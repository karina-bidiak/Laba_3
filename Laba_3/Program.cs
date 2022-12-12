using System;

namespace laba_3
{
    class Car
    {
        public string name;
        private string color;
        public double price;
        const string CompanyName = "MyCars";

        public string Color
        { get; set; }

        public Car(string modelName, string modelColor, int modelPrice)
        {
            this.name = modelName;
            this.Color = modelColor;
            this.price = modelPrice;
        }

        public void Input()
        {
            this.name = Console.ReadLine();
            this.Color = Console.ReadLine();
            this.price = Convert.ToDouble(Console.ReadLine());
        }

        public void Print()
        {
            Console.WriteLine("Name: " + this.name + ", " + "color: " + this.Color + ", " + "price: " + this.price + ", " + "company name: " + Car.CompanyName);
        }

        public void ChangePrice(double x)
        {
            this.price = this.price - this.price * x / 100;
        }

        public static bool operator ==(Car A1, Car A2)
        {
            if ((A1.name == A2.name) && (A1.price == A2.price))
                return true;
            else
                return false;
        }

        public static bool operator !=(Car A1, Car A2)
        {
            return !(A1.name == A2.name) && !(A1.price == A2.price);
        }

        public override string ToString() => $"{this.name}, {this.Color}, {this.price}";

        static void Main(string[] args)
        {
            Car BMW = new Car("BMW", "Red", 10000);
            Car Porsche = new Car("Porsche", "Black", 25000);
            Car Mercedes = new Car("Mercedes", "White", 15000);

            BMW.Print();
            BMW.ChangePrice(10);
            BMW.Print();

            Porsche.ChangePrice(10);
            Porsche.Print();

            Mercedes.ChangePrice(10);
            Mercedes.Print();

            Mercedes.Color = "Pink";
            Mercedes.Print();

            Console.WriteLine(BMW == BMW);
            Console.WriteLine(BMW.ToString());

        }

    }
}
