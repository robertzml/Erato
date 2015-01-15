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
    /// 洗净干燥业务类
    /// </summary>
    public class DryCleanBusiness
    {
        #region Field
        /// <summary>
        /// 洗净干燥 Repsitory
        /// </summary>
        private DryCleanRepository dryCleanRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 洗净干燥业务类
        /// </summary>
        public DryCleanBusiness()
        {
            this.dryCleanRepository = new DryCleanRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有洗净干燥
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DryClean> Get()
        {
            return this.dryCleanRepository.Get();
        }

        /// <summary>
        /// 获取洗净干燥
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public DryClean Get(string id)
        {
            return this.dryCleanRepository.Get(id);
        }

        /// <summary>
        /// 添加洗净干燥
        /// </summary>
        /// <param name="data">洗净干燥对象</param>
        /// <returns></returns>
        public ErrorCode Create(DryClean data)
        {
            return this.dryCleanRepository.Create(data);
        }

        /// <summary>
        /// 编辑洗净干燥,对象整体更新
        /// </summary>
        /// <param name="data">洗净干燥对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(DryClean data)
        {
            return this.dryCleanRepository.Update(data);
        }

        /// <summary>
        /// 编辑洗净干燥,对象部分更新
        /// </summary>
        /// <param name="data">洗净干燥对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(DryClean data)
        {
            return this.dryCleanRepository.Update(data);
        }

        /// <summary>
        /// 删除洗净干燥
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.dryCleanRepository.Delete(id);
        }
        #endregion //Method
    }
}
