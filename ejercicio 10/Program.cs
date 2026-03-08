void RepTexto(string texto, int veces)
{
    for(int i=0; i<veces; i++)
    {
        Console.WriteLine(texto);
        Console.WriteLine();
    }
}

RepTexto("hola", 5);