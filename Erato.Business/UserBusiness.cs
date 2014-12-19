using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Common;
using Erato.Data;
using Erato.Model;

namespace Erato.Business
{
    /// <summary>
    /// 用户业务类
    /// </summary>
    public class UserBusiness
    {
        #region Field
        /// <summary>
        /// 用户 Repsitory
        /// </summary>
        private UserRepository userRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 用户业务类
        /// </summary>
        public UserBusiness()
        {
            this.userRepository = new UserRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按用户名获取用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public User GetByUserName(string userName)
        {
            return this.userRepository.GetByUserName(userName);
        }

        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="password">密码</param>
        /// <returns></returns>
        public ErrorCode Login(string userName, string password)
        {
            User user = this.userRepository.GetByUserName(userName);

            if (user == null)
                return ErrorCode.UserNotExist;

            if (Hasher.SHA1Encrypt(password) == user.Password)
                return ErrorCode.Success;
            else
                return ErrorCode.WrongPassword;
        }
        #endregion //Method
    }
}
