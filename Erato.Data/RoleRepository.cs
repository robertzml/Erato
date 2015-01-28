using Erato.Model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erato.Data
{
    /// <summary>
    /// 角色 Repository
    /// </summary>
    public class RoleRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<Role> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 角色 Repository
        /// </summary>
        public RoleRepository()
        {
            this.repository = new MongoRepository<Role>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有角色
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Role> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取角色
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Role Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="data">角色数据</param>
        /// <returns></returns>
        public ErrorCode Create(Role data)
        {
            try
            {
                this.repository.Add(data);

                return ErrorCode.Success;
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }
        }

        /// <summary>
        /// 编辑角色
        /// </summary>
        /// <param name="data">角色数据</param>
        /// <returns></returns>
        public ErrorCode Update(Role data)
        {
            try
            {
                this.repository.Update(data);
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            try
            {
                this.repository.Delete(id);
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }

        public bool RoleNoExists(string id)
        {
            return this.repository.Exists(n => n.RoleNo == id);
        }

        public bool RoleNameExists(string name)
        {
            return this.repository.Exists(n => n.RoleName == name);
        }
        #endregion //Method


    }
}
