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
    /// 最终检查业务类
    /// </summary>
    public class FinalCheckBusiness
    {
        #region Field
        /// <summary>
        /// 最终检查 Repsitory
        /// </summary>
        private FinalCheckRepository finalCheckRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 最终检查类
        /// </summary>
        public FinalCheckBusiness()
        {
            this.finalCheckRepository = new FinalCheckRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取最终检查
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FinalCheck> Get()
        {
            return this.finalCheckRepository.Get();
        }

        /// <summary>
        /// 获取最终检查
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public FinalCheck Get(string id)
        {
            return this.finalCheckRepository.Get(id);
        }

        /// <summary>
        /// 获取前一批次
        /// </summary>
        /// <returns></returns>
        public FinalCheck GetLast()
        {
            var data = this.finalCheckRepository.Get().OrderByDescending(r => r.OperationTime).FirstOrDefault();
            return data;
        }

        /// <summary>
        /// 添加最终检查
        /// </summary>
        /// <param name="data">最终检查对象</param>
        /// <returns></returns>
        public ErrorCode Create(FinalCheck data)
        {
            data.OperationTime = DateTime.Now;
            return this.finalCheckRepository.Create(data);
        }

        /// <summary>
        /// 编辑最终检查,对象整体更新
        /// </summary>
        /// <param name="data">最终检查对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(FinalCheck data)
        {
            data.OperationTime = DateTime.Now;
            return this.finalCheckRepository.Update(data);
        }

        /// <summary>
        /// 编辑最终检查,对象部分更新
        /// </summary>
        /// <param name="data">最终检查对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(FinalCheck data)
        {
            return this.finalCheckRepository.Update(data);
        }

        /// <summary>
        /// 删除最终检查
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.finalCheckRepository.Delete(id);
        }
        #endregion //Method
    }
}
