using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFitTimer_1
{
    public partial class Form1 : Form
    {

        int sec = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            string msg = "Time " + sec.ToString();

            MessageBox.Show(msg);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
        }
    }
}
