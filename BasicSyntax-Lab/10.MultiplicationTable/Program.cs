namespace _10.MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                int product = inputNumber * i;
                Console.WriteLine($"{inputNumber} X {i} = {product}");
            }
        }
    }
}
