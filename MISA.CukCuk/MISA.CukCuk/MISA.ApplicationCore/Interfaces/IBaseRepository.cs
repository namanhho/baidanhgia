using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MISA.ApplicationCore.Interfaces
{
    /// <summary>
    /// Interface dùng chung cho việc thao tác với csdl
    /// </summary>
    /// CreatedBy: HNANH (27/11/2020)
    public interface IBaseRepository<TEntity>
    {
        /// <summary>
        /// Lấy toàn bộ danh sách thực thể
        /// </summary>
        /// <returns>Danh sách thực thể</returns>
        /// CreatedBy: HNANH (27/11/2020)
        IEnumerable<TEntity> GetEntities();
        /// <summary>
        ///Lấy danh sách nhân viên  qua StoreProcedure
        /// </summary>
        /// <param name="procedureName">Tên store</param>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: HNANH (3/12/2020)
        IEnumerable<TEntity> GetEntities(string procedureName);
        /// <summary>
        /// Tìm kiếm danh sách nhân viên theo từ khóa
        /// </summary>
        /// <param name="procedureName">Tên StoreProcedure</param>
        /// <param name="searchText">Từ khóa tìm kiếm</param>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: HNANH (3/12/2020)
        IEnumerable<TEntity> GetEntities(string procedureName, string searchText);
        /// <summary>
        ///Tìm kiếm danh sách nhân viên qua vị trí/chức vụ, phòng ban
        /// </summary>
        /// <param name="procedureName">Tên StoreProcedure</param>
        /// <param name="positionId">Mã vị trí/chức vụ</param>
        /// <param name="departmentId">Mã phòng ban</param>
        /// <returns>Danh sách nhân viên</returns>
        /// CreatedBy: HNANH (3/12/2020)
        IEnumerable<TEntity> GetEntities(string procedureName, string positionId, string departmentId);
        /// <summary>
        /// Lấy thông tin thực thể qua id
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>Thông tin thực thể có Id = entityId</returns>
        /// CreatedBy HNANH (27/11/2020)
        TEntity GetEntityById(string entityId);
        /// <summary>
        /// Thêm mới thực thể
        /// </summary>
        /// <param name="entity">Object thực thể</param>
        /// <returns>Số bản ghi thêm mới</returns>
        /// CreatedBy HNANH (27/11/2020)
        int Insert(TEntity entity);
        /// <summary>
        /// Sửa thông tin thực thể
        /// </summary>
        /// <param name="entity">Obj thực thể</param>
        /// <returns>Số bản ghi được sửa</returns>
        /// CreatedBy: HNANH (27/11/2020)
        int Update(TEntity entity);
        /// <summary>
        /// Xóa thực thể
        /// </summary>
        /// <param name="entityId">Khóa chính</param>
        /// <returns>Số bản ghi xóa được</returns>
        /// CreatedBy: HNANH (27/11/2020)
        int Delete(string entityId);

        TEntity GetEntityByProperty(TEntity entity, PropertyInfo property);
    }
}
