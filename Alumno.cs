using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeminarioUnidad1
{
    class Alumno
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int documento;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public int Documento { get => documento; set => documento = value; }

        public Alumno(string nombre, string ape, DateTime fechanac, int dni)
        {
            this.nombre = nombre;
            this.apellido = ape;
            this.fechaNacimiento = fechanac;
            this.documento = dni;
        }

        public static int Edad(DateTime nac)
        {
            int edad = DateTime.Today.Year - nac.Year;

            if (nac.Date > DateTime.Today.AddYears(-edad)) edad--;

            return edad;
        }

        public override String ToString()
        {
            return ($"Alumno: {this.Nombre}\nApellido: {this.apellido.ToString()}\nDocumento: {this.documento.ToString()}\nEdad: {Edad(this.fechaNacimiento).ToString()}\nFecha de nacimiento: {this.fechaNacimiento.ToString("D")}");
        }
    }
}
