namespace _09.PadawanEquipment.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lighsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            int allLightsabers = (int)Math.Ceiling(studentsCount * 1.10);
            int freeBelts = studentsCount / 6;

            double sumLightsabers = allLightsabers * lighsaberPrice;
            double sumRobes = studentsCount * robePrice;
            double sumBelts = (studentsCount - freeBelts) * beltPrice;
            double totalSum = sumLightsabers + sumRobes + sumBelts;

            if (budget >= totalSum)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - budget:F2}lv more.");
            }
        }
    }
}
