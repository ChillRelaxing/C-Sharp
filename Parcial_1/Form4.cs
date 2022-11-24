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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
            Conexion.Open();

            string id_estudiante = txtCodigo_Consultar.Text;
            string cadena = "DELETE FROM tblEstudiantes WHERE id_Estudiante =" + id_estudiante;
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            int cant;

            cant = comando.ExecuteNonQuery();
            if (cant == 1)
            {
                lblNombre.Text = "";
                lblEdad.Text = "";
                MessageBox.Show("Se borro el articulo");
            }
            else
            {
                MessageBox.Show("No existe un articulo con el codigo ingresado");
                //btnBuscar_Eliminar.Enabled = false;

            }
            Conexion.Close();

        }

        private void btnBuscar_Eliminar_Click(object sender, EventArgs e)
        {
            SqlConnection Conexion = new SqlConnection("server=DESKTOP-DHSOO9J\\SQLEXPRESS01; database=RegistroEstudiante ; integrated security = true");
            Conexion.Open();

            string id_estudiante = txtCodigo_Consultar.Text;
            string cadena = "SELECT id_Estudiante, nombre_estudiante, edad FROM tblEstudiantes WHERE id_Estudiante=" + id_estudiante;
            SqlCommand comando = new SqlCommand(cadena, Conexion);
            SqlDataReader registro = comando.ExecuteReader();

            if (registro.Read())
            {
                lblNombre.Text = registro["nombre_estudiante"].ToString();
                lblEdad.Text = registro["edad"].ToString();
                btnBuscar_Eliminar.Enabled = true;
            }
            else
            {
                MessageBox.Show("No exite un articulo con el codigo ingresado");
                btnBuscar_Eliminar.Enabled = false;
            }
            Conexion.Close();
        }
    }
}
