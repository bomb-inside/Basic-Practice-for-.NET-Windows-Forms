using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>

        public class Form1 : Form
        {
            public Button button1;
            public Form1()
            {
                button1 = new Button();
                button1.Size = new Size(40, 40);
                button1.Location = new Point(30, 30);
                button1.Text = "Click me";
                this.Controls.Add(button1);
                button1.Click += new EventHandler(button1_Click);
            }
            private void button1_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Hello World");
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
