void arreglos ()
{
    String[] nombre = new String[]
    {
        "Fernanda","Melvin","Luis","Brandon","Yamileth"
    };

    foreach(String nom in nombre)
    {
        Console.WriteLine(nom);
    }

    int[] notas = new int[]
    {
        70,90,43,85,30
    };

    int promedio=0;

    foreach(int i in notas) 
    {
        promedio = promedio + i;
    }


    int maximo = notas[0];
    int maxi = 0;

    for(int i= 1; i<notas.Length; i++) 
    {
        if (notas[i]> maximo)
        {
            maximo= notas[i];
            maxi = i;
        }
    }

    String nombrem = nombre[maxi];

    Console.WriteLine($"La nota mas alta es: {maximo} de la persona {nombrem}");
}

arreglos();