﻿using Erato.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erato.Data
{
    /// <summary>
    /// 
    /// </summary>
    public class BladeSpringRepository
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
        public BladeSpringRepository()
        {
            this.sqlite = new Sqlite();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有板弹簧
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BladeSpring> Get()
        {
            string sql = "SELECT * FROM BladeSpring";
            DataTable dt = this.sqlite.ExecuteQuery(sql);

            List<BladeSpring> data = new List<BladeSpring>();
            foreach(DataRow row in dt.Rows)
            {
                BladeSpring bs = new BladeSpring();
                bs.LotNo = row["LotNo"].ToString();
                bs.MachineType = row["MachineType"].ToString();
                bs.ClientName = row["ClientName"].ToString();
                bs.Time = Convert.ToDateTime(row["Time"]);
                bs.Batch = row["Batch"].ToString();
                bs.Count = Convert.ToInt32(row["Count"]);

                data.Add(bs);
            }

            return data;
        }

        /// <summary>
        /// 添加板弹簧
        /// </summary>
        /// <param name="data">板弹簧数据</param>
        /// <returns></returns>
        public ErrorCode Create(BladeSpring data)
        {
            try
            {
                string sql = string.Format("INSERT INTO BladeSpring(LotNo, MachineType, ClientName, Time, Batch, Count) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', {5})",
                    data.LotNo, data.MachineType, data.ClientName, data.Time.ToString(), data.Batch, data.Count);

                this.sqlite.ExecuteNonQuery(sql);
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
