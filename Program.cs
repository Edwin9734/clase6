//metodo                                     //metodo factura
static void factura()
{
    string producto;
    int cantidad = 0;
    int FI = 0;
    double precio = 0;
    double total = 0;
    double paga = 0;
    char OP;
    string linea;
    FI = 6;
    paga = 0;


    Console.SetCursorPosition(5, 4);// posision del cursor
    Console.Write("PRODUCTO CANTIDAD PRECIO TOTAL");
    do
    {
        Console.SetCursorPosition(5, FI);
        producto = Console.ReadLine();
        Console.SetCursorPosition(17, FI);
        linea = Console.ReadLine();
        cantidad = int.Parse(linea);
        Console.SetCursorPosition(27, FI);
        linea = Console.ReadLine();
        precio = int.Parse(linea);
        total = cantidad * precio;
        Console.SetCursorPosition(33, FI);
        Console.Write(total);
        paga = paga + total;
        //FI++;
        FI = FI + 1;
        Console.SetCursorPosition(30, 23);
        Console.Write("Otro producto?  S/N");
        linea = Console.ReadLine();
        OP = char.Parse(linea.ToUpper());


    } while (OP.ToString().Contains("S"));


    Console.WriteLine($"Total a pagar:{paga}");
    Console.WriteLine("Fin");

    Console.WriteLine("Presione cualquier letra par continuar");
    Console.ReadKey();// presiona una tecla para continuar
    //Contains  Equals  ==
}// fin del bloque

 
static String pruebaCase(int numero) 
{
    string letra;
    switch (numero)
    {
        case 1:
            letra = "uno";
            break;
        case 2:
            letra = "dos";
            break;
        case 3:
            letra = "tres";
            break;
        case 4:
            letra = "cuatro";
            break;
        case 5:
            letra = "cinco";
            break;
        case 6:
            letra = "seis";
            break;
        case 7:
            letra = "siete";
            break;
        case 8:
            letra = "ocho";
            break;
        case 9:
            letra = "nueve";
            break;
        case 10:
            letra = "diez";
            break;
        default:
            letra = "Rango invalido";
            break;
    
    }
    return letra;//devuelve el resultado

}       //convierte letras a numeros
//int n = 99;
//String resultado = pruebaCase(n);
//Console.WriteLine($"numero {n} es { resultado}");


static int FnConvertirNunero(string numero)
{
    int resultado;
    switch (numero.ToLower())
    {
        case "uno:":
            resultado = 1;
            break;
        case "dos":
            resultado = 2;
            break;
        case "tres":
            resultado = 3;
            break;
        case "cinco":
            resultado = 5;
            break;
        case "seis":
            resultado = 6;
            break;
        case "7":
            resultado = 7;
            break;
        case "ocho":
            resultado = 8;
            break;
        case "nueve":
            resultado = 9;
            break;
        case "diez":
            resultado = 10;
            break;
        default:
            resultado = 0;
            break;



    }
    return resultado;
}      //convierte numeros a letras
//int n = 10;
//string resultado = pruebaCase(n);
//Console.WriteLine($"Numero {n} es  {resultado}");
//Console.WriteLine($"impli {n} es {pruebaCase(n)}");

static string SwitchExpresion(int numero)
{
    string letra;
    letra = (numero) switch
    {
        1 => "uno",
        2 => "dos",
        3 => "tres",
        4 => "cuatro",
        5 => "cinco",
        6 => "seis",
        7 => "siete",
        8 => "ocho",
        9 => "nueve",
        10 => "diez",
        _ => "Numero Invalido",
    };
    return letra;
}     //swtch con expresion antigua

try
{


    static int FnSuma(int num1, int num2)
    {
        int respuesta = num1 / num2;
        return respuesta;
    }           //suma de dos numeros
    Console.WriteLine($"La suma de los numeros es{ FnSuma(3, 0)}");      // activar la suma
}
catch (Exception ex)
{
    Console.WriteLine("Ha habido un error");

}  //esepcion de la funcion suma

static void puebafor()
{
    for(int i=0; i<10;i++)
    {
        Console.WriteLine($"Contador{i}");
    }
}
//puebafor();


//for(int i =1; i<9;i++)
//{
//    Console.WriteLine($"numero = {i} junto a los {FnSuma(i,i+1)}  y tambien los {pruebaCase(i+2)}");
//}

static void numeroMayorMenor()
{
    int mayor = int.MinValue;
    int menor = int.MaxValue;



    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Ingrese tanda {i +1}");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero > mayor)
        {
            mayor = numero;
        }
        if (numero < menor)
        {
            menor = numero;
        }

    }

    Console.WriteLine($"El mayor es {mayor}");
    Console.WriteLine($"El menor es {menor}");
}
//numeroMayorMenor();

static void reloj()
{
    Console.WriteLine("El reloj");
    for (int h = 0; h < 24; h++)
    {
        for (int m = 0; m < 60; m++)
        {
            for (int s = 0; s < 60; s++)
            {
                Console.SetCursorPosition(10, 10);
                Console.WriteLine($"{h}:{m}:{s}");
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
//reloj();

static void excepciones()
{
    int cantidad = 0;

    try
    {
        Console.WriteLine("Ingrese cantidad:");
        cantidad = Convert.ToInt32(Console.ReadLine());
        cantidad = cantidad / 0;
    }
    catch (FormatException error)
    {
        Console.WriteLine($"No ingresaste un numero {error.Message}");
    }
    catch (DivideByZeroException error)
    {
        Console.WriteLine($"No ingresaste un 0 {error.Message}");
    }
    catch (Exception error)
    {
        Console.WriteLine($"es otro error {error.Message}");
    }


    Console.WriteLine($"la cantidad ingresada es {cantidad}");
}


//excepciones();