/*
 * Escribe un programa que reciba un texto y transforme lenguaje natural a
 * "lenguaje hacker" (conocido realmente como "leet" o "1337"). Este lenguaje
 *  se caracteriza por sustituir caracteres alfanuméricos.
 * - Utiliza esta tabla (https://www.gamehouse.com/blog/leet-speak-cheat-sheet/) 
 *   con el alfabeto y los números en "leet".
 *   (Usa la primera opción de cada transformación. Por ejemplo "4" para la "a")
 */

Console.WriteLine("Introduzca el texto a traducir a Hacker Lenguaje");
String textoIngresado;
textoIngresado = Console.ReadLine() ?? "";

string hackerLenguaje(string texto)
{
    texto = texto.ToLower();
    return texto.Replace("a", "4").Replace("b", "I3").Replace("c", "[").Replace("d", ")").Replace("e", "3")
        .Replace("f", "|=").Replace("g", "&").Replace("h", "#").Replace("i", "1").Replace("j", ",_|").Replace("k", ">|")
        .Replace("l", "1").Replace("m", "/\\/\\").Replace("n", "^/").Replace("o", "0").Replace("p", "|*").Replace("q", "(_,)")
        .Replace("r", "I2").Replace("s", "5").Replace("t", "7").Replace("u", "(_)").Replace("v", "\\/").Replace("w", "\\/\\/")
        .Replace("x", "><").Replace("y", "j").Replace("z", "2"); 
}

Console.WriteLine("The final string h: '{0}'", hackerLenguaje(textoIngresado));