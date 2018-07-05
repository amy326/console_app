namespace EMS_windows_app
{
    partial class 审核登记
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(审核登记));
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("道路交通");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("给排水");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("结构");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("设计一院", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("总工办");
            this.前期checkBox1 = new System.Windows.Forms.CheckBox();
            this.方案checkBox2 = new System.Windows.Forms.CheckBox();
            this.初步设计checkBox3 = new System.Windows.Forms.CheckBox();
            this.施工图checkBox4 = new System.Windows.Forms.CheckBox();
            this.审核意见richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // 前期checkBox1
            // 
            this.前期checkBox1.AutoSize = true;
            this.前期checkBox1.Location = new System.Drawing.Point(81, 30);
            this.前期checkBox1.Name = "前期checkBox1";
            this.前期checkBox1.Size = new System.Drawing.Size(48, 16);
            this.前期checkBox1.TabIndex = 0;
            this.前期checkBox1.Text = "前期";
            this.前期checkBox1.UseVisualStyleBackColor = true;
            this.前期checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // 方案checkBox2
            // 
            this.方案checkBox2.AutoSize = true;
            this.方案checkBox2.Location = new System.Drawing.Point(246, 30);
            this.方案checkBox2.Name = "方案checkBox2";
            this.方案checkBox2.Size = new System.Drawing.Size(48, 16);
            this.方案checkBox2.TabIndex = 1;
            this.方案checkBox2.Text = "方案";
            this.方案checkBox2.UseVisualStyleBackColor = true;
            this.方案checkBox2.CheckedChanged += new System.EventHandler(this.方案checkBox2_CheckedChanged);
            // 
            // 初步设计checkBox3
            // 
            this.初步设计checkBox3.AutoSize = true;
            this.初步设计checkBox3.Location = new System.Drawing.Point(12, 61);
            this.初步设计checkBox3.Name = "初步设计checkBox3";
            this.初步设计checkBox3.Size = new System.Drawing.Size(72, 16);
            this.初步设计checkBox3.TabIndex = 2;
            this.初步设计checkBox3.Text = "初步设计";
            this.初步设计checkBox3.UseVisualStyleBackColor = true;
            // 
            // 施工图checkBox4
            // 
            this.施工图checkBox4.AutoSize = true;
            this.施工图checkBox4.Location = new System.Drawing.Point(99, 61);
            this.施工图checkBox4.Name = "施工图checkBox4";
            this.施工图checkBox4.Size = new System.Drawing.Size(60, 16);
            this.施工图checkBox4.TabIndex = 3;
            this.施工图checkBox4.Text = "施工图";
            this.施工图checkBox4.UseVisualStyleBackColor = true;
            // 
            // 审核意见richTextBox1
            // 
            this.审核意见richTextBox1.Location = new System.Drawing.Point(12, 94);
            this.审核意见richTextBox1.Name = "审核意见richTextBox1";
            this.审核意见richTextBox1.Size = new System.Drawing.Size(159, 46);
            this.审核意见richTextBox1.TabIndex = 4;
            this.审核意见richTextBox1.Text = "";
            this.审核意见richTextBox1.TextChanged += new System.EventHandler(this.审核意见richTextBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "同意",
            "不同意"});
            this.comboBox1.Location = new System.Drawing.Point(81, 179);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "trianglify (1).png");
            this.imageList1.Images.SetKeyName(1, "trianglify.png");
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(186, 61);
            this.treeView1.Name = "treeView1";
            treeNode6.ImageIndex = 1;
            treeNode6.Name = "节点2";
            treeNode6.Text = "道路交通";
            treeNode7.Name = "节点3";
            treeNode7.Text = "给排水";
            treeNode8.Name = "节点4";
            treeNode8.Text = "结构";
            treeNode9.Name = "节点0";
            treeNode9.Tag = "备注";
            treeNode9.Text = "设计一院";
            treeNode10.Name = "节点1";
            treeNode10.Text = "总工办";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            this.treeView1.Size = new System.Drawing.Size(169, 50);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 25);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem1,
            this.打开ToolStripMenuItem1,
            this.退出ToolStripMenuItem1});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.文件ToolStripMenuItem.Text = "文件(&F)";
            // 
            // 新建ToolStripMenuItem1
            // 
            this.新建ToolStripMenuItem1.Name = "新建ToolStripMenuItem1";
            this.新建ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.新建ToolStripMenuItem1.Text = "新建(&N)";
            // 
            // 打开ToolStripMenuItem1
            // 
            this.打开ToolStripMenuItem1.Name = "打开ToolStripMenuItem1";
            this.打开ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.打开ToolStripMenuItem1.Text = "打开(&O)";
            // 
            // 退出ToolStripMenuItem1
            // 
            this.退出ToolStripMenuItem1.Name = "退出ToolStripMenuItem1";
            this.退出ToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.退出ToolStripMenuItem1.Text = "退出(&W)";
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.编辑ToolStripMenuItem.Text = "编辑(&E)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(503, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(52, 22);
            this.toolStripButton1.Text = "新建";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 270);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(503, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(246, 135);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(229, 96);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // 审核登记
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 292);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.审核意见richTextBox1);
            this.Controls.Add(this.施工图checkBox4);
            this.Controls.Add(this.初步设计checkBox3);
            this.Controls.Add(this.方案checkBox2);
            this.Controls.Add(this.前期checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "审核登记";
            this.Text = "审核登记";
            this.Load += new System.EventHandler(this.审核登记_Load_1);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox 前期checkBox1;
        private System.Windows.Forms.CheckBox 方案checkBox2;
        private System.Windows.Forms.CheckBox 初步设计checkBox3;
        private System.Windows.Forms.CheckBox 施工图checkBox4;
        private System.Windows.Forms.RichTextBox 审核意见richTextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}