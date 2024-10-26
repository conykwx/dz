using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnShowCalendar_Click(object sender, EventArgs e)
        {
            DTP.Focus();
            SendKeys.Send("%{DOWN}");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button1.Text = "Дата подтверждена: " + DTP.Value.ToString("dd.MM.yyyy");

            MessageBox.Show("Дата подтверждена: " + DTP.Value.ToString("dd.MM.yyyy"), "Подтверждение даты", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
