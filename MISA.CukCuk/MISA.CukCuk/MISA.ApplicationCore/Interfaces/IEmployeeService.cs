using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface IEmployeeService: IBaseService<Employee>
    {
        IEnumerable<Employee> GetEmployeeByProc(string procedureName);
        IEnumerable<Employee> GetEmployeeByCodeNamePhone(string procedureName, string searchText);
    }
}
