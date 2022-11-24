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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBuscar_Modificar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
            Conexion.Open();

            string id_Estudiante = txtBuscar_Modificar.Text;
            string cadena = "SELECT id_Estudiante, nombre_estudiante, edad FROM tblEstudiantes WHERE id_Estudiante=" + id_Estudiante;
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader resgistro = comando.ExecuteReader();

            if (resgistro.Read())
            {
                txtNombre_editar.Text = resgistro["nombre_estudiante"].ToString();
                txtEdad_Editar.Text = resgistro["edad"].ToString();
                btnModificar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No existe un articulo con el codigo ingresado");
                btnModificar.Enabled = false;
            }


        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
            Conexion.Open();

            string id_estudiante = txtBuscar_Modificar.Text;
            string nombre_estudiante = txtNombre_editar.Text;
            string edad_estudiante = txtEdad_Editar.Text;

            string cadena = "UPDATE tblEstudiantes SET nombre_estudiante='"+ nombre_estudiante + "', edad=" + edad_estudiante + " WHERE id_Estudiante=" + id_estudiante;
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            int cant;
            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                MessageBox.Show("Se modificaron los datos del articulo");
                txtBuscar_Modificar.Text = "";
                txtNombre_editar.Text = "";
                txtEdad_Editar.Text = "";
            }
            else
            {
                MessageBox.Show("No existe un articulo con el codigo ingresado");
                btnBuscar_Modificar.Enabled = false;
            }
            Conexion.Close();
        }
    }
}
