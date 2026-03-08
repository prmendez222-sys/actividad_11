int CuadradoNumero(int Cuad)
{
    return Cuad*Cuad;
}

Console.Write("ingrese un numero: ");
int cuadrado = CuadradoNumero(int.Parse(Console.ReadLine()));

Console.WriteLine($"el cuadrado del numero es: {cuadrado}");