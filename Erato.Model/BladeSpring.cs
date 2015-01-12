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
    [CollectionName("bladeSpring")]
    public class BladeSpring : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [BsonElement("lotNo")]
        public string LotNo { get; set; }

        /// <summary>
        /// 机种
        /// </summary>
        [Required]
        [BsonElement("type")]
        [Display(Name = "机种")]
        public string Type { get; set; }

        /// <summary>
        /// 客户名
        /// </summary>
        [Required]
        [BsonElement("custom")]
        [Display(Name = "客户名")]
        public string Custom { get; set; }

        /// <summary>
        /// 板弹簧
        /// </summary>
        [BsonElement("products")]
        [StringLength(1)]
        public string Products { get; set; }

        /// <summary>
        /// 线别
        /// </summary>
        [BsonElement("line")]
        public string Line { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [BsonElement("date")]
        public string Date { get; set; }

        [BsonElement("shifts")]
        public string Shifts { get; set; }

        [BsonElement("seqNum")]
        public string SeqNum { get; set; }

        [BsonElement("metalType")]
        public string MetalType { get; set; }

        [BsonElement("cavity")]
        public string Cavity { get; set; }

        [BsonElement("total")]
        public int Total { get; set; }

        [BsonElement("coils")]
        public string Coils { get; set; }

        [BsonElement("dsprings")]
        public string DSprings { get; set; }

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

        [BsonElement("operationTime")]
        public DateTime OperationTime { get; set; }

        [BsonElement("operator")]
        public string Operator { get; set; }
    }
}
