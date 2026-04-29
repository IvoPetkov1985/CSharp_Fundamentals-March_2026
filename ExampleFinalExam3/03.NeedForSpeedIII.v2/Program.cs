namespace _03.NeedForSpeedIII.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            Car[] cars = new Car[count];

            for (int i = 0; i < count; i++)
            {
                string[] carTokens = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string model = carTokens[0];
                int mileage = int.Parse(carTokens[1]);
                int fuel = int.Parse(carTokens[2]);
                Car car = new(model, mileage, fuel);
                cars[i] = car;
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] arguments = commandLine
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string model = arguments[1];
                Car car = cars.First(c => c.Model == model);

                if (command == "Drive")
                {
                    int distance = int.Parse(arguments[2]);
                    int fuel = int.Parse(arguments[3]);
                    car.Drive(distance, fuel);
                }
                else if (command == "Refuel")
                {
                    int fuelToRefill = int.Parse(arguments[2]);
                    car.Refuel(fuelToRefill);
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(arguments[2]);
                    car.Revert(kilometers);
                }

                commandLine = Console.ReadLine();
            }

            foreach (Car car in cars.Where(c => c.IsSold == false))
            {
                Console.WriteLine($"{car.Model} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }

    class Car
    {
        public Car(string model, int mileage, int fuel)
        {
            this.Model = model;
            this.Mileage = mileage;
            this.Fuel = fuel;
            this.IsSold = false;
        }

        public string Model { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }

        public bool IsSold { get; set; }

        public void Drive(int distance, int fuelNeeded)
        {
            if (this.Fuel >= fuelNeeded)
            {
                this.Mileage += distance;
                this.Fuel -= fuelNeeded;
                Console.WriteLine($"{this.Model} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");

                if (this.Mileage >= 100000)
                {
                    this.IsSold = true;
                    Console.WriteLine($"Time to sell the {this.Model}!");
                }
            }
            else
            {
                Console.WriteLine("Not enough fuel to make that ride");
            }
        }

        public void Refuel(int newFuel)
        {
            if (this.Fuel + newFuel > 75)
            {
                newFuel = 75 - this.Fuel;
            }

            this.Fuel += newFuel;
            Console.WriteLine($"{this.Model} refueled with {newFuel} liters");
        }

        public void Revert(int kilometers)
        {
            this.Mileage -= kilometers;

            if (this.Mileage >= 10000)
            {
                Console.WriteLine($"{this.Model} mileage decreased by {kilometers} kilometers");
            }
            else
            {
                this.Mileage = 10000;
            }
        }
    }
}
