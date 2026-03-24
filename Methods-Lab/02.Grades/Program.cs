
namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGradeInWords(grade);
        }

        static void PrintGradeInWords(double grade)
        {
            string gradeInWords = string.Empty;

            if (grade >= 2.00 && grade < 3.00)
            {
                gradeInWords = "Fail";
            }
            else if (grade >= 3.00 && grade < 3.50)
            {
                gradeInWords = "Poor";
            }
            else if (grade >= 3.50 && grade < 4.50)
            {
                gradeInWords = "Good";
            }
            else if (grade >= 4.50 && grade < 5.50)
            {
                gradeInWords = "Very good";
            }
            else if (grade >= 5.50 && grade <= 6.00)
            {
                gradeInWords = "Excellent";
            }

            Console.WriteLine(gradeInWords);
        }
    }
}
