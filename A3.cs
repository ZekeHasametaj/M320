namespace A3
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            {
                int zahla;
                int zahlb;
                int ergebnis;
                String eingabe;

// Einlesen Zahlen
                Console.WriteLine("Geben Sie die erste Zahl ein: ");
                zahla = Convert.ToInt32(Console.ReadLine()); 

                Console.WriteLine("Geben Sie die zweite Zahl ein: ");
                zahlb = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Geben sie den Operator ein: ");
                eingabe = Convert.ToString(Console.ReadLine());
// Verarbeitung Zahlung
                if (eingabe == "+")
                {
                    ergebnis = zahla + zahlb;

                    Console.WriteLine("Das Ergbenis ist: " + ergebnis);
                }

                else if (eingabe == "-") {
                    ergebnis = zahla - zahlb;

                    Console.WriteLine("Das Ergbenis ist: " + ergebnis);
                }

                else if (eingabe == "*") {


                    Console.WriteLine("Das Ergbenis ist: " + zahla * zahlb);
                }
// Ausgabe Zahlen
                else if (eingabe == "/") {

                    Console.WriteLine("Das Ergbenis ist: " + zahla / zahlb);
                }
                else {
                    System.Environment.Exit(0);
                }
            }
        }
    }
}
