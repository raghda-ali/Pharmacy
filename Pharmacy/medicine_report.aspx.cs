using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pharmacy
{
    public partial class medicine_report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateReport();
        }

        private void PopulateReport()
        {
            List<Models.Medicine> medicines = null;
            using (Models.MyDBContext d = new Models.MyDBContext())
            {
                medicines = d.medicines.OrderBy(a => a.name).ToList();

                //var v = from a in d.medicines select a;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/rpt_medicineDetails.rdlc");

                ReportViewer1.LocalReport.DataSources.Clear();
                Microsoft.Reporting.WebForms.ReportDataSource rd = new Microsoft.Reporting.WebForms.ReportDataSource("medicineDetails", medicines);
                ReportViewer1.LocalReport.DataSources.Add(rd);
                ReportViewer1.LocalReport.Refresh();

            }
        }
    }
}

    