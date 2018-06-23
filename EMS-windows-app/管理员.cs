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
    }
}
