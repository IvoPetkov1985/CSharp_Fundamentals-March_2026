namespace _04.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int carsCount = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> cars = new();

            for (int i = 0; i < carsCount; i++)
            {
                string carLine = Console.ReadLine();
                string[] carTokens = carLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string make = carTokens[0];
                int mileage = int.Parse(carTokens[1]);
                int fuel = int.Parse(carTokens[2]);
                cars.Add(make, new int[] { mileage, fuel });
            }

            string inputLine = Console.ReadLine();

            while (inputLine != "Stop")
            {
                string[] arguments = inputLine
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string command = arguments[0];
                string carName = arguments[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(arguments[2]);
                    int fuelNeeded = int.Parse(arguments[3]);

                    if (fuelNeeded > cars[carName][1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[carName][0] += distance;
                        cars[carName][1] -= fuelNeeded;
                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");

                        if (cars[carName][0] >= 100000)
                        {
                            cars.Remove(carName);
                            Console.WriteLine($"Time to sell the {carName}!");
                        }
                    }
                }
                else if (command == "Refuel")
                {
                    int newFuel = int.Parse(arguments[2]);
                    int oldQuantity = cars[carName][1];

                    if (oldQuantity + newFuel > 75)
                    {
                        newFuel = 75 - oldQuantity;
                    }

                    cars[carName][1] += newFuel;
                    Console.WriteLine($"{carName} refueled with {newFuel} liters");
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(arguments[2]);
                    cars[carName][0] -= kilometers;

                    if (cars[carName][0] < 10000)
                    {
                        cars[carName][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
                    }
                }

                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, int[]> carInfo in cars)
            {
                Console.WriteLine($"{carInfo.Key} -> Mileage: {carInfo.Value[0]} kms, Fuel in the tank: {carInfo.Value[1]} lt.");
            }
        }
    }
}
