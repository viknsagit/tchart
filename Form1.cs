using System;
using System.Windows.Forms;

namespace tchart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 5; i < 100; i++)
            {
                chart1.Series[0].Points.AddXY(i,i-5);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
        }
    }
}
