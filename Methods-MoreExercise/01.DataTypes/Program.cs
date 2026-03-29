namespace _01.DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dataType = Console.ReadLine();
            string value = Console.ReadLine();

            if (dataType == "int")
            {
                int intNumber = int.Parse(value);
                ProcessData(intNumber);
            }
            else if (dataType == "real")
            {
                double realNumber = double.Parse(value);
                ProcessData(realNumber);
            }
            else if (dataType == "string")
            {
                ProcessData(value);
            }
        }

        static void ProcessData(int number)
        {
            int result = number * 2;
            Console.WriteLine(result);
        }

        static void ProcessData(double number)
        {
            double result = number * 1.5;
            Console.WriteLine($"{result:F2}");
        }

        static void ProcessData(string text)
        {
            string line = $"${text}$";
            Console.WriteLine(line);
        }
    }
}
