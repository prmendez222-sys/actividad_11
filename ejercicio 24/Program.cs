int Factorial(int n)
{
    int factorial=1;
    for(int i = 1; i <= n; i++)
    {
        factorial *= i;
    }

    return factorial;
}

int factrial=Factorial(5);

Console.WriteLine("el factorial del numero es: " + factrial);