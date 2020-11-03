using System;

namespace CompanyHR
{
    public class EmployeeReportService {
        private string report = "";
        public void addData(string data){
            report += data;
        }

        public void outputReport(){
            Console.Write(report);
        }
        public void clearReport(){
            report = "";
        }
    }
}