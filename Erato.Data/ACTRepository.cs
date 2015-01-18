using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;

namespace Erato.Data
{
    /// <summary>
    /// ACT组立 Repository
    /// </summary>
    public class ACTRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<ACT> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// ACT组立 Repository
        /// </summary>
        public ACTRepository()
        {
            this.repository = new MongoRepository<ACT>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有ACT组立
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ACT> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取ACT组立
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ACT Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <param name="data">ACT组立数据</param>
        /// <returns></returns>
        public ErrorCode Create(ACT data)
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
        /// 编辑ACT组立
        /// </summary>
        /// <param name="data">ACT组立数据</param>
        /// <returns></returns>
        public ErrorCode Update(ACT data)
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
        /// 删除ACT组立
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
