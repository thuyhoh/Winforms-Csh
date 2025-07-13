using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loadTreeView();
        }

        void loadTreeView()
        {
            treeView1.NodeMouseClick += TreeView1_NodeMouseClick;
            TreeNode root1 = new TreeNode();
            root1.Text = "Root 1";

            TreeNode node1 = new TreeNode("node 1");
            root1.Nodes.Add(node1);
            TreeNode cnode1 = new TreeNode("child node 1");
            node1.Nodes.Add(cnode1);
            

            TreeNode root2 = new TreeNode();
            root2.Text = "Root 2";

            treeView1.Nodes.Add(root1);
            treeView1.Nodes.Add(root2);
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            MessageBox.Show("You clicked on: " + e.Node.Text, "Node Clicked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
