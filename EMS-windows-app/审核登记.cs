using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            toolStripStatusLabel2.Text = DateTime.Now.ToString();

            //以下代码如果放richTextBox则无法显示
            //实例化数据库连接对象
            SqlConnection sqlcon = new SqlConnection("Server  = CA9A; User Id = sa; Pwd = Amy7895123; DataBase = amy");
            //实例化command对象
            SqlCommand sqlcmd = new SqlCommand("select * from dbo.审核信息 where 归属部门 = '设计一院'", sqlcon);
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            richTextBox1.Text = "项目编号      子公司编号      项目经理\n"; //为文本框赋初始值
            try
            {
                if (sqldr.HasRows)//判断sqlDateReader对象是否有数据
                {
                    while (sqldr.Read())
                    {
                        //显示读取的详细信息
                        richTextBox1.Text += "" + sqldr["项目编号"] + "     " + sqldr["子公司编号"] + "     " + sqldr["项目经理"] + "\n";
                    }
                }
            }

            catch (SqlException ex) // 捕获数据库异常
            {
                MessageBox.Show(ex.ToString()); //输出异常信息
            }
            finally
            {
                sqldr.Close();//关闭sqldateReader对象
                sqlcon.Close(); //关闭数据库连接
            }






        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show("" + e.Node.Tag);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

           

            
        }
    }
}
