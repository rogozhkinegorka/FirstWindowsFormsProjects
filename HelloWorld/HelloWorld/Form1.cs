using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class ПРИВЕТСТВИЕ : Form
    {
        public ПРИВЕТСТВИЕ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.TextLength == 0 ? "Hello, World!" : $"Hello, {textBox1.Text}!";
        }
    }
}