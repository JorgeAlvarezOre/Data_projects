// Proyecto Básico de C# (Adivina el Número).
// Basado en el proyecto de: Kylie Ying (@kylieyying). 

// El usuario adivina el número aleatorio generado por la computadora.
void Adivina_el_número(int x)
{
    Console.WriteLine("============================");
    Console.WriteLine("  ¡Bienvenido(a) al Juego!  ");
    Console.WriteLine("============================");
    Console.WriteLine("Tu meta es adivinar el número generado por la computadora.");

    Random rnd = new Random();
    int número_aleatorio = rnd.Next(1, x+1); // número aleatorio entre 1 y x.

    // La predicción es 0 inicialmente para que no coincida con el número aleatorio. 
    int prediccion = 0;
    
    // Continuar prediciendo el número hasta que la predicción sea correcta.
    while(prediccion != número_aleatorio)
    {
        // El usuario ingresa un número.
        Console.Write($"Adivina un número entre 1 y {x}: ");
        prediccion = Convert.ToInt32(Console.ReadLine());
        // Si el número es menor que el número aleatorio, se muestra un mensaje.
        if(prediccion < número_aleatorio)
        {
            Console.WriteLine("Intenta otra vez. Este número es muy pequeño.");
        }
        // Si el número es mayor que el número aleatorio, se
        // muestra un mensaje.
        else if(prediccion > número_aleatorio)
        {
            Console.WriteLine("Intenta otra vez. Este número es muy grande.");
        }
    }
    // El ciclo o bucle se detiene cuando el usuario adivina el número
    // correctamente y se muestra un mensaje final.
    Console.WriteLine($"¡Felicitaciones! Adivinaste el número {número_aleatorio} correctamente.");
}

Adivina_el_número(10);