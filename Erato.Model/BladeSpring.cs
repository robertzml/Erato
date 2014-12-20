using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erato.Model
{
    /// <summary>
    /// 板弹簧类
    /// </summary>
    public class BladeSpring
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        public string LotNo { get; set; }

        /// <summary>
        /// 机种
        /// </summary>
        public string MachineType { get; set; }

        /// <summary>
        /// 客户名
        /// </summary>
        public string ClientName { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// 班别
        /// </summary>
        public string Batch { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <remarks>
        /// 最大1000
        /// </remarks>
        public int Count { get; set; }
    }
}
