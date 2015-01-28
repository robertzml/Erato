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
    /// 线圈类
    /// </summary>
    [CollectionName("coil")]
    public class Coil : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Required]
        [Display(Name = "LOTNO")]
        [BsonElement("lotNo")]
        [StringLength(17, MinimumLength = 17, ErrorMessage = "输入的LOTNO必须为17位！")]
        public string LotNo { get; set; }

        /// <summary>
        /// 品番
        /// </summary>
        [BsonElement("productNo")]
        [Required]
        [Display(Name = "品番")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "输入的品番必须为12位！")]
        [RegularExpressionAttribute(@"\b2AE-00082\w{3}\b", ErrorMessage = "输入的品番必须以2AE-00082打头,并且输入总长度为12位！")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 腔体
        /// </summary>
        [Required]
        [Display(Name = "腔体")]
        [BsonElement("cavity")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "输入的腔体必须为2位！")]
        public string Cavity { get; set; }

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
