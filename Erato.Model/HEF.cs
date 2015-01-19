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
    /// HEF洗净类
    /// </summary>
    [CollectionName("hef")]
    public class HEF : MongoEntity
    {
        /// <summary>
        /// LotNo
        /// </summary>
        [Required]
        [Display(Name = "LotNo")]
        [BsonElement("lotNo")]
        public string LotNo { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Display(Name = "操作时间")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("operationTime")]
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        [Display(Name = "操作员")]
        [BsonElement("operation")]
        public string Operator { get; set; }
    }
}
