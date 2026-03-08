bool EsPositivo(int n)
{
    if (n >0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool par = EsPositivo(-10);

if (par == true)
{
    Console.WriteLine("el numero es positivo");
}
else
{
    Console.WriteLine("el numero es negativo");
}