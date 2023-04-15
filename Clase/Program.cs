using static System.Runtime.InteropServices.JavaScript.JSType;

void arreglos ()
{
    Console.WriteLine("Ingrese la cantidad de notas a ingresar: ");
    int cant = int.Parse(Console.ReadLine());

    int[] notas1 = new int[cant];

    Console.WriteLine("Ingrese los numeros");

    for (int i = 0; i < cant; i++)
    {
        Console.WriteLine($"Ingrese el valor {i} ");
        notas1[i] = int.Parse(Console.ReadLine());
    }



    string[] nombre = new string[cant];

    Console.WriteLine("Ingrese los nombres");

    for (int i = 0; i < cant; i++)
    {
        Console.WriteLine($"Ingrese el valor {i} ");
        nombre[i] = Console.ReadLine();
    }
    //{
    //    "Fernanda","Melvin","Luis","Brandon","Yamileth"
    //};

    //foreach (String nom in nombre)
    //{
    //    Console.WriteLine(nom);
    //}

    //int[] notas = new int[]
    //{
    //    70,90,43,85,30
    //};

    //int promedio=0;

    //foreach(int i in notas) 
    //{
    //    promedio = promedio + i;
    //}


    int maximo = notas1[0];
    int maxi = 0;

    for(int i= 1; i<notas1.Length; i++) 
    {
        if (notas1[i]> maximo)
        {
            maximo= notas1[i];
            maxi = i;
        }
    }

    int minimo = notas1[0];
    int min = 4;

    for (int i = 1; i < notas1.Length; i++)
    {
        if (notas1[i] > min)
        {
            minimo = notas1[i];
            min = i;
        }
    }

    string nombrem = nombre[maxi];
    string nombremi = nombre[min];

    Console.WriteLine($"La nota mas alta es: {maximo} de la persona {nombrem}");
    Console.WriteLine($"La nota mas baja es: {minimo} de la persona {nombremi}");
}

arreglos();