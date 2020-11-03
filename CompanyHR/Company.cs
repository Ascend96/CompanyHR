using System;

namespace CompanyHR
{

public class Company {
    private HrPerson hr;

    // constructor
    public Company(){
        hr = new HrPerson();
    }

    // hires employee
    // outputs report as long as ssn matches
    public void hireEmployee(string firstName, string lastName, string ssn){
        hr.hireEmployee(firstName, lastName, ssn);
        hr.outputReport(ssn);
    }
    
    
    }
}