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
    [CollectionName("role")]
    public class Role : MongoEntity
    {
        /// <summary>
        /// 角色编号
        /// </summary>
        [Required]
        [Display(Name = "角色编号")]
        [BsonElement("roleNo")]
        [StringLength(4, MinimumLength = 4, ErrorMessage = "输入的角色编号必须为4位！")]
        public string RoleNo { get; set; }

        /// <summary>
        /// 角色名称
        /// </summary>
        [BsonElement("roleName")]
        [Required]
        [Display(Name = "角色名称")]
        [StringLength(30, ErrorMessage = "输入的角色名称必须小于30位！")]
        public string RoleName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [BsonElement("remarks")]
        [Display(Name = "备注")]
        [StringLength(30, ErrorMessage = "输入的备注必须小于30位！")]
        public string Remarks { get; set; }

        /// <summary>
        /// 模块名
        /// </summary>
        [BsonElement("module")]
        [Required]
        [Display(Name = "模块名")]
        [StringLength(30, ErrorMessage = "输入的备注必须小于30位！")]
        public string Module { get; set; }

        /// <summary>
        /// 可见权限
        /// </summary>
        [BsonElement("selectRole")]
        [Display(Name = "可见权限")]
        [Required]
        public bool SelectRole { get; set; }

        /// <summary>
        /// 新增权限
        /// </summary>
        [BsonElement("addRole")]
        [Display(Name = "新增权限")]
        [Required]
        public bool AddRole { get; set; }

        /// <summary>
        /// 编辑权限
        /// </summary>
        [BsonElement("editRole")]
        [Display(Name = "编辑权限")]
        [Required]
        public bool EditRole { get; set; }

        /// <summary>
        /// 删除权限
        /// </summary>
        [BsonElement("delRole")]
        [Display(Name = "删除权限")]
        [Required]
        public bool DelRole { get; set; }

        /// <summary>
        /// 解锁权限
        /// </summary>
        [BsonElement("unLockRole")]
        [Display(Name = "解锁权限")]
        [Required]
        public bool UnLockRole { get; set; }

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
