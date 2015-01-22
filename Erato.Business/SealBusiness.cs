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
    /// 封止业务类
    /// </summary>
    public class SealBusiness
    {
        #region Field
        /// <summary>
        /// 封止 Repsitory
        /// </summary>
        private SealRepository sealRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 封止业务类
        /// </summary>
        public SealBusiness()
        {
            this.sealRepository = new SealRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有封止
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Seal> Get()
        {
            return this.sealRepository.Get();
        }

        /// <summary>
        /// 获取封止
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Seal Get(string id)
        {
            return this.sealRepository.Get(id);
        }

        /// <summary>
        /// 获取上一次批次
        /// </summary>
        /// <returns></returns>
        public Seal GetLast()
        {
            var data = this.sealRepository.Get().OrderByDescending(r => r.OperationTime).FirstOrDefault();
            return data;
        }

        /// <summary>
        /// 添加封止
        /// </summary>
        /// <param name="data">封止对象</param>
        /// <returns></returns>
        public ErrorCode Create(Seal data)
        {
            data.OperationTime = DateTime.Now;
            return this.sealRepository.Create(data);
        }

        /// <summary>
        /// 编辑封止,对象整体更新
        /// </summary>
        /// <param name="data">封止对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Seal data)
        {
            data.OperationTime = DateTime.Now;
            return this.sealRepository.Update(data);
        }

        /// <summary>
        /// 编辑封止,对象部分更新
        /// </summary>
        /// <param name="data">封止对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Seal data)
        {
            return this.sealRepository.Update(data);
        }

        /// <summary>
        /// 删除封止
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.sealRepository.Delete(id);
        }
        #endregion //Method
    }
}
