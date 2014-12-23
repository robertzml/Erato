using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Erato.Business;

namespace Erato.FormUI
{
    /// <summary>
    /// 板弹簧工序窗口
    /// </summary>
    public partial class BladeSpringForm : Form
    {
        #region Constructor
        public BladeSpringForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入板弹簧数据
        /// </summary>
        private void LoadBladeSpring()
        {
            BladeSpringBusiness springBusiness = new BladeSpringBusiness();

            this.bladeSpringBindingSource.DataSource = springBusiness.Get().ToList();
            this.bladeSpringBindingSource.ResetBindings(false);
        }
        #endregion //Function

        #region Event
        private void toolStripShow_Click(object sender, EventArgs e)
        {
            LoadBladeSpring();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            BladeSpringCreateForm form = new BladeSpringCreateForm();
            form.ShowDialog();

            LoadBladeSpring();
        }
        #endregion //Event
    }
}
