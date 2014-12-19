using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erato.Model
{
    public class User
    {
        /// <summary>
        /// 用户名
        /// </summary>       
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        /// <summary>
        /// 密码
        /// </summary>     
        [Display(Name = "密码")]
        public string Password { get; set; }
    }
}
