int MayorMenor(int a, int b)
{
    if (a>b) 
    {
        return a;
    }
    else
    {
        return b;
    }
}

Console.Write("ingrese el primer numero: ");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine();
Console.Write("ingrese el segundo numero: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();

int mayor = MayorMenor(num1,num2);

Console.WriteLine($"el numero mayor es: {mayor}");
