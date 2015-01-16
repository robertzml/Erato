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
    /// 下板弹簧 Repository
    /// </summary>
    public class LowSpringRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<LowSpring> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 下板弹簧 Repository
        /// </summary>
        public LowSpringRepository()
        {
            this.repository = new MongoRepository<LowSpring>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有下板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LowSpring> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取下板弹簧
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public LowSpring Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加下板弹簧
        /// </summary>
        /// <param name="data">下板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Create(LowSpring data)
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
        /// 编辑下板弹簧
        /// </summary>
        /// <param name="data">下板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Update(LowSpring data)
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
        /// 删除下板弹簧
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
