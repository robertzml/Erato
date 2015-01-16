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
    /// 线圈业务类
    /// </summary>
    public class CoilBusiness
    {
        #region Field
        /// <summary>
        /// 线圈 Repsitory
        /// </summary>
        private CoilRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 线圈业务类
        /// </summary>
        public CoilBusiness()
        {
            this.bladeSpringRepository = new CoilRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有线圈
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Coil> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取线圈
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Coil Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加线圈
        /// </summary>
        /// <param name="data">线圈对象</param>
        /// <returns></returns>
        public ErrorCode Create(Coil data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑线圈,对象整体更新
        /// </summary>
        /// <param name="data">线圈对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Coil data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑线圈,对象部分更新
        /// </summary>
        /// <param name="data">线圈对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Coil data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除线圈
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
