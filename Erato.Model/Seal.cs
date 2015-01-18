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
    /// 封止类
    /// </summary>
    [CollectionName("seal")]
    public class Seal : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Required]
        [BsonElement("lotNo")]
        public string LotNo { get; set; }

        [BsonElement("metalType")]
        public string MetalType { get; set; }

        [BsonElement("cavity")]
        public string Cavity { get; set; }

        [BsonElement("total")]
        public int Total { get; set; }

        [BsonElement("defectiveNum")]
        public int DefectiveNum { get; set; }

        [BsonElement("output")]
        public int Output { get; set; }

        [BsonElement("defRecoder")]
        public string DefRecoder { get; set; }

        [BsonElement("stat")]
        public string Stat { get; set; }

        [BsonElement("cleanOperator")]
        public string CleanOperator { get; set; }

        /// <summary>
        /// 操作时间
        /// </summary>
        [Display(Name = "操作时间")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        [BsonElement("operationTime")]
        public DateTime OperationTime { get; set; }

        /// <summary>
        /// 操作人
        /// </summary>
        [Display(Name = "操作人")]
        [BsonElement("operator")]
        public string Operator { get; set; }
    }
}
