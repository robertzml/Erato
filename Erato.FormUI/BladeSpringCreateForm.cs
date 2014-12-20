﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Erato.Business;
using Erato.Common;
using Erato.Model;

namespace Erato.FormUI
{
    public partial class BladeSpringCreateForm : Form
    {
        #region Field
        /// <summary>
        /// 板弹簧业务对象
        /// </summary>
        private BladeSpringBusiness springBusiness;
        #endregion //Field

        #region Constructor
        public BladeSpringCreateForm()
        {
            InitializeComponent();

            this.springBusiness = new BladeSpringBusiness();
        }
        #endregion //Constructor

        #region Event
        private void buttonSave_Click(object sender, EventArgs e)
        {
            BladeSpring data = new BladeSpring();
            data.LotNo = this.textBox1.Text;
            data.MachineType = this.textBox2.Text;
            data.ClientName = this.textBox3.Text;
            data.Time = DateTime.Now;
            data.Batch = this.textBox5.Text;
            data.Count = (int)this.numericUpDown1.Value;

            ErrorCode result = this.springBusiness.Create(data);
            if (result == ErrorCode.Success)
            {
                MessageBox.Show("添加数据成功", FormConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.DisplayName(), FormConstant.MessageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        #endregion //Event
    }
}
