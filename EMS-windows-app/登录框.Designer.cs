namespace EMS_windows_app
{
    partial class LogIn
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button_login = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radioButton_admin = new System.Windows.Forms.RadioButton();
            this.radioButton_general_user = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(58, 188);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(118, 36);
            this.button_login.TabIndex = 0;
            this.button_login.TabStop = false;
            this.button_login.Text = "登录";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.Click += new System.EventHandler(this.Button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 21);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "用户名：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(58, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "密码：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button_quit
            // 
            this.button_quit.Location = new System.Drawing.Point(200, 188);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(118, 36);
            this.button_quit.TabIndex = 9;
            this.button_quit.Text = "退出";
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(183, 21);
            this.textBox2.TabIndex = 10;
            // 
            // radioButton_admin
            // 
            this.radioButton_admin.AutoSize = true;
            this.radioButton_admin.Location = new System.Drawing.Point(61, 150);
            this.radioButton_admin.Name = "radioButton_admin";
            this.radioButton_admin.Size = new System.Drawing.Size(59, 16);
            this.radioButton_admin.TabIndex = 11;
            this.radioButton_admin.TabStop = true;
            this.radioButton_admin.Text = "管理员";
            this.radioButton_admin.UseVisualStyleBackColor = true;
            this.radioButton_admin.CheckedChanged += new System.EventHandler(this.radioButton_admin_CheckedChanged);
            // 
            // radioButton_general_user
            // 
            this.radioButton_general_user.AutoSize = true;
            this.radioButton_general_user.Location = new System.Drawing.Point(200, 150);
            this.radioButton_general_user.Name = "radioButton_general_user";
            this.radioButton_general_user.Size = new System.Drawing.Size(71, 16);
            this.radioButton_general_user.TabIndex = 12;
            this.radioButton_general_user.TabStop = true;
            this.radioButton_general_user.Text = "一般用户";
            this.radioButton_general_user.UseVisualStyleBackColor = true;
            this.radioButton_general_user.CheckedChanged += new System.EventHandler(this.radioButton_general_user_CheckedChanged);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.radioButton_general_user);
            this.Controls.Add(this.radioButton_admin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button_quit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_login);
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LogIn_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radioButton_admin;
        private System.Windows.Forms.RadioButton radioButton_general_user;
    }
}

