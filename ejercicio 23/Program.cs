int SumaN(int n)
{
    int suma=0;

    for(int i = 1; i <= n; i++)
    {
        suma += i;
    }

    return suma;
}
int suma = SumaN(5);

Console.WriteLine($"la suma de los numeros: {suma} ");