// See https://aka.ms/new-console-template for more information

NOKtoEUR(12);
NOKtoUSD(19);

void NOKtoEUR(double NOK)
{
    double EUR = NOK / 11.56;
    Console.WriteLine(EUR);
}

void NOKtoUSD(double NOK)
{
    double USD = NOK / 10.29;
    Console.WriteLine(USD);
}

void EURtoNOK(double EUR)
{
    double NOK = EUR * 11.56;
    Console.WriteLine(NOK);
}

void USDtoNOK(double USD)
{
    double NOK = USD * 10.29;
    Console.WriteLine(NOK);
}