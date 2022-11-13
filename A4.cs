using System;

namespace A4
{
    internal class calculator
    {
        static void Main(string[] args)
        {
            
            int zahla;
            int zahlb;
            int ergebnis;
            int anzahl;
            int i = 0;
            String eingabe;

            Console.Write("Geben Sie an wieviele Nummer Sie eigeben wollen: ");
            anzahl = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie den Operator ein: ");
            eingabe = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Geben Sie die 1. Zahl ein: ");
            zahla = Convert.ToInt32(Console.ReadLine());


            if (eingabe == "+")
            {
                Console.WriteLine("Geben Sie die nächste Zahl ein: ", i);
                zahlb = Convert.ToInt32(Console.ReadLine());
                i++;
                while (i >= anzahl)
                {
                    i++;

                    Console.WriteLine("Geben Sie die nächste Zahl ein: ", i);
                    zahlb = Convert.ToInt32(Console.ReadLine());

                    zahlb += zahlb;

                }

            ergebnis = zahla + zahlb;

                Console.WriteLine("Das Ergbenis ist: " + zahla + zahlb);
            }

            else if (eingabe == "-")
            {
                Console.WriteLine("Geben Sie die nächste Zahl ein: ");
                zahlb = Convert.ToInt32(Console.ReadLine());
                i++;
                while (i >= anzahl)
                {
                    i++;

                    Console.WriteLine("Geben Sie die nächste Zahl ein: ");
                    zahlb = Convert.ToInt32(Console.ReadLine());

                    zahlb -= zahlb;

                }

            ergebnis = zahla - zahlb;

            Console.WriteLine("Das Ergbenis ist: " + ergebnis);
            }

            else if (eingabe == "*")
            {
        Console.WriteLine("Geben Sie die nächste Zahl ein: ");
        zahlb = Convert.ToInt32(Console.ReadLine());
        i++;
        while (i >= anzahl)
        {
        i++;

        Console.WriteLine("Geben Sie die nächste Zahl ein: ");
        zahlb = Convert.ToInt32(Console.ReadLine());

        zahlb *= zahlb;

    }

        Console.WriteLine("Das Ergbenis ist: " + zahla * zahlb);
    }

    else if (eingabe == "/")
    {
    Console.WriteLine("Geben Sie die nächste Zahl ein: ");
    zahlb = Convert.ToInt32(Console.ReadLine());
    i++;
    while (i >= anzahl)
    {
        i++;

        Console.WriteLine("Geben Sie die nächste Zahl ein: ");
        zahlb = Convert.ToInt32(Console.ReadLine());

        zahlb /= zahlb;

    }

            Console.WriteLine("Das Ergbenis ist: " + zahla / zahlb);
            }
            else
            {
                System.Environment.Exit(0);
            }
         }
     }
}
    
