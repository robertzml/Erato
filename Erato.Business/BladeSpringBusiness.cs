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
    /// 板弹簧业务类
    /// </summary>
    public class BladeSpringBusiness
    {
        #region Field
        /// <summary>
        /// 板弹簧 Repsitory
        /// </summary>
        private BladeSpringRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 板弹簧业务类
        /// </summary>
        public BladeSpringBusiness()
        {
            this.bladeSpringRepository = new BladeSpringRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BladeSpring> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取板弹簧
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public BladeSpring Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <param name="data">板弹簧对象</param>
        /// <returns></returns>
        public ErrorCode Create(BladeSpring data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑板弹簧,对象整体更新
        /// </summary>
        /// <param name="data">板弹簧对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(BladeSpring data)
        {
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑板弹簧,对象部分更新
        /// </summary>
        /// <param name="data">板弹簧对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(BladeSpring data)
        {
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除板弹簧
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
