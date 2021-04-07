using System;
using MaterialSkin;
using System.Windows.Forms;
using MaterialSkin.Animations;
using MaterialSkin.Controls;
using MaterialSkin.Properties;

namespace tchart
{
    public partial class Form1 : MaterialForm
    {
        bool coords = true;
        public Form1()
        {
           InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Red400, Primary.Red400, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (coords == true)
            {
                for (int i = 0; i < 100; i++)
                {
                    graf.Series[0].Points.AddXY(i, i - 5);
                    coords = false;
                }
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            graf.Series[0].Points.Clear();
            coords = true;
        }
    }
}
