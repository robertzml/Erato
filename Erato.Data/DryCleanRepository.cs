using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;

namespace Erato.Data
{
    /// <summary>
    /// 洗净干燥 Repository
    /// </summary>
    public class DryCleanRepository
    {
         #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<DryClean> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 板弹簧 Repository
        /// </summary>
        public DryCleanRepository()
        {
            this.repository = new MongoRepository<DryClean>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有洗净干燥
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DryClean> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取洗净干燥
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public DryClean Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加洗净干燥
        /// </summary>
        /// <param name="data">洗净干燥数据</param>
        /// <returns></returns>
        public ErrorCode Create(DryClean data)
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
        /// 编辑洗净干燥
        /// </summary>
        /// <param name="data">洗净干燥数据</param>
        /// <returns></returns>
        public ErrorCode Update(DryClean data)
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
        /// 删除洗净干燥
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
