namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rowsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsData = new();

            for (int i = 0; i < rowsCount; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                studentsData.TryAdd(studentName, new List<double>());
                studentsData[studentName].Add(grade);
            }

            foreach (KeyValuePair<string, List<double>> student in studentsData)
            {
                double averageGrade = student.Value.Average();

                if (averageGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:F2}");
                }
            }
        }
    }
}
