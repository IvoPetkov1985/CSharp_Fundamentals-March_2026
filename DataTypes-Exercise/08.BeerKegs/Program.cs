namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte kegsCount = byte.Parse(Console.ReadLine());

            string biggestKegModel = string.Empty;
            double biggestKegVolume = 0;

            for (int i = 0; i < kegsCount; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double currentKegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (currentKegVolume > biggestKegVolume)
                {
                    biggestKegModel = model;
                    biggestKegVolume = currentKegVolume;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
