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
        /// 用户类别ID
        /// </summary>
        [BsonElement("userTypeId")]
        public int UserTypeId { get; set; }
    }
}
