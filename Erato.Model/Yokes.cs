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
    /// 磁轭类
    /// </summary>
    [CollectionName("yokes")]
    public class Yokes : MongoEntity
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Required]
        [Display(Name = "LOTNO")]
        [BsonElement("lotNo")]
        [StringLength(18, MinimumLength = 18, ErrorMessage = "输入的LOTNO必须为18位！")]
        public string LotNo { get; set; }

        /// <summary>
        /// 品番
        /// </summary>
        [BsonElement("productNo")]
        [Required]
        [Display(Name = "品番")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "输入的品番必须为12位！")]
        public string ProductNo { get; set; }

        /// <summary>
        /// 型
        /// </summary>
        [Required]
        [Display(Name = "型")]
        [BsonElement("yoketype")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "输入的型必须为1位！")]
        public string YokeType { get; set; }

        /// <summary>
        /// ランク
        /// </summary>
        [Required]
        [Display(Name = "ランク")]
        [BsonElement("rank")]
        [StringLength(1, MinimumLength = 1, ErrorMessage = "输入的型必须为1位！")]
        public string Rank { get; set; }

        /// <summary>
        /// 总量
        /// </summary>
        [Required]
        [Display(Name = "总量")]
        [BsonElement("quantity")]
        [Range(0, Int32.MaxValue)]
        public int Quantity { get; set; }

        /// <summary>
        /// 使用量
        /// </summary>
        [Required]
        [Display(Name = "使用量")]
        [BsonElement("usedqty")]
        [Range(0, Int32.MaxValue)]
        public int UsedQty { get; set; }

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
