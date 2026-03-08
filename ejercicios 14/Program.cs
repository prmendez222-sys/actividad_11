int Divicion(int a, int b)
{
    return a / b;
}

Console.Write("ingrese operando 1: ");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.Write("ingrese operando 1: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine();

if (num2 != 0)
{
    int res=Divicion(num1, num2);
    Console.WriteLine($"el resultado de la divicion es: {res}");
}
else
{
    Console.WriteLine("no se puede dividir en cero");
}