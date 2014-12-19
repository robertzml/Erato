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
        /// <summary>
        /// 数据库连接
        /// </summary>
        private Sqlite sqlite;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 用户 Repository
        /// </summary>
        public UserRepository()
        {
            this.sqlite = new Sqlite();
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
            string sql = string.Format("SELECT * FROM User WHERE UserName = '{0}'", userName);

            DataRow row = this.sqlite.ExecuteRow(sql);

            if (row == null)
                return null;

            User user = new User();
            user.UserName = row["UserName"].ToString();
            user.Password = row["Password"].ToString();

            return user;
        }
        #endregion //Method
    }
}
