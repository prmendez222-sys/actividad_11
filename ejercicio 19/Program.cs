bool EsMultiplo(int n, int m)
{
    if (n % m == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

bool multiplo = EsMultiplo(5,10);

Console.WriteLine(multiplo);