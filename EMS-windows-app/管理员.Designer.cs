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
            this.SuspendLayout();
            // 
            // openFileDialog1_管理员
            // 
            this.openFileDialog1_管理员.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_管理员_FileOk_1);
            // 
            // button1_导入数据
            // 
            this.button1_导入数据.Location = new System.Drawing.Point(84, 119);
            this.button1_导入数据.Name = "button1_导入数据";
            this.button1_导入数据.Size = new System.Drawing.Size(75, 23);
            this.button1_导入数据.TabIndex = 0;
            this.button1_导入数据.Text = "导入";
            this.button1_导入数据.UseVisualStyleBackColor = true;
            this.button1_导入数据.Click += new System.EventHandler(this.button1_导入数据_Click);
            // 
            // button1_导出数据
            // 
            this.button1_导出数据.Location = new System.Drawing.Point(248, 118);
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
            // 管理员
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 198);
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
    }
}