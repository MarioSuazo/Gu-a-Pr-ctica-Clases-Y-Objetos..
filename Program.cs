using eliminar;

namespace guiaN2
{
    internal class Program
    {
        //Se declara el arrayList estático con el fín de utilizarlo en métodos más prácticos.
        static List<Empleado> listaEmpleados = new List<Empleado>();

        static void Main(string[] args)
        {
            //Se añade un try-catch para manejar excepciones y que no se quiebre el código.
            try
            {
                Console.WriteLine("Aplicación de Gestión de Empleados");

                //List<Empleado> listaEmpleados = new List<Empleado>();

                listaEmpleados.Add(new Empleado("Juan", 1010, 30000));
                listaEmpleados.Add(new Empleado("María", 1020, 35000));
                listaEmpleados.Add(new Empleado("Pedro", 1030, 32000, false));

                //Añado dos objetos propios.
                listaEmpleados.Add(new Empleado("Nando", 1339, 40000, true));
                listaEmpleados.Add(new Empleado("Mada", 1096, 50000, true));

                //Una iteración para recorrer la lista empleados, e imprimir los datos de los elementos.
                foreach (var empleado in listaEmpleados)
                {
                    empleado.mostrarDetalles();
                }

                //Se ejecutan los métodos.
                cambiarEstado();

                aumentarSalario();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error {e}");
            }
        }

        //Metodo default.
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

        //Creación de método para cambiar de estado a un empleado.
        //Método default.
        static void cambiarEstado()
        {
            Console.Write("\n\t¿Quiere cambiar el estado de un empleado?\n\t(1. Sí.\t2. No.): ");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                Console.Write("\nDigite el Numero de Empleado a Cambiar de Estado: ");
                int numeroEmpleadoCambiarEstado = Convert.ToInt32(Console.ReadLine());

                Empleado empleadoCambiarEstado = buscarEmpleado(listaEmpleados, numeroEmpleadoCambiarEstado);

                if (empleadoCambiarEstado != null)
                {
                    empleadoCambiarEstado.cambiarEstado(1);
                    empleadoCambiarEstado.mostrarDetalles();
                }
                else
                {
                    Console.WriteLine($"Empleado con número {numeroEmpleadoCambiarEstado} no encontrado");
                }
            }
            else { }
        }

        //creación de método para aumentar salario a un empleado.
        static void aumentarSalario()
        {
            Console.Write("\n\t¿Quiere aumentar el sueldo de un empleado?\n\t(1. Sí.\t2. No.): ");
            int op = Convert.ToInt32(Console.ReadLine());

            if (op == 1)
            {
                /* Nueva Funcionalidad de */
                //Se solicita el numero del empleado al que se le subirá el sueldo.
                Console.Write("\nIngrese el numero del empleado a aumentar el salario: ");

                //Se crea la variable donde se almacena el numero de empleado anterior digitado en la consola.
                int numEmpleado = Convert.ToInt32(Console.ReadLine());

                //Se crea una variable de tipo "Empleado" para poder acceder a los métodos de la clase genérica y poder llamar a los métodos.
                Empleado empNuevoSalario = buscarEmpleado(listaEmpleados, numEmpleado);
                string nombre = empNuevoSalario.getName();

                //Se valida la existencia del empleado con el numero de empleado que se digitó.
                if (empNuevoSalario != null)
                {
                    Console.WriteLine();
                    //Si el empleado existe entonces imprimir sus datos
                    empNuevoSalario.mostrarDetalles();

                    //Se solicita en Porcentaje la cantidad de sueldo a aumentarle al empleado.
                    Console.Write("\nDigitar el porcentaje a aumentar: ");

                    //Se crea la variable que almacena el porcentaje a aumentar del sueldo.
                    decimal porc = Convert.ToDecimal(Console.ReadLine());

                    /*Se hace uso de la variable tipo "Empleado" para acceder al salario (porque es privado)
                     y se crea una variable para almacenar el salario con el que se instanció el objeto Empleado. */
                    decimal salViejo = empNuevoSalario.getSalario();

                    //Se hace el cálculo del nuevo salario a partir del salario anterior y el porcentaje solicitado.
                    decimal nuevoSalario = salViejo + (salViejo * (porc / 100));

                    //Se imprime el resultado final, mostrando el porcentaje que se le aumentó, y el monto final del nuevo salario.
                    Console.WriteLine($"\nSe aumentó el salario en {porc} %.\nEl nuevo salario de '{nombre}' es de: {nuevoSalario}.");
                }
                else
                {
                    //Si no existe el numero de empleado, se muestra que no se encontró.
                    Console.WriteLine($"Empleado con número {empNuevoSalario} no encontrado");
                }
            }
            else { }
        }
    }
}