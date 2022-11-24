using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
            Conexion.Open();

            string nombre_estudiante = txtNombre.Text;
            string Edades_Estudiantes = txtEdad.Text;

            string cadena = "INSERT INTO tblEstudiantes(nombre_estudiante, edad) values ('"+ nombre_estudiante + "'," + Edades_Estudiantes + ")";

            SqlCommand comando = new SqlCommand(cadena, Conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se registraron los datos correctamente!");
            txtNombre.Text = "";
            txtEdad.Text = "";
            Conexion.Close();


        }
    }
}
