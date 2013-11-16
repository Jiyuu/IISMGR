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
                var application =site.Applications[0];
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
    }
}
