using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyHR
{
public class HrPerson{
    private List<Employee> employees;  

    // constructor
    public HrPerson(){ employees = new List<Employee>(); }

    // creates new employee
    // adds to list
    // calls orientEmployee method

    public void hireEmployee(string firstName, string lastName, string ssn){
        Employee e = new Employee(firstName, lastName, ssn);
        employees.Add(e);
        orientEmployee(e);
    }

    // does first time orientation for employee
    // and sets cubicle equal to B101
    private void orientEmployee(Employee emp){
        emp.doFirstTimeOrientation("B101");
    }

    // if all required orientation methods are true 
    // prints all employees in list and reports data
    public void outputReport(string ssn){

        foreach(Employee emp in employees){
            if(emp.getSsn().Equals(ssn)){
                if(emp.hasMetWithHr() && emp.hasMetDeptStaff()
                && emp.hasReviewedDeptPolicies() && emp.hasMovedIn()){
                    emp.printReport();
                }
                break;
                }
            }
        }
    }
}