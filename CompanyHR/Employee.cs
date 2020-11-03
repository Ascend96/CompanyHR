using System;


namespace CompanyHR
{
    public class Employee{
        private string REQUIRED_MSG = " is mandatory";
        private string NEWLINE = "\n";

        private string _firstName;
            public string firstName{
                get{
                    return _lastName;
                }
                set{
                    if(value == null){
                    throw new System.ArgumentException("last name" + REQUIRED_MSG);
                }
                _firstName = value;
                }

            }
        private string _lastName;
        public string lastName { 
            get {
                return _lastName;
            }
            set{
                if(value == null){
                    throw new System.ArgumentException("last name" + REQUIRED_MSG);
                }
                _lastName = value;
            }
         }
        private string _ssn; 
        public string ssn{    
            get{
                return _ssn;
            }
            set{
                if(value == null || value.Length < 9 || value.Length > 11){
                    throw new System.ArgumentException("ssn" + REQUIRED_MSG + "and must be between 9 and 11 characters (if hyphens are used)");
                }
                _ssn = value;
            }
         }
        private bool metWithHr { get; set; }
        private bool metDeptStaff { get; set; }
        private bool reviewedDeptPolicies { get; set; }
        private bool movedIn { get; set; }
        private string _cubeID;  
        public string cubeID{    
            get{
                return _cubeID;
            }
            set{
                if(value == null){
                    throw new System.ArgumentException("cube id" + REQUIRED_MSG);
                }
                _cubeID = value;
            }
         }
        private DateTime _orientationDate; 
        public DateTime orientationDate{ 
            get{
                return _orientationDate;
            }
            set{
                if(value == null){
                    throw new System.ArgumentException("orientation date" + REQUIRED_MSG);
                }
                _orientationDate = value;
            }
         }
        private EmployeeReportService reportService { get; set; }

        // constructor for employee
        public Employee(string first, string last, string ssnumber){
            firstName = first;
            lastName = last;
            ssn = ssnumber;
            reportService = new EmployeeReportService();
        }

        // formats the date
        private string getFormattedDate(){
            return $"{orientationDate:M/d/yy}";
        }

        // calls all methods required for first time 
        // orientation and sets the date and time
        public void doFirstTimeOrientation(string cubeID){
            orientationDate = DateTime.Now;
            meetWithHrForBenefitAndSalaryInfo();
            meetDepartmentStaff();
            reviewDeptPolicies();
            moveIntoCubicle(cubeID);
            
        }
        // adds data for when employee met with hr and 
        // sets met with hr equal to true
        private void meetWithHrForBenefitAndSalaryInfo(){
            metWithHr = true;
            reportService.addData(firstName + " " + lastName + " met with hr on " 
            + getFormattedDate() + NEWLINE);
        }

        // adds data for when employee met with dept staff
        // and sets met with dept staff equal to true
        private void meetDepartmentStaff(){
            metDeptStaff = true;
            reportService.addData(firstName + " " + lastName + " met with dept staff on " 
            + getFormattedDate() + NEWLINE);
        }

        // adds data for when employee reviewed dept policies
        // and sets reviewed policies equal to true
        public void reviewDeptPolicies(){
            reviewedDeptPolicies = true;
            reportService.addData(firstName + " " + lastName + " reviewed dept policies on " 
            + getFormattedDate() + NEWLINE);
        }

        // adds data for when employee moved into cubicle
        // and sets moved in equal to
        public void moveIntoCubicle(string cubeId){
            cubeId = cubeID;

            this.movedIn = true;
            reportService.addData(firstName + " " + lastName + " moved in to cubicle " + cubeID + " on " + getFormattedDate() + NEWLINE);
            
        }
        public bool hasMetWithHr(){
            return metWithHr;
        }

        public bool hasMetDeptStaff(){
            return metDeptStaff;
        }

        public bool hasReviewedDeptPolicies(){
            return reviewedDeptPolicies;
        }

        public bool hasMovedIn(){
            return movedIn;
        }

        public string getSsn(){
            return ssn;
        }

        public void printReport(){
            reportService.outputReport();
        }

        public string toString(){
            return "Employee{" + "firstName=" + firstName + ", lasName=" + lastName + ", ssn=" + ssn + "}";
        }
    }

}