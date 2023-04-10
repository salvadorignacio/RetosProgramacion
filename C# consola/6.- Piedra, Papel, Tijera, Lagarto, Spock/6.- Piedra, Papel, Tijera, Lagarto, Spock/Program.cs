/*
 * Crea un programa que calcule quien gana más partidas al piedra,
 * papel, tijera, lagarto, spock.
 * - El resultado puede ser: "Player 1", "Player 2", "Tie" (empate)
 * - La función recibe un listado que contiene pares, representando cada jugada.
 * - El par puede contener combinaciones de "🗿" (piedra), "📄" (papel),
 *   "✂️" (tijera), "🦎" (lagarto) o "🖖" (spock).
 * - Ejemplo. Entrada: [("🗿","✂️"), ("✂️","🗿"), ("📄","✂️")]. Resultado: "Player 2".
 * - Debes buscar información sobre cómo se juega con estas 5 posibilidades.
 */


string cachipunSpock(string lista) {
    string resultado = "";
    String[] partidas = lista.Split(',');
    String[] piedraGana  = { "tijeras", "lagarto"};
    String[] tijerasGana = { "papel", "lagarto" };
    String[] papelGana   = { "piedra", "spock" };
    String[] spockGana   = { "piedra", "tijeras" };
    String[] lagartoGana = { "spock", "papel" };
    int puntosP1 = 0;
    int puntosP2 = 0;
    string temp = "";


    foreach (String partida in partidas)
    {
        if (temp == "") {
            temp = partida;
        } else
        {
            if (temp == partida)
            {
                temp = "";
                break;
            }
            if (temp == "piedra") { 
                if (Array.IndexOf(piedraGana,partida) != -1)
                {
                    puntosP1++;
                } else
                {
                    puntosP2++;
                }
            }
            else if (temp == "tijeras")
            {
                if (Array.IndexOf(tijerasGana, partida) != -1)
                {
                    puntosP1++;
                }
                else
                {
                    puntosP2++;
                }
            }
            else if (temp == "papel")
            {
                if (Array.IndexOf(papelGana, partida) != -1)
                {
                    puntosP1++;
                }
                else
                {
                    puntosP2++;
                }
            }
            else if (temp == "spock")
            {
                if (Array.IndexOf(spockGana, partida) != -1)
                {
                    puntosP1++;
                }
                else
                {
                    puntosP2++;
                }
            }
            else if (temp == "lagarto")
            {
                if (Array.IndexOf(lagartoGana, partida) != -1)
                {
                    puntosP1++;
                }
                else
                {
                    puntosP2++;
                }
            }
            temp = "";
        }
    }
    Console.WriteLine(puntosP1);
    if (puntosP1 > puntosP2)
    {
        resultado = "Gana el jugador 1";
    } else if(puntosP1 < puntosP2)
    {
        resultado = "Gana el jugador 2";
    } else
    {
        resultado = "Ha sido un empate";
    }

    return resultado;
}

Console.WriteLine("Partido de Cachipun, ingresa la secuencia del cachipun (piedra,papel,tijeras,spock,lagarto): ");
String secuencia;
secuencia = Console.ReadLine() ?? "";
Console.WriteLine("*");
Console.WriteLine("*");

Console.WriteLine(cachipunSpock(secuencia));
