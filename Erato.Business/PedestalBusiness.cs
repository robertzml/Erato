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
    /// 底座业务类
    /// </summary>
    public class PedestalBusiness
    {
        #region Field
        /// <summary>
        /// 底座 Repsitory
        /// </summary>
        private PedestalRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 底座业务类
        /// </summary>
        public PedestalBusiness()
        {
            this.bladeSpringRepository = new PedestalRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有底座
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Pedestal> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取底座
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Pedestal Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加底座
        /// </summary>
        /// <param name="data">底座对象</param>
        /// <returns></returns>
        public ErrorCode Create(Pedestal data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑底座,对象整体更新
        /// </summary>
        /// <param name="data">底座对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Pedestal data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑底座,对象部分更新
        /// </summary>
        /// <param name="data">底座对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Pedestal data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除底座
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
