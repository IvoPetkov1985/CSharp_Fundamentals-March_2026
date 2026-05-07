namespace _03.NeedForSpeedIII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, string> cars = new();

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] carInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);

                string carName = carInfo[0];
                string mileage = carInfo[1];
                string fuel = carInfo[2];

                cars.Add(carName, $"{mileage}:{fuel}");
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] commandInfo = commandLine
                    .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

                string command = commandInfo[0];
                string car = commandInfo[1];

                string[] carDetails = cars[car].Split(":");
                int currentMileage = int.Parse(carDetails[0]);
                int currentFuel = int.Parse(carDetails[1]);

                if (command == "Drive")
                {
                    int distance = int.Parse(commandInfo[2]);
                    int fuel = int.Parse(commandInfo[3]);

                    if (currentFuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        commandLine = Console.ReadLine();
                        continue;
                    }

                    currentMileage += distance;
                    currentFuel -= fuel;
                    cars[car] = $"{currentMileage}:{currentFuel}";
                    Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                    if (currentMileage >= 100_000)
                    {
                        cars.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                else if (command == "Refuel")
                {
                    int newFuel = int.Parse(commandInfo[2]);

                    if (currentFuel + newFuel > 75)
                    {
                        newFuel = 75 - currentFuel;
                    }

                    currentFuel += newFuel;
                    cars[car] = $"{currentMileage}:{currentFuel}";
                    Console.WriteLine($"{car} refueled with {newFuel} liters");
                }
                else if (command == "Revert")
                {
                    int kilometers = int.Parse(commandInfo[2]);
                    currentMileage -= kilometers;

                    if (currentMileage < 10_000)
                    {
                        currentMileage = 10_000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {kilometers} kilometers");
                    }

                    cars[car] = $"{currentMileage}:{currentFuel}";
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> carInfo in cars)
            {
                string[] details = carInfo.Value.Split(":");
                Console.WriteLine($"{carInfo.Key} -> Mileage: {details[0]} kms, Fuel in the tank: {details[1]} lt.");
            }
        }
    }
}
