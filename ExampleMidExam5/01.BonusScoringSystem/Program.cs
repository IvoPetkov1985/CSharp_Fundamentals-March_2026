namespace _01.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lecturesCount = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            int maxAttendances = 0;
            double maxBonus = 0;

            for (int i = 1; i <= studentsCount; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());
                double totalBonus = studentAttendances / (double)lecturesCount * (5 + additionalBonus);

                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                    maxAttendances = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");
        }
    }
}
