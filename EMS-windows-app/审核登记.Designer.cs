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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("道路交通");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("给排水");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("结构");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("设计一院", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("总工办");
            this.前期checkBox1 = new System.Windows.Forms.CheckBox();
            this.方案checkBox2 = new System.Windows.Forms.CheckBox();
            this.初步设计checkBox3 = new System.Windows.Forms.CheckBox();
            this.施工图checkBox4 = new System.Windows.Forms.CheckBox();
            this.审核意见richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
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
            this.初步设计checkBox3.Location = new System.Drawing.Point(81, 61);
            this.初步设计checkBox3.Name = "初步设计checkBox3";
            this.初步设计checkBox3.Size = new System.Drawing.Size(72, 16);
            this.初步设计checkBox3.TabIndex = 2;
            this.初步设计checkBox3.Text = "初步设计";
            this.初步设计checkBox3.UseVisualStyleBackColor = true;
            // 
            // 施工图checkBox4
            // 
            this.施工图checkBox4.AutoSize = true;
            this.施工图checkBox4.Location = new System.Drawing.Point(246, 61);
            this.施工图checkBox4.Name = "施工图checkBox4";
            this.施工图checkBox4.Size = new System.Drawing.Size(60, 16);
            this.施工图checkBox4.TabIndex = 3;
            this.施工图checkBox4.Text = "施工图";
            this.施工图checkBox4.UseVisualStyleBackColor = true;
            // 
            // 审核意见richTextBox1
            // 
            this.审核意见richTextBox1.Location = new System.Drawing.Point(81, 94);
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
            this.treeView1.Location = new System.Drawing.Point(286, 124);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "节点2";
            treeNode1.Text = "道路交通";
            treeNode2.Name = "节点3";
            treeNode2.Text = "给排水";
            treeNode3.Name = "节点4";
            treeNode3.Text = "结构";
            treeNode4.Name = "节点0";
            treeNode4.Tag = "备注";
            treeNode4.Text = "设计一院";
            treeNode5.Name = "节点1";
            treeNode5.Text = "总工办";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 6;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // 审核登记
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 233);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.审核意见richTextBox1);
            this.Controls.Add(this.施工图checkBox4);
            this.Controls.Add(this.初步设计checkBox3);
            this.Controls.Add(this.方案checkBox2);
            this.Controls.Add(this.前期checkBox1);
            this.Name = "审核登记";
            this.Text = "审核登记";
            this.Load += new System.EventHandler(this.审核登记_Load_1);
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
    }
}