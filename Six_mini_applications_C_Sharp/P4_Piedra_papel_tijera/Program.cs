// Proyecto Básico de C# (Piedra, Papel o Tijera).
// Basado en el proyecto de: Kylie Ying (@kylieyying).

string jugar()
{
    Console.WriteLine("Escoge una opción: 'pi' para piedra, 'pa' para papel, 'ti' para tijera.");
    string usuario = Console.ReadLine().ToLower();

    Random rnd = new Random();
    var list = new List<string> {"pi", "pa", "ti"};
    int index = rnd.Next(list.Count);
    string computadora = list[index];

    if(usuario == computadora)
        return "¡Empate!";

    if(ganó_el_jugador(usuario, computadora))
        return "¡Ganaste!";
    
    return "¡Perdiste!";
}


bool ganó_el_jugador(string jugador, string oponente)
{
    // Retornar true (verdadero) si gana el jugador.
    // Piedra gana a Tijera (pi > ti).
    // Tijera gana a Papel (ti > pa).
    // Papel gana a Piedra (pa > pi).
    if((jugador == "pi" && oponente == "ti") || (jugador == "ti" && oponente == "pa") || (jugador == "pa" && oponente == "pi"))
        return true;
    else
        return false;
}

Console.WriteLine(jugar());