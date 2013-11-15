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

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var site in sm.Sites)
            {
                site.
            }
        }
    }
}
