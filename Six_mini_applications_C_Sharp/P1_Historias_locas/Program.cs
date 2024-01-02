// Proyecto Básico de Python (Mad Libs / Historias Locas).
// Basado en el proyecto de: Kylie Ying (@kylieyying). 
 
// Concatenar cadenas de caracteres.
// Supongamos que queremos crear una cadena que diga:
// "Aprende a programar con ________."

// The system will ask for some words and then will concatenate in a funny sentences

string organización = "freeCodeCamp"; // Cadena de caracteres asignada a una variable string

Console.WriteLine("Aprende a programar con " + organización); // Concatenar
Console.WriteLine($"Aprende a programar con {organización}");

// Mad Libs (Historias Locas)

Console.Write("Adjetivo: ");
string adj = Console.ReadLine(); // asombroso
Console.Write("Verbo 1: ");
string verbo1 = Console.ReadLine(); // resolver
Console.Write("Verbo 2: ");
string verbo2 = Console.ReadLine(); // programar
Console.Write("Sustantivo (plural): ");
string sustantivo_plural = Console.ReadLine(); // metas, objetivos

string madlib = $"¡Programar es {adj}! Siempre me emociona porque me encanta {verbo1} problemas. ¡Aprende a {verbo2} con freeCodeCamp y alcanza tus {sustantivo_plural}!";

Console.WriteLine(madlib);
Console.ReadLine();