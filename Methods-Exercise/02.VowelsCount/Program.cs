namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int vowelsCount = GetVowelsCount(inputText);
            Console.WriteLine(vowelsCount);
        }

        static int GetVowelsCount(string text)
        {
            int counter = 0;
            char[] vowels = new char[12] { 'a', 'o', 'u', 'e', 'i', 'y', 'A', 'O', 'U', 'E', 'I', 'Y' };

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];

                if (vowels.Contains(currentLetter))
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
