

for (int i = 3; i <= 100; i++)
{
    Console.WriteLine(i);
    if (i % 3 == 0 && i % 5 == 0) {  Console.WriteLine("FizzBizz"); }
    else if (i % 3 == 0)
    {
        Console.WriteLine("Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Bizz");
    }

}