using SistemaRecursosHumanosJurgen;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaRecursosHumanosJurgen;
class Program
{
    static void Main()
    {
        Menu menú = new Menu();

        while (true)
        {
            menú.MostrarMenú();
            int opción = Convert.ToInt32(Console.ReadLine());

            switch (opción)
            {
                case 1:
                    menú.AgregarEmpleado();
                    break;
                case 2:
                    menú.ConsultarEmpleados();
                    break;
                case 3:
                    menú.ModificarEmpleado();
                    break;
                case 4:
                    menú.BorrarEmpleado();
                    break;
                case 5:
                    menú.InicializarArreglos();
                    break;
                case 6:
                    menú.MostrarReportes();
                    break;
                case 0:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }
}