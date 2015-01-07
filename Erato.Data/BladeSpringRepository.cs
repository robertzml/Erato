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
    /// 
    /// </summary>
    public class BladeSpringRepository
    {
        #region Field
        
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 用户 Repository
        /// </summary>
        public BladeSpringRepository()
        {
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BladeSpring> Get()
        {
            return null;
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <param name="data">板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Create(BladeSpring data)
        {
            return ErrorCode.NotImplement;
        }
        #endregion //Method
    }
}
