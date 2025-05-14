// See https://aka.ms/new-console-template for more information

Console.WriteLine("1.NOK til Euro");
Console.WriteLine("2.NOK til USD");
Console.WriteLine("3.EUR til NOK");
Console.WriteLine("4.USD til NOK");



string valg = Convert.ToString(Console.ReadLine());
double belop = Convert.ToDouble(Console.ReadLine());
string fra = "", til = "";
double resultat = 0;



switch (valg)
{
    case "1":
        double NokEuro = Convert.ToDouble(NOKtoEUR(belop));
        Console.WriteLine($"Resultatet er: {NokEuro} EUR");
        break;
    case "2":
        double NokUsd = Convert.ToDouble(NOKtoUSD(belop));
        Console.WriteLine($"Resultat: {NokUsd} USD");
        break;
    case "3":
        double EurNok = Convert.ToDouble(EURtoNOK(belop));
        Console.WriteLine($"Resultat: {EurNok} NOK");
        break;
    case "4":
        double UsdNok = Convert.ToDouble(USDtoNOK(belop));
        Console.WriteLine($"Resultat: {UsdNok} NOK");
                    
        break;
    default: Console.WriteLine("Ugyldig svar");
        break;
}


double NOKtoEUR(double NOK)
{
    double EUR = NOK / 11.56;
    return EUR;
}

double NOKtoUSD(double NOK)
{
    double USD = NOK / 10.29;
    return USD;
}

double EURtoNOK(double EUR)
{
    double NOK = EUR * 11.56;
    return NOK;
}

double USDtoNOK(double USD)
{
    double NOK = USD * 10.29;
    return NOK;
}

