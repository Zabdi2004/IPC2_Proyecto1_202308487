using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

// Importar el espacio de nombres que contiene la clase Nodo
using Nodos;

namespace ListasEnlazadas
{
    public class ListaEnlazada
    {
        // Variable para almacenar la referencia al primer nodo de la lista
        // Se utiliza el tipo Nodo? para permitir que la cabeza pueda ser null (lista vacía)
        private Nodo? cabeza;

        // Constructor: inicializa la cabeza de la lista como null
        public ListaEnlazada()
        {
            cabeza = null;
        }

        // Método para agregar un nuevo nodo al final de la lista
        public void Agregar(object data)
        {
            Nodo nuevoNodo = new Nodo(data); // Crear un nuevo nodo con el valor proporcionado
            if (cabeza == null) // Si la lista está vacía, el nuevo nodo se convierte en la cabeza
            {
                cabeza = nuevoNodo;
            }
            else // Si la lista no está vacía, recorrer hasta el final y agregar el nuevo nodo
            {
                Nodo actual = cabeza; // Empezar desde la cabeza
                while (actual.Siguiente != null) // Recorrer hasta el último nodo
                {
                    actual = actual.Siguiente; // Mover al siguiente nodo
                }
                actual.Siguiente = nuevoNodo; // Agregar el nuevo nodo al final de la lista
            }
        }

        // Método para imprimir los valores de la lista
        public void Recorrer()
        {
            Nodo? actual = cabeza; // Empezar desde la cabeza
            while (actual != null) // Recorrer mientras no se alcance el final de la lista
            {
                Console.WriteLine(actual.data); // Imprimir el tipo del objeto almacenado en el nodo
                actual = actual.Siguiente; // Mover al siguiente nodo
            }
        }

        // Método para eliminar un nodo con un valor específico
        public void Eliminar(object data)
        {
            if (cabeza == null) // Si la lista está vacía, no hay nada que eliminar
            {
                return;
            }
            if (cabeza.data.Equals(data)) // Si el nodo a eliminar es la cabeza
            {
                cabeza = cabeza.Siguiente; // La nueva cabeza será el siguiente nodo
                return;
            }
            Nodo? actual = cabeza; // Empezar desde la cabeza
            while (actual.Siguiente != null) // Recorrer mientras no se alcance el final de la lista
            {
                if (actual.Siguiente.data.Equals(data)) // Si se encuentra el nodo a eliminar
                {
                    actual.Siguiente = actual.Siguiente.Siguiente; // Saltar el nodo a eliminar
                    return;
                }
                actual = actual.Siguiente; // Mover al siguiente nodo
            }
        }
    }
}
