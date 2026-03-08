namespace _12.EvenNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            while (inputNumber % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                inputNumber = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"The number is: {Math.Abs(inputNumber)}");
        }
    }
}
