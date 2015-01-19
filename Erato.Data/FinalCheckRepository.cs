using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;

namespace Erato.Data
{
    /// <summary>
    /// 最终检查 Repository
    /// </summary>
    public class FinalCheckRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<FinalCheck> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 最终检查 Repository
        /// </summary>
        public FinalCheckRepository()
        {
            this.repository = new MongoRepository<FinalCheck>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有最终检查
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FinalCheck> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取最终检查
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public FinalCheck Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加最终检查
        /// </summary>
        /// <param name="data">最终检查数据</param>
        /// <returns></returns>
        public ErrorCode Create(FinalCheck data)
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
        /// 编辑最终检查
        /// </summary>
        /// <param name="data">最终检查数据</param>
        /// <returns></returns>
        public ErrorCode Update(FinalCheck data)
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
        /// 删除最终检查
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
