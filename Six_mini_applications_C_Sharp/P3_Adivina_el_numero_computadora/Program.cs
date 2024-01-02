// Proyecto Básico de C# (Adivina el Número (Computadora)).
// Basado en el proyecto de: Kylie Ying (@kylieyying). 

// La computadora debe adivinar el número seleccionado por el jugador.
void adivina_el_numero_computadora(int x)
{
    Console.WriteLine("============================");
    Console.WriteLine("  ¡Bienvenido(a) al Juego!  ");
    Console.WriteLine("============================");
    Console.WriteLine($"Selecciona un número entre 1 y {x} para que la computadora intente adivinarlo.");

    // Intervalo de valores válidos
    int límite_inferior = 1;
    int límite_superior = x;
    string respuesta = "";
    int prediccion = 0;

    // Miestras el usuario no indique que la respuesta es correcta, continuar el proceso.
    while(respuesta != "c")
    {
        // Generar predicción
        if(límite_inferior != límite_superior)
        {
            Random rnd = new Random();
            prediccion = rnd.Next(límite_inferior, límite_superior+1);
        }
        else
        {
            prediccion = límite_inferior;  // también podría ser límite_superior porque los límites son iguales.
        }
        // Obtener respuesta del usuario
        Console.Write($"Mi predicción es {prediccion}. Si es muy alta, ingresa (A). Si es muy baja, ingresa (B). Si es correcta ingresa (C) ");
        respuesta = Console.ReadLine().ToLower();
        
        if(respuesta == "a")
        {
            límite_superior = prediccion - 1;
        }
        else if(respuesta == "b")
        {
            límite_inferior = prediccion + 1;
        }
    }
    Console.WriteLine($"¡Siii! La computadora adivinó tu número correctamente: {prediccion}");
}

adivina_el_numero_computadora(10);