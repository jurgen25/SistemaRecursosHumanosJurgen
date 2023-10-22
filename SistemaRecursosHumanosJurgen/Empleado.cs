using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecursosHumanosJurgen
{
    internal class Empleado
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Dirección { get; set; }
        public string Teléfono { get; set; }
        public decimal Salario
        { get; set;}

        // Constructor para inicializar los atributos del empleado
        public Empleado(string cedula, string nombre, string dirección, string teléfono, decimal salario)
        {
            Cedula = cedula;
            Nombre = nombre;
            Dirección = dirección;
            Teléfono = teléfono;
            Salario = salario;
        }
    }
}
