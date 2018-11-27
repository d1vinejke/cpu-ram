using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            progressBar4.Value = (int)(performanceCounter1.NextValue());
            label4.Text = "Загрузка процессора: " + progressBar4.Value.ToString() + "%";
            progressBar5.Value = (int)(performanceCounter2.NextValue());
            label5.Text = "Загрузка памяти: " + progressBar5.Value.ToString() + "%";
            progressBar6.Value = (int)(performanceCounter3.NextValue());
            label6.Text = "Загрузка GPU: " + progressBar6.Value.ToString() + "%";
        }

        private void инфоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Empty");
        }

        private void контактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: ...");
        }
    }
}
