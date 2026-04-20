namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            Dictionary<string, List<string>> courses = new();

            while (inputLine != "end")
            {
                string[] tokens = inputLine.Split(" : ");
                string courseName = tokens[0];
                string studentName = tokens[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }

                courses[courseName].Add(studentName);
                inputLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, List<string>> courseInfo in courses)
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
