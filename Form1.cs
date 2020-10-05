using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public string serialNum = "";
        Form3 MDIChild1;
        Form2 MDIChild2;

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MDIChild1 = new Form3();
            //MDIChild1.MdiParent = this;
            MDIChild1.FormClosed += MDIChild1_FormClosed; //close event
            MDIChild1.Show();

            /*
            //Just creating a new window
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.
            newMDIChild.MdiParent = this;
            // Display the new form. : newMDIChild.Show();
            newMDIChild.Show();
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            */

        }

        private void MDIChild1_FormClosed(object sender, FormClosedEventArgs e) //corresponds to the close event above
        {
            this.serialNum = MDIChild1.serialNum;
            MDIChild1 = null;
            MDIChild2 = new Form2();
            MDIChild2.MdiParent = this;
            MDIChild2.serialNum = this.serialNum;
            MDIChild2.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        

        /*
        //--Button Example--
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

    }
}
