using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IIsManage
{
    public class SiteRecord
    {
        public string Name { get; set; }

        public long ID { get; set; }

        public Microsoft.Web.Administration.ObjectState SiteState { get; set; }

        public string AppPoolName { get; set; }

        public Microsoft.Web.Administration.ApplicationPool AppPool { get; set; }

        public Microsoft.Web.Administration.ObjectState AppPoolState { get; set; }

        public string Path { get; set; }

        public Microsoft.Web.Administration.Application Application { get; set; }

        public Microsoft.Web.Administration.Site Site { get; set; }

        public Microsoft.Web.Administration.VirtualDirectory VDir { get; set; }
    }
}
