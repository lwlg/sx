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
using NDolls.Data.Entity;
namespace sxpos.Manage
{
    public partial class GoodMng : BaseForm
    {
        private String id = "";
        private String code = "";//条码

        private sx.Service.GoodsService s = new sx.Service.GoodsService();
        private sx.Service.DicService d = new sx.Service.DicService();
        private sx.Model.posGoods m = null;

        sx.Service.SupplierService _s = new sx.Service.SupplierService();

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
            List<NDolls.Data.Entity.EntityBase> list = new List<NDolls.Data.Entity.EntityBase>();
            sx.Model.pos_StockLog sm = new sx.Model.pos_StockLog();

            sm.ID = Guid.NewGuid().ToString("N");

            if (String.IsNullOrEmpty(this.id))//新增
            {
                if (s.GetGoodsByBarCode(varBarCode.Text.Trim()).Count > 0)
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

                sm.PreStock = 0;//新增库存变动前量为0
            }
            else//修改
            {
                m.UpdateTime = DateTime.Now;

                sm.PreStock = m.Total;//库存变动前量
            }

            sm.GoodsID = m.ID;
            sm.Variation = int.Parse(varTotal.Text) - sm.PreStock;
            sm.AfterStock = int.Parse(varTotal.Text);
            sm.CreateTime = sm.UpdateTime = DateTime.Now;
            //sm.Modifier = Funs.Constant.UserAccount;
            sm.StockMark = "商品管理入库";
            list.Add(sm);//库存变动记录

            NDolls.Forms.WinUtil.GetModel(this, m, "var");
            m.IsOnSale = true;

            if (!d.Exist("商品类别", varCategory.Text.Trim()))
            {
                sx.Model.sys_Dictionary dm = new sx.Model.sys_Dictionary();
                dm.DID = Guid.NewGuid().ToString("N");
                dm.DType = "商品类别";
                dm.DName = varCategory.Text.Trim();
                dm.Sequence = "99";
                dm.CreateTime = dm.UpdateTime = DateTime.Now;
                list.Add(dm);
            }
            if (!d.Exist("商品单位", varUnit.Text.Trim()))
            {
                sx.Model.sys_Dictionary dm = new sx.Model.sys_Dictionary();
                dm.DID = Guid.NewGuid().ToString("N");
                dm.DType = "商品单位";
                dm.Sequence = "99";
                dm.DName = varUnit.Text.Trim();
                dm.CreateTime = dm.UpdateTime = DateTime.Now;
                list.Add(dm);
            }
            if (!d.Exist("商品品牌", varBrand.Text.Trim()))
            {
                sx.Model.sys_Dictionary dm = new sx.Model.sys_Dictionary();
                dm.DID = Guid.NewGuid().ToString("N");
                dm.DType = "商品品牌";
                dm.Sequence = "99";
                dm.DName = varBrand.Text.Trim();
                dm.CreateTime = dm.UpdateTime = DateTime.Now;
                list.Add(dm);
            }

            //维护供应商信息
            if (varSupplier.Text.Trim() != "")
            {
                try
                {
                    varSupplier.Tag = _s.Find(new List<Item> { new ConditionItem("SName", varSupplier.Text.Trim(), SearchType.Accurate) })[0].SID;
                }
                catch
                {
                    varSupplier.Tag = null;
                }

                sx.Model.pos_Supplier _sm = new sx.Model.pos_Supplier();
                if (varSupplier.Tag == null || String.IsNullOrEmpty(varSupplier.Tag.ToString()))
                {
                    _sm.SID = Guid.NewGuid().ToString("N");
                    _sm.CreateTime = _sm.UpdateTime = DateTime.Now;
                    _sm.ShortCode = Funs.SpellingUtil.GetPrefixLetters(varSupplier.Text.Trim());
                }
                else
                {
                    _sm = _s.GetModel(varSupplier.Tag.ToString());
                }
                _sm.SName = varSupplier.Text.Trim();
                list.Add(_sm);

                sx.Model.pos_SupplierGoods sgm = new sx.Model.pos_SupplierGoods();
                sgm.SID = _sm.SID;
                sgm.GoodsID = m.ID;
                sgm.GoodsName = m.GoodsName;
                sgm.GoodsBrand = m.Brand;
                sgm.BuyingPrice = m.BuyingPrice;
                sgm.SalePrice = m.RetailPrice;
                list.Add(sgm);
            }

            list.Add(m);

            if (NDolls.Data.RepositoryBase<NDolls.Data.Entity.EntityBase>.BatchSave(list))
            {
                if (String.IsNullOrEmpty(this.id))
                {
                    Funs.GridUtil.AppendRow<sx.Model.posGoods>(BSource, m);
                    varBarCode.Enabled = false;
                    MessageBox.Show("添加成功");
                    //btnNew_Click(sender, e);
                }
                else
                {
                    if (m.BarCode == ((sx.Model.posGoods)BSource.Current).BarCode)
                        Funs.GridUtil.UpdateRow(BSource, m);

                    MessageBox.Show("修改成功");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("保存失败");
            }


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
            changeMode(code);

            // 

            //

        }

        private void changeMode(string barCode)
        {
            try
            {
                m = s.GetGoodsByBarCode(barCode)[0];
                if (m != null)
                {
                    if (Funs.Constant.UserRole != "Admin")
                    {
                        MessageBox.Show("该商品已存在，您没有修改商品权限，请联系店长处理!");
                        return;
                    }
                    this.id = m.ID;
                    NDolls.Forms.WinUtil.SetObject(this, m, "var");
                    if (m.Category == null)
                    {
                        varCategory.Text = "";
                    }
                    m.IsOnSale = true;

                    varBarCode.Enabled = false;
                    checkBox1.Visible = false;
                    //todo::
                }
                else //add new
                {
                    this.id = "";
                    varBarCode.Enabled = true;
                }
            }
            catch
            {
                this.id = "";
                varBarCode.Enabled = true;
            }
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
