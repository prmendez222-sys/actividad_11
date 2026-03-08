int MostrarDoble(int n)
{
    return n * 2;
}

Console.Write("ingrese un numero entero: ");

int doble=MostrarDoble(int.Parse(Console.ReadLine()));

Console.WriteLine();
Console.WriteLine($"el doble del numero ingresado es: {doble}");