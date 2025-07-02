using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;


namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = { };
            if(SerialPort.GetPortNames().Length != 0)
            {
                ports = SerialPort.GetPortNames();
                cboCOM.Text = ports[0];
                cboCOM.Items.AddRange(ports);
            }
            string[] baudrate = { "9600", "115200" };
            cboBaudrate.Text = "9600";
            cboBaudrate.Items.AddRange(baudrate);
            string[] Databits = { "7", "8" };
            cboDatabits.Items.AddRange(Databits);
            cboDatabits.Text = "8"; 
            string[] Parity = { "None", "Even", "Odd" };
            cboParity.Text = "None";    
            cboParity.Items.AddRange(Parity);
        }

        private void btnDevice1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(button.Text == "ON")
            {
                button.Text = "OFF";
            }
            else
            {
                button.Text = "ON";
            }
        }
        private void btnDevice2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "ON")
            {
                button.Text = "OFF";
            }
            else
            {
                button.Text = "ON";
            }
        }

        private void btnDevice3_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "ON")
            {
                button.Text = "OFF";
            }
            else
            {
                button.Text = "ON";
            }
        }

        private void btnDevice4_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.Text == "ON")
            {
                button.Text = "OFF";
            }
            else
            {
                button.Text = "ON";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!serCOM.IsOpen)
            {
                if (SerialPort.GetPortNames().Length == 0)
                {
                    DialogResult result = MessageBox.Show("Please Connect COM port", "notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                serCOM.BaudRate = Convert.ToInt32(cboBaudrate.Text);
                serCOM.PortName = cboCOM.Text;
                serCOM.DataBits = Convert.ToInt32(cboDatabits.Text);
                if (cboParity.Text == "None")
                {
                    serCOM.Parity = Parity.None;
                }
                else if (cboParity.Text == "Even")
                {
                    serCOM.Parity = Parity.Even;
                }
                else if (cboParity.Text == "Odd")
                {
                    serCOM.Parity = Parity.Odd;
                }
                serCOM.Open();
                btnConnect.Text = "Connected";
                btnConnect.ForeColor = Color.Red;
            }
            else
            {
                btnConnect.Text = "Connect";
                btnConnect.ForeColor = Color.Green;
                serCOM.Close();
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(txSend.Text != "")
            {
                txSend.Text = "";
                serCOM.Write(txSend.Text);
            }  
        }

        private void serCOM_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            /*
             * Hàm nhận dữ liệu từ cổng COM
             */
            String AllData = serCOM.ReadExisting();

        }
    }
}
