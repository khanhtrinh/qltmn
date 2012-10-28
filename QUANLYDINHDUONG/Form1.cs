using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void My_Key_Press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                MessageBox.Show("tyyt" + e.KeyChar);
                comboBox1.Focus();
            }
        }

        private void My_Key_Press1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && Control.ModifierKeys == Keys.Shift)
            {
                MessageBox.Show("back" + e.KeyChar);
                textBox1.Focus();
            }
        }
    }
}
