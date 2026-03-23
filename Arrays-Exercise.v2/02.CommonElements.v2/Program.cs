namespace _02.CommonElements.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstInputArr = Console.ReadLine().Split();
            string[] secondInputArr = Console.ReadLine().Split();
            string result = string.Empty;

            foreach (string element2 in secondInputArr)
            {
                foreach (string element1 in firstInputArr)
                {
                    if (element1 == element2)
                    {
                        result += $"{element1} ";
                    }
                }
            }

            Console.WriteLine(result.TrimEnd());
        }
    }
}
