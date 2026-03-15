namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte linesCount = byte.Parse(Console.ReadLine());
            ushort water = 0;
            ushort capacity = 255;

            for (int i = 0; i < linesCount; i++)
            {
                ushort quantity = ushort.Parse(Console.ReadLine());

                if (quantity > (capacity - water))
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    water += quantity;
                }
            }

            Console.WriteLine(water);
        }
    }
}
