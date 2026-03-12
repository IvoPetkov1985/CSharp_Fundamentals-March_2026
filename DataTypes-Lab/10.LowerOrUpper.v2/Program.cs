namespace _10.LowerOrUpper.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char inputLetter = char.Parse(Console.ReadLine());
            sbyte aCode = 97;
            sbyte zCode = 122;
            string output = string.Empty;

            if (inputLetter >= aCode && inputLetter <= zCode)
            {
                output = "lower-case";
            }
            else
            {
                output = "upper-case";
            }

            Console.WriteLine(output);
        }
    }
}
