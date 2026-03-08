void saludar(string nombre)
{
    Console.WriteLine($"hola {nombre}");
}

Console.Write("ingrese un nombre: ");
saludar(Console.ReadLine());