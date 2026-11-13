using System;

namespace ConListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaEnlazada listaEnlazada = new ListaEnlazada();

            listaEnlazada.ImprimeLosNodos();
            Console.WriteLine();

            listaEnlazada.AniadeAlInicio(100);
            listaEnlazada.AniadeAlFinal(12);
            listaEnlazada.AniadeAlFinal(13);
            listaEnlazada.AniadeAlFinal(14);
            listaEnlazada.AniadeAlFinal(15);
            listaEnlazada.ImprimeLosNodos();
            Console.WriteLine();

            listaEnlazada.AniadeAlInicio(55);
            listaEnlazada.ImprimeLosNodos();
            Console.WriteLine();

            listaEnlazada.EliminaDelInicio();
            listaEnlazada.ImprimeLosNodos();
            Console.WriteLine();

            listaEnlazada.EliminaDelFinal();
            listaEnlazada.ImprimeLosNodos();
            Console.WriteLine();

            int c = listaEnlazada.Cuenta();
            Console.WriteLine("Existen {0} nodos", c);

            listaEnlazada.EliminaPosicion(3);
            listaEnlazada.ImprimeLosNodos();
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    public class Nodo
    {
        public Nodo sig;
        public object Elemento;
    }

    public class ListaEnlazada
    {
        private Nodo inicio;
        private Nodo actual;   // último nodo real (cola)
        private int contar;

        public ListaEnlazada()
        {
            inicio = new Nodo();
            actual = inicio;
            contar = 0;
        }

        // Añadir al final
        public void AniadeAlFinal(object dato)
        {
            Nodo nvoNodo = new Nodo();
            nvoNodo.Elemento = dato;
            actual.sig = nvoNodo;
            actual = nvoNodo;
            contar++;
        }

        // Añadir al inicio
        public void AniadeAlInicio(object dato)
        {
            Nodo nvoNodo = new Nodo();
            nvoNodo.Elemento = dato;
            nvoNodo.sig = inicio.sig;
            inicio.sig = nvoNodo;
            contar++;

            // si la lista estaba vacía, el nuevo también es el último
            if (actual == inicio)
                actual = nvoNodo;
        }

        // Eliminar del inicio
        public void EliminaDelInicio()
        {
            if (contar != 0)
            {
                inicio.sig = inicio.sig.sig;
                contar--;

                if (inicio.sig == null)
                    actual = inicio;
            }
            else
            {
                Console.WriteLine("No existen elementos en la lista");
            }
        }

        // Eliminar del final
        public void EliminaDelFinal()
        {
            if (inicio.sig == null)
            {
                Console.WriteLine("Lista vacía");
                return;
            }

            Nodo p = inicio;
            while (p.sig != null && p.sig.sig != null)
                p = p.sig;

            p.sig = null;
            actual = p;
            contar--;
        }

        // Eliminar en posición
        public void EliminaPosicion(int posicion)
        {
            if (posicion < 1 || posicion > contar)
            {
                Console.WriteLine("Posición fuera de rango");
                return;
            }

            Nodo p = inicio;
            for (int i = 1; i < posicion; i++)
            {
                p = p.sig;
            }

            p.sig = p.sig.sig;
            contar--;

            if (p.sig == null)
                actual = p;
        }

        // Imprimir la lista
        public void ImprimeLosNodos()
        {
            Console.Write("Inicio -> ");
            Nodo p = inicio;
            while (p.sig != null)
            {
                p = p.sig;
                Console.Write(p.Elemento);
                Console.Write(" -> ");
            }
            Console.Write("NULL");
        }

        public int Cuenta()
        {
            return contar;
        }
    }
}