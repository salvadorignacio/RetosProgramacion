/*
 * Dado un método que recibe una String, comprobar si todos los caracteres son únicos o no.
 *
 * isUnique("abcde") => true;
 * isUnique("abcded") => false;
 */


bool esUnico(string texto) {
    int numeroCaracteres = 128; //ASCII
    string seudoHashMap = "";
    texto = texto.ToLower();
    char[] arr = texto.ToCharArray(); // Se convierte el texto en un array
    if (texto.Length > numeroCaracteres)
    {
        return false;
    }

    for (int i = 0; i < arr.Length; i++)
    {
        if (seudoHashMap.Contains(arr[i])) // Validamos que el caracter se encuentre en el texto hashMap (inicialmente habia utilizado indexof)
        {
            return false;
        } else
        {
            seudoHashMap += arr[i];
        }
    }
    return true; 
}

// TEST

Console.WriteLine(esUnico("abcde")); // TRUE
Console.WriteLine(esUnico("abcded")); // FALSE
Console.WriteLine(esUnico("abcdefghe")); // FALSE
Console.WriteLine(esUnico("abcdefgh")); // TRUE
