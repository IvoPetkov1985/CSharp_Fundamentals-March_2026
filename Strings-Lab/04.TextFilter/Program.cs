namespace _04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string textToEdit = Console.ReadLine();

            foreach (string word in bannedWords)
            {
                string replacement = new string('*', word.Length);
                textToEdit = textToEdit.Replace(word, replacement);
            }

            Console.WriteLine(textToEdit);
        }
    }
}
