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
        /// 数量
        /// </summary>
        [Required]
        [Display(Name = "数量")]
        [BsonElement("quantity")]
        [Range(0, Int32.MaxValue)]
        public int Quantity { get; set; }

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
