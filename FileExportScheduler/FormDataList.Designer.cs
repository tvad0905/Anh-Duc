namespace FileExportScheduler
{
    partial class FormDataList
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Thiết bị", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Giao thức", 2, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDataList));
            this.ctxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.tvMain = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tx2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.tx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctxMenu
            // 
            this.ctxMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAdd});
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(105, 26);
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Size = new System.Drawing.Size(104, 22);
            this.mnuAdd.Text = "Thêm";
            this.mnuAdd.Click += new System.EventHandler(this.mnuAdd_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tvMain);
            this.splitContainer.Size = new System.Drawing.Size(1105, 633);
            this.splitContainer.SplitterDistance = 250;
            this.splitContainer.TabIndex = 0;
            // 
            // tvMain
            // 
            this.tvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMain.ImageIndex = 0;
            this.tvMain.ImageList = this.imageList;
            this.tvMain.Location = new System.Drawing.Point(0, 0);
            this.tvMain.Name = "tvMain";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Devices";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Thiết bị";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Protocols";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Giao thức";
            this.tvMain.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tvMain.SelectedImageIndex = 0;
            this.tvMain.Size = new System.Drawing.Size(250, 633);
            this.tvMain.TabIndex = 0;
            this.tvMain.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMain_NodeMouseClick);
            this.tvMain.DoubleClick += new System.EventHandler(this.tvMain_DoubleClick);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "Protocol.ico");
            this.imageList.Images.SetKeyName(1, "Device.ico");
            this.imageList.Images.SetKeyName(2, "network.ico");
            // 
            // tx2
            // 
            this.tx2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tx2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delToolStripMenuItem});
            this.tx2.Name = "tx2";
            this.tx2.Size = new System.Drawing.Size(95, 26);
            // 
            // delToolStripMenuItem
            // 
            this.delToolStripMenuItem.Name = "delToolStripMenuItem";
            this.delToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.delToolStripMenuItem.Text = "Xóa";
            this.delToolStripMenuItem.Click += new System.EventHandler(this.delToolStripMenuItem_Click);
            // 
            // FormDataList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 633);
            this.Controls.Add(this.splitContainer);
            this.Name = "FormDataList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý dữ liệu";
            this.Load += new System.EventHandler(this.FormDataList_Load);
            this.ctxMenu.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.tx2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        public System.Windows.Forms.TreeView tvMain;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAdd;
        public System.Windows.Forms.ContextMenuStrip tx2;
        private System.Windows.Forms.ToolStripMenuItem delToolStripMenuItem;
    }
}