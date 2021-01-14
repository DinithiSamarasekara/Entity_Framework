using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Demo
{
    internal class EmployeeRepo : IEmployeeRepo
    {
        public readonly EmployeeContext employeeContext;
        
        public EmployeeRepo(EmployeeContext employeeContext)
        {
            this.employeeContext = employeeContext;
        }
        Employee Create(string firstNamr,
            string lastName,
            string address,
            string homePhone,
            string cellPhone)
        {
            var response = employeeContext.Add(new Employee
            {
                FirstName=firstNamr,
                LastName=lastName,
                Address=address,
                HomePhoned=homePhone,
                CellPhone=cellPhone
            });
            employeeContext.SaveChanges();
            return response.Entity;
        }
        Employee Update(Employee employee)
        {
            var response = employeeContext.Update(employee);
            employeeContext.SaveChanges();
            return response.Entity;
        }

        void Delate(Employee employee)
        {
            employeeContext.Remove(employee);
            employeeContext.SaveChanges();
        }
    }
}
