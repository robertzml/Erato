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
    /// 部材类
    /// </summary>
    public class Component
    {
        /// <summary>
        /// LOTNO
        /// </summary>
        [Display(Name = "LOTNO")]
        [BsonElement("lotNo")]
        public string LotNo { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        [Display(Name = "数量")]
        [BsonElement("number")]
        public int Numbert { get; set; }
    }
}
