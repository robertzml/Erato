using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Model;
using System.Data;

namespace Erato.Data
{
    /// <summary>
    /// 用户 Repository
    /// </summary>
    public class UserRepository
    {
        #region Field
       
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 用户 Repository
        /// </summary>
        public UserRepository()
        {
           
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public User GetByUserName(string userName)
        {
            User user = new User();
            user.UserName = "admin";
            return user;
        }
        #endregion //Method
    }
}
