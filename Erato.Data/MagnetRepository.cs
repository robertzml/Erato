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
    /// 磁石 Repository
    /// </summary>
    public class MagnetRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<Magnet> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 磁石 Repository
        /// </summary>
        public MagnetRepository()
        {
            this.repository = new MongoRepository<Magnet>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有磁石
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Magnet> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取磁石
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Magnet Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加磁石
        /// </summary>
        /// <param name="data">磁石数据</param>
        /// <returns></returns>
        public ErrorCode Create(Magnet data)
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
        /// 编辑磁石
        /// </summary>
        /// <param name="data">磁石数据</param>
        /// <returns></returns>
        public ErrorCode Update(Magnet data)
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
        /// 删除磁石
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
