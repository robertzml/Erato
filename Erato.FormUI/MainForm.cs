using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Erato.FormUI
{
    public partial class MainForm : Form
    {
        #region Constructor
        public MainForm()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function

        #endregion //Function

        #region Event
        #region Form Event
        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        #endregion //Form Event

        #region Control Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        #endregion //Control Event

        #region Blade Spring Event
        /// <summary>
        /// 板弹簧添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripbladeSpringCreate_Click(object sender, EventArgs e)
        {
            BladeSpringCreateForm form = new BladeSpringCreateForm();
            form.ShowDialog();
        }
        #endregion //Blade Spring Event
        #endregion //Event
    }
}
