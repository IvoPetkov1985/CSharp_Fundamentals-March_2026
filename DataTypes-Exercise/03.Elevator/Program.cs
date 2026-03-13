namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short peopleCount = short.Parse(Console.ReadLine());
            short capacity = short.Parse(Console.ReadLine());

            short courses = (short)Math.Ceiling(peopleCount / (double)capacity);
            Console.WriteLine(courses);
        }
    }
}
