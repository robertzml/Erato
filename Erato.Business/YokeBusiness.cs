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
    public class YokeBusiness
    {
        #region Field
        /// <summary>
        /// 磁轭 Repsitory
        /// </summary>
        private YokeRepository yokeRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 磁轭业务类
        /// </summary>
        public YokeBusiness()
        {
            this.yokeRepository = new YokeRepository();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有磁轭
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Yoke> Get()
        {
            return this.yokeRepository.Get();
        }

        /// <summary>
        /// 获取磁轭
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Yoke Get(string id)
        {
            return this.yokeRepository.Get(id);
        }

        /// <summary>
        /// 获取上一次批次
        /// </summary>
        /// <returns></returns>
        public Yoke GetLast()
        {
            var data = this.yokeRepository.Get().OrderByDescending(r => r.OperationTime).FirstOrDefault();
            return data;
        }

        /// <summary>
        /// 添加磁轭
        /// </summary>
        /// <param name="data">磁轭对象</param>
        /// <returns></returns>
        public ErrorCode Create(Yoke data)
        {
            data.OperationTime = DateTime.Now;
            return this.yokeRepository.Create(data);
        }

        /// <summary>
        /// 编辑磁轭,对象整体更新
        /// </summary>
        /// <param name="data">磁轭对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Yoke data)
        {
            return this.yokeRepository.Update(data);
        }

        /// <summary>
        /// 编辑磁轭,对象部分更新
        /// </summary>
        /// <param name="data">磁轭对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Yoke data)
        {
            return this.yokeRepository.Update(data);
        }

        /// <summary>
        /// 删除磁轭
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.yokeRepository.Delete(id);
        }
        #endregion //Method
    }
}
