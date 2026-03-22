namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int capacity = 255;
            int waterInTank = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int inputWater = int.Parse(Console.ReadLine());

                if (inputWater > (capacity - waterInTank))
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    waterInTank += inputWater;
                }
            }

            Console.WriteLine(waterInTank);
        }
    }
}
