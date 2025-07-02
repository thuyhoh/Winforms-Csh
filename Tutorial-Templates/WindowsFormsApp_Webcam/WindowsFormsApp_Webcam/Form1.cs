using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp_Webcam
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        public Form1()
        {
            InitializeComponent();
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo info in cameras)
            {
                comboBox1.Items.Add(info.Name); 
            }
            comboBox1.SelectedIndex = 0; // Select the first camera by default  

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cam != null && cam.IsRunning)
            {
                cam.SignalToStop();
                cam.WaitForStop();
                cam = null;
                button1.Text = "Start Camera";
            }
            else
            {
                if (cameras.Count > 0)
                {
                    cam = new VideoCaptureDevice(cameras[comboBox1.SelectedIndex].MonikerString);
                    cam.NewFrame += Cam_NewFrame;
                    cam.Start();
                    button1.Text = "Stop Camera";
                }
                else
                    MessageBox.Show("No camera found.");
                }
            }

        private void Cam_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //throw new NotImplementedException();
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            if (pictureBox1.InvokeRequired)
            {
                pictureBox1.Invoke(new MethodInvoker(() => pictureBox1.Image = frame));
            }
            else
            {
                pictureBox1.Image = frame;
            }

        }        

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "D:\\Program_Languages\\Csh-Winforms\\Winforms\\WindowsFormsApp_Webcam\\Photos";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }
    }
}
