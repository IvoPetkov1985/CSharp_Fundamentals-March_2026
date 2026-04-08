namespace _01.ReverseStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            while (inputString != "end")
            {
                string result = string.Empty;

                for (int i = inputString.Length - 1; i >= 0; i--)
                {
                    result += inputString[i];
                }

                Console.WriteLine($"{inputString} = {result}");
                inputString = Console.ReadLine();
            }
        }
    }
}
