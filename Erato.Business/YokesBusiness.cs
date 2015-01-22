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
    /// 磁轭业务类
    /// </summary>
    public class YokesBusiness
    {
        #region Field
        /// <summary>
        /// 磁轭 Repsitory
        /// </summary>
        private YokesRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 磁轭业务类
        /// </summary>
        public YokesBusiness()
        {
            this.bladeSpringRepository = new YokesRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有磁轭
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Yokes> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取磁轭
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Yokes Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加磁轭
        /// </summary>
        /// <param name="data">磁轭对象</param>
        /// <returns></returns>
        public ErrorCode Create(Yokes data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑磁轭,对象整体更新
        /// </summary>
        /// <param name="data">磁轭对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Yokes data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑磁轭,对象部分更新
        /// </summary>
        /// <param name="data">磁轭对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Yokes data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除磁轭
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.bladeSpringRepository.Delete(id);
        }
        #endregion //Method
    }
}
