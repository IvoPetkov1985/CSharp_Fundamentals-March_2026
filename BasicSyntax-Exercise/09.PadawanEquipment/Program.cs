namespace _09.PadawanEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightsabers = Math.Ceiling(students * 1.10);
            double freeBelts = Math.Truncate(students / 6.0);
            double belts = students - freeBelts;

            double sumLightsabers = lightsabers * lightsaberPrice;
            double sumRobes = students * robePrice;
            double sumBelts = belts * beltPrice;
            double totalCost = sumLightsabers + sumRobes + sumBelts;

            if (budget >= totalCost)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCost:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalCost - budget:F2}lv more.");
            }
        }
    }
}
