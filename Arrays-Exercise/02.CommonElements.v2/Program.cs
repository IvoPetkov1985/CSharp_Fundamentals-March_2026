namespace _02.CommonElements.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] secondArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            List<string> result = new();

            foreach (string el in secondArray)
            {
                foreach (string compared in firstArray)
                {
                    if (compared == el)
                    {
                        result.Add(compared);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
