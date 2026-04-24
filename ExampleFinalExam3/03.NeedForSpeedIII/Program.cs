namespace _03.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            List<Car> parking = new List<Car>();

            for (int i = 0; i < carsCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] carTokens = inputLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string carName = carTokens[0];
                int mileage = int.Parse(carTokens[1]);
                int fuel = int.Parse(carTokens[2]);
                Car car = new Car(carName, mileage, fuel);
                parking.Add(car);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] arguments = commandLine
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string carName = arguments[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(arguments[2]);
                    int fuel = int.Parse(arguments[3]);

                    Car carToDrive = parking.First(c => c.Name == carName);

                    if (carToDrive.Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carToDrive.Mileage += distance;
                        carToDrive.Fuel -= fuel;
                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (carToDrive.Mileage >= 100000)
                        {
                            parking.Remove(carToDrive);
                            Console.WriteLine($"Time to sell the {carName}!");
                        }
                    }
                }
                else if (command == "Refuel")
                {
                    int newFuel = int.Parse(arguments[2]);
                    Car carToRefuel = parking.First(c => c.Name == carName);

                    if (carToRefuel.Fuel + newFuel > 75)
                    {
                        newFuel = 75 - carToRefuel.Fuel;
                    }

                    carToRefuel.Fuel += newFuel;
                    Console.WriteLine($"{carName} refueled with {newFuel} liters");
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(arguments[2]);
                    Car carToRevert = parking.First(c => c.Name == carName);
                    carToRevert.Mileage -= kilometers;

                    if (carToRevert.Mileage >= 10000)
                    {
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                    else
                    {
                        carToRevert.Mileage = 10000;
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (Car car in parking)
            {
                Console.WriteLine($"{car.Name} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }

        class Car
        {
            public Car(string name, int mileage, int fuel)
            {
                this.Name = name;
                this.Mileage = mileage;
                this.Fuel = fuel;
            }

            public string Name { get; set; }

            public int Mileage { get; set; }

            public int Fuel { get; set; }
        }
    }
}
