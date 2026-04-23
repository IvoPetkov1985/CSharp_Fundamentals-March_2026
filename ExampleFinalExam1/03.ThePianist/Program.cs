namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());

            Dictionary<string, string> piecesComposers = new();
            Dictionary<string, string> piecesKeys = new();

            for (int i = 0; i < piecesCount; i++)
            {
                string inputLine = Console.ReadLine();
                string[] tokens = inputLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string piece = tokens[0];
                string composer = tokens[1];
                string key = tokens[2];

                piecesComposers.TryAdd(piece, composer);
                piecesKeys.TryAdd(piece, key);
            }

            string commandLine = Console.ReadLine();

            while (commandLine != "Stop")
            {
                string[] arguments = commandLine.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = arguments[0];
                string piece = arguments[1];

                switch (command)
                {
                    case "Add":

                        if (piecesComposers.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            string composer = arguments[2];
                            string key = arguments[3];
                            piecesComposers.Add(piece, composer);
                            piecesKeys.Add(piece, key);
                            Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                        }

                        break;

                    case "Remove":
                        bool isRemoved = piecesComposers.Remove(piece);

                        if (isRemoved == true)
                        {
                            piecesKeys.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }

                        break;

                    case "ChangeKey":
                        if (piecesKeys.ContainsKey(piece))
                        {
                            string newKey = arguments[2];
                            piecesKeys[piece] = newKey;
                            Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }

                commandLine = Console.ReadLine();
            }

            foreach (KeyValuePair<string, string> piece in piecesComposers)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value}, Key: {piecesKeys[piece.Key]}");
            }
        }
    }
}
