using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Data;
using Erato.Model;

namespace Erato.Business
{
    /// <summary>
    /// 角色业务类
    /// </summary>
    public class RoleBusiness
    {
        #region Field
        /// <summary>
        /// 角色 Repsitory
        /// </summary>
        private RoleRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 角色业务类
        /// </summary>
        public RoleBusiness()
        {
            this.bladeSpringRepository = new RoleRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有角色
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Role> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取角色
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Role Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="data">角色对象</param>
        /// <returns></returns>
        public ErrorCode Create(Role data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑角色,对象整体更新
        /// </summary>
        /// <param name="data">角色对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Role data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑角色,对象部分更新
        /// </summary>
        /// <param name="data">角色对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Role data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.bladeSpringRepository.Delete(id);
        }

        /// <summary>
        /// 角色编号是否存在
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public bool RoleNoExists(string id)
        {
            return this.bladeSpringRepository.RoleNoExists(id);
        }

        /// <summary>
        /// 角色名称是否存在
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public bool RoleNameExists(string id)
        {
            return this.bladeSpringRepository.RoleNameExists(id);
        }
        #endregion //Method
    }
}
