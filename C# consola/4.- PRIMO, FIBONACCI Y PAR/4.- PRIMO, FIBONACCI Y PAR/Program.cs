/*
 * Escribe un programa que, dado un número, compruebe y muestre si es primo, fibonacci y par.
 * Ejemplos:
 * - Con el número 2, nos dirá: "2 es primo, fibonacci y es par"
 * - Con el número 7, nos dirá: "7 es primo, no es fibonacci y es impar"
 */

bool esFibonacci(int numero)
{
    return (Math.Pow((5 * numero), 2) + 4) % 2 == 0;
}

bool esPrimo(int numero)
{
    if (numero > 1) 
    { 
        for (int i = 2; i < numero; i++) 
        {
            if (numero % i == 0) 
            {
                return false;
            }
                
        }

        return true;

    } else
    {
        return false;
    }
}

bool esPar(int numero)
{
    return numero % 2 == 0;
}
string evaluaNumero(int numero)
{
    string respuesta = "El numero " + numero + " ";

    if (esPrimo(numero))
    {
        respuesta += "es primo,";
    }
    else
    {
        respuesta += "no es primo,";
    }

    if (esFibonacci(numero))
    {
        respuesta += " fibonacci ";
    } else
    {
        respuesta += " no es fibonacci ";
    }

    if (esPar(numero))
    {
        respuesta += "y es par.";
    }
    else
    {
        respuesta += "y es impar.";
    }

    return respuesta;
}

Console.WriteLine("Evalua numeros: Fibonacci, primo o par");
Console.WriteLine("Ingresa número a evaluar");
String numeroIngresado;
numeroIngresado = Console.ReadLine() ?? "";


Console.WriteLine("*");
Console.WriteLine("*");

Console.WriteLine(evaluaNumero(Int32.Parse(numeroIngresado)));

