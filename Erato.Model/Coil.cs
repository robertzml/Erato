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
    /// 板弹簧类
    /// </summary>
    [CollectionName("coil")]
    public class Coil : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [BsonElement("lotNo")]
        [Required]
        [Display(Name = "LOTNO")]
        public string LotNo { get; set; }

        /// <summary>
        /// 品番
        /// </summary>
        [BsonElement("productNo")]
        [Required]
        [Display(Name = "品番")]
        public string ProductNo { get; set; }

        [BsonElement("cavity")]
        [Required]
        [Display(Name = "cav")]
        public string Cavity { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [BsonElement("quantity")]
        [Required]
        [Display(Name = "数量")]
        public int Quantity { get; set; }

        /// <summary>
        /// 上次操作时间
        /// </summary>
        [BsonElement("operationTime")]
        [Display(Name = "上次操作时间")]
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// 上次操作人
        /// </summary>
        [BsonElement("operator")]
        [Display(Name = "上次操作人")]
        public string Operator { get; set; }
    }
}
