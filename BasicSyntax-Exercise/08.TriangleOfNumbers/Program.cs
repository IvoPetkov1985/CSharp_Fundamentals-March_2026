namespace _08.TriangleOfNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= inputNumber; i++)
            {
                int[] ints = new int[i];
                
                for (int j = 0; j < ints.Length; j++)
                {
                    ints[j] = i;
                }

                Console.WriteLine(string.Join(" ", ints));
            }
        }
    }
}
