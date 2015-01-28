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
    /// 部门 Repository
    /// </summary>
    public class DeptRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<Dept> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 部门 Repository
        /// </summary>
        public DeptRepository()
        {
            this.repository = new MongoRepository<Dept>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有部门
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Dept> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取部门
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Dept Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="data">部门数据</param>
        /// <returns></returns>
        public ErrorCode Create(Dept data)
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
        /// 编辑部门
        /// </summary>
        /// <param name="data">部门数据</param>
        /// <returns></returns>
        public ErrorCode Update(Dept data)
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
        /// 删除部门
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

        public bool DeptNoExists(string id)
        {
            return this.repository.Exists(n => n.DeptNo == id);
        }

        public bool DeptNameExists(string name)
        {
            return this.repository.Exists(n => n.DeptName == name);
        }
        #endregion //Method


    }
}
