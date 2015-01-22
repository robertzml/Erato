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
    /// 上板弹簧业务类
    /// </summary>
    public class UpperSpringBusiness
    {
        #region Field
        /// <summary>
        /// 上板弹簧 Repsitory
        /// </summary>
        private UpperSpringRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 上板弹簧业务类
        /// </summary>
        public UpperSpringBusiness()
        {
            this.bladeSpringRepository = new UpperSpringRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有上板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UpperSpring> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取上板弹簧
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public UpperSpring Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加上板弹簧
        /// </summary>
        /// <param name="data">上板弹簧对象</param>
        /// <returns></returns>
        public ErrorCode Create(UpperSpring data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑上板弹簧,对象整体更新
        /// </summary>
        /// <param name="data">上板弹簧对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(UpperSpring data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑上板弹簧,对象部分更新
        /// </summary>
        /// <param name="data">上板弹簧对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(UpperSpring data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除上板弹簧
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
