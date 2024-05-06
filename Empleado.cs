using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiaN2
{
    internal class Empleado
    {
        private string nombre;
        private int numeroEmpleado;
        private decimal salario;
        private bool activo;

        public Empleado(string nombre, int numeroEmpleado, decimal salario, bool activo)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
            this.activo = activo;
        }

        /* Constructor con 3 Parámetros, Agregado para Procesar Objetos sin estado de actividad.*/
        public Empleado(string nombre, int numeroEmpleado, decimal salario)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
        }

        public void mostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre}, Numero de Empleado: {numeroEmpleado}, Salario: {salario}, Estado: {estado}");
        }

        public int obtenerNumeroEmpleado()
        {
            return numeroEmpleado;
        }

        public void cambiarEstado(int nuevoEstado)
        {
            if (nuevoEstado == 1)
            {
                activo = true;
                Console.WriteLine("Empleado Activado.");
            } 
            else if (nuevoEstado == 0)
            {
                activo = false;
                Console.WriteLine("Empleado Desactivado.");
            }
            else
            {
                Console.WriteLine("Estado No Válido.");
            }
        }
    }
}