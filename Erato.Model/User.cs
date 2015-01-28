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
    [CollectionName("user")]
    public class User : MongoEntity
    {
        /// <summary>
        /// 用户名
        /// </summary>       
        [BsonElement("userName")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>     
        [BsonElement("password")]
        [Display(Name = "密码")]
        public string Password { get; set; }

        /// <summary>
        /// 角色编号
        /// </summary>
        [BsonElement("roleNo")]
        [Display(Name = "角色编号")]
        [Required]
        public string RoleNo { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [BsonElement("sex")]
        [Display(Name = "性别")]
        [Required]
        public bool Sex { get; set; }

        /// <summary>
        /// 员工工号
        /// </summary>
        [BsonElement("empNo")]
        [Display(Name = "员工工号")]
        [Required]
        public string EmpNo { get; set; }

        /// <summary>
        /// 员工姓名
        /// </summary>
        [BsonElement("empName")]
        [Display(Name = "员工姓名")]
        [Required]
        public string EmpName { get; set; }

        /// <summary>
        /// 部门编号
        /// </summary>
        [BsonElement("deptNo")]
        [Display(Name = "部门编号")]
        [Required]
        public string DeptNo { get; set; }

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
