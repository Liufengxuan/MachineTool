using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            verDrill1.Click += verDrill1_Click;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           Random random = new Random();
            int i= random.Next(1, 4);

            switch (i)
            {
                case 1:this.BackColor = Color.White; break;
                case 2: this.BackColor = Color.Yellow; break;
                case 3: this.BackColor = Color.Blue; break;
                case 4: this.BackColor = Color.DarkRed; break;
            }
        }

        private void verDrill1_Click(object sender, EventArgs e)
        {
            verDrill1.IsActivate= !verDrill1.IsActivate;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axisDisplay1.AddTestData();
        }
    }
}
