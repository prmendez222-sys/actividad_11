bool EsPar(int n)
{
    if (n % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool par = EsPar(10);

if (par == true)
{
    Console.WriteLine("el numero es Par");
}
else
{
    Console.WriteLine("el numero es impar");
}