namespace ProcessHandlesManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lvwProcesses = new System.Windows.Forms.ListView();
            this.colPID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProcessName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.lvwHandles = new System.Windows.Forms.ListView();
            this.colProcessID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHandle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHandleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHandleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.txtHandleName = new System.Windows.Forms.ToolStripTextBox();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.lblStatus = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lvwProcesses);
            this.splitContainer1.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lvwHandles);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip2);
            this.splitContainer1.Size = new System.Drawing.Size(1022, 417);
            this.splitContainer1.SplitterDistance = 244;
            this.splitContainer1.TabIndex = 0;
            // 
            // lvwProcesses
            // 
            this.lvwProcesses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colPID,
            this.colProcessName});
            this.lvwProcesses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwProcesses.FullRowSelect = true;
            this.lvwProcesses.GridLines = true;
            this.lvwProcesses.HideSelection = false;
            this.lvwProcesses.Location = new System.Drawing.Point(0, 25);
            this.lvwProcesses.MultiSelect = false;
            this.lvwProcesses.Name = "lvwProcesses";
            this.lvwProcesses.ShowItemToolTips = true;
            this.lvwProcesses.Size = new System.Drawing.Size(244, 392);
            this.lvwProcesses.TabIndex = 0;
            this.lvwProcesses.UseCompatibleStateImageBehavior = false;
            this.lvwProcesses.View = System.Windows.Forms.View.Details;
            this.lvwProcesses.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwProcesses_ColumnClick);
            this.lvwProcesses.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvwProcesses_MouseDoubleClick);
            // 
            // colPID
            // 
            this.colPID.Text = "PID";
            // 
            // colProcessName
            // 
            this.colProcessName.Text = "进程名";
            this.colProcessName.Width = 150;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(244, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(36, 22);
            this.btnRefresh.Text = "刷新";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lvwHandles
            // 
            this.lvwHandles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProcessID,
            this.colHandle,
            this.colHandleType,
            this.colHandleName});
            this.lvwHandles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwHandles.FullRowSelect = true;
            this.lvwHandles.GridLines = true;
            this.lvwHandles.HideSelection = false;
            this.lvwHandles.Location = new System.Drawing.Point(0, 25);
            this.lvwHandles.MultiSelect = false;
            this.lvwHandles.Name = "lvwHandles";
            this.lvwHandles.ShowItemToolTips = true;
            this.lvwHandles.Size = new System.Drawing.Size(774, 392);
            this.lvwHandles.TabIndex = 1;
            this.lvwHandles.UseCompatibleStateImageBehavior = false;
            this.lvwHandles.View = System.Windows.Forms.View.Details;
            this.lvwHandles.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwHandles_ColumnClick);
            // 
            // colProcessID
            // 
            this.colProcessID.Text = "PID";
            // 
            // colHandle
            // 
            this.colHandle.Text = "句柄";
            this.colHandle.Width = 80;
            // 
            // colHandleType
            // 
            this.colHandleType.Text = "句柄类型";
            this.colHandleType.Width = 120;
            // 
            // colHandleName
            // 
            this.colHandleName.Text = "名称";
            this.colHandleName.Width = 500;
            // 
            // toolStrip2
            // 
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnFind,
            this.txtHandleName,
            this.pbStatus,
            this.lblStatus});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(774, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 22);
            this.btnClose.Text = "关闭句柄";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnFind
            // 
            this.btnFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFind.Image = ((System.Drawing.Image)(resources.GetObject("btnFind.Image")));
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(60, 22);
            this.btnFind.Text = "查找句柄";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtHandleName
            // 
            this.txtHandleName.Name = "txtHandleName";
            this.txtHandleName.Size = new System.Drawing.Size(200, 25);
            this.txtHandleName.ToolTipText = "句柄的一部分名称";
            // 
            // pbStatus
            // 
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 22);
            this.pbStatus.Step = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 22);
            this.lblStatus.Text = "0 / 0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 417);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "进程句柄管理器";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView lvwProcesses;
        private System.Windows.Forms.ColumnHeader colPID;
        private System.Windows.Forms.ColumnHeader colProcessName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ListView lvwHandles;
        private System.Windows.Forms.ColumnHeader colHandle;
        private System.Windows.Forms.ColumnHeader colHandleType;
        private System.Windows.Forms.ColumnHeader colHandleName;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ColumnHeader colProcessID;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.ToolStripTextBox txtHandleName;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.ToolStripLabel lblStatus;
    }
}

