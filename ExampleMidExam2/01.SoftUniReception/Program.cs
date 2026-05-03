namespace _01.SoftUniReception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstEmplyeeEfficiency = int.Parse(Console.ReadLine());
            int secondEmplyeeEfficiency = int.Parse(Console.ReadLine());
            int thirdEmplyeeEfficiency = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());

            int totalStudentsPerHour = firstEmplyeeEfficiency + secondEmplyeeEfficiency + thirdEmplyeeEfficiency;
            int hours = 0;

            while (studentsCount > 0)
            {
                hours++;

                if (hours % 4 == 0)
                {
                    continue;
                }

                studentsCount -= totalStudentsPerHour;
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
