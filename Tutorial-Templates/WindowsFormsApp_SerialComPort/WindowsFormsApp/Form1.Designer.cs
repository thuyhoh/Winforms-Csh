namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDevice4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDevice3 = new System.Windows.Forms.Button();
            this.btnDevice2 = new System.Windows.Forms.Button();
            this.btnDevice1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txSend = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbGasVal = new System.Windows.Forms.Label();
            this.lbTempVal = new System.Windows.Forms.Label();
            this.lbHumVal = new System.Windows.Forms.Label();
            this.lbAllDataVal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbAllData = new System.Windows.Forms.Label();
            this.lbTemp = new System.Windows.Forms.Label();
            this.lbHum = new System.Windows.Forms.Label();
            this.lbCOM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDatabits = new System.Windows.Forms.Label();
            this.cboCOM = new System.Windows.Forms.ComboBox();
            this.cboBaudrate = new System.Windows.Forms.ComboBox();
            this.cboDatabits = new System.Windows.Forms.ComboBox();
            this.lbParity = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnDevice4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnDevice3);
            this.groupBox1.Controls.Add(this.btnDevice2);
            this.groupBox1.Controls.Add(this.btnDevice1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.groupBox1.Location = new System.Drawing.Point(12, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(364, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Device4";
            // 
            // btnDevice4
            // 
            this.btnDevice4.AutoSize = true;
            this.btnDevice4.Location = new System.Drawing.Point(216, 169);
            this.btnDevice4.Name = "btnDevice4";
            this.btnDevice4.Size = new System.Drawing.Size(87, 35);
            this.btnDevice4.TabIndex = 6;
            this.btnDevice4.Text = "ON";
            this.btnDevice4.UseVisualStyleBackColor = true;
            this.btnDevice4.Click += new System.EventHandler(this.btnDevice4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Device3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Device2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Device1";
            // 
            // btnDevice3
            // 
            this.btnDevice3.AutoSize = true;
            this.btnDevice3.Location = new System.Drawing.Point(216, 121);
            this.btnDevice3.Name = "btnDevice3";
            this.btnDevice3.Size = new System.Drawing.Size(87, 35);
            this.btnDevice3.TabIndex = 2;
            this.btnDevice3.Text = "ON";
            this.btnDevice3.UseVisualStyleBackColor = true;
            this.btnDevice3.Click += new System.EventHandler(this.btnDevice3_Click);
            // 
            // btnDevice2
            // 
            this.btnDevice2.AutoSize = true;
            this.btnDevice2.Location = new System.Drawing.Point(216, 75);
            this.btnDevice2.Name = "btnDevice2";
            this.btnDevice2.Size = new System.Drawing.Size(87, 35);
            this.btnDevice2.TabIndex = 1;
            this.btnDevice2.Text = "ON";
            this.btnDevice2.UseVisualStyleBackColor = true;
            this.btnDevice2.Click += new System.EventHandler(this.btnDevice2_Click);
            // 
            // btnDevice1
            // 
            this.btnDevice1.AutoSize = true;
            this.btnDevice1.Location = new System.Drawing.Point(216, 29);
            this.btnDevice1.Name = "btnDevice1";
            this.btnDevice1.Size = new System.Drawing.Size(87, 35);
            this.btnDevice1.TabIndex = 0;
            this.btnDevice1.Text = "ON";
            this.btnDevice1.UseVisualStyleBackColor = true;
            this.btnDevice1.Click += new System.EventHandler(this.btnDevice1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(255, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESP32 WinformsApp";
            // 
            // btnConnect
            // 
            this.btnConnect.AutoSize = true;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.Green;
            this.btnConnect.Location = new System.Drawing.Point(422, 384);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(159, 39);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = true;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(616, 384);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 39);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txSend
            // 
            this.txSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txSend.Location = new System.Drawing.Point(439, 324);
            this.txSend.Name = "txSend";
            this.txSend.Size = new System.Drawing.Size(243, 32);
            this.txSend.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Blue;
            this.btnSend.Location = new System.Drawing.Point(703, 322);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(72, 35);
            this.btnSend.TabIndex = 5;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serCOM_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbGasVal);
            this.groupBox3.Controls.Add(this.lbTempVal);
            this.groupBox3.Controls.Add(this.lbHumVal);
            this.groupBox3.Controls.Add(this.lbAllDataVal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbAllData);
            this.groupBox3.Controls.Add(this.lbTemp);
            this.groupBox3.Controls.Add(this.lbHum);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.groupBox3.Location = new System.Drawing.Point(12, 292);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(364, 158);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data";
            // 
            // lbGasVal
            // 
            this.lbGasVal.AutoSize = true;
            this.lbGasVal.Location = new System.Drawing.Point(115, 120);
            this.lbGasVal.Name = "lbGasVal";
            this.lbGasVal.Size = new System.Drawing.Size(23, 25);
            this.lbGasVal.TabIndex = 7;
            this.lbGasVal.Text = "0";
            // 
            // lbTempVal
            // 
            this.lbTempVal.AutoSize = true;
            this.lbTempVal.Location = new System.Drawing.Point(115, 86);
            this.lbTempVal.Name = "lbTempVal";
            this.lbTempVal.Size = new System.Drawing.Size(23, 25);
            this.lbTempVal.TabIndex = 6;
            this.lbTempVal.Text = "0";
            // 
            // lbHumVal
            // 
            this.lbHumVal.AutoSize = true;
            this.lbHumVal.Location = new System.Drawing.Point(115, 57);
            this.lbHumVal.Name = "lbHumVal";
            this.lbHumVal.Size = new System.Drawing.Size(23, 25);
            this.lbHumVal.TabIndex = 5;
            this.lbHumVal.Text = "0";
            // 
            // lbAllDataVal
            // 
            this.lbAllDataVal.AutoSize = true;
            this.lbAllDataVal.Location = new System.Drawing.Point(115, 32);
            this.lbAllDataVal.Name = "lbAllDataVal";
            this.lbAllDataVal.Size = new System.Drawing.Size(23, 25);
            this.lbAllDataVal.TabIndex = 4;
            this.lbAllDataVal.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gas:";
            // 
            // lbAllData
            // 
            this.lbAllData.AutoSize = true;
            this.lbAllData.Location = new System.Drawing.Point(23, 29);
            this.lbAllData.Name = "lbAllData";
            this.lbAllData.Size = new System.Drawing.Size(86, 25);
            this.lbAllData.TabIndex = 2;
            this.lbAllData.Text = "All Data:";
            // 
            // lbTemp
            // 
            this.lbTemp.AutoSize = true;
            this.lbTemp.Location = new System.Drawing.Point(23, 83);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(69, 25);
            this.lbTemp.TabIndex = 1;
            this.lbTemp.Text = "Temp:";
            // 
            // lbHum
            // 
            this.lbHum.AutoSize = true;
            this.lbHum.Location = new System.Drawing.Point(23, 54);
            this.lbHum.Name = "lbHum";
            this.lbHum.Size = new System.Drawing.Size(59, 25);
            this.lbHum.TabIndex = 0;
            this.lbHum.Text = "Hum:";
            // 
            // lbCOM
            // 
            this.lbCOM.AutoSize = true;
            this.lbCOM.Location = new System.Drawing.Point(22, 39);
            this.lbCOM.Name = "lbCOM";
            this.lbCOM.Size = new System.Drawing.Size(66, 25);
            this.lbCOM.TabIndex = 0;
            this.lbCOM.Text = "COM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baudrate:";
            // 
            // lbDatabits
            // 
            this.lbDatabits.AutoSize = true;
            this.lbDatabits.Location = new System.Drawing.Point(22, 135);
            this.lbDatabits.Name = "lbDatabits";
            this.lbDatabits.Size = new System.Drawing.Size(94, 25);
            this.lbDatabits.TabIndex = 2;
            this.lbDatabits.Text = "Data bits:";
            // 
            // cboCOM
            // 
            this.cboCOM.FormattingEnabled = true;
            this.cboCOM.Location = new System.Drawing.Point(199, 39);
            this.cboCOM.Name = "cboCOM";
            this.cboCOM.Size = new System.Drawing.Size(121, 33);
            this.cboCOM.TabIndex = 3;
            // 
            // cboBaudrate
            // 
            this.cboBaudrate.FormattingEnabled = true;
            this.cboBaudrate.Location = new System.Drawing.Point(199, 85);
            this.cboBaudrate.Name = "cboBaudrate";
            this.cboBaudrate.Size = new System.Drawing.Size(121, 33);
            this.cboBaudrate.TabIndex = 4;
            // 
            // cboDatabits
            // 
            this.cboDatabits.FormattingEnabled = true;
            this.cboDatabits.Location = new System.Drawing.Point(199, 135);
            this.cboDatabits.Name = "cboDatabits";
            this.cboDatabits.Size = new System.Drawing.Size(121, 33);
            this.cboDatabits.TabIndex = 5;
            // 
            // lbParity
            // 
            this.lbParity.AutoSize = true;
            this.lbParity.Location = new System.Drawing.Point(22, 184);
            this.lbParity.Name = "lbParity";
            this.lbParity.Size = new System.Drawing.Size(67, 25);
            this.lbParity.TabIndex = 6;
            this.lbParity.Text = "Parity:";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(199, 181);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(121, 33);
            this.cboParity.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboParity);
            this.groupBox2.Controls.Add(this.lbParity);
            this.groupBox2.Controls.Add(this.cboDatabits);
            this.groupBox2.Controls.Add(this.cboBaudrate);
            this.groupBox2.Controls.Add(this.cboCOM);
            this.groupBox2.Controls.Add(this.lbDatabits);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lbCOM);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(395, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(393, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Set up";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txSend);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txSend;
        private System.Windows.Forms.Button btnSend;
        private System.IO.Ports.SerialPort serCOM;
        private System.Windows.Forms.Button btnDevice3;
        private System.Windows.Forms.Button btnDevice2;
        private System.Windows.Forms.Button btnDevice1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbTemp;
        private System.Windows.Forms.Label lbHum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbAllData;
        private System.Windows.Forms.Label lbGasVal;
        private System.Windows.Forms.Label lbTempVal;
        private System.Windows.Forms.Label lbHumVal;
        private System.Windows.Forms.Label lbAllDataVal;
        private System.Windows.Forms.Label lbCOM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDatabits;
        private System.Windows.Forms.ComboBox cboCOM;
        private System.Windows.Forms.ComboBox cboBaudrate;
        private System.Windows.Forms.ComboBox cboDatabits;
        private System.Windows.Forms.Label lbParity;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDevice4;
    }
}

