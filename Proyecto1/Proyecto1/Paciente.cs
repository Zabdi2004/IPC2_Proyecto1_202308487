using System;
using System.Collections.Generic;
using System.Text;

// Importar el espacio de nombres que contiene la clase Rejilla
using Rejillas;

namespace Pacientes
{
    public class Paciente
    {
        // Definir Atributos de la clase Paciente
        public string Nombre;
        public string? Resultado; // Variable para almacenar el resultado del diagnóstico (Sano, Grave, Mortal),
                                  // por ahora se deja vacía, se asignará un valor después de analizar los patrones de infección.

        public int Edad;
        public int Periodos;
        public int M; //Tamaño de la rejilla (M x M)

        public int N; //Periodo patrón 1
        public int N1; //Periodo patrón 2

        public Rejilla RejillaPaciente;

        public Paciente(string nombre, int edad, int periodos, int M)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Periodos = periodos;
            this.M = M;
            RejillaPaciente = new Rejilla(M);

            Resultado = null;
            N = 0;
            N1 = 0;
        }

        public override string ToString()
        {
            string mensaje = $"Nombre: {Nombre}, Edad: {Edad}, Periodos: {Periodos}, Tamaño Rejilla: {M}x{M}";
            return mensaje;
        }



        /*
         * Caso Normal (Se repite el patron incial)
         * - Si el patron inicial se repite luego de N periodos, es una enfermedad grave.
         * - Si el patron inicial se repite luego de N periodos y N = 1, esto quiere decir que no cambio, 
         *   por lo cual siempre sera el mismo patron, por lo tanto el paciente morira a causa de la enferdad ya que sera incurable, osea Mortal.
         * Caso Especial (Se repite un patron distinto al inicial)
         * - Si un patron distinto al inicial se repite luego de N periodos, apartir de la aparicion de este patron, 
         *   se repite cada N1 periodos, la enfermedad sera grave.
         * - Si un patron distinto al inicial se repite luego de N periodos, apartir de la aparicion de este patron, 
         *   se repite cada N1 periodos y N1 = 1, quiere decir que desde que aparecio este patron ya no cambio, el paciente morira 
         *   ya que la enfermedad sera incurable, por lo tanto sera Mortal.
         * Si el patron inicial no se repite o si nunca se repite un patron en los N periodos en los que se ejecuto el programa,
         *   el paciente se sanara o estara sano.         
         */

    }
}
