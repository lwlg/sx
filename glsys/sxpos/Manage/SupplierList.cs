/*
 * 1、查询显示供应商
 * 2、对供应商进行增、删、改、查
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
using NDolls.Data.Attribute;
using NDolls.Data;
namespace sxpos.Manage
{
    public partial class SupplierList : BaseForm
    {
        private sx.Service.SupplierService s = new sx.Service.SupplierService();
        public SupplierList()
        {
            InitializeComponent();
        }

        private void SupplierList_Load(object sender, EventArgs e)
        {
             DataTable dt = s.GetAll();

            List<CustomAttribute> cols = sx.Service.SupplierService.r.GetCustomFieldsByType("GridCol");
            Funs.GridUtil.InitDataGrid(dataGridView1, cols);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.DataSource = dt;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = s.GetModels(varKeywords.Text);
            dataGridView1.DataSource = bindingSource1.DataSource;
        }

        /// <summary>
        /// 增加供应商
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            SupplierMng frm = new SupplierMng("");
            frm.BSource = bindingSource1;
            frm.ShowDialog();
        }
    }
}
