
double sum=0;
string response;
do
{
    Console.WriteLine("Sheiyvanet Productis Fasi :");
    double fasi = Convert.ToDouble(Console.ReadLine());
    sum += fasi;
    Console.WriteLine("Shualeduri fasi archeuli productebis :" + sum);
    Console.WriteLine("gsurt gagrdzeleba? (Yes/No)");
    response = Console.ReadLine().ToLower();
}
while (response == "yes" || response == "y");

Console.WriteLine("Jamuri fasi yvela productisaa:"+sum);

Console.WriteLine("good Shoping");
