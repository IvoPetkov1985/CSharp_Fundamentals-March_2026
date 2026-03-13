namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (char c = (char)startNumber; c < (char)endNumber; c++)
            {
                Console.Write(c + " ");
            }

            Console.WriteLine((char)endNumber);
        }
    }
}
