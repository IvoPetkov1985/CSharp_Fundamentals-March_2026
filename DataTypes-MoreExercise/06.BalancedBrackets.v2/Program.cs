namespace _06.BalancedBrackets.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            char opening = '\0';
            int counterOpening = 0;
            int counterClosing = 0;
            bool areBalanced = true;

            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();

                if (line == "(" && opening != '(')
                {
                    opening = '(';
                    counterOpening++;
                }
                else if ((line == "(" && opening == '(') || (line == ")" && opening == '\0'))
                {
                    areBalanced = false;
                    break;
                }
                else if (line == ")" && opening == '(')
                {
                    counterClosing++;
                    opening = '\0';
                }
            }

            if (areBalanced && (counterOpening == counterClosing))
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
