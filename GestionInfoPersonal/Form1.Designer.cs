﻿namespace GestionInfoPersonal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlPestanias = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.monthCalendarFeNaci = new System.Windows.Forms.MonthCalendar();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.lblEdad = new System.Windows.Forms.Label();
            this.cbxIncripcionSi = new System.Windows.Forms.CheckBox();
            this.cbxIncripcionNo = new System.Windows.Forms.CheckBox();
            this.blbPreguntaSuscripcion = new System.Windows.Forms.Label();
            this.checkedListBoxHobbies = new System.Windows.Forms.CheckedListBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.trackBarCalificacion = new System.Windows.Forms.TrackBar();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.tabControlPestanias.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlPestanias
            // 
            this.tabControlPestanias.Controls.Add(this.tabPage1);
            this.tabControlPestanias.Controls.Add(this.tabPage2);
            this.tabControlPestanias.Controls.Add(this.tabPage3);
            this.tabControlPestanias.Location = new System.Drawing.Point(19, 40);
            this.tabControlPestanias.Name = "tabControlPestanias";
            this.tabControlPestanias.SelectedIndex = 0;
            this.tabControlPestanias.Size = new System.Drawing.Size(756, 356);
            this.tabControlPestanias.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblEdad);
            this.tabPage1.Controls.Add(this.numericUpDownEdad);
            this.tabPage1.Controls.Add(this.lblFechaNacimiento);
            this.tabPage1.Controls.Add(this.monthCalendarFeNaci);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.lblDireccion);
            this.tabPage1.Controls.Add(this.txtEmail);
            this.tabPage1.Controls.Add(this.txtDireccion);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Controls.Add(this.lblNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(748, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Personales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbFemenino);
            this.panel1.Controls.Add(this.rbMasculino);
            this.panel1.Controls.Add(this.lblGenero);
            this.panel1.Location = new System.Drawing.Point(36, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Location = new System.Drawing.Point(17, 13);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(52, 16);
            this.lblGenero.TabIndex = 0;
            this.lblGenero.Text = "Genero";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(33, 142);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(118, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Correo Electrónico";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(30, 95);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Dirección";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 137);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(166, 90);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(187, 22);
            this.txtDireccion.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 22);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 40);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblSatisfaccion);
            this.tabPage2.Controls.Add(this.trackBarCalificacion);
            this.tabPage2.Controls.Add(this.lblPais);
            this.tabPage2.Controls.Add(this.comboBoxPais);
            this.tabPage2.Controls.Add(this.lblHobbies);
            this.tabPage2.Controls.Add(this.checkedListBoxHobbies);
            this.tabPage2.Controls.Add(this.blbPreguntaSuscripcion);
            this.tabPage2.Controls.Add(this.cbxIncripcionNo);
            this.tabPage2.Controls.Add(this.cbxIncripcionSi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(748, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preferencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(748, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Timer";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(40, 32);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(89, 20);
            this.rbMasculino.TabIndex = 1;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(40, 58);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(88, 20);
            this.rbFemenino.TabIndex = 2;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // monthCalendarFeNaci
            // 
            this.monthCalendarFeNaci.Enabled = false;
            this.monthCalendarFeNaci.Location = new System.Drawing.Point(516, 22);
            this.monthCalendarFeNaci.MaxSelectionCount = 1;
            this.monthCalendarFeNaci.Name = "monthCalendarFeNaci";
            this.monthCalendarFeNaci.TabIndex = 7;
            this.monthCalendarFeNaci.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarFeNaci_DateChanged);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(372, 40);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(132, 16);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(573, 277);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownEdad.TabIndex = 9;
            this.numericUpDownEdad.ValueChanged += new System.EventHandler(this.numericUpDownEdad_ValueChanged);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(497, 277);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // cbxIncripcionSi
            // 
            this.cbxIncripcionSi.AutoSize = true;
            this.cbxIncripcionSi.Location = new System.Drawing.Point(72, 57);
            this.cbxIncripcionSi.Name = "cbxIncripcionSi";
            this.cbxIncripcionSi.Size = new System.Drawing.Size(41, 20);
            this.cbxIncripcionSi.TabIndex = 0;
            this.cbxIncripcionSi.Text = "Sí";
            this.cbxIncripcionSi.UseVisualStyleBackColor = true;
            // 
            // cbxIncripcionNo
            // 
            this.cbxIncripcionNo.AutoSize = true;
            this.cbxIncripcionNo.Location = new System.Drawing.Point(72, 84);
            this.cbxIncripcionNo.Name = "cbxIncripcionNo";
            this.cbxIncripcionNo.Size = new System.Drawing.Size(47, 20);
            this.cbxIncripcionNo.TabIndex = 1;
            this.cbxIncripcionNo.Text = "No";
            this.cbxIncripcionNo.UseVisualStyleBackColor = true;
            // 
            // blbPreguntaSuscripcion
            // 
            this.blbPreguntaSuscripcion.AutoSize = true;
            this.blbPreguntaSuscripcion.Location = new System.Drawing.Point(24, 28);
            this.blbPreguntaSuscripcion.Name = "blbPreguntaSuscripcion";
            this.blbPreguntaSuscripcion.Size = new System.Drawing.Size(186, 16);
            this.blbPreguntaSuscripcion.TabIndex = 2;
            this.blbPreguntaSuscripcion.Text = "¿Quiere suscribirse al boletín?";
            // 
            // checkedListBoxHobbies
            // 
            this.checkedListBoxHobbies.FormattingEnabled = true;
            this.checkedListBoxHobbies.Items.AddRange(new object[] {
            "Deporte",
            "Pintura y Dibujo",
            "Escritura",
            "Manualidades",
            "Jardinería",
            "Cocina",
            "Danza",
            "Literatura"});
            this.checkedListBoxHobbies.Location = new System.Drawing.Point(42, 164);
            this.checkedListBoxHobbies.Name = "checkedListBoxHobbies";
            this.checkedListBoxHobbies.Size = new System.Drawing.Size(152, 140);
            this.checkedListBoxHobbies.TabIndex = 3;
            // 
            // lblHobbies
            // 
            this.lblHobbies.AutoSize = true;
            this.lblHobbies.Location = new System.Drawing.Point(15, 128);
            this.lblHobbies.Name = "lblHobbies";
            this.lblHobbies.Size = new System.Drawing.Size(217, 16);
            this.lblHobbies.TabIndex = 4;
            this.lblHobbies.Text = "Selecciona los hobbies e Intereses";
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Items.AddRange(new object[] {
            "Alemania",
            "Austria",
            "Francia",
            "Italia",
            "Reino Unido",
            "Rusia",
            "Japón",
            "Portugal",
            "España",
            "Polonia"});
            this.comboBoxPais.Location = new System.Drawing.Point(452, 57);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPais.TabIndex = 5;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.Location = new System.Drawing.Point(395, 28);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(203, 16);
            this.lblPais.TabIndex = 6;
            this.lblPais.Text = "Selecciona el país de residencia";
            // 
            // trackBarCalificacion
            // 
            this.trackBarCalificacion.Location = new System.Drawing.Point(466, 164);
            this.trackBarCalificacion.Name = "trackBarCalificacion";
            this.trackBarCalificacion.Size = new System.Drawing.Size(143, 56);
            this.trackBarCalificacion.TabIndex = 7;
            // 
            // lblSatisfaccion
            // 
            this.lblSatisfaccion.AutoSize = true;
            this.lblSatisfaccion.Location = new System.Drawing.Point(395, 128);
            this.lblSatisfaccion.Name = "lblSatisfaccion";
            this.lblSatisfaccion.Size = new System.Drawing.Size(312, 16);
            this.lblSatisfaccion.TabIndex = 8;
            this.lblSatisfaccion.Text = "Califica el nivel de satisfacción de nuestros servicio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControlPestanias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FormGeneral";
            this.tabControlPestanias.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalificacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPestanias;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.MonthCalendar monthCalendarFeNaci;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numericUpDownEdad;
        private System.Windows.Forms.CheckedListBox checkedListBoxHobbies;
        private System.Windows.Forms.Label blbPreguntaSuscripcion;
        private System.Windows.Forms.CheckBox cbxIncripcionNo;
        private System.Windows.Forms.CheckBox cbxIncripcionSi;
        private System.Windows.Forms.Label lblSatisfaccion;
        private System.Windows.Forms.TrackBar trackBarCalificacion;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.Label lblHobbies;
    }
}

