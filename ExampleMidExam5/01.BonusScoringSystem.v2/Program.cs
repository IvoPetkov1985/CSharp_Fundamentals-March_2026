namespace _01.BonusScoringSystem.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double bestBonus = 0;
            int bestStudentAttendances = 0;

            for (int i = 1; i <= students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double totalBonus = attendances / (double)lectures * (5 + additionalBonus);

                if (totalBonus > bestBonus)
                {
                    bestBonus = totalBonus;
                    bestStudentAttendances = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(bestBonus)}.");
            Console.WriteLine($"The student has attended {bestStudentAttendances} lectures.");
        }
    }
}
