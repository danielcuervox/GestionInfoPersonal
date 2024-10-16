﻿using System;
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

        String nombre;
        String direcion;
        String email;
        String genero;
        decimal edad;
        String fechaNaci;
        String suscripcion;
        List<String> pasatiempos = new List<string>();
        String pais;
        int nivelSatisfaccion;


        public Form1()
        {
            InitializeComponent();
           
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

        // ---------------------- PRIMERA ETIQUETA ----------------
        //nNOMBRE
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
        }

        //GÉNERO
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (rbMasculino.Checked)
            {
                genero = rbMasculino.Text;
            }
            else if (rbFemenino.Checked) {
                genero = rbFemenino.Text;
            }

        }
        
        //FECHA DE NACIMIENTO
        private void monthCalendarFeNaci_DateChanged(object sender, DateRangeEventArgs e)
        {
            monthCalendarFeNaci.RemoveAllBoldedDates();
            DateTime fNaci = e.Start;
            monthCalendarFeNaci.AddBoldedDate(fNaci);
            monthCalendarFeNaci.UpdateBoldedDates();

            fechaNaci = fNaci.ToShortDateString();

        }

        //EDAD
        private void numericUpDownEdad_ValueChanged(object sender, EventArgs e)
        {
            edad = numericUpDownEdad.Value;
        }

        //EMAIL
        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            email = txtEmail.Text;
        }

        //DIRECCION
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            direcion = txtDireccion.Text;
        }

        // ---------------------- SEGUNDO ETIQUETA ----------------

        private void timerHoraActual_Tick(object sender, EventArgs e)
        {
            lblHoraActual.Text = DateTime.Now.ToString("ss");
        }

        private void panelSuscricion_Paint(object sender, PaintEventArgs e)
        {
            if (cbxIncripcionNo.Checked)
            {
                suscripcion = cbxIncripcionSi.Text;
            }
            else
            {
                suscripcion = txtDireccion.Text;
            }


        }


        // ---------------------- TERCERA ETIQUETA - BOTONES ----------------
        //BOTÓN DE GUARDAR
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            direcion = txtDireccion.Text;
            email = txtEmail.Text;
            
            if(rbMasculino.Checked)
            {
                genero = rbMasculino.Text;
            }
            else
            {
                genero = rbFemenino.Text;
            }

            int edad = int.Parse(numericUpDownEdad.Value.ToString());

            //guardar primero en un DAteTime y luego a la variable tipo String
            DateTime fechaNacimiento = monthCalendarFeNaci.SelectionStart;
            fechaNaci = fechaNacimiento.ToShortDateString();

            suscripcion = cbxIncripcionSi.Text;

            //recorre la lista de los items chequeados en la checedlistbox y lso almacena en la lista
            pasatiempos.Clear();
            foreach (var item in checkedListBoxHobbies.CheckedItems)
            {
                pasatiempos.Add(item.ToString());
            }

            pais = comboBoxPais.Text;
            nivelSatisfaccion = trackBarCalificacion.Value;

            Usuario encuesta = new Usuario(nombre, direcion, email, genero, edad, fechaNaci, suscripcion, pasatiempos, pais, nivelSatisfaccion);

            MessageBox.Show(encuesta.mostrarInfo());
            

        }
        //BOTÓN DE LIMPIAR
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
            
            //para desmarcar los items del checkedbox list
            for(int i = 0; i < checkedListBoxHobbies.Items.Count; i++)
            {
                checkedListBoxHobbies.SetItemChecked(i, false);
            }
            comboBoxPais.Text = string.Empty;   
            trackBarCalificacion.Value = 0;

        }
        //BOTÓN DE CERRAR
        private void brnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        

        

        
        private void tabPage3_Click(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        private void checkedListBoxHobbies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void lblHoraActual_Click(object sender, EventArgs e)
        {

        }
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void cbxIncripcionSi_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void horaActual()
        {
            //return DateTime.Now.ToString("ss");
            //lblHoraActual.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void comboBoxPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBarCalificacion_Scroll(object sender, EventArgs e)
        {

        }
    }
}
