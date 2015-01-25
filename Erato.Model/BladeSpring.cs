﻿using System;
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
        [Required]
        [Display(Name = "LOTNO")]
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
        /// 客户
        /// </summary>
        [Required]
        [BsonElement("custom")]
        [Display(Name = "客户")]
        public string Custom { get; set; }

        /// <summary>
        /// 板弹簧
        /// </summary>
        [Display(Name = "板弹簧")]
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

        /// <summary>
        /// 班别
        /// </summary>
        [Display(Name = "班别")]
        [BsonElement("shifts")]
        public string Shifts { get; set; }

        /// <summary>
        /// 顺番号
        /// </summary>
        [Display(Name = "顺番号")]
        [BsonElement("seqNum")]
        public string SeqNum { get; set; }

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
        /// 数量
        /// </summary>
        [Range(0, Int32.MaxValue)]
        [Display(Name = "数量")]
        [BsonElement("total")]
        public int Total { get; set; }

        /// <summary>
        /// 线圈部材
        /// </summary>
        [Display(Name = "线圈部材")]
        [BsonElement("coils")]
        public string Coils { get; set; }

        /// <summary>
        /// 下板弹簧部材
        /// </summary>
        [Display(Name = "下板弹簧部材")]
        [BsonElement("dsprings")]
        public string DSprings { get; set; }

        /// <summary>
        /// 不良数
        /// </summary>
        [Display(Name = "不良数")]
        [BsonElement("defectiveNum")]
        public int DefectiveNum { get; set; }

        /// <summary>
        /// 外观后数量
        /// </summary>
        [Display(Name = "外观后数量")]
        [BsonElement("output")]
        public int Output { get; set; }

        /// <summary>
        /// 外观人员
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
        /// 录入人工号
        /// </summary>
        [Display(Name = "录入人工号")]
        [BsonElement("operator")]
        public string Operator { get; set; }
    }
}
