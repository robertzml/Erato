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
    /// 最终检查类
    /// </summary>
    [CollectionName("finalCheck")]
    public class FinalCheck : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Required]
        [Display(Name = "LOTNO")]
        [BsonElement("lotNo")]
        public string LotNo { get; set; }

        /// <summary>
        /// 金型
        /// </summary>
        [Display(Name = "金型")]
        [BsonElement("metalType")]
        public string MetalType { get; set; }

        /// <summary>
        /// 腔体
        /// </summary>
        [Display(Name = "腔体")]
        [BsonElement("cavity")]
        public string Cavity { get; set; }

        /// <summary>
        /// 总产量
        /// </summary>
        [Display(Name = "总产量")]
        [BsonElement("total")]
        public int Total { get; set; }

        /// <summary>
        /// 不良数
        /// </summary>
        [Display(Name = "不良数")]
        [BsonElement("defectiveNum")]
        public int DefectiveNum { get; set; }

        /// <summary>
        /// 良品数
        /// </summary>
        [Display(Name = "良品数")]
        [BsonElement("output")]
        public int Output { get; set; }

        /// <summary>
        /// 不良数录入人工号
        /// </summary>
        [Display(Name = "不良数录入人工号")]
        [BsonElement("defRecoder")]
        public string DefRecoder { get; set; }

        /// <summary>
        /// 状态, 0:完成，1:未完成
        /// </summary>
        [Display(Name = "状态")]
        [BsonElement("stat")]
        public string Stat { get; set; }

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
