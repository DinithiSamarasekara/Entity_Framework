using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Demo
{
    internal class IEmployeeRepo
    {
        Employee Create(string firstNamr,
            string lastName,
            string address,
            string homePhone,
            string cellPhone);
        Employee Update(Employee employee);

        void Delate(Employee employee);
    }
}
