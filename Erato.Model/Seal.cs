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
        [Display(Name = "LOTNO")]
        [BsonElement("lotNo")]
        public string LotNo { get; set; }

        /// <summary>
        /// 金型
        /// </summary>
        [Display(Name = "金型")]
        [RegularExpression(@"[a-zA-Z]{1}", ErrorMessage = "请输入1位字母")]
        [BsonElement("metalType")]
        public string MetalType { get; set; }

        /// <summary>
        /// 腔体
        /// </summary>
        [Display(Name = "腔体")]
        [BsonElement("cavity")]
        public string Cavity { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Display(Name = "数量")]
        [Range(0, 1000)]
        [BsonElement("total")]
        public int Total { get; set; }

        /// <summary>
        /// 外观后数量
        /// </summary>
        /// <remarks>
        /// 良品数
        /// </remarks>
        [Display(Name = "外观后数量")]
        [Range(0, 1000)]
        [BsonElement("output")]
        public int Output { get; set; }

        /// <summary>
        /// 不良数
        /// </summary>
        [Display(Name = "不良数")]
        [Range(0, 1000)]
        [BsonElement("defectiveNum")]
        public int DefectiveNum { get; set; }

        /// <外观人员>
        /// 不良数录入人工号
        /// </summary>
        [Display(Name = "外观人员")]
        [BsonElement("defRecoder")]
        public string DefRecoder { get; set; }

        /// <summary>
        /// 状态, 0:完成，1:未完成
        /// </summary>
        [Display(Name = "状态")]
        [BsonElement("stat")]
        public string Stat { get; set; }

        /// <summary>
        /// 干燥洗净人员工号
        /// </summary>
        [Display(Name = "干燥洗净人员工号")]
        [BsonElement("cleanOperator")]
        public string CleanOperator { get; set; }

        /// <summary>
        /// 录入时间
        /// </summary>
        [Display(Name = "录入时间")]
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
