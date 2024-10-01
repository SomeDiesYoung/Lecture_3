
double sum = 0;
string response;
int count = 0;
do
{
    Console.WriteLine("Sheiyvane Saganshi migebuli qula :");
    double Qula = Convert.ToDouble(Console.ReadLine());
    if (Qula < 0)
    {
        Console.WriteLine("Qula unda iyos dadebiti ricxvi");
        break;
    }
    Console.WriteLine("Gsurs gagrdzeleba ? (Yes/No)");
    response = Console.ReadLine().ToLower();
    sum += Qula;
    count++;

} while (response == "yes" || response =="Y");
if (count > 0)
{
    Console.WriteLine($"Sashualo qulaa {sum / count}");
}
else
{
    Console.WriteLine("Ver gaangarisot sashualo qula, ar sheiyvanet qulebi.");
}