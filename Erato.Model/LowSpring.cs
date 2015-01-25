using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Erato.Model
{
    /// <summary>
    /// 下板弹簧类
    /// </summary>
    [CollectionName("lowSpring")]
    public class LowSpring : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Display(Name = "LOTNO")]
        [Required]
        [BsonElement("lotNo")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "输入的LOTNO必须为9位！")]
        public string LotNo { get; set; }

        /// <summary>
        /// 品番
        /// </summary>
        [Required]
        [BsonElement("drawingno")]
        [Display(Name = "品番")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "输入的品番必须为13位！")]
        public string DrawingNo { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [Required]
        [Display(Name = "总量")]
        [BsonElement("quantity")]
        [Range(0, Int32.MaxValue)]
        public int Quantity { get; set; }

        /// <summary>
        /// 使用量
        /// </summary>
        [Required]
        [Display(Name = "使用量")]
        [BsonElement("usedqty")]
        [Range(0, Int32.MaxValue)]
        public int UsedQty { get; set; }

        /// <summary>
        /// 录入时间
        /// </summary>
        [BsonElement("operationTime")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [Display(Name = "录入时间")]
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// 录入人工号
        /// </summary>
        [BsonElement("operator")]
        [Display(Name = "录入人工号")]
        public string Operator { get; set; }
    }
}
