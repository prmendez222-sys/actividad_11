bool Primo(int n)
{
    bool esPrimo = true;

    if (n == 2)
    {
        esPrimo = true; 
    }

    if(n==1)
        esPrimo= false;

    for(int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            esPrimo = false;
            break;
        }
    }

    return esPrimo;
}

bool primo = Primo(4);

if (primo == true)
{
    Console.WriteLine("el numero es primo");
}
else
{
    Console.WriteLine("el numero no es primo");
}

