using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;

namespace Erato.Data
{
    /// <summary>
    /// 封止 Repository
    /// </summary>
    public class SealRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<Seal> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 封止 Repository
        /// </summary>
        public SealRepository()
        {
            this.repository = new MongoRepository<Seal>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有封止
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Seal> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取封止
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Seal Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加封止
        /// </summary>
        /// <param name="data">封止数据</param>
        /// <returns></returns>
        public ErrorCode Create(Seal data)
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
        /// 编辑封止
        /// </summary>
        /// <param name="data">封止数据</param>
        /// <returns></returns>
        public ErrorCode Update(Seal data)
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
        /// 删除封止
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
