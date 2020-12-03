using MISA.ApplicationCore.Entities;
using MISA.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Services
{
    public class EmployeeService :BaseService<Employee>, IEmployeeService
    {
        IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository): base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public IEnumerable<Employee> GetEmployeeByCodeNamePhone(string procedureName, string searchText)
        {
            return _employeeRepository.GetEntities(procedureName, searchText);
        }
        public IEnumerable<Employee> GetEmployeeByPositionDepartment(string procedureName, string positionId, string departmentId)
        {
            return _employeeRepository.GetEntities(procedureName, positionId, departmentId);
        }
        public IEnumerable<Employee> GetEmployeeByProc(string procedureName)
        {
           return _employeeRepository.GetEntities(procedureName);
        }

        public IEnumerable<Employee> GetEmployeesFilter(string searchText, Guid? departmentId, Guid? positionId)
        {
            return _employeeRepository.GetEmployeesFilter(searchText, departmentId, positionId);
        }
    }
        //IEmployeeRepository _employeeRepository;
        //public EmployeeService(IEmployeeRepository employeeRepository)
        //{
        //    _employeeRepository = employeeRepository;
        //}
        //public int DeleteEmployee(string employeeId)
        //{
        //    throw new NotImplementedException();
        //}

        //public Employee GetEmployeeById(string employeeId)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<Employee> GetEmployees()
        //{
        //    return _employeeRepository.GetEmployees();
        //}

        //public int InsertEmployee(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}

        //public int UpdateEmployee(Employee employee)
        //{
        //    throw new NotImplementedException();
        //}
        //}
    }
