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
        /// 获取所有用户
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> Get()
        {
            return this.userRepository.Get();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="data">用户对象</param>
        /// <returns></returns>
        public ErrorCode Create(User data)
        {
            return this.userRepository.Create(data);
        }

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
        /// 删除用户
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.userRepository.Delete(id);
        }


        /// <summary>
        /// 用户名称是否存在
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public bool UserNameExists(string id)
        {
            return this.userRepository.UserNameExists(id);
        }

        /// <summary>
        /// 编辑用户,对象整体更新
        /// </summary>
        /// <param name="data">用户对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(User data)
        {
            data.OperationTime = DateTime.Now;
            return this.userRepository.Update(data);
        }

        /// <summary>
        /// 获取部门
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public User Get(string id)
        {
            return this.userRepository.Get(id);
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
