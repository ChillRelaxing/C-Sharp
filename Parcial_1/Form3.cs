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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
            Conexion.Open();

            string cadena = "SELECT id_Estudiante, nombre_estudiante, edad FROM tblEstudiantes";

            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader registros = comando.ExecuteReader();

            while (registros.Read())
            {
                txtMostrarDatos.AppendText("ID: ");
                txtMostrarDatos.AppendText(registros["id_Estudiante"].ToString());
                txtMostrarDatos.AppendText("\r\n" + "Nombre: ");
                txtMostrarDatos.AppendText(registros["nombre_estudiante"].ToString());
                txtMostrarDatos.AppendText("\r\n" + "Años: ");
                txtMostrarDatos.AppendText(registros["edad"].ToString());
                txtMostrarDatos.AppendText(Environment.NewLine);

            }
            Conexion.Close();

        }
    }
}
