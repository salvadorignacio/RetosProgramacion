/*
 * Escribe un programa que sea capaz de generar contraseñas de forma aleatoria.
 * Podrás configurar generar contraseñas con los siguientes parámetros:
 * - Longitud: Entre 8 y 16.
 * - Con o sin letras mayúsculas.
 * - Con o sin números.
 * - Con o sin símbolos.
 * (Pudiendo combinar todos estos parámetros entre ellos)
 */


using System.Linq;

string generaPassword(int longitud, bool mayuscula, bool numeros, bool simbolos)
{
    string password = "";
    Random random = new Random();
    char[] listaNumeros = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    char[] abecedario = Enumerable.Range('a', 26).Select(x => (char)x).ToArray();
    char[] abecedarioMayus = Enumerable.Range('A', 26).Select(x => (char)x).ToArray();
    char[] listaSimbolos = { '@', '#', '$', '%', '&', '*', '+' };
    char[] lista = abecedario;
    if(mayuscula)
    {
        lista = lista.Concat(abecedarioMayus).ToArray();
    }

    if (numeros)
    {
        lista = lista.Concat(listaNumeros).ToArray();
    }

    if (simbolos)
    {
        lista = lista.Concat(listaSimbolos).ToArray();
    }

    for (int i = 0; i < longitud; i++)
    {
        int j = random.Next(0, lista.Length);
        password = lista[j] + password;
    }
    
    return password;
}

Console.WriteLine("Generador de contraseña");
Console.WriteLine("Ingresa longitud entre 8 y 16.");
String longitud;
longitud = Console.ReadLine() ?? "";
Console.WriteLine("Desea que contenga mayúsculas (S/N)");
String mayuscula;
mayuscula = Console.ReadLine() ?? "";
Console.WriteLine("Desea que contenga números (S/N)");
String numeros;
numeros = Console.ReadLine() ?? "";
Console.WriteLine("Desea que contenga símbolos (S/N)");
String simbolos;
simbolos = Console.ReadLine() ?? "";

Console.WriteLine("*");
Console.WriteLine("*");

Console.WriteLine("Tu contraseña es: {0}", generaPassword(Int16.Parse(longitud), mayuscula.ToUpper() == "S", numeros.ToUpper() == "S", simbolos.ToUpper() == "S"));
