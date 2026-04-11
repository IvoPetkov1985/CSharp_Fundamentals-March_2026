namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int strength = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    int number = int.Parse(text[i + 1].ToString());
                    strength += number;
                }
                else if (strength > 0 && text[i] != '>')
                {
                    text = text.Remove(i, 1);
                    strength--;
                    i--;
                }
            }

            Console.WriteLine(text);
        }
    }
}
