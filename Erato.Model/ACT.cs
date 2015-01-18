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
    /// ACT组立类
    /// </summary>
    [CollectionName("Act")]
    public class ACT : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Required]
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


        [BsonElement("products")]
        [StringLength(1)]
        public string Products { get; set; }

        /// <summary>
        /// 线别
        /// </summary>
        [Display(Name = "线别")]
        [BsonElement("line")]
        public string Line { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        [Display(Name = "日期")]
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

        [BsonElement("springs")]
        public string Springs { get; set; }

        [BsonElement("yokes")]
        public string Yokes { get; set; }


        [BsonElement("buttom")]
        public string Buttom { get; set; }


        [BsonElement("defectiveNum")]
        public int DefectiveNum { get; set; }

        [BsonElement("output")]
        public int Output { get; set; }

        [BsonElement("defRecoder")]
        public string DefRecoder { get; set; }

        [BsonElement("stat")]
        public string Stat { get; set; }

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
