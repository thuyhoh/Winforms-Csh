using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_Picturebox.Properties;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp_Picturebox
{
    public partial class Form1 : Form
    {
        public Form1()  
        {
            InitializeComponent();
            LoadImageName();
        }

        void LoadImageName()
        {
            List<string> ListImage = new List<string>() { "1", "2", "3" };
            comboBox1.DataSource = ListImage;
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;

            if (cb.SelectedValue != null)
            {
                string path = System.Windows.Forms.Application.StartupPath + "\\Resources\\" + cb.SelectedValue + ".jpg";
                Bitmap bm = new Bitmap(System.Windows.Forms.Application.StartupPath + "\\Resources\\" + cb.SelectedValue.ToString() + ".jpg");
                pictureBox1.Image = bm;
            }
        }
    }
}
