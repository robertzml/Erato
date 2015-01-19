using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Erato.Data;
using Erato.Model;

namespace Erato.Business
{
    /// <summary>
    /// HEF洗净业务类
    /// </summary>
    public class HEFBusiness
    {
        #region Field
        /// <summary>
        /// HEF洗净 Repsitory
        /// </summary>
        private HEFRepository hefRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// HEF洗净业务类
        /// </summary>
        public HEFBusiness()
        {
            this.hefRepository = new HEFRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有HEF洗净
        /// </summary>
        /// <returns></returns>
        public IEnumerable<HEF> Get()
        {
            return this.hefRepository.Get();
        }

        /// <summary>
        /// 获取HEF洗净
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public HEF Get(string id)
        {
            return this.hefRepository.Get(id);
        }

        /// <summary>
        /// 添加HEF洗净
        /// </summary>
        /// <param name="data">HEF洗净对象</param>
        /// <returns></returns>
        public ErrorCode Create(HEF data)
        {
            data.OperationTime = DateTime.Now;
            return this.hefRepository.Create(data);
        }

        /// <summary>
        /// 编辑HEF洗净,对象整体更新
        /// </summary>
        /// <param name="data">HEF洗净对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(HEF data)
        {
            data.OperationTime = DateTime.Now;
            return this.hefRepository.Update(data);
        }

        /// <summary>
        /// 编辑HEF洗净,对象部分更新
        /// </summary>
        /// <param name="data">HEF洗净对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(HEF data)
        {
            return this.hefRepository.Update(data);
        }

        /// <summary>
        /// 删除HEF洗净
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.hefRepository.Delete(id);
        }
        #endregion //Method
    }
}
