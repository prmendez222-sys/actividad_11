int Menor(int a, int b, int c)
{
    int elMenor = a;

    if(elMenor > b)
    {
        elMenor = b; 
    }

    if(elMenor > c)
    {
        elMenor = c;
    }

    return elMenor;
}

Console.Write("ingrese el primer numero: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("ingrese el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("ingrese el segundo numero: ");
int num3 = int.Parse(Console.ReadLine());
Console.WriteLine();

int menor = Menor(num1, num2, num3);

Console.WriteLine($"el numero menor es: {menor}");
