namespace _01.ConvertMetersToKilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distanceInMeters = int.Parse(Console.ReadLine());

            float distanceInKm = distanceInMeters / 1000f;
            Console.WriteLine($"{distanceInKm:F2}");
        }
    }
}
