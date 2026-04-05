namespace _10.SoftUniCoursePlanning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> schedule = Console.ReadLine()
                .Split(", ")
                .ToList();

            string commandLine = Console.ReadLine();

            while (commandLine != "course start")
            {
                string[] tokens = commandLine
                    .Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                string lessonTitle = tokens[1];

                if (command == "Add")
                {
                    if (schedule.Contains(lessonTitle) == false)
                    {
                        schedule.Add(lessonTitle);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(tokens[2]);

                    if (schedule.Contains(lessonTitle) == false && index >= 0 && index <= schedule.Count)
                    {
                        schedule.Insert(index, lessonTitle);
                    }
                }
                else if (command == "Remove")
                {
                    schedule.Remove(lessonTitle);
                    schedule.Remove($"{lessonTitle}-Exercise");
                }
                else if (command == "Swap")
                {
                    string otherLesson = tokens[2];

                    if (schedule.Contains(lessonTitle) && schedule.Contains(otherLesson))
                    {
                        int indexOfLessonTitle = schedule.IndexOf(lessonTitle);
                        int indexOfOtherLesson = schedule.IndexOf(otherLesson);

                        string temp = schedule[indexOfLessonTitle];
                        schedule[indexOfLessonTitle] = schedule[indexOfOtherLesson];
                        schedule[indexOfOtherLesson] = temp;

                        string ex1 = $"{lessonTitle}-Exercise";

                        if (schedule.Contains(ex1))
                        {
                            schedule.Remove(ex1);
                            int lessonIndex = schedule.IndexOf(lessonTitle);
                            schedule.Insert(lessonIndex + 1, ex1);
                        }

                        string ex2 = $"{otherLesson}-Exercise";

                        if (schedule.Contains(ex2))
                        {
                            schedule.Remove(ex2);
                            int lessonIndex = schedule.IndexOf(otherLesson);
                            schedule.Insert(lessonIndex + 1, ex2);
                        }
                    }
                }
                else if (command == "Exercise")
                {
                    if (schedule.Contains(lessonTitle) == false)
                    {
                        schedule.Add(lessonTitle);
                        schedule.Add($"{lessonTitle}-Exercise");
                    }
                    else if (schedule.Contains(lessonTitle) && schedule.Contains($"{lessonTitle}-Exercise") == false)
                    {
                        int index = schedule.IndexOf(lessonTitle);
                        schedule.Insert(index + 1, $"{lessonTitle}-Exercise");
                    }
                }
                commandLine = Console.ReadLine();
            }

            int counter = 0;
            foreach (string lesson in schedule)
            {
                counter++;
                Console.WriteLine($"{counter}.{lesson}");
            }
        }
    }
}
