namespace EMS_windows_app
{
    partial class 管理员
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
            this.openFileDialog1_管理员 = new System.Windows.Forms.OpenFileDialog();
            this.button1_导入数据 = new System.Windows.Forms.Button();
            this.button1_导出数据 = new System.Windows.Forms.Button();
            this.saveFileDialog1_管理员 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1_管理员添加 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1_管理员添加 = new System.Windows.Forms.TextBox();
            this.textBox2_管理员添加 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1_管理员
            // 
            this.openFileDialog1_管理员.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_管理员_FileOk_1);
            // 
            // button1_导入数据
            // 
            this.button1_导入数据.Location = new System.Drawing.Point(49, 170);
            this.button1_导入数据.Name = "button1_导入数据";
            this.button1_导入数据.Size = new System.Drawing.Size(75, 23);
            this.button1_导入数据.TabIndex = 0;
            this.button1_导入数据.Text = "导入";
            this.button1_导入数据.UseVisualStyleBackColor = true;
            this.button1_导入数据.Click += new System.EventHandler(this.button1_导入数据_Click);
            // 
            // button1_导出数据
            // 
            this.button1_导出数据.Location = new System.Drawing.Point(149, 170);
            this.button1_导出数据.Name = "button1_导出数据";
            this.button1_导出数据.Size = new System.Drawing.Size(75, 23);
            this.button1_导出数据.TabIndex = 1;
            this.button1_导出数据.Text = "导出";
            this.button1_导出数据.UseVisualStyleBackColor = true;
            this.button1_导出数据.Click += new System.EventHandler(this.button1_导出数据_Click);
            // 
            // saveFileDialog1_管理员
            // 
            this.saveFileDialog1_管理员.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_管理员_FileOk);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1_管理员添加
            // 
            this.button1_管理员添加.Location = new System.Drawing.Point(361, 111);
            this.button1_管理员添加.Name = "button1_管理员添加";
            this.button1_管理员添加.Size = new System.Drawing.Size(75, 23);
            this.button1_管理员添加.TabIndex = 4;
            this.button1_管理员添加.Text = "添加";
            this.button1_管理员添加.UseVisualStyleBackColor = true;
            this.button1_管理员添加.Click += new System.EventHandler(this.button1_管理员添加_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "项目编号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(277, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "项目经理";
            // 
            // textBox1_管理员添加
            // 
            this.textBox1_管理员添加.Location = new System.Drawing.Point(336, 21);
            this.textBox1_管理员添加.Name = "textBox1_管理员添加";
            this.textBox1_管理员添加.Size = new System.Drawing.Size(100, 21);
            this.textBox1_管理员添加.TabIndex = 7;
            // 
            // textBox2_管理员添加
            // 
            this.textBox2_管理员添加.Location = new System.Drawing.Point(337, 63);
            this.textBox2_管理员添加.Name = "textBox2_管理员添加";
            this.textBox2_管理员添加.Size = new System.Drawing.Size(100, 21);
            this.textBox2_管理员添加.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "label5";
            // 
            // 管理员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 238);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2_管理员添加);
            this.Controls.Add(this.textBox1_管理员添加);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1_管理员添加);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1_导出数据);
            this.Controls.Add(this.button1_导入数据);
            this.Name = "管理员";
            this.Text = "管理员";
            this.Load += new System.EventHandler(this.管理员_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1_管理员;
        private System.Windows.Forms.Button button1_导入数据;
        private System.Windows.Forms.Button button1_导出数据;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1_管理员;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1_管理员添加;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1_管理员添加;
        private System.Windows.Forms.TextBox textBox2_管理员添加;
        private System.Windows.Forms.Label label5;
    }
}