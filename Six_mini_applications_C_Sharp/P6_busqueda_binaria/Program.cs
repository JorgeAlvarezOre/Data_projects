// Proyecto Básico de C# (Búsqueda Binaria).
// Basado en el proyecto de: Kylie Ying (@kylieyying). 

int búsqueda_ingenua(List<int> lista, int objetivo)
{
    // for i in range(len(lista)):
    //     if lista[i] == objetivo:
    //         return i
    
    for (int i = 0; i < lista.Count; i++)
    {
        if(lista[i] == objetivo)
            return i;
    }
    return -1;
}

int búsqueda_binaria(List<int> lista, int objetivo, int límite_inferior = -2, int límite_superior = -2)
{
    if(límite_inferior is -2)
        límite_inferior = 0; // Inicio de la lista
    if(límite_superior is -2)
        límite_superior = lista.Count - 1; // Final de la lista

    if(límite_superior < límite_inferior)
        return -1;

    int punto_medio = (límite_inferior + límite_superior)/2;

    if(lista[punto_medio] == objetivo)
        return punto_medio;
    else if(objetivo < lista[punto_medio])
        return búsqueda_binaria(lista, objetivo, límite_inferior, punto_medio-1);
    else
        return búsqueda_binaria(lista, objetivo, punto_medio+1, límite_superior);
}

int tamaño = 100000;
HashSet<int> conjunto_inicial = new HashSet<int>();
Random rnd = new Random();

while(conjunto_inicial.Count < tamaño)
    conjunto_inicial.Add(rnd.Next(-3*tamaño, 3*tamaño+1));

SortedList<int,int> lista_ordenada = new SortedList<int,int>();
foreach(int elemento in conjunto_inicial)
{
    lista_ordenada.Add(elemento,elemento);
}
List<int> lista_ordenada_list = lista_ordenada.Values.ToList();

// Medir el tiempo de búsqueda ingenua.
var inicio = DateTime.Now;
foreach(int objetivo in lista_ordenada_list)
    búsqueda_ingenua(lista_ordenada_list, objetivo);
var fin = DateTime.Now;
Console.WriteLine($"Tiempo de búsqueda ingenua: {fin - inicio} segundos.");

// Medir el tiempo de búsqueda binaria.
inicio = DateTime.Now;
foreach(int objetivo in lista_ordenada_list)
    búsqueda_binaria(lista_ordenada_list, objetivo);
fin = DateTime.Now;
Console.WriteLine($"Tiempo de búsqueda binaria: {fin - inicio} segundos.");