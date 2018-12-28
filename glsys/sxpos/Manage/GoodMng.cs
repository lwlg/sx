/*
  添加一种商品信息
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
    public partial class GoodMng : BaseForm
    {
        private String id = "";
        private String code = "";

        private sx.Service.DicService d = new sx.Service.DicService();

        public GoodMng(String barcode)
        {
            this.code = barcode;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 供应商选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            //             SupplierList frm = new SupplierList();
            //             frm.ShowDialog();

        }

        private void GoodMng_Load(object sender, EventArgs e)
        {
            NDolls.Forms.WinUtil.InitComboBox<sx.Model.sys_Dictionary>(varCategory,
                "DName", "DName", d.GetDicsByType("商品类别"));


            NDolls.Forms.WinUtil.InitComboBox<sx.Model.sys_Dictionary>(varUnit,
                "DName", "DName", d.GetDicsByType("商品单位"));


            NDolls.Forms.WinUtil.InitComboBox<sx.Model.sys_Dictionary>(varBrand,
                            "DName", "DName", d.GetDicsByType("商品品牌"));

            varBarCode.Text = code;
            //changeMode

            // 

            //

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                varBarCode.Text = Guid.NewGuid().ToString("N");
                varBarCode.Visible = true;
            }
            else
            {
                varBarCode.Text = "";
                varBarCode.Visible = true;
                varBarCode.Focus();

            }
        }
    }
}
