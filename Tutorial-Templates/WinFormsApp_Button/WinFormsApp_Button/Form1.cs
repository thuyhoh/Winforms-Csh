namespace WinFormsApp_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 1 clicked!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2 clicked!");
        }
    }
}
