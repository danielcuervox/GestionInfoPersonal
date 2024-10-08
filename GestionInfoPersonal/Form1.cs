using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionInfoPersonal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //timerHoraActual_Tick().Start();
        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rbMasculino.Checked)
            {
                String genero = "masculino";
            }
            else if (rbMasculino.Checked) {
                String genero = "femenino";
            }

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendarFeNaci_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarFeNaci.RemoveAllBoldedDates();
            DateTime fNaci = e.Start;
            monthCalendarFeNaci.AddBoldedDate(fNaci);
            monthCalendarFeNaci.UpdateBoldedDates();

           

        }

        private void numericUpDownEdad_ValueChanged(object sender, EventArgs e)
        {
            decimal edad = numericUpDownEdad.Value;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void lblHoraActual_Click(object sender, EventArgs e)
        {
            
        }

        private void horaActual()
        {
            //return DateTime.Now.ToString("ss");
            //lblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("ss");
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
        //método que se llama al iniciar el formulario
        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.txtNombre, "Nombre del Usuario");
            this.toolTip1.SetToolTip(this.txtDireccion, "Nombre del Usuario");
            this.toolTip1.SetToolTip(this.txtEmail, "email del Usuario");
            this.toolTip1.SetToolTip(this.lblNombre, "email del Usuario");
            this.toolTip1.SetToolTip(this.lblDireccion, "Dirección del usuario");
            this.toolTip1.SetToolTip(this.lblEmail, "email del usuario");
            this.toolTip1.SetToolTip(this.panel1Genero, "selecciona el género");
            this.toolTip1.SetToolTip(this.lblEdad, "selecciona el género");
            this.toolTip1.SetToolTip(this.numericUpDownEdad, "selecciona tu edad");
            this.toolTip1.SetToolTip(this.lblFechaNacimiento, "selecciona tu fecha de nacimiento");
            this.toolTip1.SetToolTip(this.monthCalendarFeNaci, "selecciona tu fecha de nacimiento");
            this.toolTip1.SetToolTip(this.blbPreguntaSuscripcion, "te quieres suscribir?");
            this.toolTip1.SetToolTip(this.panelSuscricion, "te quieres suscribir?");
            this.toolTip1.SetToolTip(this.lblHobbies, "selecciona los pasatiempos");
            this.toolTip1.SetToolTip(this.checkedListBoxHobbies, "selecciona los pasatiempos");
            this.toolTip1.SetToolTip(this.lblPais, "selecciona tu país");
            this.toolTip1.SetToolTip(this.comboBoxPais, "selecciona tu país");
            this.toolTip1.SetToolTip(this.lblSatisfaccion, "cómo calificas nuestro servicio");
            this.toolTip1.SetToolTip(this.trackBarCalificacion, "cómo calificas nuestro servicio");
            this.toolTip1.SetToolTip(this.pboxFotoPerfil, "tu foto de perfil");
            this.toolTip1.SetToolTip(this.lblHoraActual, "los segundos de la hora actual");
            this.toolTip1.SetToolTip(this.lblSegundos, "los segundos de la hora actual");

        }

        private void cbxIncripcionSi_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtEmail.Text = string.Empty;
            rbMasculino.Checked = false;
            rbFemenino.Checked = false;
            numericUpDownEdad.Value = 0;
            DateTime dt = DateTime.Now;
            monthCalendarFeNaci.SetDate(dt);
            cbxIncripcionSi.Checked = false;
            cbxIncripcionNo.Checked = false;
            /*
            foreach(var i in checkedListBoxHobbies.CheckedItems)
            {
                int item = checkedListBoxHobbies.Items.IndexOf(i);
                checkedListBoxHobbies.SetItemChecked(item, false);
            }*/

            //foreach(var item in checkedListBoxHobbies.Items)
            //{
            //    checkedListBoxHobbies.Items.
            //}
            comboBoxPais.Text = string.Empty;   
            trackBarCalificacion.Value = 0;


        }

        private void brnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
