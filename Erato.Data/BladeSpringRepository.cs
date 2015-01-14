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
    /// 板弹簧 Repository
    /// </summary>
    public class BladeSpringRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<BladeSpring> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 板弹簧 Repository
        /// </summary>
        public BladeSpringRepository()
        {
            this.repository = new MongoRepository<BladeSpring>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BladeSpring> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取板弹簧
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public BladeSpring Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <param name="data">板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Create(BladeSpring data)
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
        /// 编辑板弹簧
        /// </summary>
        /// <param name="data">板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Update(BladeSpring data)
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
        /// 删除板弹簧
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
