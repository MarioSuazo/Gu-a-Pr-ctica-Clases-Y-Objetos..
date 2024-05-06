using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eliminar
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

        public Empleado(string nombre, int numeroEmpleado, decimal salario)
        {
            this.nombre = nombre;
            this.numeroEmpleado = numeroEmpleado;
            this.salario = salario;
        }

        public void mostrarDetalles()
        {
            string estado = (activo) ? "Activo" : "Inactivo";
            Console.WriteLine($"Nombre: {nombre},\tNumero de Empleado: {numeroEmpleado},    Salario: {salario:C},\tEstado: {estado}.");
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
                Console.WriteLine("\nEmpleado Activo.");
            }
            else if (nuevoEstado == 0)
            {
                activo = false;
                Console.WriteLine("\nEmpleado Inactivo.");
            }
            else
            {
                Console.WriteLine("\nEstado No Válido.");
            }
        }

        public decimal getSalario()
        {
            return salario;
        }

        public string getName()
        {
            return nombre;
        }

        /*Commit 2, función aumentar salario.
         macho del método para aumentar salario.

        Resultado = No Funcionó.

        public void aumentarSalario(int numeroEmpleado)
        {
            Console.Write("Digitar el porcentaje a aumentar: ");
            decimal porc = Convert.ToDecimal(Console.ReadLine());
            decimal nuevoSalario = salario + (salario * porc);
            Console.WriteLine($"Se aumentó el salario en {(porc / 100)} %.\nSu nuevo salario es de: {nuevoSalario}");
        } */
    }
}