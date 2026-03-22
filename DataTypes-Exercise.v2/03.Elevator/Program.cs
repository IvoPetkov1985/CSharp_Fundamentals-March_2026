namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint numberOfPeople = uint.Parse(Console.ReadLine());
            uint elevatorCapacity = uint.Parse(Console.ReadLine());

            uint numberOfCourses = numberOfPeople / elevatorCapacity;

            if (numberOfPeople % elevatorCapacity > 0)
            {
                numberOfCourses += 1;
            }

            Console.WriteLine(numberOfCourses);
        }
    }
}
