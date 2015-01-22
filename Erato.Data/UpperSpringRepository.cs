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
    /// 上板弹簧 Repository
    /// </summary>
    public class UpperSpringRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<UpperSpring> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 上板弹簧 Repository
        /// </summary>
        public UpperSpringRepository()
        {
            this.repository = new MongoRepository<UpperSpring>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有上板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UpperSpring> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取上板弹簧
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public UpperSpring Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加上板弹簧
        /// </summary>
        /// <param name="data">上板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Create(UpperSpring data)
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
        /// 编辑上板弹簧
        /// </summary>
        /// <param name="data">上板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Update(UpperSpring data)
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
        /// 删除上板弹簧
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
