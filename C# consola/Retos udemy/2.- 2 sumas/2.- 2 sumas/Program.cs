/*
 * Dado un array de números enteros y un target, retorna los índices de dos
 * números para los que la suma de ambos sea igual al target.
 *
 * Puedes asumir que hay solamente una solución.
 *
 * Ejemplo 1:
 *  Input: nums = [9,2,5,6], target = 7
 *  Output: [1,2]
 *  Explicación: nums[1] + nums[2] == 7, devolvemos [1, 2].
 *
 * Ejemplo 2:
 *  Input: nums = [9,2,5,6], target = 100
 *  Output: null
 */

using System.Linq;

int[]? dosSumas(int[] numeros, int target) //el '?' sirve para decirle al programa que el retorno puede ser null (nullable<int>)
{
    Dictionary<int, int> hashMap = new Dictionary<int, int>();
    if (numeros == null || numeros.Length <2) { return null; }

    for (int i = 0; i < numeros.Length; i++)
    {
        if (hashMap.ContainsKey(numeros[i]))
        {
            return new int[] { hashMap[numeros[i]], i };
        }
        hashMap.Add(target - numeros[i], i);

    }

    return null;
}

//TEST
int[] arrTest   = { 9, 2, 5, 6 };
int[] res       = dosSumas(arrTest, 7);

for (int i = 0;  i < res.Length; i++)
{
    Console.WriteLine(res[i]);
}
