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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        审核登记 shenhe = new 审核登记(); //窗体也是对象，调用时需要创建对象

        private void Button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            shenhe.Show();  
        }      
        private void buttonhide_Click(object sender, EventArgs e)
        {
            shenhe.Close();
        }

        private void form1_file_Click(object sender, EventArgs e)
        {
            
        }

        private void form1_file_ButtonClick(object sender, EventArgs e)
        {

        }


        private void 关闭ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shenhe.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void form1_windows_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void 打开toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            审核登记 frm2 = new 审核登记();
            frm2.Show();
            frm2.MdiParent = this; //子窗体停留在父窗体中

            Form3 frm3 = new Form3();
            frm3.Show();
            frm3.MdiParent = this;

        }

        private void 关闭toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            shenhe.Close();
            
        }

        private void 垂直ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 水平ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)//用于点击时生成一个txt框
        {
            TextBox txt = new TextBox(); //创建对象txt
            txt.Location = new Point(0, 0);//初始化位置
            this.Controls.Add(txt);  // this.Controls指的是button这个控件，触发的事件是add新增
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton_admin_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_admin.Checked)
            {
                MessageBox.Show ("以管理员身份登录");
            }
        }

        private void radioButton_general_user_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton_general_user.Checked)
            {
                MessageBox.Show("以一般用户身份登录");
            }
        }

        private void LogIn_Load_1(object sender, EventArgs e)
        {
            
        }

        
    }
}
