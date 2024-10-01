
Random random = new Random();

decimal balance = random.Next(100,7000);

string TransaqciisArcheva;
decimal transaqciisTanxa;
string response;

do
{
    Console.WriteLine("Shemosavlis Tu Xarjis tranzaqciis chatareba gsurt? (Income/Spending)");
    TransaqciisArcheva = Console.ReadLine().ToLower();


    Console.WriteLine("Sheiyvanet sasurveli tanxa :");
    transaqciisTanxa = Convert.ToDecimal(Console.ReadLine());

    if (TransaqciisArcheva == "income")
    {
        balance += transaqciisTanxa;
    }else if (TransaqciisArcheva == "spending")
    {
        if (balance > transaqciisTanxa)
        {
            balance -= transaqciisTanxa;
        }
        else
        {
            Console.WriteLine("balansze arsebuli tanxa ar akmayofilebs motxovnas ");
        }
    }
    else
    {
        Console.WriteLine("ver moidzebna sheyvanili transaqciit tipi");
    }

    Console.WriteLine("gsurt operacis gagrdzeleba? (Yes/No)");
    response = Console.ReadLine().ToLower();
} while (response == "yes" || response == "y");

if (balance > 0)
{
    Console.WriteLine("Balansze arsebuli tanxaa:"+ balance);
}
