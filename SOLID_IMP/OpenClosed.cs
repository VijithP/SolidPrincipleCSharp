using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_IMP
{
    public class OpenClosed
    {
        CrystalReportGeneraion cr = new CrystalReportGeneraion();
        PDFReportGeneraion pr = new PDFReportGeneraion();
        public OpenClosed()
        {
            Employee emp = new Employee() { Employee_Id = 101, Employee_Name = "Vijith" };
           Console.WriteLine( cr.GenerateReport(emp));
           Console.WriteLine(pr.GenerateReport(emp));

        }
    }

    public abstract class ReportGeneration
    {
        /// <summary>
        /// Method to generate report
        /// </summary>
        /// <param name="em"></param>
       
        public abstract string GenerateReport(Employee em);

    }
    /// <summary>
    /// Class to generate Crystal report
    /// </summary>
    public class CrystalReportGeneraion : ReportGeneration
    {
        public override string GenerateReport(Employee em)
        {
            // Generate crystal report.
            string result = "Crystal Report Created";
            return result;
        }

    }
    /// <summary>
    /// Class to generate PDF report
    /// </summary>
    public class PDFReportGeneraion : ReportGeneration
    {
        public override string GenerateReport(Employee em)
        {
            // Generate PDF report.
            string result = "PDF Report Created";
            return result;
        }
    }

}
