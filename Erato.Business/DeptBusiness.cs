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
    /// 部门业务类
    /// </summary>
    public class DeptBusiness
    {
        #region Field
        /// <summary>
        /// 部门 Repsitory
        /// </summary>
        private DeptRepository bladeSpringRepository;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 部门业务类
        /// </summary>
        public DeptBusiness()
        {
            this.bladeSpringRepository = new DeptRepository(); 
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取所有部门
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Dept> Get()
        {
            return this.bladeSpringRepository.Get();
        }

        /// <summary>
        /// 获取部门
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public Dept Get(string id)
        {
            return this.bladeSpringRepository.Get(id);
        }

        /// <summary>
        /// 添加部门
        /// </summary>
        /// <param name="data">部门对象</param>
        /// <returns></returns>
        public ErrorCode Create(Dept data)
        {
            return this.bladeSpringRepository.Create(data);
        }

        /// <summary>
        /// 编辑部门,对象整体更新
        /// </summary>
        /// <param name="data">部门对象</param>
        /// <returns></returns>
        /// <remarks>对象整体更新，新建对象覆盖。</remarks>
        public ErrorCode Update(Dept data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 编辑部门,对象部分更新
        /// </summary>
        /// <param name="data">部门对象</param>
        /// <returns></returns>
        /// <remarks>对象部分更新，仅编辑对象自身部分属性。</remarks>
        public ErrorCode Edit(Dept data)
        {
            data.OperationTime = DateTime.Now;
            return this.bladeSpringRepository.Update(data);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public ErrorCode Delete(string id)
        {
            return this.bladeSpringRepository.Delete(id);
        }

        /// <summary>
        /// 部门编号是否存在
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public bool DeptNoExists(string id)
        {
            return this.bladeSpringRepository.DeptNoExists(id);
        }

        /// <summary>
        /// 部门名称是否存在
        /// </summary>
        /// <param name="id">ID</param>
        /// <returns></returns>
        public bool DeptNameExists(string id)
        {
            return this.bladeSpringRepository.DeptNameExists(id);
        }
        #endregion //Method
    }
}
