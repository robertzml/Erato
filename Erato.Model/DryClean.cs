using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Erato.Model
{
    /// <summary>
    /// 洗净干燥类
    /// </summary>
    [CollectionName("dryClean")]
    public class DryClean : MongoEntity
    {
        /// <summary>
        /// LotNo
        /// </summary>
        [Required]
        [Display(Name = "LOTNO")]
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
        [BsonElement("operator")]
        public string Operator { get; set; }
    }
}
