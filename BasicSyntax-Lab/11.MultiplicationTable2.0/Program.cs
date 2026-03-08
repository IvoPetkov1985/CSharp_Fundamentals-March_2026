namespace _11.MultiplicationTable2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int multiplyer = int.Parse(Console.ReadLine());

            do
            {
                int product = inputNumber * multiplyer;
                Console.WriteLine($"{inputNumber} X {multiplyer} = {product}");
                multiplyer++;
            }
            while (multiplyer <= 10);
        }
    }
}
