namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split();
            string[] secondArray = Console.ReadLine().Split();
            List<string> common = new();

            foreach (string el1 in secondArray)
            {
                foreach (string el2 in firstArray)
                {
                    if (el2 == el1)
                    {
                        common.Add(el1);
                    }
                }
            }

            Console.WriteLine(string.Join(" ", common));
        }
    }
}
