namespace _10.LowerOrUpper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputLetter = char.Parse(Console.ReadLine());

            if (char.IsLower(inputLetter))
            {
                Console.WriteLine("lower-case");
            }
            else if (char.IsUpper(inputLetter))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
