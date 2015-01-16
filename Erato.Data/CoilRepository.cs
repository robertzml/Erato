using Erato.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erato.Data
{
    /// <summary>
    /// 线圈 Repository
    /// </summary>
    public class CoilRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<Coil> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 线圈 Repository
        /// </summary>
        public CoilRepository()
        {
            this.repository = new MongoRepository<Coil>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有线圈
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Coil> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取线圈
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Coil Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加线圈
        /// </summary>
        /// <param name="data">线圈数据</param>
        /// <returns></returns>
        public ErrorCode Create(Coil data)
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
        /// 编辑线圈
        /// </summary>
        /// <param name="data">线圈数据</param>
        /// <returns></returns>
        public ErrorCode Update(Coil data)
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
        /// 删除线圈
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
        #endregion //Method
    }
}
