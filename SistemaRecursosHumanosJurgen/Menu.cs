using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecursosHumanosJurgen
{
    internal class Menu
    {
        private List<Empleado> empleados = new List<Empleado>();

        // Método para mostrar el menú principal
        public void MostrarMenú()
        {
            Console.WriteLine("Menú Principal:");
            Console.WriteLine("1. Agregar Empleados");
            Console.WriteLine("2. Consultar Empleados");
            Console.WriteLine("3. Modificar Empleados");
            Console.WriteLine("4. Borrar Empleados");
            Console.WriteLine("5. Inicializar Arreglos");
            Console.WriteLine("6. Reportes");
            Console.WriteLine("0. Salir");
        }

        // Método para agregar un empleado al sistema
        public void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese la cédula: ");
            string cedula = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese la dirección: ");
            string dirección = Console.ReadLine();
            Console.WriteLine("Ingrese el teléfono: ");
            string teléfono = Console.ReadLine();
            Console.WriteLine("Ingrese el salario: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            // Aqui cee un objeto Empleado con los datos ingresados y agregarlo a la lista de empleados
            Empleado empleado = new Empleado(cedula, nombre, dirección, teléfono, salario);
            empleados.Add(empleado);
            Console.WriteLine("Empleado agregado con éxito.");
        }
        // Método para consultar un empleado por número de cédula
        public void ConsultarEmpleados()
        {
            Console.WriteLine("Ingrese la cédula del empleado a consultar: ");
            string cedula = Console.ReadLine();

            Empleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine($"Cédula: {empleado.Cedula}");
                Console.WriteLine($"Nombre: {empleado.Nombre}");
                Console.WriteLine($"Dirección: {empleado.Dirección}");
                Console.WriteLine($"Teléfono: {empleado.Teléfono}");
                Console.WriteLine($"Salario: {empleado.Salario}");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }
        // Método para modificar los datos de un empleado existente
        public void ModificarEmpleado()
        {
            Console.WriteLine("Ingrese la cédula del empleado a modificar: ");
            string cedula = Console.ReadLine();
            // Aqui busco al empleado en la lista por número de cédula
            Empleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                Console.WriteLine("Ingrese el nuevo nombre: ");
                empleado.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la nueva dirección: ");
                empleado.Dirección = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo teléfono: ");
                empleado.Teléfono = Console.ReadLine();
                Console.WriteLine("Ingrese el nuevo salario: ");
                empleado.Salario = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Empleado modificado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }
        // Método para eliminar un empleado del sistema
        public void BorrarEmpleado()
        {
            Console.WriteLine("Ingrese la cédula del empleado a borrar: ");
            string cedula = Console.ReadLine();
            // Busca al empleado en la lista por número de cédula
            Empleado empleado = empleados.Find(e => e.Cedula == cedula);

            if (empleado != null)
            {
                // Esto elimina al empleado de la lista
                empleados.Remove(empleado);
                Console.WriteLine("Empleado eliminado con éxito.");
            }
            else
            {
                Console.WriteLine("Empleado no encontrado.");
            }
        }
        // Método para inicializar la lista de empleados
        public void InicializarArreglos()
        {
            // Elimina todos los empleados de la lista
            empleados.Clear();
            Console.WriteLine("Arreglos inicializados.");
        }
        // Método para mostrar el menú de reportes
        public void MostrarReportes()
        {
            Console.WriteLine("Menú de Reportes:");
            Console.WriteLine("1. Consultar empleados con número de cédula.");
            Console.WriteLine("2. Listar todos los empleados ordenados por nombre.");
            Console.WriteLine("3. Calcular y mostrar el promedio de los salarios.");
            Console.WriteLine("4. Calcular y mostrar el salario más alto y el más bajo de todos los empleados.");
            Console.WriteLine("0. Volver al menú principal");

            int opción = Convert.ToInt32(Console.ReadLine());

            switch (opción)
            {
                case 1:
                    ConsultarEmpleados();
                    break;
                case 2:
                    ListarEmpleadosOrdenadosPorNombre();
                    break;
                case 3:
                    MostrarPromedioSalarios();
                    break;
                case 4:
                    MostrarSalariosExtremos();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
        // Método para listar empleados ordenados por nombre
        private void ListarEmpleadosOrdenadosPorNombre()
        {
            var empleadosOrdenados = empleados.OrderBy(e => e.Nombre).ToList();
            foreach (var empleado in empleadosOrdenados)
            {
                Console.WriteLine($"Cédula: {empleado.Cedula}, Nombre: {empleado.Nombre}");
            }
        }
        // Método para mostrar el promedio de los salarios
        private void MostrarPromedioSalarios()
        {
            if (empleados.Count > 0)
            { 
                // Calcula la suma total de los salarios
                decimal totalSalarios = empleados.Sum(e => e.Salario);
                // Calcula el promedio dividiendo la suma total por la cantidad de empleados
                decimal promedio = totalSalarios / empleados.Count;
                Console.WriteLine($"Promedio de salarios: {promedio}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");
            }
        }
        // Método para mostrar el salario más alto y más bajo
        private void MostrarSalariosExtremos()
        {
            if (empleados.Count > 0)
            { 
                // Encuentra el salario más alto y más bajo en la lista
                decimal salarioMásAlto = empleados.Max(e => e.Salario);
                decimal salarioMásBajo = empleados.Min(e => e.Salario);
                Console.WriteLine($"Salario más alto: {salarioMásAlto}");
                Console.WriteLine($"Salario más bajo: {salarioMásBajo}");
            }
            else
            {
                Console.WriteLine("No hay empleados registrados.");
            }
        }
    }
}
