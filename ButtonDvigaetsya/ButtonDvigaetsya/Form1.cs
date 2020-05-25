using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonDvigaetsya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            if (buttonB.Right - buttonB.Width - buttonA.Right >= 20)
            {
                buttonA.Left += 10;
                buttonB.Left -= 10;
            }
            else if (buttonB.Right - buttonB.Width - buttonA.Right > 0)
            {
                buttonA.Left += (buttonB.Right - buttonB.Width - buttonA.Right) / 2;
                buttonB.Left -= (buttonB.Right - buttonB.Width - buttonA.Right);
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            if(buttonA.Right-buttonA.Width >= 10)
                buttonA.Left -= 10;
            else if(buttonA.Right - buttonA.Width > 0)
                buttonA.Left -= (buttonA.Right-buttonA.Width);
            if (this.ClientSize.Width-buttonB.Right >= 10)
                buttonB.Left += 10;
            else if (this.ClientSize.Width-buttonB.Right > 0)
                buttonB.Left += this.ClientSize.Width-buttonB.Right;
        }
    }
}
