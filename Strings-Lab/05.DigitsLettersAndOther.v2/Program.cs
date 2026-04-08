namespace _05.DigitsLettersAndOther.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            char[] allSymbols = inputLine.ToCharArray();
            char[] digits = Array.FindAll(allSymbols, c => char.IsDigit(c));
            char[] letters = Array.FindAll(allSymbols, c => char.IsLetter(c));
            char[] other = Array.FindAll(allSymbols, c => !char.IsLetterOrDigit(c));
            Console.WriteLine(string.Join(string.Empty, digits));
            Console.WriteLine(string.Join(string.Empty, letters));
            Console.WriteLine(string.Join(string.Empty, other));
        }
    }
}
