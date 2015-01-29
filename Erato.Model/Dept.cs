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
    /// 线圈类
    /// </summary>
    [CollectionName("dept")]
    public class Dept : MongoEntity
    {
        /// <summary>
        /// 部门编号
        /// </summary>
        [Required]
        [Display(Name = "部门编号")]
        [BsonElement("deptNo")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "输入的部门编号必须为4位！")]
        public string DeptNo { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        [BsonElement("deptName")]
        [Required]
        [Display(Name = "部门名称")]
        [StringLength(30, ErrorMessage = "输入的部门名称必须小于30位！")]
        public string DeptName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [BsonElement("remarks")]
        [Display(Name = "备注")]
        [StringLength(30, ErrorMessage = "输入的备注必须小于30位！")]
        public string Remarks { get; set; }


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
