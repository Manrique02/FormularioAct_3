using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FormularioAct_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string Nombre = TbxNombre.Text;
            string Apellido = TbxApellido.Text;
            string Telefono = TbxTelefono.Text;
            string Estatura = TbxEstatura.Text;
            string Edad = TbxEdad.Text;

            string Genero = "";
            if (RBtnHombre.Checked)
            {
                Genero = "Hombre";
            }
            else if(RBtnMujer.Checked)
            {
                Genero = "Mujer";
            }

            string Datos = $"Nombre:{Nombre}\r\nApellidos:{Apellido}\r\n " +
                $"Telefono: {Telefono}\r\n Estatura:{Estatura}\r\n " +
                $"Edad:{Edad}años\r\n Genero{Genero}";

            //Guardar el código en un archivo
            string Ruta_Archivo = "C:\\Users\\Rober\\Documents\\Datos.txt";
            bool ArchivoExiste = File.Exists(Ruta_Archivo);

            using (StreamWriter writer = new StreamWriter(Ruta_Archivo, true)) 
            {
                if (ArchivoExiste)
                {
                    writer.WriteLine();
                }
                else
                {
                    writer.WriteLine();
                }
                MessageBox.Show("Tus datos fueron registrados exitosamente:\r\n" + Datos, "Detalles" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }  
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            TbxNombre.Clear();
            TbxApellido.Clear();
            TbxEstatura.Clear();
            TbxTelefono.Clear();
            TbxEdad.Clear();
            RBtnHombre.Checked = false;
            RBtnMujer.Checked = false;
        }
    }
}
