using MISA.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    public interface IEmployeeService: IBaseService<Employee>
    {
        /// <summary>
        /// Lấy danh sách nhân viên theo StoreProcedure
        /// </summary>
        /// <param name="procedureName">Tên StoreProcedure</param>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: HNANH (3/12/20200
        IEnumerable<Employee> GetEmployeeByProc(string procedureName);
        /// <summary>
        /// Tìm kiếm danh sách nhân viên theo từ khóa(theo mã, tên hoặc số điện thoại)
        /// </summary>
        /// <param name="procedureName">Tên StoreProcedure</param>
        /// <param name="searchText">Từ khóa tìm kiếm (theo mã, tên hoặc số điện thoại)</param>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: HNANH(3/12/2020)
        IEnumerable<Employee> GetEmployeeByCodeNamePhone(string procedureName, string searchText);
        /// <summary>
        /// Tìm kiếm danh sách nhân viên theo vị trí/chứ vụ, phòng ban
        /// </summary>
        /// <param name="procedureName">Tên StoreProcedure</param>
        /// <param name="positionId">Mã vị trí/chức vụ</param>
        /// <param name="departmentId">Mã phòng ban</param>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: HNANH(3/12/2020)
        IEnumerable<Employee> GetEmployeeByPositionDepartment(string procedureName, string positionId, string departmentId);
        IEnumerable<Employee> GetEmployeesFilter(string searchText, Guid? departmentId, Guid? positionId);
    }
}
