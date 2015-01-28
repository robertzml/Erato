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
    /// ACT业务类
    /// </summary>
    public class ACTBusiness
    {
        #region Field
        /// <summary>
        /// ACT Repsitory
        /// </summary>
        private ACTRepository actRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// ACT业务类
        /// </summary>
        public ACTBusiness()
        {
            this.actRepository = new ACTRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有ACT
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ACT> Get()
        {
            return this.actRepository.Get();
        }

        /// <summary>
        /// 获取ACT
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ACT Get(string id)
        {
            return this.actRepository.Get(id);
        }

        /// <summary>
        /// 获取上一批次
        /// </summary>
        /// <returns></returns>
        public ACT GetLast()
        {
            var data = this.actRepository.Get().OrderByDescending(r => r.OperationTime).FirstOrDefault();
            return data;
        }

        /// <summary>
        /// 添加ACT
        /// </summary>
        /// <param name="data">ACT对象</param>
        /// <returns></returns>
        public ErrorCode Create(ACT data)
        {
            data.OperationTime = DateTime.Now;
            return this.actRepository.Create(data);
        }

        /// <summary>
        /// 编辑ACT,对象整体更新
        /// </summary>
        /// <param name="data">ACT对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(ACT data)
        {
            data.OperationTime = DateTime.Now;
            return this.actRepository.Update(data);
        }

        /// <summary>
        /// 编辑ACT,对象部分更新
        /// </summary>
        /// <param name="data">ACT对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(ACT data)
        {
            return this.actRepository.Update(data);
        }

        /// <summary>
        /// 删除ACT
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.actRepository.Delete(id);
        }
        #endregion //Method
    }
}
