namespace IIsManage
{
    partial class IISManagerFrm
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
            this.sitesGrid = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appPoolNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appPoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appPoolStateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pathDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.applicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vDirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteRecordBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChangeDirBtn = new System.Windows.Forms.Button();
            this.RecycleAppPoolBtn = new System.Windows.Forms.Button();
            this.StopAppPoolBtn = new System.Windows.Forms.Button();
            this.StartAppPoolBtn = new System.Windows.Forms.Button();
            this.RestartSitesBtn = new System.Windows.Forms.Button();
            this.StartSitesBtn = new System.Windows.Forms.Button();
            this.StopSitesBtn = new System.Windows.Forms.Button();
            this.FilterTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.sitesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteRecordBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // sitesGrid
            // 
            this.sitesGrid.AllowUserToAddRows = false;
            this.sitesGrid.AllowUserToDeleteRows = false;
            this.sitesGrid.AutoGenerateColumns = false;
            this.sitesGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.sitesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sitesGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.siteStateDataGridViewTextBoxColumn,
            this.appPoolNameDataGridViewTextBoxColumn,
            this.appPoolDataGridViewTextBoxColumn,
            this.appPoolStateDataGridViewTextBoxColumn,
            this.pathDataGridViewTextBoxColumn,
            this.applicationDataGridViewTextBoxColumn,
            this.siteDataGridViewTextBoxColumn,
            this.vDirDataGridViewTextBoxColumn});
            this.sitesGrid.DataSource = this.siteRecordBindingSource;
            this.sitesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sitesGrid.Location = new System.Drawing.Point(0, 20);
            this.sitesGrid.Name = "sitesGrid";
            this.sitesGrid.ReadOnly = true;
            this.sitesGrid.Size = new System.Drawing.Size(629, 459);
            this.sitesGrid.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 60;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            this.iDDataGridViewTextBoxColumn.Width = 43;
            // 
            // siteStateDataGridViewTextBoxColumn
            // 
            this.siteStateDataGridViewTextBoxColumn.DataPropertyName = "SiteState";
            this.siteStateDataGridViewTextBoxColumn.HeaderText = "SiteState";
            this.siteStateDataGridViewTextBoxColumn.Name = "siteStateDataGridViewTextBoxColumn";
            this.siteStateDataGridViewTextBoxColumn.ReadOnly = true;
            this.siteStateDataGridViewTextBoxColumn.Width = 75;
            // 
            // appPoolNameDataGridViewTextBoxColumn
            // 
            this.appPoolNameDataGridViewTextBoxColumn.DataPropertyName = "AppPoolName";
            this.appPoolNameDataGridViewTextBoxColumn.HeaderText = "AppPoolName";
            this.appPoolNameDataGridViewTextBoxColumn.Name = "appPoolNameDataGridViewTextBoxColumn";
            this.appPoolNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // appPoolDataGridViewTextBoxColumn
            // 
            this.appPoolDataGridViewTextBoxColumn.DataPropertyName = "AppPool";
            this.appPoolDataGridViewTextBoxColumn.HeaderText = "AppPool";
            this.appPoolDataGridViewTextBoxColumn.Name = "appPoolDataGridViewTextBoxColumn";
            this.appPoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.appPoolDataGridViewTextBoxColumn.Visible = false;
            this.appPoolDataGridViewTextBoxColumn.Width = 72;
            // 
            // appPoolStateDataGridViewTextBoxColumn
            // 
            this.appPoolStateDataGridViewTextBoxColumn.DataPropertyName = "AppPoolState";
            this.appPoolStateDataGridViewTextBoxColumn.HeaderText = "AppPoolState";
            this.appPoolStateDataGridViewTextBoxColumn.Name = "appPoolStateDataGridViewTextBoxColumn";
            this.appPoolStateDataGridViewTextBoxColumn.ReadOnly = true;
            this.appPoolStateDataGridViewTextBoxColumn.Width = 97;
            // 
            // pathDataGridViewTextBoxColumn
            // 
            this.pathDataGridViewTextBoxColumn.DataPropertyName = "Path";
            this.pathDataGridViewTextBoxColumn.HeaderText = "Path";
            this.pathDataGridViewTextBoxColumn.Name = "pathDataGridViewTextBoxColumn";
            this.pathDataGridViewTextBoxColumn.ReadOnly = true;
            this.pathDataGridViewTextBoxColumn.Width = 54;
            // 
            // applicationDataGridViewTextBoxColumn
            // 
            this.applicationDataGridViewTextBoxColumn.DataPropertyName = "Application";
            this.applicationDataGridViewTextBoxColumn.HeaderText = "Application";
            this.applicationDataGridViewTextBoxColumn.Name = "applicationDataGridViewTextBoxColumn";
            this.applicationDataGridViewTextBoxColumn.ReadOnly = true;
            this.applicationDataGridViewTextBoxColumn.Visible = false;
            this.applicationDataGridViewTextBoxColumn.Width = 84;
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "Site";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            this.siteDataGridViewTextBoxColumn.ReadOnly = true;
            this.siteDataGridViewTextBoxColumn.Visible = false;
            this.siteDataGridViewTextBoxColumn.Width = 50;
            // 
            // vDirDataGridViewTextBoxColumn
            // 
            this.vDirDataGridViewTextBoxColumn.DataPropertyName = "VDir";
            this.vDirDataGridViewTextBoxColumn.HeaderText = "VDir";
            this.vDirDataGridViewTextBoxColumn.Name = "vDirDataGridViewTextBoxColumn";
            this.vDirDataGridViewTextBoxColumn.ReadOnly = true;
            this.vDirDataGridViewTextBoxColumn.Visible = false;
            this.vDirDataGridViewTextBoxColumn.Width = 52;
            // 
            // siteRecordBindingSource
            // 
            this.siteRecordBindingSource.DataSource = typeof(IIsManage.SiteRecord);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChangeDirBtn);
            this.panel1.Controls.Add(this.RecycleAppPoolBtn);
            this.panel1.Controls.Add(this.StopAppPoolBtn);
            this.panel1.Controls.Add(this.StartAppPoolBtn);
            this.panel1.Controls.Add(this.RestartSitesBtn);
            this.panel1.Controls.Add(this.StartSitesBtn);
            this.panel1.Controls.Add(this.StopSitesBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(629, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(145, 479);
            this.panel1.TabIndex = 1;
            // 
            // ChangeDirBtn
            // 
            this.ChangeDirBtn.Location = new System.Drawing.Point(26, 256);
            this.ChangeDirBtn.Name = "ChangeDirBtn";
            this.ChangeDirBtn.Size = new System.Drawing.Size(99, 23);
            this.ChangeDirBtn.TabIndex = 7;
            this.ChangeDirBtn.Text = "Change Path";
            this.ChangeDirBtn.UseVisualStyleBackColor = true;
            this.ChangeDirBtn.Click += new System.EventHandler(this.ChangeDirBtn_Click);
            // 
            // RecycleAppPoolBtn
            // 
            this.RecycleAppPoolBtn.Location = new System.Drawing.Point(26, 174);
            this.RecycleAppPoolBtn.Name = "RecycleAppPoolBtn";
            this.RecycleAppPoolBtn.Size = new System.Drawing.Size(97, 23);
            this.RecycleAppPoolBtn.TabIndex = 6;
            this.RecycleAppPoolBtn.Text = "Recycle AppPool";
            this.RecycleAppPoolBtn.UseVisualStyleBackColor = true;
            this.RecycleAppPoolBtn.Click += new System.EventHandler(this.RecycleAppPoolBtn_Click);
            // 
            // StopAppPoolBtn
            // 
            this.StopAppPoolBtn.Location = new System.Drawing.Point(26, 145);
            this.StopAppPoolBtn.Name = "StopAppPoolBtn";
            this.StopAppPoolBtn.Size = new System.Drawing.Size(97, 23);
            this.StopAppPoolBtn.TabIndex = 5;
            this.StopAppPoolBtn.Text = "Stop AppPool";
            this.StopAppPoolBtn.UseVisualStyleBackColor = true;
            this.StopAppPoolBtn.Click += new System.EventHandler(this.StopAppPoolBtn_Click);
            // 
            // StartAppPoolBtn
            // 
            this.StartAppPoolBtn.Location = new System.Drawing.Point(26, 116);
            this.StartAppPoolBtn.Name = "StartAppPoolBtn";
            this.StartAppPoolBtn.Size = new System.Drawing.Size(97, 23);
            this.StartAppPoolBtn.TabIndex = 4;
            this.StartAppPoolBtn.Text = "Start AppPool";
            this.StartAppPoolBtn.UseVisualStyleBackColor = true;
            this.StartAppPoolBtn.Click += new System.EventHandler(this.StartAppPoolBtn_Click);
            // 
            // RestartSitesBtn
            // 
            this.RestartSitesBtn.Location = new System.Drawing.Point(36, 71);
            this.RestartSitesBtn.Name = "RestartSitesBtn";
            this.RestartSitesBtn.Size = new System.Drawing.Size(75, 23);
            this.RestartSitesBtn.TabIndex = 3;
            this.RestartSitesBtn.Text = "Restart Sites";
            this.RestartSitesBtn.UseVisualStyleBackColor = true;
            this.RestartSitesBtn.Click += new System.EventHandler(this.RestartSitesBtn_Click);
            // 
            // StartSitesBtn
            // 
            this.StartSitesBtn.Location = new System.Drawing.Point(36, 12);
            this.StartSitesBtn.Name = "StartSitesBtn";
            this.StartSitesBtn.Size = new System.Drawing.Size(75, 23);
            this.StartSitesBtn.TabIndex = 2;
            this.StartSitesBtn.Text = "Start Sites";
            this.StartSitesBtn.UseVisualStyleBackColor = true;
            this.StartSitesBtn.Click += new System.EventHandler(this.StartSitesBtn_Click);
            // 
            // StopSitesBtn
            // 
            this.StopSitesBtn.Location = new System.Drawing.Point(36, 41);
            this.StopSitesBtn.Name = "StopSitesBtn";
            this.StopSitesBtn.Size = new System.Drawing.Size(75, 23);
            this.StopSitesBtn.TabIndex = 0;
            this.StopSitesBtn.Text = "Stop Sites";
            this.StopSitesBtn.UseVisualStyleBackColor = true;
            this.StopSitesBtn.Click += new System.EventHandler(this.StopSitesBtn_Click);
            // 
            // FilterTxt
            // 
            this.FilterTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilterTxt.Location = new System.Drawing.Point(0, 0);
            this.FilterTxt.Margin = new System.Windows.Forms.Padding(0);
            this.FilterTxt.Name = "FilterTxt";
            this.FilterTxt.Size = new System.Drawing.Size(629, 20);
            this.FilterTxt.TabIndex = 8;
            this.FilterTxt.TextChanged += new System.EventHandler(this.FilterTxt_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.FilterTxt);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 20);
            this.panel2.TabIndex = 2;
            // 
            // IISManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 479);
            this.Controls.Add(this.sitesGrid);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IISManagerFrm";
            this.Text = "IIS Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sitesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siteRecordBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView sitesGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource siteRecordBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appPoolNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appPoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appPoolStateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn applicationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vDirDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button StartSitesBtn;
        private System.Windows.Forms.Button StopSitesBtn;
        private System.Windows.Forms.Button RestartSitesBtn;
        private System.Windows.Forms.Button RecycleAppPoolBtn;
        private System.Windows.Forms.Button StopAppPoolBtn;
        private System.Windows.Forms.Button StartAppPoolBtn;
        private System.Windows.Forms.Button ChangeDirBtn;
        private System.Windows.Forms.TextBox FilterTxt;
        private System.Windows.Forms.Panel panel2;
    }
}

