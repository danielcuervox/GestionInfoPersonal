namespace GestionInfoPersonal
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
            this.components = new System.ComponentModel.Container();
            this.tabControlPestanias = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEdad = new System.Windows.Forms.Label();
            this.numericUpDownEdad = new System.Windows.Forms.NumericUpDown();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.monthCalendarFeNaci = new System.Windows.Forms.MonthCalendar();
            this.panel1Genero = new System.Windows.Forms.Panel();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSuscricion = new System.Windows.Forms.Panel();
            this.cbxIncripcionSi = new System.Windows.Forms.CheckBox();
            this.cbxIncripcionNo = new System.Windows.Forms.CheckBox();
            this.lblSatisfaccion = new System.Windows.Forms.Label();
            this.trackBarCalificacion = new System.Windows.Forms.TrackBar();
            this.lblPais = new System.Windows.Forms.Label();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.lblHobbies = new System.Windows.Forms.Label();
            this.checkedListBoxHobbies = new System.Windows.Forms.CheckedListBox();
            this.blbPreguntaSuscripcion = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblSegundos = new System.Windows.Forms.Label();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.pboxFotoPerfil = new System.Windows.Forms.PictureBox();
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.brnSalir = new System.Windows.Forms.Button();
            this.tabControlPestanias.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).BeginInit();
            this.panel1Genero.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSuscricion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalificacion)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoPerfil)).BeginInit();
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
            this.tabPage1.Controls.Add(this.panel1Genero);
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
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(281, 200);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(40, 16);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // numericUpDownEdad
            // 
            this.numericUpDownEdad.Location = new System.Drawing.Point(271, 232);
            this.numericUpDownEdad.Name = "numericUpDownEdad";
            this.numericUpDownEdad.Size = new System.Drawing.Size(70, 22);
            this.numericUpDownEdad.TabIndex = 9;
            this.numericUpDownEdad.ValueChanged += new System.EventHandler(this.numericUpDownEdad_ValueChanged);
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(449, 40);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(132, 16);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // monthCalendarFeNaci
            // 
            this.monthCalendarFeNaci.Location = new System.Drawing.Point(452, 71);
            this.monthCalendarFeNaci.MaxSelectionCount = 1;
            this.monthCalendarFeNaci.Name = "monthCalendarFeNaci";
            this.monthCalendarFeNaci.TabIndex = 7;
            this.monthCalendarFeNaci.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarFeNaci_DateChanged);
            // 
            // panel1Genero
            // 
            this.panel1Genero.Controls.Add(this.rbFemenino);
            this.panel1Genero.Controls.Add(this.rbMasculino);
            this.panel1Genero.Controls.Add(this.lblGenero);
            this.panel1Genero.Location = new System.Drawing.Point(36, 200);
            this.panel1Genero.Name = "panel1Genero";
            this.panel1Genero.Size = new System.Drawing.Size(200, 100);
            this.panel1Genero.TabIndex = 6;
            this.panel1Genero.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(166, 90);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(187, 22);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(166, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(187, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
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
            this.tabPage2.Controls.Add(this.panelSuscricion);
            this.tabPage2.Controls.Add(this.lblSatisfaccion);
            this.tabPage2.Controls.Add(this.trackBarCalificacion);
            this.tabPage2.Controls.Add(this.lblPais);
            this.tabPage2.Controls.Add(this.comboBoxPais);
            this.tabPage2.Controls.Add(this.lblHobbies);
            this.tabPage2.Controls.Add(this.checkedListBoxHobbies);
            this.tabPage2.Controls.Add(this.blbPreguntaSuscripcion);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(748, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Preferencias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelSuscricion
            // 
            this.panelSuscricion.Controls.Add(this.cbxIncripcionSi);
            this.panelSuscricion.Controls.Add(this.cbxIncripcionNo);
            this.panelSuscricion.Location = new System.Drawing.Point(66, 47);
            this.panelSuscricion.Name = "panelSuscricion";
            this.panelSuscricion.Size = new System.Drawing.Size(85, 66);
            this.panelSuscricion.TabIndex = 9;
            this.panelSuscricion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuscricion_Paint);
            // 
            // cbxIncripcionSi
            // 
            this.cbxIncripcionSi.AutoSize = true;
            this.cbxIncripcionSi.Location = new System.Drawing.Point(22, 10);
            this.cbxIncripcionSi.Name = "cbxIncripcionSi";
            this.cbxIncripcionSi.Size = new System.Drawing.Size(41, 20);
            this.cbxIncripcionSi.TabIndex = 0;
            this.cbxIncripcionSi.Text = "Sí";
            this.cbxIncripcionSi.UseVisualStyleBackColor = true;
            this.cbxIncripcionSi.CheckedChanged += new System.EventHandler(this.cbxIncripcionSi_CheckedChanged);
            // 
            // cbxIncripcionNo
            // 
            this.cbxIncripcionNo.AutoSize = true;
            this.cbxIncripcionNo.Location = new System.Drawing.Point(22, 36);
            this.cbxIncripcionNo.Name = "cbxIncripcionNo";
            this.cbxIncripcionNo.Size = new System.Drawing.Size(47, 20);
            this.cbxIncripcionNo.TabIndex = 1;
            this.cbxIncripcionNo.Text = "No";
            this.cbxIncripcionNo.UseVisualStyleBackColor = true;
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
            // trackBarCalificacion
            // 
            this.trackBarCalificacion.Location = new System.Drawing.Point(466, 164);
            this.trackBarCalificacion.Name = "trackBarCalificacion";
            this.trackBarCalificacion.Size = new System.Drawing.Size(143, 56);
            this.trackBarCalificacion.TabIndex = 7;
            this.trackBarCalificacion.Scroll += new System.EventHandler(this.trackBarCalificacion_Scroll);
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
            this.comboBoxPais.SelectedIndexChanged += new System.EventHandler(this.comboBoxPais_SelectedIndexChanged);
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
            this.checkedListBoxHobbies.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxHobbies_SelectedIndexChanged);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSegundos);
            this.tabPage3.Controls.Add(this.lblHoraActual);
            this.tabPage3.Controls.Add(this.pboxFotoPerfil);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(748, 327);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Timer";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // lblSegundos
            // 
            this.lblSegundos.AutoSize = true;
            this.lblSegundos.Location = new System.Drawing.Point(253, 266);
            this.lblSegundos.Name = "lblSegundos";
            this.lblSegundos.Size = new System.Drawing.Size(75, 16);
            this.lblSegundos.TabIndex = 2;
            this.lblSegundos.Text = "Segundos: ";
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.Location = new System.Drawing.Point(359, 250);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(153, 51);
            this.lblHoraActual.TabIndex = 1;
            this.lblHoraActual.Text = "label1";
            this.lblHoraActual.Click += new System.EventHandler(this.lblHoraActual_Click);
            // 
            // pboxFotoPerfil
            // 
            this.pboxFotoPerfil.Image = global::GestionInfoPersonal.Properties.Resources._ca0d59ee_e62d_48b3_af4a_cec45b260a7b;
            this.pboxFotoPerfil.Location = new System.Drawing.Point(260, 6);
            this.pboxFotoPerfil.Name = "pboxFotoPerfil";
            this.pboxFotoPerfil.Size = new System.Drawing.Size(225, 217);
            this.pboxFotoPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxFotoPerfil.TabIndex = 0;
            this.pboxFotoPerfil.TabStop = false;
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Enabled = true;
            this.timerHoraActual.Interval = 1000;
            this.timerHoraActual.Tick += new System.EventHandler(this.timerHoraActual_Tick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(165, 425);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(307, 424);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // brnSalir
            // 
            this.brnSalir.Location = new System.Drawing.Point(460, 424);
            this.brnSalir.Name = "brnSalir";
            this.brnSalir.Size = new System.Drawing.Size(75, 23);
            this.brnSalir.TabIndex = 3;
            this.brnSalir.Text = "Salir";
            this.brnSalir.UseVisualStyleBackColor = true;
            this.brnSalir.Click += new System.EventHandler(this.brnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(810, 493);
            this.Controls.Add(this.brnSalir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tabControlPestanias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "FormGeneral";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlPestanias.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEdad)).EndInit();
            this.panel1Genero.ResumeLayout(false);
            this.panel1Genero.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panelSuscricion.ResumeLayout(false);
            this.panelSuscricion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarCalificacion)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxFotoPerfil)).EndInit();
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
        private System.Windows.Forms.Panel panel1Genero;
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
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.PictureBox pboxFotoPerfil;
        private System.Windows.Forms.Timer timerHoraActual;
        private System.Windows.Forms.Label lblSegundos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panelSuscricion;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button brnSalir;
    }
}

