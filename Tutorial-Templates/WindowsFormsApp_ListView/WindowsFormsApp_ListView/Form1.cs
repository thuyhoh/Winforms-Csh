using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp_ListView
{
    public partial class Form1 : Form
    {

        ImageList SmallImageList;
        ImageList LargeImageList;

        public Form1()
        {
            InitializeComponent();
            loadImageLists();
            loadListView();
        }

        void loadImageLists()
        {
            SmallImageList = new ImageList() { ImageSize = new Size(16,16)};
           SmallImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\1.png"));
            SmallImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\2.png"));
            SmallImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\3.png"));

            LargeImageList = new ImageList() { ImageSize = new Size(68, 68) };
            LargeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\1.png"));
            LargeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\2.png"));
            LargeImageList.Images.Add(new Bitmap(Application.StartupPath + "\\Images\\3.png"));
        }

        void loadListView()
        {
            listView1.Columns.Add("Columns 1", 100);
            listView1.Columns.Add("Columns 2", 100);
            listView1.Columns.Add("Columns 3", 100);

            listView1.FullRowSelect = true;

            ListViewItem item1 = new ListViewItem("Item 1");  
            item1.ImageIndex = 0; // Set the image index for the first item
            item1.SubItems.Add("1 SubItem 1");
            item1.SubItems.Add("1 SubItem 2");
            listView1.Items.Add(item1);

            ListViewItem item2 = new ListViewItem("Item 2");
            item2.ImageIndex = 1; // Set the image index for the second item
            item2.SubItems.Add("2 SubItem 1");
            item2.SubItems.Add("2 SubItem 2");
            listView1.Items.Add(item2);

            ListViewItem item3 = new ListViewItem("Item 3");
            item3.ImageIndex = 2; // Set the image index for the third item
            item3.SubItems.Add("2 SubItem 1");
            item3.SubItems.Add("2 SubItem 2");
            listView1.Items.Add(item3);
        }

        void button1_Click(object sender, EventArgs e)
        {
            listView1.View = View.SmallIcon;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.View = View.Details;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lv = sender as System.Windows.Forms.ListView;

            if (lv.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lv.SelectedItems)
                {
                    MessageBox.Show("Selected Item: " + item.Text);
                }
            }
        }
    }
}
