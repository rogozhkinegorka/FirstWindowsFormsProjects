using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Praktika16_ili_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void Do_Click(object sender, EventArgs e)
        {
            try
            {
                Class1 Number = new Class1(Binary_number.Text);
                if (radioButton1.Checked == true) textBox2.Text = Number.Perevod(8);
                if (radioButton2.Checked == true) textBox2.Text = Number.Perevod(10);
                if (radioButton3.Checked == true) textBox2.Text = Number.Perevod(16);
            }
            catch (Exception ex)
            {
                textBox2.Text = "ошибка";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
