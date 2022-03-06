using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLife
{
    public partial class SeedSettings : Form
    {
        public SeedSettings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
                numSelect.Enabled = true;
            }
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton2.Checked = true;
                radioButton1.Checked = false;
                numSelect.Enabled = false;
            }
        }
    }
}
