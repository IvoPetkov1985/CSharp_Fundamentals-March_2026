namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double singlePrice = 0;

            if (groupType == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday": singlePrice = 8.45; break;
                    case "Saturday": singlePrice = 9.80; break;
                    case "Sunday": singlePrice = 10.46; break;
                }
            }
            else if (groupType == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday": singlePrice = 10.90; break;
                    case "Saturday": singlePrice = 15.60; break;
                    case "Sunday": singlePrice = 16.00; break;
                }
            }
            else if (groupType == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday": singlePrice = 15.00; break;
                    case "Saturday": singlePrice = 20.00; break;
                    case "Sunday": singlePrice = 22.50; break;
                }
            }

            double totalPrice = singlePrice * peopleCount;

            if (groupType == "Students" && peopleCount >= 30)
            {
                totalPrice *= 0.85;
            }

            if (groupType == "Business" && peopleCount >= 100)
            {
                totalPrice -= (singlePrice * 10);
            }

            if (groupType == "Regular" && peopleCount >= 10 && peopleCount <= 20)
            {
                totalPrice *= 0.95;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
