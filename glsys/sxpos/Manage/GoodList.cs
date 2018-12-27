/*
 查询所有商品类别
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sxpos.Manage
{
    public partial class GoodList : BaseForm
    {
        public GoodList()
        {
            InitializeComponent();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            e.Handled = true;
            switch (e.KeyCode)
            {
                case Keys.F2://商品入库
                    //GoodIn frm = new GoodIn();
                    //frm.ShowDialog();
                    break;
                default:
                    e.Handled = false;
                    break;
            }
        }

        private void GoodList_Load(object sender, EventArgs e)
        {
            //NDolls.Forms.WinUtil.InitComboBox(varCategory,"DName", "DName",)
        }

        /// <summary>
        /// 添加商品信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GoodMng frm = new GoodMng();
            frm.ShowDialog();
        }



        
    }
}
