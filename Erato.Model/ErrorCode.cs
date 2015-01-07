using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Erato.Model
{
    /// <summary>
    /// 错误代码
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// 成功
        /// </summary>
        [Display(Name = "成功")]
        Success = 0,

        /// <summary>
        /// 错误
        /// </summary>
        [Display(Name = "错误")]
        Error = 1,

        /// <summary>
        /// 异常
        /// </summary>
        [Display(Name = "异常")]
        Exception = 2,

        /// <summary>
        /// 未实现程序
        /// </summary>
        [Display(Name = "未实现程序")]
        NotImplement = 3,

        /// <summary>
        /// 用户不存在
        /// </summary>
        [Display(Name = "用户不存在")]
        UserNotExist = 10,

        /// <summary>
        /// 密码错误
        /// </summary>
        [Display(Name = "密码错误")]
        WrongPassword = 11,
    }
}
