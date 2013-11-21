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
using Equin.ApplicationFramework;

namespace IIsManage
{
    public partial class IISManagerFrm : Form
    {
        Microsoft.Web.Administration.ServerManager sm = new ServerManager();
        public IISManagerFrm()
        {
            InitializeComponent();
        }

        List<SiteRecord> siteRecords ;
        BindingListView<SiteRecord> siteRecordsView;
        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void StartSitesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                ObjectView<SiteRecord> ovo= row.DataBoundItem as ObjectView<SiteRecord>;
                if (ovo==null)
                    continue;
                SiteRecord record = ovo.Object;
                if (record != null)
                {
                    record.Site.Start();
                    ovo.BeginEdit();
                    record.SiteState = record.Site.State;
                    ovo.EndEdit();
                }
            }

        }

        private void StopSitesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                ObjectView<SiteRecord> ovo = row.DataBoundItem as ObjectView<SiteRecord>;
                if (ovo == null)
                    continue;
                SiteRecord record = ovo.Object;
                if (record != null)
                {
                    record.Site.Stop();
                    ovo.BeginEdit();
                    record.SiteState = record.Site.State;
                    ovo.EndEdit();
                }
            }
        }

        private void RestartSitesBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                ObjectView<SiteRecord> ovo = row.DataBoundItem as ObjectView<SiteRecord>;
                if (ovo == null)
                    continue;
                SiteRecord record = ovo.Object;
                if (record != null)
                {
                    record.Site.Stop();
                    record.Site.Start();
                    ovo.BeginEdit();
                    record.SiteState = record.Site.State;
                    ovo.EndEdit();
                }
            }
        }

        private void StartAppPoolBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                ObjectView<SiteRecord> ovo = row.DataBoundItem as ObjectView<SiteRecord>;
                if (ovo == null)
                    continue;
                SiteRecord record = ovo.Object;
                if (record != null)
                {
                    record.AppPool.Start();
                    ovo.BeginEdit();
                    record.AppPoolState = record.AppPool.State;
                    ovo.EndEdit();
                }
            }
        }

        private void StopAppPoolBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                ObjectView<SiteRecord> ovo = row.DataBoundItem as ObjectView<SiteRecord>;
                if (ovo == null)
                    continue;
                SiteRecord record = ovo.Object;
                if (record != null)
                {
                    if (record.AppPool.State == ObjectState.Started)
                        record.AppPool.Stop();
                    ovo.BeginEdit();
                    record.AppPoolState = record.AppPool.State;
                    ovo.EndEdit();
                }
            }
        }

        private void RecycleAppPoolBtn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                ObjectView<SiteRecord> ovo = row.DataBoundItem as ObjectView<SiteRecord>;
                if (ovo == null)
                    continue;
                SiteRecord record = ovo.Object;
                if (record != null)
                {
                    if (record.AppPool.State == ObjectState.Started)
                        record.AppPool.Stop();
                    record.AppPool.Start();
                    ovo.BeginEdit();
                    record.AppPoolState = record.AppPool.State;
                    ovo.EndEdit();
                }
            }
        }

        private void ChangeDirBtn_Click(object sender, EventArgs e)
        {
            string selectedPath = null;
            bool AllUsingSamePath = true;
            foreach (DataGridViewRow row in sitesGrid.SelectedRows)
            {
                ObjectView<SiteRecord> ovo = row.DataBoundItem as ObjectView<SiteRecord>;
                if (ovo == null)
                    continue;
                SiteRecord record = ovo.Object;
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
                    ObjectView<SiteRecord> ovo = row.DataBoundItem as ObjectView<SiteRecord>;
                    if (ovo == null)
                        continue;
                    SiteRecord record = ovo.Object;
                    if (record != null)
                    {
                        record.VDir.PhysicalPath = selectedPath;
                        ovo.BeginEdit();
                        record.Path = record.VDir.PhysicalPath;
                        ovo.EndEdit();
                    }
                }
                sm.CommitChanges();

            }


        }

        private void FilterTxt_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            foreach (var record in siteRecords)
            {
                record.Populate();
            }

            foreach (ObjectView<SiteRecord> recV in siteRecordsView)
            {
                recV.BeginEdit();
                recV.Object.Populate();
                recV.EndEdit();
            }

        }

        private void HardRefreshBtn_Click(object sender, EventArgs e)
        {
            RefreshData();
            ApplyFilter();
        }
        private void RefreshData()
        {
            var sites = sm.Sites;
            var appPools = sm.ApplicationPools;
            var tmpList = new List<SiteRecord>();
            BindingListView<SiteRecord> tmpView;

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
                record.Populate();
                tmpList.Add(record);
            }
            sitesGrid.AutoGenerateColumns = false;

            tmpView = new BindingListView<SiteRecord>(tmpList);

            siteRecords = tmpList;
            siteRecordsView = tmpView;

            sitesGrid.DataSource = siteRecordsView;
        }

        private void ApplyFilter()
        {
            siteRecordsView.ApplyFilter(record => record.Name.ToLower().Contains(FilterTxt.Text.ToLower()) || record.Path.ToLower().Contains(FilterTxt.Text.ToLower()));
        }
    }
}
