// See https://aka.ms/new-console-template for more information


    Console.WriteLine("NOK til Euro");
    Console.WriteLine("NOK til USD");



    string valg = Convert.ToString(Console.ReadLine());
    double belop = Convert.ToDouble(Console.ReadLine());
    string fra = "", til = "";
    double resultat = 0;


    switch (valg)
            {
                case "1": 
                    resultat = belop / 11.56;
                    Console.WriteLine($"Resultat: {resultat}");
                    break;
                case "2":
                    resultat = belop / 10.29;
                    Console.WriteLine($"Resultat: {resultat}");
                    break;
                default: Console.WriteLine("Ugyldig svar");
                    break;
            }

  