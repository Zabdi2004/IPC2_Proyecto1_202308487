using System;
using System.Collections.Generic;
using System.Text;

namespace Nodos 

{
    public class Nodo 
    {
        public object data; // Variable para almacenar el valor del nodo (Paciente)
        public Nodo? Siguiente; // Variable para almacenar la referencia al siguiente nodo

        // Constructor para inicializar el nodo con un valor
        public Nodo(object data)
        {
            this.data = data;
            Siguiente = null;
        }
    }
}
