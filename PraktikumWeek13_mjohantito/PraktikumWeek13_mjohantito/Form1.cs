using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PraktikumWeek13_mjohantito
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            if (labelHasil.Text == "[EMPTY]")
            {
                labelHasil.Text = textBoxInput.Text;
            }
            else if (labelHasil.Text != "[EMPTY]" && textBoxInput.Text == "DELETE")
            {
                labelHasil.Text = "[EMPTY]";
                labelHasil.ForeColor = Color.Black;
            }
            else if (labelHasil.Text != "[EMPTY]" && textBoxInput.Text == "HIDE")
            {
                labelHasil.Visible = false;
            }
            else if (labelHasil.Text != "[EMPTY]" && textBoxInput.Text == "SHOWN")
            {
                labelHasil.Visible = true;
            }
            else if (labelHasil.Text != "[EMPTY]" && textBoxInput.Text == "RED")
            {
                labelHasil.ForeColor = Color.Red;
            }
            else if (labelHasil.Text != "[EMPTY]" && textBoxInput.Text == "GREEN")
            {
                labelHasil.ForeColor = Color.Green;
            }
            else if (labelHasil.Text != "[EMPTY]" && textBoxInput.Text == "BLUE")
            {
                labelHasil.ForeColor = Color.Blue;
            }
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonProses_Click(sender, e);
            }
        }
    }
}
