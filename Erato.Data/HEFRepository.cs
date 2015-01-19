using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;

namespace Erato.Data
{
    /// <summary>
    /// HEF洗净 Repository
    /// </summary>
    public class HEFRepository
    {
         #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<HEF> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// HEF洗净 Repository
        /// </summary>
        public HEFRepository()
        {
            this.repository = new MongoRepository<HEF>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有HEF洗净
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HEF> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取HEF洗净
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public HEF Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加HEF洗净
        /// </summary>
        /// <param name="data">HEF洗净数据</param>
        /// <returns></returns>
        public ErrorCode Create(HEF data)
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
        /// 编辑HEF洗净
        /// </summary>
        /// <param name="data">HEF洗净数据</param>
        /// <returns></returns>
        public ErrorCode Update(HEF data)
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
        /// 删除HEF洗净
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
