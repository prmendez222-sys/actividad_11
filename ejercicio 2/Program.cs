void MostrarNombre(string nombre)
{
    Console.WriteLine($"hola {nombre}");
}

Console.Write("ingrese su nombre: ");
MostrarNombre(Console.ReadLine());