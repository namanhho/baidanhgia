using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface IEmployeeRepository: IBaseRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesFilter(string searchText, Guid? departmentId, Guid? positionId);
        /// <summary>
        /// Lấy khách hàng qua mã khách hàng
        /// </summary>
        /// <param name="EmployeeCode">Mã khách hàng</param>
        /// <returns>Khách hàng</returns>
        /// CreatedBy: HNANH (26/11/2020)
        Employee GetEmployeeByCode(string employeeCode);
        /// <summary>
        /// Lấy danh sách khách hàng qua mã khách hàng
        /// </summary>
        /// <param name="Employee">Object khách hàng</param>
        /// <returns>Danh sách khách hàng</returns>
        /// CreatedBy: HNANH (26/11/2020)
        Employee GetAllEmployeeByCode(Employee employee);
        /// <summary>
        /// Lấy danh sách khách hàng qua số điện thoại
        /// </summary>
        /// <param name="Employee">Object khách hàng</param>
        /// <returns>Danh sách khách hàng</returns>
        /// CreatedBy: HNANH (26/11/2020)
        Employee GetAllEmployeeByPhoneNumber(Employee employee);

    }
}
