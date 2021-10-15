using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Data.Entity;

namespace PassDataFromViewModelToReport.Models {
    public class MainViewModel : ViewModelBase {
        readonly Data.NWindDBContext dbContext = new Data.NWindDBContext();

        public IEnumerable<Data.Employee> Employees { get; }

        public Data.Employee SelectedEmployee {
            get => GetProperty(() => SelectedEmployee);
            set => SetProperty(() => SelectedEmployee, value);
        }

        public MainViewModel() {
            dbContext.Employees.Load();
            Employees = dbContext.Employees.Local;
        }

        [Command(CanExecuteMethodName = nameof(CanShowPrintPreview))]
        public void ShowPrintPreview() {
            XtraReport report = new EmployeeReport(dbContext);
            report.Parameters["EmployeeId"].Value = SelectedEmployee.EmployeeID;
            using(report) {
                GetService<IDialogService>()
                    .ShowDialog(null, "Print Preview", new DocumentPreviewViewModel(report));
            }
        }
        public bool CanShowPrintPreview() => SelectedEmployee != null;
    }
}
