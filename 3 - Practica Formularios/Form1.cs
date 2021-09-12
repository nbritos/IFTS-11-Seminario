using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3___Practica_Formularios
{
    public partial class Form1 : Form
    {
        private bool ciclovalida = true;
        List<Alumno> listaalumnos = new List<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int indiceFilas = 0;
           //valido antes de cargar al alumno
            Validar();

            while (ciclovalida==true)
            {
                //agrego nuevo renglón
                indiceFilas= dtgvAlumnos.Rows.Add();
                //ingreso la info de cada alumno
                dtgvAlumnos.Rows[indiceFilas].Cells[0].Value = txtNombre.Text;
                dtgvAlumnos.Rows[indiceFilas].Cells[1].Value = dateRegistro.Value;
                dtgvAlumnos.Rows[indiceFilas].Cells[2].Value = comboEstadoCivil.SelectedItem;
                dtgvAlumnos.Rows[indiceFilas].Cells[3].Value = Sexo();
                dtgvAlumnos.Rows[indiceFilas].Cells[4].Value = MetodoExtranjero();
                CreaAlumno();
                Limpieza();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CEP();
        }

        private void comboEstadoCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            CEP();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbHombre.Checked==true)
            {
                rbHombre.Checked = true;
                rbMujer.Checked = false;
            }
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMujer.Checked == true)
            {
                rbMujer.Checked = true;
                rbHombre.Checked = false;
            }
        }

        private void dateRegistro_ValueChanged(object sender, EventArgs e)
        {
            CEP();
        }

        private void CEP()
        {
            lblCarga.Text = "Carga en proceso";
        }

        private void lblCarga_Click(object sender, EventArgs e)
        {

        }

        public void CreaAlumno()
        {
            listaalumnos.Add(new Alumno(txtNombre.Text, dateRegistro.Value, comboEstadoCivil.SelectedItem.ToString(), Sexo(), MetodoExtranjero()));
            //listaalumnos.Remove(Alumno => Alumno.);
        }

        public void Limpieza()
        {
            //limpio los boxes
            txtNombre.Text = "";
            rbHombre.Checked = false;
            rbMujer.Checked = false;
            chckbExtranjero.Checked = false;
            lblCarga.Text = "";
            ciclovalida = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Validar()
        {
            string mensaje = "";

            if (txtNombre.Text.Equals(""))
            {
                mensaje = "Ingrese un nombre válido\n";
            }
            if (rbHombre.Checked==false&& rbMujer.Checked==false)
            {
                //MessageBox.Show(mensaje, "Error");
                mensaje += "Ingrese el sexo\n";
            }
            if (comboEstadoCivil.SelectedIndex<1)
            {
               mensaje +="Seleccione estado civil\n";
            }
            if (!mensaje.Equals(""))
            {
                MessageBox.Show(mensaje, "Error");
                ciclovalida = false;
            }
            else
            {
                ciclovalida = true;
            }
        }

        private string Sexo()
        {
            if (rbHombre.Checked)
            {
                return "Hombre";
            }
            else
            {
                return "Mujer";
            }
        }

        private string MetodoExtranjero()
        {
            if (chckbExtranjero.Checked)
            {

                return "SI";
            }
            else
            {
                return "NO";
            }
        }
    }
}
