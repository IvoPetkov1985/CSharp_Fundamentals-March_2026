namespace _04.BackIn30Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int addedMinutes = 30;

            int timeInMinutes = hours * 60 + minutes;
            timeInMinutes += addedMinutes;

            int newHours = timeInMinutes / 60;
            int newMinutes = timeInMinutes % 60;

            if (newHours > 23)
            {
                newHours = 0;
            }

            Console.WriteLine($"{newHours}:{newMinutes:D2}");
        }
    }
}
