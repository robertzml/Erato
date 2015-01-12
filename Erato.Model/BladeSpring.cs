using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erato.Model
{
    /// <summary>
    /// 板弹簧类
    /// </summary>
    public class BladeSpring : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        public string LotNo { get; set; }

        /// <summary>
        /// 机种
        /// </summary>
        [Required]
        [Display(Name = "机种")]
        public string Type { get; set; }

        /// <summary>
        /// 客户名
        /// </summary>
        [Required]
        [Display(Name = "客户名")]
        public string Custom { get; set; }

        [StringLength(1)]
        public string Products { get; set; }

        /// <summary>
        /// 线别
        /// </summary>
        public string Line { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        public string Date { get; set; }

        public string Shifts { get; set; }

        public string SeqNum { get; set; }

        public string MetalType { get; set; }

        public string Cavity { get; set; }

        public int Total { get; set; }

        public string Coils { get; set; }

        public string DSprings { get; set; }

        public int DefectiveNum { get; set; }

        public int Output { get; set; }

        public string DefRecoder { get; set; }

        public string Stat { get; set; }

        public string CleanOperator { get; set; }

        public DateTime OperationTime { get; set; }

        public string Operator { get; set; }
    }
}
