namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            string biggestKegModel = string.Empty;
            double biggestKegVolume = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                uint height = uint.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume > biggestKegVolume)
                {
                    biggestKegModel = model;
                    biggestKegVolume = kegVolume;
                }
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
