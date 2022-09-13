
namespace RandomZahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("------------------");
            Console.WriteLine("- Höher | Tiefer -");
            Console.WriteLine("------------------");

            
            var isGameRunning = true;

            
            while (isGameRunning)
            {
                
                var player = GetPlayerSelection();

                
                var computer = new Random().Next(1, 101);

                
                var counter = 1;

                
                while (player != computer)
                {
                    if (player > computer)
                        Console.WriteLine("Deine Nummer ist zu hoch!");
                    else
                        Console.WriteLine("Deine nummer ist zu tief!");

                    counter++;
                    player = GetPlayerSelection();
                }

                Console.WriteLine($"Gratulieren! Du hast die Zahl in {counter} Schritten erraten!\n\n");

                
                Console.WriteLine("Willst du nochmal spielen?\n[y] yes | [n] no");
                var input = Console.ReadLine();

                if (input.ToLower() != "y")
                    isGameRunning = false;
            }
        }

        static int GetPlayerSelection()
        {
            Console.WriteLine("Gieb eine Zahl von 1-100 ein:");
            var input = Console.ReadLine();

            if (int.TryParse(input, out int intVariable))
            {
                if (intVariable >= 1 && intVariable <= 100)
                    return intVariable;
            }

            return GetPlayerSelection();
        }
    }

}
  