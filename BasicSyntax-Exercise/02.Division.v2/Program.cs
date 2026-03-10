namespace _02.Division.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] divisors = new int[] { 10, 7, 6, 3, 2 };
            bool isDivisible = false;

            for (int i = 0; i < divisors.Length; i++)
            {
                if (number % divisors[i] == 0)
                {
                    isDivisible = true;
                    Console.WriteLine($"The number is divisible by {divisors[i]}");
                    break;
                }
            }

            if (isDivisible == false)
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
