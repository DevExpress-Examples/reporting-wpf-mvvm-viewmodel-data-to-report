using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace PassDataFromViewModelToReport {
    public partial class EmployeeReport : DevExpress.XtraReports.UI.XtraReport {
        public EmployeeReport() {
            InitializeComponent();
        }

        public EmployeeReport(object dataSource) : this() {
            objectDataSource1.DataSource = dataSource;
        }
    }
}
