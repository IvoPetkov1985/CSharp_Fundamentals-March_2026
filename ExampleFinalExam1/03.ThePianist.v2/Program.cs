namespace _03.ThePianist.v2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());
            List<Piece> pieces = new();

            for (int i = 0; i < piecesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] tokens = inputLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string pieceName = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];
                Piece piece = new(pieceName, composer, key);
                pieces.Add(piece);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] arguments = commandLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string pieceName = arguments[1];

                if (command == "Add")
                {
                    string composer = arguments[2];
                    string key = arguments[3];

                    if (!pieces.Any(p => p.Name == pieceName))
                    {
                        Piece piece = new(pieceName, composer, key);
                        pieces.Add(piece);
                        Console.WriteLine($"{pieceName} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{pieceName} is already in the collection!");
                    }
                }
                else if (command == "Remove")
                {
                    Piece pieceToRemove = pieces.FirstOrDefault(p => p.Name == pieceName);

                    if (pieceToRemove != null)
                    {
                        pieces.Remove(pieceToRemove);
                        Console.WriteLine($"Successfully removed {pieceName}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }
                else if (command == "ChangeKey")
                {
                    string newKey = arguments[2];
                    Piece pieceToEdit = pieces.FirstOrDefault(p => p.Name == pieceName);

                    if (pieceToEdit != null)
                    {
                        pieceToEdit.Key = newKey;
                        Console.WriteLine($"Changed the key of {pieceName} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }
                }

                commandLine = Console.ReadLine();
            }

            foreach (Piece piece in pieces)
            {
                Console.WriteLine($"{piece.Name} -> Composer: {piece.Composer}, Key: {piece.Key}");
            }
        }

        class Piece
        {
            public Piece(string name, string composer, string key)
            {
                this.Name = name;
                this.Composer = composer;
                this.Key = key;
            }

            public string Name { get; set; }

            public string Composer { get; set; }

            public string Key { get; set; }
        }
    }
}
