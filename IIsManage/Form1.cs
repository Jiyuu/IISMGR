using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Web.Administration;

namespace IIsManage
{
    public partial class Form1 : Form
    {
        Microsoft.Web.Administration.ServerManager sm = new ServerManager();
        public Form1()
        {
            InitializeComponent();
        }

        SortableBindingList<SiteRecord> siteRecords = new SortableBindingList<SiteRecord>();
        private void Form1_Load(object sender, EventArgs e)
        {
            var sites = sm.Sites;
            var appPools = sm.ApplicationPools;
            foreach (var site in sm.Sites)
            {
                var record = new SiteRecord();
                var pool = appPools.SingleOrDefault(a => a.Name == site.Applications[0].ApplicationPoolName);
                var application = site.Applications[0];
                if (pool == null)
                {
                    System.Diagnostics.Trace.WriteLine(string.Format("no app pool for site {0}", site.Name));
                    continue;
                }
                record.Site = site;
                record.Application = application;

                record.Name = site.Name;
                record.ID = site.Id;
                record.SiteState = site.State;
                record.AppPoolName = application.ApplicationPoolName;
                record.AppPool = pool;
                record.AppPoolState = pool.State;
                record.Path = application.VirtualDirectories[0].PhysicalPath;
                record.VDir = application.VirtualDirectories[0];

                siteRecords.Add(record);
            }
            sitesGrid.AutoGenerateColumns = false;
            sitesGrid.DataSource = siteRecords;

        }

        private void StartSitesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                SiteRecord record = row.DataBoundItem as SiteRecord;
                if (record != null)
                {
                    record.Site.Start();
                    record.SiteState = record.Site.State;

                    siteRecords.ResetItem(siteRecords.IndexOf(record));

                }
            }

        }

        private void StopSitesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                SiteRecord record = row.DataBoundItem as SiteRecord;
                if (record != null)
                {
                    record.Site.Stop();
                    record.SiteState = record.Site.State;

                    siteRecords.ResetItem(siteRecords.IndexOf(record));

                }
            }
        }

        private void RestartSitesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                SiteRecord record = row.DataBoundItem as SiteRecord;
                if (record != null)
                {
                    record.Site.Stop();
                    record.Site.Start();
                    record.SiteState = record.Site.State;

                    siteRecords.ResetItem(siteRecords.IndexOf(record));

                }
            }
        }

        private void StartAppPoolBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                SiteRecord record = row.DataBoundItem as SiteRecord;
                if (record != null)
                {
                    record.AppPool.Start();
                    record.AppPoolState = record.AppPool.State;

                    siteRecords.ResetItem(siteRecords.IndexOf(record));
                }
            }
        }

        private void StopAppPoolBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                SiteRecord record = row.DataBoundItem as SiteRecord;
                if (record != null)
                {
                    record.AppPool.Stop();
                    record.AppPoolState = record.AppPool.State;

                    siteRecords.ResetItem(siteRecords.IndexOf(record));
                }
            }
        }

        private void RecycleAppPoolBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                SiteRecord record = row.DataBoundItem as SiteRecord;
                if (record != null)
                {
                    record.AppPool.Stop();
                    record.AppPool.Start();
                    record.AppPoolState = record.AppPool.State;

                    siteRecords.ResetItem(siteRecords.IndexOf(record));
                }
            }
        }

        private void ChangeDirBtn_Click(object sender, EventArgs e)
        {
            string selectedPath = null;
            bool AllUsingSamePath = true;
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                SiteRecord record = row.DataBoundItem as SiteRecord;
                if (record != null)
                {
                    if (selectedPath == null)
                    {
                        selectedPath = record.VDir.PhysicalPath;
                    }
                    else if (record.VDir.PhysicalPath == selectedPath)
                    {
                        continue;
                    }
                    else
                    {
                        AllUsingSamePath = false;
                        break;
                    }

                }
            }

            if (!AllUsingSamePath)
            {
                selectedPath = "";
            }

            FolderBrowserDialogEx fd = new FolderBrowserDialogEx();
            fd.Description = "Select a folder to extract to:";
            fd.ShowNewFolderButton = true;
            fd.ShowEditBox = true;
            //dlg1.NewStyle = false;
            fd.SelectedPath = selectedPath;
            fd.ShowFullPathInEditBox = true;
            fd.RootFolder = System.Environment.SpecialFolder.MyComputer;

            // Show the FolderBrowserDialog.
            DialogResult result = fd.ShowDialog();
            if (result == DialogResult.OK)
            {
                selectedPath = fd.SelectedPath;

                foreach (DataGridViewRow row in sitesGrid.SelectedRows)
                {
                    SiteRecord record = row.DataBoundItem as SiteRecord;
                    if (record != null)
                    {
                        record.VDir.PhysicalPath = selectedPath;
                        record.Path = record.VDir.PhysicalPath;

                        siteRecords.ResetItem(siteRecords.IndexOf(record));
                    }
                }
            }


        }
    }
}
