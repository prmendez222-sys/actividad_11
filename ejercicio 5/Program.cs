void Presionar()
{
    Console.WriteLine();
    Console.WriteLine("Presione Enter para finalizar");
    Console.ReadLine();
}
void MostrarMenu()
{
    string opcion;

    do
    {
        Console.WriteLine("1. opcion a");
        Console.WriteLine("2. opcion b");
        Console.WriteLine("3. salir");
        Console.WriteLine();
        Console.Write("ingrese una opcion: ");
        opcion= Console.ReadLine();
        Console.Clear();

        switch (opcion)
        {
            case "a":
                Console.WriteLine("hola");
                Presionar();
                break;
            case "b":
                Console.WriteLine("adios");
                Presionar();
                break;
            case "3":
                Console.WriteLine("saliendo...");
                Thread.Sleep(1000);
                break;
            default:
                Console.WriteLine("opcion no valida");
                Presionar();
                break;
        }
        Console.Clear();
    } while(opcion!="3");
}

MostrarMenu();