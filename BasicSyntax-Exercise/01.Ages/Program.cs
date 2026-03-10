namespace _01.Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inputAge = int.Parse(Console.ReadLine());
            string output = string.Empty;

            if (inputAge <= 2)
            {
                output = "baby";
            }
            else if (inputAge <= 13)
            {
                output = "child";
            }
            else if (inputAge <= 19)
            {
                output = "teenager";
            }
            else if (inputAge <= 65)
            {
                output = "adult";
            }
            else if (inputAge > 65)
            {
                output = "elder";
            }

            Console.WriteLine(output);
        }
    }
}
