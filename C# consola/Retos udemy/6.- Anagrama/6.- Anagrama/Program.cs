/*
 * Un anagrama es una palabra creada a partir de la reordenación de las letras de otra palabra. Ej: saco - caso
 * Dado un array de strings, devuelve los anagramas agrupados. Cualquier orden es válido.
 *
 * Ejemplo:
 *  Input: words = ["saco", "arresto", "programa", "rastreo", "caso"].
 *  Output: [["saco", "caso"], ["arresto", "rastreo"], ["programa"]].
 */


string buildAnagramaMap(string[] grupoAnagramas) {
    string result = "";
    Dictionary<string, List<string>> anagramaMap = new Dictionary< string, List< string >> ();

    foreach (var s in grupoAnagramas)
    {
        string hash = getHashAnagrama(s);
        if (!anagramaMap.ContainsKey(hash)) // evalua si existe el hash dentro del map
        {
            anagramaMap.Add(hash, new List<string>()); //agrega el nuevo hash
        }

        anagramaMap[hash].Add(s); //agrega el elemento al hash
    }

    result = string.Join(",", anagramaMap.Select(kvp => string.Join(":", kvp.Value)));
    return result;

}
string getHashAnagrama(string palabra)
{
    string result = "";
    int[] contadorLetras = new int[26]; //Cantidad de letras sin contar la ñ
    char[] palabrasArray = palabra.ToCharArray();

    foreach (char c in palabrasArray)
    {
        contadorLetras[c - 'a']++; 
    }

    result = string.Join(",", contadorLetras);

    return result;
}

//TEST

string[] words = { "saco", "arresto", "programa", "rastreo", "caso" };

Console.WriteLine(buildAnagramaMap(words));