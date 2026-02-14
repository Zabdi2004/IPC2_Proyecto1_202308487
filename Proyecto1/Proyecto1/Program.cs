using Nodos;
using ListasEnlazadas;
using Pacientes;

class Program
{
    // Crear una instancia de ListaEnlazada para almacenar pacientes
    static ListaEnlazada listaPacientes = new ListaEnlazada(); //

    static void Main(string[] args)
    {

        // Crear algunos pacientes y agregarlos a la lista
        // Paciente(nombre, edad, periodos, M)
        Paciente paciente1 = new Paciente("Carlos", 40, 6, 3);

        // Infectar al paciente1 con el virus
        paciente1.RejillaPaciente.InfectarCelda(1, 1);

        // Agregar los pacientes a la lista enlazada
        listaPacientes.Agregar(paciente1);

        // Imprimir los pacientes en la lista
        Console.WriteLine("Lista de Pacientes:");
        listaPacientes.Recorrer();
    }
}
