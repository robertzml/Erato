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
    /// 上板弹簧类
    /// </summary>
    [CollectionName("upperspring")]
    public class UpperSpring : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Required]
        [Display(Name = "LOTNO")]
        [BsonElement("lotNo")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "输入的LOTNO必须为9位！")]
        public string LotNo { get; set; }

        /// <summary>
        /// 品番
        /// </summary>
        [BsonElement("productNo")]
        [Required]
        [Display(Name = "品番")]
        [StringLength(13, MinimumLength = 13, ErrorMessage = "输入的品番必须为13位！")]
        public string ProductNo { get; set; }


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
        [Display(Name = "录入时间")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("operationTime")]
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// 录入人工号
        /// </summary>
        [Display(Name = "录入人工号")]
        [BsonElement("operator")]
        public string Operator { get; set; }
    }
}
