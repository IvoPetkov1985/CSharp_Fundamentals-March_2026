namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstCharIndex = int.Parse(Console.ReadLine());
            int secondCharIndex = int.Parse(Console.ReadLine());

            char[] chars = new char[(secondCharIndex - firstCharIndex) + 1];

            for (int i = 0; i < chars.Length; i++)
            {
                chars[i] = (char)(i + firstCharIndex);
            }

            Console.WriteLine(string.Join(" ", chars));
        }
    }
}
