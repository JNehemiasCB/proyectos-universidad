using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // =======================================================
        // 🔢 ARRAYS
        // Son colecciones de elementos del mismo tipo con tamaño fijo.
        // Se usan cuando sabemos cuántos elementos habrá.
        // =======================================================
        Console.WriteLine("=== Arrays ===");
        int[] numerosArr = { 10, 20, 30, 40 };

        Console.WriteLine($"Primer número: {numerosArr[0]}");

        foreach (int n in numerosArr)
            Console.WriteLine(n);

        // -------------------------------------------------------

        // =======================================================
        // 📋 LISTAS (List<T>)
        // Estructura dinámica que permite agregar o quitar elementos.
        // Ideal cuando no sabemos el tamaño exacto de la colección.
        // =======================================================
        Console.WriteLine("\n=== Listas ===");
        List<string> nombres = new List<string> { "Ana", "Luis", "Carlos" };
        nombres.Add("María");
        nombres.Remove("Luis");

        foreach (var nombre in nombres)
            Console.WriteLine(nombre);

        // -------------------------------------------------------

        // =======================================================
        // 🧱 PILAS (Stack)
        // Siguen el principio LIFO (Last In, First Out).
        // El último en entrar es el primero en salir.
        // =======================================================
        Console.WriteLine("\n=== Pilas (Stack) ===");
        Stack<string> pila = new Stack<string>();
        pila.Push("A");
        pila.Push("B");
        pila.Push("C");

        Console.WriteLine($"Elemento quitado de la pila: {pila.Pop()}");

        Console.WriteLine("Elementos restantes en la pila:");
        foreach (var item in pila)
            Console.WriteLine(item);

        // -------------------------------------------------------

        // =======================================================
        // 🚶‍♂️ COLAS (Queue)
        // Siguen el principio FIFO (First In, First Out).
        // El primero en entrar es el primero en salir.
        // =======================================================
        Console.WriteLine("\n=== Colas (Queue) ===");
        Queue<string> cola = new Queue<string>();
        cola.Enqueue("Cliente 1");
        cola.Enqueue("Cliente 2");
        cola.Enqueue("Cliente 3");

        Console.WriteLine($"Atendiendo: {cola.Dequeue()}");

        Console.WriteLine("Clientes restantes en la cola:");
        foreach (var cliente in cola)
            Console.WriteLine(cliente);

        // -------------------------------------------------------

        // =======================================================
        // 🧮 TABLAS HASH (Dictionary)
        // Guardan pares clave-valor. Permiten acceder rápido a un valor
        // usando su clave, como si fuera una "etiqueta".
        // =======================================================
        Console.WriteLine("\n=== Tablas Hash (Dictionary) ===");
        Dictionary<string, int> inventario = new Dictionary<string, int>
        {
            {"Cerveza", 20},
            {"Refresco", 15},
            {"Agua", 10}
        };

        Console.WriteLine($"Cerveza: {inventario["Cerveza"]} unidades");

        inventario["Refresco"] += 5; // Aumentamos stock
        Console.WriteLine($"Refresco actualizado: {inventario["Refresco"]}");

        // -------------------------------------------------------

        // =======================================================
        // 🔢 CONJUNTOS (HashSet)
        // Almacenan valores únicos sin permitir duplicados.
        // Son útiles para eliminar repeticiones rápidamente.
        // =======================================================
        Console.WriteLine("\n=== Conjuntos (HashSet) ===");
        HashSet<int> numeros = new HashSet<int> { 1, 2, 3, 3, 2 };
        Console.WriteLine("Elementos únicos:");
        Console.WriteLine(string.Join(", ", numeros));

        // -------------------------------------------------------

        // =======================================================
        // 🔗 LISTAS ENLAZADAS (LinkedList)
        // Cada elemento apunta al siguiente. Son útiles para insertar
        // o eliminar nodos sin mover todos los elementos.
        // =======================================================
        Console.WriteLine("\n=== Listas enlazadas (LinkedList) ===");
        LinkedList<string> lista = new LinkedList<string>();
        lista.AddLast("Inicio");
        lista.AddLast("Medio");
        lista.AddLast("Fin");

        lista.AddAfter(lista.First, "Nuevo"); // Agrega después del primero

        foreach (var item in lista)
            Console.WriteLine(item);

        // -------------------------------------------------------

        // =======================================================
        // 🌳 ÁRBOLES BINARIOS
        // Estructura jerárquica donde cada nodo tiene hijos izquierdo y derecho.
        // Se usan para búsquedas y jerarquías de datos.
        // =======================================================
        Console.WriteLine("\n=== Árboles ===");
        Nodo raiz = new Nodo(10);
        raiz.Izq = new Nodo(5);
        raiz.Der = new Nodo(15);

        Console.WriteLine("Recorrido del árbol (InOrden):");
        RecorrerInOrden(raiz);

        // -------------------------------------------------------

        // =======================================================
        // 🕸️ GRAFOS
        // Representan relaciones o conexiones entre elementos (nodos).
        // Se usan en mapas, redes sociales, rutas, etc.
        // =======================================================
        Console.WriteLine("\n=== Grafos ===");
        Grafo grafo = new Grafo();
        grafo.AgregarConexion("A", "B");
        grafo.AgregarConexion("A", "C");
        grafo.AgregarConexion("B", "D");

        foreach (var nodo in grafo.Adyacencias)
        {
            Console.WriteLine($"{nodo.Key} -> {string.Join(", ", nodo.Value)}");
        }
    }

    // ------------------ CLASES AUXILIARES ------------------

    // Clase para nodos de árbol binario
    class Nodo
    {
        public int Valor;
        public Nodo Izq, Der;

        public Nodo(int valor)
        {
            Valor = valor;
        }
    }

    // Método recursivo para recorrer un árbol en orden
    static void RecorrerInOrden(Nodo nodo)
    {
        if (nodo == null) return;
        RecorrerInOrden(nodo.Izq);
        Console.WriteLine(nodo.Valor);
        RecorrerInOrden(nodo.Der);
    }

    // Clase para representar un grafo con lista de adyacencias
    class Grafo
    {
        public Dictionary<string, List<string>> Adyacencias = new Dictionary<string, List<string>>();

        public void AgregarConexion(string a, string b)
        {
            if (!Adyacencias.ContainsKey(a))
                Adyacencias[a] = new List<string>();

            Adyacencias[a].Add(b);
        }
    }
}
