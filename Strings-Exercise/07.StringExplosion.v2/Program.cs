using System.Text;

namespace _07.StringExplosion.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder result = new();

            int strength = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    int newStrength = int.Parse(text[i + 1].ToString());
                    result.Append(text[i]);
                    strength += newStrength;
                }
                else if (strength == 0)
                {
                    result.Append(text[i]);
                }
                else if (strength > 0)
                {
                    strength--;
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
