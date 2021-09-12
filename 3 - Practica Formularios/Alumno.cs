using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Practica_Formularios
{
    class Alumno
    {
        private string nombre;
        private DateTime fechaCreacion;
        private string estadoCivil;
        private string sexo;
        private string extranjero;

        List<Alumno> listaalumno = new List<Alumno>();

        public string Nombre { get => nombre; set => nombre = value; }
        public DateTime FechaCreacion { get => fechaCreacion; set => fechaCreacion = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Extranjero { get => extranjero; set => extranjero = value; }

        public Alumno(string nomb, DateTime fcrea, string civil, string sex, string extranj)
        {
            this.Nombre = nomb;
            this.FechaCreacion = fcrea;
            this.EstadoCivil = civil;
            this.Sexo = sex;
            this.Extranjero = extranj;
           
        }

    }
}
