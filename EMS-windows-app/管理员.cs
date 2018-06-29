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
    public partial class 管理员 : Form
    {
        public 管理员()
        {
            InitializeComponent();
        }

        private void openFileDialog1_管理员_FileOk_1(object sender, CancelEventArgs e)
        {
            
        }

        private void 管理员_Load(object sender, EventArgs e)
        {
            string SqlStr = "Server = CA9A; User Id = sa; Pwd = Amy7895123; DataBase = amy"; // user id 一般是sa；如果用户名或者server名字有斜杠的话，记得多输入一个“\”，反斜杠
            SqlConnection con = new SqlConnection(SqlStr);
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                label1.Text = "sql已连接";
                con.Close();
            }

            if (con.State == ConnectionState.Closed)
            {
                label2.Text = "sql已断开";
            }

        }

        private void button1_导入数据_Click(object sender, EventArgs e)
        {
            openFileDialog1_管理员.InitialDirectory = "c:\\";
            openFileDialog1_管理员.Filter = "文本文件(*.txt)|*.txt|Word文件(*.doc)|*.doc"; //只能打开文本文件和
            openFileDialog1_管理员.ShowDialog();
        }

        private void button1_导出数据_Click(object sender, EventArgs e)
        {
            saveFileDialog1_管理员.Filter = "所有文件(*.*)|*.*";
            saveFileDialog1_管理员.ShowDialog();
        }

        private void saveFileDialog1_管理员_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_管理员添加_Click(object sender, EventArgs e)
        {
            
            //实例化数据库连接对象
            SqlConnection con = new SqlConnection("Server = CA9A; User Id = sa; Pwd = Amy7895123; DataBase = amy ");

            //定义添加数据库的sql语句
            string strsql = "insert into dbo.审核信息(项目编号, 项目经理) values('" + textBox1_管理员添加.Text + "', '" + Convert.ToString(textBox2_管理员添加.Text) + "')" ;
            SqlCommand comm = new SqlCommand(strsql, con); // 实例化sqlcommand对象

            if(con.State == ConnectionState.Closed)//判断连接是否关闭
            {
                con.Open();//打开数据库
            }
            
            //判断ExecuteNonQuery方法返回值是否大于0，如果大于0则表示数据添加成功
            if( Convert.ToInt32( comm.ExecuteNonQuery()) > 0 )
            {
                label5.Text = "添加成功";
            }

            else
            {
                label5.Text = "添加失败";
            }

            con.Close();
        }
    }
}
