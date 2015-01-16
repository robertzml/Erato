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
    /// 下板弹簧业务类
    /// </summary>
    public class LowSpringBusiness
    {
        #region Field
        /// <summary>
        /// 下板弹簧 Repsitory
        /// </summary>
        private LowSpringRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 下板弹簧业务类
        /// </summary>
        public LowSpringBusiness()
        {
            this.bladeSpringRepository = new LowSpringRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有下板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<LowSpring> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取下板弹簧
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public LowSpring Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加下板弹簧
        /// </summary>
        /// <param name="data">下板弹簧对象</param>
        /// <returns></returns>
        public ErrorCode Create(LowSpring data)
        {
            data.OperationTime =DateTime.Now;
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑下板弹簧,对象整体更新
        /// </summary>
        /// <param name="data">下板弹簧对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(LowSpring data)
        {
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑下板弹簧,对象部分更新
        /// </summary>
        /// <param name="data">下板弹簧对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(LowSpring data)
        {
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除下板弹簧
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
