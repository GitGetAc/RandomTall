namespace GjettNummer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("+++++ Dette er et spill hvor du skal gjette hva tall jeg tenker på +++++\n");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");
            
            Console.Write("Kan vi begynne? (Trykk på en knapp...)"); Console.ReadKey();

            int tilfeldigTall = LageTilfeldigTall();
            Console.WriteLine("Da tenkte jeg på et tall mellom 1-100. Gjett hvilket tall jeg tenkte på!\n");

            while (true)
            {
                int brukerTall;
                string input = Console.ReadLine()!;

                //Check if user input is really an integer and then assign its value to the brukerTall variable
                if (int.TryParse(input, out brukerTall))
                {
                    if(brukerTall == tilfeldigTall)
                    {
                        Console.WriteLine($"Du gjetter riktig! Ditt tall var: {brukerTall} det samme som jeg tenkte på!");
                        break;
                    }
                    else if(brukerTall < tilfeldigTall && brukerTall > 0)
                    {
                        Console.WriteLine("Du gjetter for lavt! Prøv igjen!");
                    }
                    else if(brukerTall > tilfeldigTall && brukerTall < 101)
                    {
                        Console.WriteLine("Du gjetter for høyt! Prøv igjen!");
                    }
                    else
                    {
                        Console.WriteLine("Du må skrive et tall mellom 1-100! Prøv igjen!");
                    }
                }
                else
                {
                    Console.WriteLine("Du må skrive et tall mellom 1-100! Prøv igjen!");
                }
            }

            Console.WriteLine("Vil du spille igjen? (J)a/(N)ei: ");
            
            var PlayAgain = Console.ReadLine()!;    //Fixing a warning for assigning a maybe-null expression to a not-null variable with the "!" at the end

            if (PlayAgain.ToLower() == "j" || PlayAgain.ToLower() == "ja")
            {
                Main(args);     //Recursive function call (Basically we call the program main() function to run from the begining again)
            }
            else if(PlayAgain.ToLower() == "n" || PlayAgain.ToLower() == "nei")
            {
                Console.WriteLine("Da sees vi neste gang! Ha det bra!");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Du har ikke gitt noe svar! Programmet avsluttes nå!");
                return;
            }
        }

        public static int LageTilfeldigTall()
        {
            Random rand = new Random();
            int randomTall = rand.Next(1, 101);

            return randomTall;
        }
    
    }
}

