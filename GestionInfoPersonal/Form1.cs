using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
