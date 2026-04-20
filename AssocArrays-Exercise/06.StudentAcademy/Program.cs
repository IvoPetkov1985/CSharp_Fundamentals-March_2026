namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> academy = new();

            for (int i = 0; i < rowsCount; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!academy.ContainsKey(studentName))
                {
                    academy.Add(studentName, new List<double>());
                }

                academy[studentName].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> studentInfo in academy)
            {
                string studentName = studentInfo.Key;
                double averageGrade = studentInfo.Value.Average();

                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{studentName} -> {averageGrade:F2}");
                }
            }
        }
    }
}
