using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Data;
using Erato.Model;

namespace Erato.Business
{
    /// <summary>
    /// 磁石业务类
    /// </summary>
    public class MagnetBusiness
    {
        #region Field
        /// <summary>
        /// 磁石 Repsitory
        /// </summary>
        private MagnetRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 磁石业务类
        /// </summary>
        public MagnetBusiness()
        {
            this.bladeSpringRepository = new MagnetRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有磁石
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Magnet> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取磁石
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Magnet Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加磁石
        /// </summary>
        /// <param name="data">磁石对象</param>
        /// <returns></returns>
        public ErrorCode Create(Magnet data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑磁石,对象整体更新
        /// </summary>
        /// <param name="data">磁石对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Magnet data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑磁石,对象部分更新
        /// </summary>
        /// <param name="data">磁石对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Magnet data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除磁石
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.bladeSpringRepository.Delete(id);
        }
        #endregion //Method
    }
}
