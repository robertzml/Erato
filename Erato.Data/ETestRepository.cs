using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;

namespace Erato.Data
{
    /// <summary>
    /// 电检 Repository 
    /// </summary>
    public class ETestRepository
    {
         #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<ETest> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 电检 Repository
        /// </summary>
        public ETestRepository()
        {
            this.repository = new MongoRepository<ETest>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有电检
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ETest> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取电检
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ETest Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加电检
        /// </summary>
        /// <param name="data">电检数据</param>
        /// <returns></returns>
        public ErrorCode Create(ETest data)
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
        /// 编辑电检
        /// </summary>
        /// <param name="data">电检数据</param>
        /// <returns></returns>
        public ErrorCode Update(ETest data)
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
        /// 删除电检
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
