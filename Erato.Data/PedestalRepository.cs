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
    /// 底座 Repository
    /// </summary>
    public class PedestalRepository
    {
        #region Field
        /// <summary>
        /// Repository对象
        /// </summary>
        private IMongoRepository<Pedestal> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 底座 Repository
        /// </summary>
        public PedestalRepository()
        {
            this.repository = new MongoRepository<Pedestal>(RheaServer.EratoDatabase);
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有底座
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pedestal> Get()
        {
            return this.repository.AsEnumerable();
        }

        /// <summary>
        /// 获取底座
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Pedestal Get(string id)
        {
            return this.repository.GetById(id);
        }

        /// <summary>
        /// 添加底座
        /// </summary>
        /// <param name="data">底座数据</param>
        /// <returns></returns>
        public ErrorCode Create(Pedestal data)
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
        /// 编辑底座
        /// </summary>
        /// <param name="data">底座数据</param>
        /// <returns></returns>
        public ErrorCode Update(Pedestal data)
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
        /// 删除底座
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
