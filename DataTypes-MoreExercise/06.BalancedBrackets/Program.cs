namespace _06.BalancedBrackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string open = string.Empty;
            int openCounter = 0;
            int closeCounter = 0;
            bool isValid = true;

            for (int i = 0; i < numberOfLines; i++)
            {
                string line = Console.ReadLine();

                if (line == "(" && open != "(")
                {
                    open = "(";
                    openCounter++;
                }
                else if (line == "(" && open == "(")
                {
                    isValid = false;
                    break;
                }
                else if (line == ")" && open == "(")
                {
                    open = string.Empty;
                    closeCounter++;
                }
                else if (line == ")" && open != "(")
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid && openCounter == closeCounter)
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
