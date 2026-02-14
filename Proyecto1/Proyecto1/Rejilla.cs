using System;
using System.Collections.Generic;
using System.Text;

namespace Rejillas
{
    public class Rejilla
    {
        public int[,] Matrix;
        public int Tamaño;

        // Constructor para inicializar la rejilla con un tamaño específico
        public Rejilla(int m) 
        { 
            Tamaño = m;
            Matrix = new int[m,m];
        }

        // Método para infectar una celda específica en la rejilla
        public void InfectarCelda(int fila, int columna)
        {
            Matrix[fila, columna] = 1;
        }
    }
}
