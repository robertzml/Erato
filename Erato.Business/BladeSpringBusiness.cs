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
        /// 添加板弹簧
        /// </summary>
        /// <param name="data">板弹簧对象</param>
        /// <returns></returns>
        public ErrorCode Create(BladeSpring data)
        {
            return this.bladeSpringRepository.Create(data);
        }
        #endregion //Method
    }
}
