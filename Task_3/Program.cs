
//1
int i;
do
{
    Console.WriteLine("Sheiyvanet rixcvi 10-ze naklebi");
    i = Convert.ToInt32(Console.ReadLine());
    i++;
} while (i > 10);

//2
int k =0;
string response;
do
{
    Console.WriteLine("Do you want to continue?");
    response = Console.ReadLine().ToLower();
    k++;
    if (response != "yes")
    {
        break;
    }
} while (k < 3);