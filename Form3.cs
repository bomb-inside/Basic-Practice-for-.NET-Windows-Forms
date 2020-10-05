using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string serialNum = "";

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialNumIn();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                e.Handled = true; // No sound when pressing enter key
                SerialNumIn();
            }
        }

        private void SerialNumIn()
        {
            if (this.textBox1.Text != "")
            {
                serialNum = textBox1.Text;
                Close();
            }

            else
            {
                MessageBox.Show("Error : Empty", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }
        }
    }
}
