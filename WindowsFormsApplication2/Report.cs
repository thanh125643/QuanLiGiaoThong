using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            ReportDocument objrep = new ThongTinRP();
            ConnectionInfo mycon = new ConnectionInfo();
            TableLogOnInfo myinfo = new TableLogOnInfo();
            mycon.IntegratedSecurity = true;
            mycon.ServerName = "DESKTOP-2IAIEK9";
            mycon.DatabaseName = "QLGT";
            myinfo.ConnectionInfo = mycon;
            objrep.Database.Tables[0].ApplyLogOnInfo(myinfo);
            rv.ReportSource = objrep;
            rv.Refresh();
        }
    }
}
