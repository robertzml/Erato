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
using Erato.Model;

namespace Erato.FormUI
{
    public partial class MainForm : Form
    {
        #region Field
        /// <summary>
        /// 当前用户
        /// </summary>
        private User currentUser;
        #endregion //Field

        #region Constructor
        public MainForm(User user)
        {
            InitializeComponent();

            this.currentUser = user;
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            this.labelUserName.Text = this.currentUser.UserName;
        }

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
        #region Form Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitControls();
        }
        #endregion //Form Event

        #region Menu Event
        private void menuBladeSpringSeq_Click(object sender, EventArgs e)
        {
            LoadBladeSpring();
            this.tabControl1.SelectedIndex = 1;
        }
        #endregion //Menu Event

        #region Control Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString();
        }
        #endregion //Control Event

        #region Blade Spring Event
        /// <summary>
        /// 板弹簧一览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bladeSpringToolStripShow_Click(object sender, EventArgs e)
        {
            LoadBladeSpring();
        }

        /// <summary>
        /// 板弹簧添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripbladeSpringCreate_Click(object sender, EventArgs e)
        {
            BladeSpringCreateForm form = new BladeSpringCreateForm();
            form.ShowDialog();

            LoadBladeSpring();
        }
        #endregion //Blade Spring Event
        #endregion //Event
    }
}
