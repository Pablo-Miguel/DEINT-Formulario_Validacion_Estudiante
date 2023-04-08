using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEINT_Formulario_Validacion_Estudiante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tbNif_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbNif.Text, @"^\d{8}[A-Z]$"))
            {
                lblNif.ForeColor = Color.Green;
            }
            else{
                lblNif.ForeColor = Color.Red;
            }
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {
            if (tbNombre.Text.Equals(""))
            {
                lblNombre.ForeColor = Color.Red;
            }
            else
            {
                lblNombre.ForeColor = Color.Green;
            }
        }

        private void tbApellido_TextChanged(object sender, EventArgs e)
        {
            if (tbApellido.Text.Equals(""))
            {
                lblApellido.ForeColor = Color.Red;
            }
            else
            {
                lblApellido.ForeColor = Color.Green;
            }
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(tbEmail.Text, @"^.+@.+\.\w+$"))
            {
                lblEmail.ForeColor = Color.Green;
            }
            else
            {
                lblEmail.ForeColor = Color.Red;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNif.Clear();
            tbNombre.Clear();
            tbApellido.Clear();
            tbEmail.Clear();
        }

        private void pbEstudiante_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Filter = "Imagenes|*.jpg;*.jpeg;*.png";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
            }

            pbEstudiante.ImageLocation = filePath;
            pbHead.ImageLocation = filePath;
        }

        private void tbNif_Validating(object sender, CancelEventArgs e)
        {

            if (!Regex.IsMatch(tbNif.Text, @"^\d{8}[A-Z]$") || String.IsNullOrEmpty(tbNif.Text))
            {
                this.epNif.SetError(this.tbNif, "El formato del NIF es incorrecto.");
                e.Cancel = true;
            }
            else
            {
                this.epNif.SetError(this.tbNif, "");
                e.Cancel = false;
            }

        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {
            if (tbNombre.Text.Equals(""))
            {
                this.epNombre.SetError(this.tbNombre, "El nombre no puede estar vacío.");
                e.Cancel = true;
            }
            else
            {
                this.epNombre.SetError(this.tbNombre, "");
                e.Cancel = false;
            }
        }

        private void tbApellido_Validating(object sender, CancelEventArgs e)
        {
            if (tbApellido.Text.Equals(""))
            {
                this.epApellido.SetError(this.tbApellido, "El apellido no puede estar vacío.");
                e.Cancel = true;
            }
            else
            {
                this.epApellido.SetError(this.tbApellido, "");
                e.Cancel = false;
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(tbEmail.Text, @"^.+@.+\.\w+$") || String.IsNullOrEmpty(tbEmail.Text))
            {
                this.epEmail.SetError(this.tbEmail, "El formato del Email es incorrecto.");
                e.Cancel = true;
            }
            else
            {
                this.epEmail.SetError(this.tbEmail, "");
                e.Cancel = false;
            }
        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                MessageBox.Show("Se ha añadido el alumno correctamente");
            }
            else {
                MessageBox.Show("Algún campo es incorrecto");
            }
        }
    }
}
