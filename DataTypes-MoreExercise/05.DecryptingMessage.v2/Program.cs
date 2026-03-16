namespace _05.DecryptingMessage.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte offset = byte.Parse(Console.ReadLine());
            byte numberOfCharacters = byte.Parse(Console.ReadLine());

            string output = string.Empty;

            for (int i = 0; i < numberOfCharacters; i++)
            {
                char inputLetter = char.Parse(Console.ReadLine());
                int letterCode = (int)inputLetter;
                letterCode += offset;
                output += (char)letterCode;
            }

            Console.WriteLine(output);
        }
    }
}
