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
        Form3 SNinput;
        Form2 ChildWindow;

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SNinput = new Form3();
            //SNinput.MdiParent = this;
            SNinput.FormClosed += SNinput_FormClosed; //close event
            SNinput.Show();

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

        private void SNinput_FormClosed(object sender, FormClosedEventArgs e) //corresponds to the close event above
        {
            this.serialNum = SNinput.serialNum;
            SNinput = null;
            ChildWindow = new Form2();
            ChildWindow.MdiParent = this;
            ChildWindow.serialNum = this.serialNum;
            ChildWindow.Show();
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeToolStripMenuItem_Click(object sender, EventArgs e)
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
