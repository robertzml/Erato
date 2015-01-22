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
    /// 电检业务类
    /// </summary>
    public class ETestBusiness
    {
        #region Field
        /// <summary>
        /// 电检 Repsitory
        /// </summary>
        private ETestRepository etestRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 电检业务类
        /// </summary>
        public ETestBusiness()
        {
            this.etestRepository = new ETestRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有电检
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ETest> Get()
        {
            return this.etestRepository.Get();
        }

        /// <summary>
        /// 获取电检
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ETest Get(string id)
        {
            return this.etestRepository.Get(id);
        }

        /// <summary>
        /// 获取上一批次
        /// </summary>
        /// <returns></returns>
        public ETest GetLast()
        {
            var data = this.etestRepository.Get().OrderByDescending(r => r.OperationTime).FirstOrDefault();
            return data;
        }

        /// <summary>
        /// 添加电检
        /// </summary>
        /// <param name="data">电检对象</param>
        /// <returns></returns>
        public ErrorCode Create(ETest data)
        {
            data.OperationTime = DateTime.Now;
            return this.etestRepository.Create(data);
        }

        /// <summary>
        /// 编辑电检,对象整体更新
        /// </summary>
        /// <param name="data">电检对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(ETest data)
        {
            data.OperationTime = DateTime.Now;
            return this.etestRepository.Update(data);
        }

        /// <summary>
        /// 编辑电检,对象部分更新
        /// </summary>
        /// <param name="data">电检对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(ETest data)
        {
            return this.etestRepository.Update(data);
        }

        /// <summary>
        /// 删除电检
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.etestRepository.Delete(id);
        }
        #endregion //Method
    }
}
