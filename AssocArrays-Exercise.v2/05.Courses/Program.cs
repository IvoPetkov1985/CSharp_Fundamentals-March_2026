namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> academy = new();

            while (true)
            {
                string inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    break;
                }

                string[] arguments = inputLine.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];

                academy.TryAdd(courseName, new List<string>());
                academy[courseName].Add(studentName);
            }

            foreach (KeyValuePair<string, List<string>> courseInfo in academy)
            {
                Console.WriteLine($"{courseInfo.Key}: {courseInfo.Value.Count}");

                foreach (string studentName in courseInfo.Value)
                {
                    Console.WriteLine($"-- {studentName}");
                }
            }
        }
    }
}
