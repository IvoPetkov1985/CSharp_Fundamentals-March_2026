namespace _08.TownInfo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string townName = Console.ReadLine();
            uint population = uint.Parse(Console.ReadLine());
            ushort areaInSqKm = ushort.Parse(Console.ReadLine());

            Console.WriteLine($"Town {townName} has population of {population} and area {areaInSqKm} square km.");
        }
    }
}
