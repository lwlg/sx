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

        private sx.Service.GoodsService goodService = new sx.Service.GoodsService();
        private sx.Service.DicService d = new sx.Service.DicService();
        private sx.Model.posGoods m = null;

        /// <summary>
        /// 父窗体数据绑定
        /// </summary>
        public BindingSource BSource
        { get; set; }

        /// <summary>
        /// 数据列表
        /// </summary>
        public DataGridView gridView
        { get; set; }

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
            List<NDolls.Data.Entity.EntityBase> lst = new List<NDolls.Data.Entity.EntityBase>();
            sx.Model.pos_StockLog sm = new sx.Model.pos_StockLog();

            sm.ID = Guid.NewGuid().ToString("N");
            if (String.IsNullOrEmpty(this.id))
            {
                if (goodService.GetGoodByBarCode(varBarCode.Text.Trim()).Count > 0)
                {
                    MessageBox.Show("该条码商品已存在,无法重复添加.");
                    varBarCode.Focus();
                    return;
                }
                m = new sx.Model.posGoods();
                m.CreateTime = m.UpdateTime = DateTime.Now;
                if (checkBox1.Checked)
                {
                    m.ID = varBarCode.Text;
                }
                else
                {
                    m.ID = Guid.NewGuid().ToString("N");
                }
                sm.PreStock = 0;
            }
            else
            {
                m.UpdateTime = DateTime.Now;
                sm.PreStock = m.Total;
            }

            sm.GoodsID = m.ID;
            sm.Variation = int.Parse(varTotal.Text) - sm.PreStock;
            sm.AfterStock = int.Parse(varTotal.Text);
            sm.CreateTime = sm.UpdateTime = DateTime.Now;
            // sm.Modifier = Funs.Constant.;
            lst.Add(sm);
            NDolls.Forms.WinUtil.GetModel(this, m, "var");
            m.IsOnSale = true;
            ////
            ////

            if (!d.Exist("商品类别", varCategory.Text.Trim()))
            {
                sx.Model.sys_Dictionary dm = new sx.Model.sys_Dictionary();
                dm.DID = Guid.NewGuid().ToString("N");
                dm.DType = "商品类别";
                dm.DName = varCategory.Text.Trim();
                dm.Sequence = "99";
                lst.Add(dm);
            }
            if (!d.Exist("商品单位", varUnit.Text.Trim()))
            {
                sx.Model.sys_Dictionary dm = new sx.Model.sys_Dictionary();
                dm.DID = Guid.NewGuid().ToString("N");
                dm.DType = "商品单位";
                dm.DName = varUnit.Text.Trim();
                dm.Sequence = "99";
                lst.Add(dm);
            }
            if (!d.Exist("商品品牌", varBrand.Text.Trim()))
            {
                sx.Model.sys_Dictionary dm = new sx.Model.sys_Dictionary();
                dm.DID = Guid.NewGuid().ToString("N");
                dm.DType = "商品品牌";
                dm.DName = varBrand.Text.Trim();
                dm.Sequence = "99";
                lst.Add(dm);
            }

            lst.Add(m);

            if (NDolls.Data.RepositoryBase<NDolls.Data.Entity.EntityBase>.BatchSave(lst))
            {
                if (String.IsNullOrEmpty(this.id))
                {
                    Funs.GridUtil.AppendRow<sx.Model.posGoods>(BSource, m);
                    varBarCode.Enabled = false;
                    MessageBox.Show("添加成功");
                }
                else
                {
                    if (m.BarCode == ((sx.Model.posGoods)BSource.Current).BarCode)
                    {
                        Funs.GridUtil.UpdateRow(BSource, m);
                    }
                    MessageBox.Show("修改成功");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("保存失败");
            }

            #region

            #endregion




        }

        /// <summary>
        /// 供应商选择界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectSupplier frm = new SelectSupplier();
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                varSupplier.Text = frm.SName;
                varSupplier.Tag = frm.SID;
            }

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
