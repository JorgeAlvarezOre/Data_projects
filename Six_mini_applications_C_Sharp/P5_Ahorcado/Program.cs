// Proyecto Básico de C# (El Ahorcado).
// Basado en el proyecto de: Kylie Ying (@kylieyying). 

using P5_Ahorcado.Palabras;
using P5_Ahorcado.Ahorcado_diagramas;

Dictionary<int,string> vidas_diccionario_visual = Ahorcado_diagramas.vidas_diccionario_visual;
// Console.WriteLine(vidas_diccionario_visual[0]);

string obtener_palabra_válida(List<string> palabras)
{
    Random rnd = new Random();
    int index = rnd.Next(palabras.Count);
    string palabra = palabras[index];  // seleccionar una palabra al azar de la lista

    // Si la palabra contiene un guión o un espacio,
    // seguir seleccionando una palabra al azar.
    while(palabra.Contains("-") || palabra.Contains(" "))
    {
        index = rnd.Next(palabras.Count);
        palabra = palabras[index];
    }
    return palabra.ToUpper();
}

void ahorcado()
{
    Console.WriteLine("=======================================");
    Console.WriteLine(" ¡Bienvenido(a) al juego del Ahorcado! ");
    Console.WriteLine("=======================================");

    List<string> palabras = Palabras.palabras;
    string palabra = obtener_palabra_válida(palabras);
    HashSet<char> letras_por_adivinar = new HashSet<char>(palabra); // conjunto de letras de la palabra que deben ser adivinadas.
    HashSet<char> abecedario = new HashSet<char>("ABCDEFGHIJKLMNOPQRSTUVWXYZ"); // conjunto de letras en el abecedario.
    HashSet<char> letras_adivinadas = new HashSet<char>();  // letras que el usuario ha advinado durante el juego.

    int vidas = 7;

    // Obtener respuesta del usuario mientras existan 
    // letras pendientes y al jugador le queden vidas.
    while(letras_por_adivinar.Count > 0 && vidas > 0)
    {
        // Letras adivinadas:
        // String.Join(" ", letras_adivinadas) ['a', 'b', 'c'] --> 'a b c'
        string letras_adivinadas_temp = String.Join(" ", letras_adivinadas);
        Console.WriteLine($"Te quedan {vidas} vidas y has usado estas letras: {letras_adivinadas_temp}");

        // Estado actual de la palabra que el jugador debe adivinar (por ejemplo:  H - L A)
        List<char> palabra_lista = new List<char>();
        foreach (char letra in palabra) // Recorrer cada letra de la palabra
        {
            if (letras_adivinadas.Contains(letra)) // Si la letra está en el conjunto de letras adivinadas
                palabra_lista.Add(letra); // Agregar la letra a la lista
            else // Si la letra no está en el conjunto
                palabra_lista.Add('-'); // Agregar un guión a la lista
        }

        Console.WriteLine(vidas_diccionario_visual[vidas]); // mostrar estado del ahorcado.
        string palabra_lista_temp = String.Join(" ", palabra_lista);
        Console.WriteLine($"Palabra: {palabra_lista_temp}"); // mostrar las letras separadas por un espacio.

        // El usuario escoge una letra nueva
        Console.Write("Escoge una letra: ");
        String letra_usuario = Console.ReadLine().ToUpper();

        // Si la letra escogida por el usuario está en el abecedario
        // y no está en el conjunto de letras que ya se han ingresado,
        // se añade la letra al conjunto de letras ingresadas.
        if(abecedario.Contains(letra_usuario[0]) && !letras_adivinadas.Contains(letra_usuario[0]))
        {
            letras_adivinadas.Add(letra_usuario[0]);
            // Si la letra está en la palabra, quitar la letra 
            // del conjunto de letras pendientes por adivinar. 
            if(letras_por_adivinar.Contains(letra_usuario[0]))
            {
                letras_por_adivinar.Remove(letra_usuario[0]);
                Console.WriteLine("");
            }
            // Si la letra no está en la palabra, quitar una vida.
            else
            {
                vidas = vidas - 1;
                Console.WriteLine($"\nTu letra, {letra_usuario} no está en la palabra.");
            }
        }
        // Si la letra escogida por el usuario ya fue ingresada.
        else if(letras_adivinadas.Contains(letra_usuario[0]))
            Console.WriteLine("\nYa escogiste esa letra. Por favor escoge una letra nueva.");
        else
            Console.WriteLine("\nEsta letra no es válida.");
    }

    // El juego llega a esta línea cuando se agotan las vidas del jugador 
    // o cuando se adivinan todas las letras de la palabra.
    if(vidas == 0)
    {
        Console.WriteLine(vidas_diccionario_visual[vidas]);
        Console.WriteLine($"¡Ahorcado! Perdiste. Lo lamento mucho. La palabra era: {palabra}");
    }
    else
        Console.WriteLine($"¡Excelente! ¡Adivinaste la palabra {palabra}!");
}

ahorcado();