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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form.
            newMDIChild.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            /*
            --Button Example--
            public Button button1;
            public Form1()
            {
                button1 = new Button();
                button1.Size = new Size(100, 100);
                button1.Location = new Point(50, 50);
                button1.Text = "Click me";
                this.Controls.Add(button1);
                button1.Click += new EventHandler(button1_Click);
            }
            private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Hello World");
            }
            */

            //protected void MDIChildNew_Click(object sender, System.EventArgs e)
            //{
            //Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            //newMDIChild.MdiParent = this;
            // Display the new form.
            //newMDIChild.Show();
            //}
        }

    }
}
