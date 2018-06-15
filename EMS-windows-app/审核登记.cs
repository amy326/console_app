using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EMS_windows_app
{
    public partial class 审核登记 : Form
    {
        public 审核登记()
        {
            InitializeComponent();
        }
        private void 审核登记_Load(object sender, EventArgs e)
        {
            审核意见richTextBox1.SelectionFont = new Font("宋体", 12, FontStyle.Bold);
            审核意见richTextBox1.SelectionColor = Color.Red;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(前期checkBox1.Checked == true)
            {
                MessageBox.Show("已选：前期");
            }          
        }

        private void 方案checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(方案checkBox2.CheckState == CheckState.Checked)
            {
                MessageBox.Show("已选：方案");
            }
        }

        private void 审核意见richTextBox1_TextChanged(object sender, EventArgs e)
        {
            审核意见richTextBox1.SelectionBullet = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show("是否同意:" + comboBox1.SelectedItem);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void 审核登记_Load_1(object sender, EventArgs e)
        {
            TreeNode tr1 = treeView1.Nodes.Add("设计二院");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("" + e.Node.Tag);
        }
    }
}
