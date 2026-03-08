int Suma(int a, int b)
{
    return a + b;
}

Console.Write("ingrese operando 1: ");
int num1=int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("ingrese operando 1: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();

int res = suma(num1, num2);

Console.WriteLine($"el resultado de la suma es: {res}");