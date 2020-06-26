namespace EntFrm.RegistConsole
{
    partial class frmMainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.操作ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemWDog = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRDog = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnListApps = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnWriteDog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnReadDog = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUpload = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作ToolStripMenuItem,
            this.MenuItem2,
            this.关于ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(901, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 操作ToolStripMenuItem
            // 
            this.操作ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemList,
            this.MenuItemWDog,
            this.MenuItemRDog,
            this.MenuItemExit});
            this.操作ToolStripMenuItem.Name = "操作ToolStripMenuItem";
            this.操作ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.操作ToolStripMenuItem.Text = "操作";
            // 
            // MenuItemList
            // 
            this.MenuItemList.Name = "MenuItemList";
            this.MenuItemList.Size = new System.Drawing.Size(159, 26);
            this.MenuItemList.Text = "授权列表";
            this.MenuItemList.Click += new System.EventHandler(this.MenuItemList_Click);
            // 
            // MenuItemWDog
            // 
            this.MenuItemWDog.Name = "MenuItemWDog";
            this.MenuItemWDog.Size = new System.Drawing.Size(159, 26);
            this.MenuItemWDog.Text = "写加密狗";
            this.MenuItemWDog.Click += new System.EventHandler(this.MenuItemWDog_Click);
            // 
            // MenuItemRDog
            // 
            this.MenuItemRDog.Name = "MenuItemRDog";
            this.MenuItemRDog.Size = new System.Drawing.Size(159, 26);
            this.MenuItemRDog.Text = "生成注册码";
            this.MenuItemRDog.Click += new System.EventHandler(this.MenuItemRDog_Click);
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.Size = new System.Drawing.Size(159, 26);
            this.MenuItemExit.Text = "退出程序";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSetting});
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(51, 24);
            this.MenuItem2.Text = "设置";
            // 
            // MenuItemSetting
            // 
            this.MenuItemSetting.Name = "MenuItemSetting";
            this.MenuItemSetting.Size = new System.Drawing.Size(144, 26);
            this.MenuItemSetting.Text = "参数设置";
            this.MenuItemSetting.Click += new System.EventHandler(this.MenuItemSetting_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAbout,
            this.MenuItemUpdate});
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.关于ToolStripMenuItem.Text = "帮助";
            // 
            // MenuItemAbout
            // 
            this.MenuItemAbout.Name = "MenuItemAbout";
            this.MenuItemAbout.Size = new System.Drawing.Size(114, 26);
            this.MenuItemAbout.Text = "关于";
            this.MenuItemAbout.Click += new System.EventHandler(this.MenuItemAbout_Click);
            // 
            // MenuItemUpdate
            // 
            this.MenuItemUpdate.Name = "MenuItemUpdate";
            this.MenuItemUpdate.Size = new System.Drawing.Size(114, 26);
            this.MenuItemUpdate.Text = "更新";
            this.MenuItemUpdate.Click += new System.EventHandler(this.MenuItemUpdate_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnListApps,
            this.toolStripSeparator1,
            this.btnWriteDog,
            this.toolStripSeparator3,
            this.btnReadDog,
            this.toolStripSeparator2,
            this.btnRefresh,
            this.toolStripSeparator4,
            this.btnUpload});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(901, 64);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnListApps
            // 
            this.btnListApps.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnListApps.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnListApps.Image = ((System.Drawing.Image)(resources.GetObject("btnListApps.Image")));
            this.btnListApps.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnListApps.Name = "btnListApps";
            this.btnListApps.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.btnListApps.Size = new System.Drawing.Size(116, 61);
            this.btnListApps.Text = "授权列表";
            this.btnListApps.ToolTipText = "授权列表";
            this.btnListApps.Click += new System.EventHandler(this.btnListApps_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 64);
            // 
            // btnWriteDog
            // 
            this.btnWriteDog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnWriteDog.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnWriteDog.Image = ((System.Drawing.Image)(resources.GetObject("btnWriteDog.Image")));
            this.btnWriteDog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnWriteDog.Name = "btnWriteDog";
            this.btnWriteDog.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.btnWriteDog.Size = new System.Drawing.Size(116, 61);
            this.btnWriteDog.Text = "写加密狗";
            this.btnWriteDog.Click += new System.EventHandler(this.btnWriteDog_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 64);
            // 
            // btnReadDog
            // 
            this.btnReadDog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnReadDog.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnReadDog.Image = ((System.Drawing.Image)(resources.GetObject("btnReadDog.Image")));
            this.btnReadDog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReadDog.Name = "btnReadDog";
            this.btnReadDog.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.btnReadDog.Size = new System.Drawing.Size(136, 61);
            this.btnReadDog.Text = "生成注册码";
            this.btnReadDog.Click += new System.EventHandler(this.btnReadDog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 64);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.btnRefresh.Size = new System.Drawing.Size(76, 61);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 64);
            // 
            // btnUpload
            // 
            this.btnUpload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F);
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.btnUpload.Size = new System.Drawing.Size(116, 61);
            this.btnUpload.Text = "同步数据";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 506);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(901, 25);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbStatus
            // 
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(159, 20);
            this.lbStatus.Text = "运行状态：网络已连接";
            // 
            // frmMainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 531);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainFrame";
            this.Text = "授权管理程序";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainFrame_FormClosing);
            this.Load += new System.EventHandler(this.frmMainFrame_Load);
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

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 操作ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemList;
        private System.Windows.Forms.ToolStripMenuItem MenuItemWDog;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRDog;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUpdate;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItem2;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSetting;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnListApps;
        private System.Windows.Forms.ToolStripButton btnReadDog;
        private System.Windows.Forms.ToolStripButton btnWriteDog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnUpload;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbStatus;
    }
}