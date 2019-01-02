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
using NDolls.Data.Attribute;
namespace sxpos.Manage
{
    public partial class GoodList : BaseForm
    {
        private sx.Service.GoodsService r = new sx.Service.GoodsService();
        private sx.Service.DicService d = new sx.Service.DicService();
        //private sx.Service.
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
            NDolls.Forms.WinUtil.InitComboBox<sx.Model.sys_Dictionary>(varCategory,
                "DName", "DName", d.GetDicsByType("商品类别"));
            NDolls.Forms.WinUtil.InitComboBox<sx.Model.sys_Dictionary>(varBrand,
                "DName", "DName", d.GetDicsByType("商品品牌"));

            List<CustomAttribute> cols = sx.Service.GoodsService.r.GetCustomFieldsByType("GridCol");
            Funs.GridUtil.InitDataGrid(dataGridView1, cols);

            dataGridView1.Columns["RetailPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["RetailPrice"].DefaultCellStyle.Format = "0.00元";
            dataGridView1.Columns["BuyingPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["BuyingPrice"].DefaultCellStyle.Format = "0.00元";
            dataGridView1.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        /// <summary>
        /// 添加商品信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            GoodMng frm = new GoodMng("");
            frm.gridView = dataGridView1;
            frm.BSource = bindingSource1;
            frm.ShowDialog();
        }




    }
}
