/*
 * Escribe un programa que muestre cómo transcurre un juego de tenis y quién lo ha ganado.
 * El programa recibirá una secuencia formada por "P1" (Player 1) o "P2" (Player 2), según quien
 * gane cada punto del juego.
 * 
 * - Las puntuaciones de un juego son "Love" (cero), 15, 30, 40, "Deuce" (empate), ventaja.
 * - Ante la secuencia [P1, P1, P2, P2, P1, P2, P1, P1], el programa mostraría lo siguiente:
 *   15 - Love
 *   30 - Love
 *   30 - 15
 *   30 - 30
 *   40 - 30
 *   Deuce
 *   Ventaja P1
 *   Ha ganado el P1
 * - Si quieres, puedes controlar errores en la entrada de datos.   
 * - Consulta las reglas del juego si tienes dudas sobre el sistema de puntos.   
 */

Console.WriteLine("Partido de Tenis, ingresa la secuencia del Set: ");
String secuencia;
secuencia = Console.ReadLine() ?? "";
Console.WriteLine("*");
Console.WriteLine("*");

void partidoTenis(string set)
{
    set = set.ToLower();
    String[] puntosSet = set.Split(',');
    String[] puntosTennis = { "love", "15", "30", "40"};
    int puntosP1 = 0;
    int puntosP2 = 0;
    Console.WriteLine("Inicio del Partido");
    for (int i = 0; i < puntosSet.Length; i++)
    {
        if (puntosSet[i].Trim() == "p1") { puntosP1++; } else { puntosP2++; }

        if(puntosP1 < 3 || puntosP2 < 3) {
            Console.WriteLine("{0} - {1}", puntosTennis[puntosP1], puntosTennis[puntosP2]);
        } 
        
        if (puntosP1 > 2 && puntosP2 > 2) {
            int dif = 0;
            dif = puntosP1 - puntosP2;
            if (dif >= 2)
            {
                Console.WriteLine("P1 ha ganado el partido");
            } else if (dif == 1)
            {
                Console.WriteLine("Ventaja p1");
            }
            else if (dif == 0)
            {
                Console.WriteLine("Deuce");
            }
            else if (dif == -1)
            {
                Console.WriteLine("Ventaja p2");
            }
            else if (dif < 0)
            {
                Console.WriteLine("P2 ha ganado el partido");
            }
        }
    }
}

partidoTenis(secuencia);
