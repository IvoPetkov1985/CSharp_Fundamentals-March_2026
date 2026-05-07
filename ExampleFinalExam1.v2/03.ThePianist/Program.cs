namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPieces = int.Parse(Console.ReadLine());
            ICollection<Piece> pieces = new List<Piece>();

            for (int i = 0; i < numberOfPieces; i++)
            {
                string[] pieceInfo = Console.ReadLine()
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];

                Piece piece = new(name, composer, key);
                pieces.Add(piece);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] commandInfo = commandLine
                    .Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = commandInfo[0];
                string pieceName = commandInfo[1];
                Piece piece = pieces.FirstOrDefault(p => p.Name == pieceName);

                switch (command)
                {
                    case "Add":
                        string composer = commandInfo[2];
                        string key = commandInfo[3];

                        if (piece == null)
                        {
                            piece = new Piece(pieceName, composer, key);
                            pieces.Add(piece);
                            Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{pieceName} is already in the collection!");
                        }

                        break;

                    case "Remove":

                        if (pieces.Remove(piece))
                        {
                            Console.WriteLine($"Successfully removed {pieceName}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                        }

                        break;

                    case "ChangeKey":
                        string newKey = commandInfo[2];

                        if (piece != null)
                        {
                            piece.Key = newKey;
                            Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                        }

                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (Piece piece in pieces)
            {
                Console.WriteLine(piece.ToString());
            }
        }
    }

    class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; } = null!;

        public string Composer { get; set; } = null!;

        public string Key { get; set; } = null!;

        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }
}
