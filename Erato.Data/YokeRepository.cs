using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;

namespace Erato.Data
{
    /// <summary>
    /// 磁轭 Repository
    /// </summary>
    public class YokeRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<Yoke> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 磁轭 Repository
        /// </summary>
        public YokeRepository()
        {
            this.repository = new MongoRepository<Yoke>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有磁轭
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Yoke> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取磁轭
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Yoke Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加磁轭
        /// </summary>
        /// <param name="data">磁轭数据</param>
        /// <returns></returns>
        public ErrorCode Create(Yoke data)
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
        /// 编辑磁轭
        /// </summary>
        /// <param name="data">磁轭数据</param>
        /// <returns></returns>
        public ErrorCode Update(Yoke data)
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
        /// 删除磁轭
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
