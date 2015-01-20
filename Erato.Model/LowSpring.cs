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
        [BsonElement("lotNo")]
        public string LotNo { get; set; }

        /// <summary>
        /// 品番
        /// </summary>
        [Required]
        [BsonElement("drawingno")]
        [Display(Name = "品番")]
        public string DrawingNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Required]
        [BsonElement("quantity")]
        [Display(Name = "数量")]
        public int Quantity { get; set; }

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
