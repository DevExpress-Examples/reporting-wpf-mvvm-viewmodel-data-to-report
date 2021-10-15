using DevExpress.Mvvm;
using DevExpress.XtraReports.UI;

namespace PassDataFromViewModelToReport.Models {
    public class DocumentPreviewViewModel : BindableBase {
        public XtraReport Report { get; }
        public DocumentPreviewViewModel(XtraReport report) {
            Report = report;
        }
    }
}
