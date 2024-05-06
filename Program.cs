namespace guiaN2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aplicación de Gestión de Empleados.");

            List<Empleado> listaEmpleados = new List<Empleado>();

            listaEmpleados.Add(new Empleado("Juan", 101, 30000));
            listaEmpleados.Add(new Empleado("María", 102, 35000));
            listaEmpleados.Add(new Empleado("Pedro", 103, 32000, false));

            foreach (var empleado in listaEmpleados)
            {
                empleado.mostrarDetalles();
            }

            int numeroEmpleadoCambiarEstado = 103;
            Empleado empleadoCambiarEStado = buscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

            if (empleadoCambiarEStado != null)
            {
                empleadoCambiarEStado.cambiarEstado(1);
                empleadoCambiarEStado.mostrarDetalles();
            }
            else
            {
                Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado");
            }
        }

        static Empleado buscarEmpleado(List<Empleado> empleados, int numeroEmpleados)
        {
            foreach (var empleado in empleados)
            {
                if (empleado.obtenerNumeroEmpleado() == numeroEmpleados)
                {
                    return empleado;
                }
            }
            return null;
        }
    }
}