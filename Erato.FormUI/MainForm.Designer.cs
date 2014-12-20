namespace Erato.FormUI
{
    partial class MainForm
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuWorkCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.部材受入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBladeSpringSeq = new System.Windows.Forms.ToolStripMenuItem();
            this.洗净干燥工序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.磁轭工序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCT组立工序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.封止工序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEF洗净工序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电检工序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最终外观检查ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.追溯统计ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.角色管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripbladeSpringCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(215)))), ((int)(((byte)(235)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 64);
            this.panel1.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuWorkCenter,
            this.追溯统计ToolStripMenuItem,
            this.系统设置ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 64);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuWorkCenter
            // 
            this.menuWorkCenter.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.部材受入ToolStripMenuItem,
            this.menuBladeSpringSeq,
            this.洗净干燥工序ToolStripMenuItem,
            this.磁轭工序ToolStripMenuItem,
            this.aCT组立工序ToolStripMenuItem,
            this.封止工序ToolStripMenuItem,
            this.hEF洗净工序ToolStripMenuItem,
            this.电检工序ToolStripMenuItem,
            this.最终外观检查ToolStripMenuItem});
            this.menuWorkCenter.Name = "menuWorkCenter";
            this.menuWorkCenter.Size = new System.Drawing.Size(68, 21);
            this.menuWorkCenter.Text = "组立中心";
            // 
            // 部材受入ToolStripMenuItem
            // 
            this.部材受入ToolStripMenuItem.Name = "部材受入ToolStripMenuItem";
            this.部材受入ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.部材受入ToolStripMenuItem.Text = "部材受入";
            // 
            // menuBladeSpringSeq
            // 
            this.menuBladeSpringSeq.Name = "menuBladeSpringSeq";
            this.menuBladeSpringSeq.Size = new System.Drawing.Size(148, 22);
            this.menuBladeSpringSeq.Text = "板弹簧工序";
            // 
            // 洗净干燥工序ToolStripMenuItem
            // 
            this.洗净干燥工序ToolStripMenuItem.Name = "洗净干燥工序ToolStripMenuItem";
            this.洗净干燥工序ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.洗净干燥工序ToolStripMenuItem.Text = "洗净干燥工序";
            // 
            // 磁轭工序ToolStripMenuItem
            // 
            this.磁轭工序ToolStripMenuItem.Name = "磁轭工序ToolStripMenuItem";
            this.磁轭工序ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.磁轭工序ToolStripMenuItem.Text = "磁轭工序";
            // 
            // aCT组立工序ToolStripMenuItem
            // 
            this.aCT组立工序ToolStripMenuItem.Name = "aCT组立工序ToolStripMenuItem";
            this.aCT组立工序ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.aCT组立工序ToolStripMenuItem.Text = "ACT组立工序";
            // 
            // 封止工序ToolStripMenuItem
            // 
            this.封止工序ToolStripMenuItem.Name = "封止工序ToolStripMenuItem";
            this.封止工序ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.封止工序ToolStripMenuItem.Text = "封止工序";
            // 
            // hEF洗净工序ToolStripMenuItem
            // 
            this.hEF洗净工序ToolStripMenuItem.Name = "hEF洗净工序ToolStripMenuItem";
            this.hEF洗净工序ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.hEF洗净工序ToolStripMenuItem.Text = "HEF洗净工序";
            // 
            // 电检工序ToolStripMenuItem
            // 
            this.电检工序ToolStripMenuItem.Name = "电检工序ToolStripMenuItem";
            this.电检工序ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.电检工序ToolStripMenuItem.Text = "电检工序";
            // 
            // 最终外观检查ToolStripMenuItem
            // 
            this.最终外观检查ToolStripMenuItem.Name = "最终外观检查ToolStripMenuItem";
            this.最终外观检查ToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.最终外观检查ToolStripMenuItem.Text = "最终外观检查";
            // 
            // 追溯统计ToolStripMenuItem
            // 
            this.追溯统计ToolStripMenuItem.Name = "追溯统计ToolStripMenuItem";
            this.追溯统计ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.追溯统计ToolStripMenuItem.Text = "追溯统计";
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.角色管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.toolStripSeparator1,
            this.修改密码ToolStripMenuItem});
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.系统设置ToolStripMenuItem.Text = "系统设置";
            // 
            // 角色管理ToolStripMenuItem
            // 
            this.角色管理ToolStripMenuItem.Name = "角色管理ToolStripMenuItem";
            this.角色管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.角色管理ToolStripMenuItem.Text = "角色管理";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(121, 6);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1008, 641);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 615);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "我的工作台";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.toolStrip1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1000, 615);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "板弹簧工序";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(994, 584);
            this.dataGridView1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton5,
            this.toolStripLabel1,
            this.toolStripComboBox1,
            this.toolStripTextBox1,
            this.toolStripButton4,
            this.toolStripSeparator2,
            this.toolStripbladeSpringCreate,
            this.toolStripButton2,
            this.toolStripButton3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(994, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "查询条件";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "时间",
            "录入人",
            "LOTNO"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 25);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton5.Text = "一览";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton4.Text = "查询";
            // 
            // toolStripbladeSpringCreate
            // 
            this.toolStripbladeSpringCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripbladeSpringCreate.Image = ((System.Drawing.Image)(resources.GetObject("toolStripbladeSpringCreate.Image")));
            this.toolStripbladeSpringCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripbladeSpringCreate.Name = "toolStripbladeSpringCreate";
            this.toolStripbladeSpringCreate.Size = new System.Drawing.Size(36, 22);
            this.toolStripbladeSpringCreate.Text = "添加";
            this.toolStripbladeSpringCreate.Click += new System.EventHandler(this.toolStripbladeSpringCreate_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton2.Text = "编辑";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(36, 22);
            this.toolStripButton3.Text = "删除";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Erato.FormUI.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1008, 64);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ALPS组立工程生产管理监控平台";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuWorkCenter;
        private System.Windows.Forms.ToolStripMenuItem 部材受入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBladeSpringSeq;
        private System.Windows.Forms.ToolStripMenuItem 洗净干燥工序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 磁轭工序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCT组立工序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 封止工序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hEF洗净工序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电检工序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最终外观检查ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 追溯统计ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 系统设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 角色管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripbladeSpringCreate;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}

