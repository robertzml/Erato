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
        /// 载入功能列表项
        /// </summary>
        private void LoadListViewItem(string name)
        {
            this.listViewFunction.BeginUpdate();

            this.listViewFunction.Items.Clear();

            switch (name)
            {
                case "nodeBladeSpring":
                    ListViewItem lvi0 = new ListViewItem();
                    lvi0.Name = "bladeSpringSeqItem";
                    lvi0.Text = "工序入口";
                    lvi0.SubItems.Add("板弹簧工序入口");

                    ListViewItem lvi1 = new ListViewItem();
                    lvi1.Text = "日盘点";
                    lvi1.SubItems.Add("日盘点入口");

                    ListViewItem lvi2 = new ListViewItem();
                    lvi2.Text = "周盘点";
                    lvi2.SubItems.Add("周盘点入口");

                    ListViewItem lvi3 = new ListViewItem();
                    lvi3.Text = "月盘点";
                    lvi3.SubItems.Add("月盘点入口");

                    this.listViewFunction.Items.Add(lvi0);
                    this.listViewFunction.Items.Add(lvi1);
                    this.listViewFunction.Items.Add(lvi2);
                    this.listViewFunction.Items.Add(lvi3);
                    break;
            }

            this.listViewFunction.EndUpdate();
        }       
        #endregion //Function

        #region Event
        #region Form Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitControls();
        }
        #endregion //Form Event
        
        #region Control Event
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.labelTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 树菜单选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var node = this.treeViewMenu.SelectedNode;
            if (node == null)
                return;

            LoadListViewItem(node.Name);
        }

        /// <summary>
        /// 列表功能选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listViewFunction_ItemActivate(object sender, EventArgs e)
        {
            if (this.listViewFunction.SelectedItems.Count == 0)
                return;

            var item = this.listViewFunction.SelectedItems[0];
            if (item.Name == "bladeSpringSeqItem")
            {
                BladeSpringForm form = new BladeSpringForm();
                form.ShowDialog();
            }           
        }

        #endregion //Control Event
        #endregion //Event
    }
}
