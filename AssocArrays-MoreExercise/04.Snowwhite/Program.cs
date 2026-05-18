namespace _04.Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dwarf> dwarves = new();

            string inputLine = Console.ReadLine();

            while (inputLine != "Once upon a time")
            {
                string[] dwarfData = inputLine
                    .Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = dwarfData[0];
                string hatColor = dwarfData[1];
                int physics = int.Parse(dwarfData[2]);

                Dwarf dwarf = dwarves.FirstOrDefault(d => d.Name == name && d.HatColor == hatColor);

                if (dwarf == null)
                {
                    dwarf = new(name, hatColor, physics);
                    dwarves.Add(dwarf);
                }
                else
                {
                    if (dwarf.Physics < physics)
                    {
                        dwarf.Physics = physics;
                    }
                }

                inputLine = Console.ReadLine();
            }

            List<Dwarf> sortedDwarves = dwarves.OrderByDescending(d => d.Physics)
                .ThenByDescending(d => dwarves.Count(x => x.HatColor == d.HatColor))
                .ToList();

            foreach (Dwarf dwarf in sortedDwarves)
            {
                Console.WriteLine(dwarf);
            }
        }
    }

    public class Dwarf
    {
        public Dwarf(string name, string hatColor, int physics)
        {
            Name = name;
            HatColor = hatColor;
            Physics = physics;
        }

        public string Name { get; set; }

        public string HatColor { get; set; }

        public int Physics { get; set; }

        public override string ToString()
        {
            return $"({HatColor}) {Name} <-> {Physics}";
        }
    }
}
