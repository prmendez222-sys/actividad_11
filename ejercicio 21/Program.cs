int contVocales(string texto)
{
    texto = texto.ToLower();
    int cont = 0;

    foreach (char c in texto)
    {
        if (c == 'a' || c =='e' ||  c =='i' ||  c =='o' || c =='u') 
            cont++;
    }

    return cont;
}

int contV = contVocales("hola");

Console.WriteLine($"el texto tiene {contV} vocales");