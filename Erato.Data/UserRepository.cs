﻿using System;
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
        /// Repository对象
        /// </summary>
        private IMongoRepository<User> repository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 用户 Repository
        /// </summary>
        public UserRepository()
        {
            this.repository = new MongoRepository<User>(RheaServer.EratoDatabase);
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
            var data = this.repository.Where(r => r.UserName == userName);
            if (data.Count() == 0)
                return null;
            else
                return data.First();
        }

        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="data">用户信息</param>
        /// <returns></returns>
        public ErrorCode Create(User data)
        {
            try
            {
                bool dup = this.repository.Exists(r => r.UserName == data.UserName);
                if (dup)
                    return ErrorCode.DuplicateUserName;

                this.repository.Add(data);
            }
            catch (Exception)
            {
                return ErrorCode.Exception;
            }

            return ErrorCode.Success;
        }
        #endregion //Method
    }
}
