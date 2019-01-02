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
using NDolls.Data.Entity;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        List<Item> list = new List<Item>();
        private void SearchPaper(int pageIndex)
        {
            String key = varKeywords.Text.Trim();
            list = new List<Item>();
            ConditionOrGroup groupOr = new ConditionOrGroup();
            groupOr.AddCondition(new ConditionItem("GoodsName", key, SearchType.Fuzzy));
            groupOr.AddCondition(new ConditionItem("BarCode", key, SearchType.Fuzzy));
            groupOr.AddCondition(new ConditionItem("StockNo", key, SearchType.Fuzzy));
            groupOr.AddCondition(new ConditionItem("ShortCode", key, SearchType.Fuzzy));
            list.Add(groupOr);

            if (varCategory.Text.Trim() != "")
            {
                list.Add(new ConditionItem("Category", varCategory.Text, SearchType.Fuzzy));
            }

            if (varBrand.Text.Trim() != "")
            {
                list.Add(new ConditionItem("Brand", varBrand.Text, SearchType.Fuzzy));
            }

            if (Funs.ValidateUtil.IsInt(varTotal.Text.Trim()))
            {
                list.Add(new ConditionItem("Total", varTotal.Text, SearchType.GreaterEqual));
            }
            if (Funs.ValidateUtil.IsInt(varTotalEx.Text.Trim()))
            {
                list.Add(new ConditionItem("Total", varTotalEx.Text, SearchType.LowerEqual));
            }

            Paper<sx.Model.posGoods> paper = sx.Service.GoodsService.r.FindPager(15, pageIndex, list);
            if (paper != null)
            {
                varDataCount.Text = paper.Total.ToString();
                varPageCount.Text = "共" + paper.PageCount + "页";
                varCurrent.Text = pageIndex.ToString();

                bindingSource1.DataSource = paper.Result;
                dataGridView1.DataSource = bindingSource1;
            }
            else
            {
                varDataCount.Text = "0";
                varPageCount.Text = "共0页";
                varCurrent.Text = "0";

                bindingSource1.DataSource = null;
                dataGridView1.DataSource = bindingSource1;
            }

        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchPaper(1);

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            try
            {

                string sqlcmd = "COUNT(1) CNT,SUM(CASE WHEN Total<0 THEN 0 ELSE Total END) aTotal,SUM(CASE WHEN Total<0 THEN 0 ELSE Total END*RetailPrice) aPrice";
                DataTable dt = r.CustomSearch(sqlcmd, list);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    this.varSummary.Text = String.Format("{0}种，{1}件，{2}元", row["CNT"].ToString(), row["aTotal"].ToString(),
                        float.Parse(row["aPrice"].ToString()).ToString("f2"));
                }
            }
            catch
            {

            }
            refreshStock();

        }

        private void refreshStock()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                String a = row.Cells["Total"].Value.ToString();
                String b = row.Cells["Alarm"].Value.ToString();
                if (float.Parse(a) <= float.Parse(b))
                {
                    row.Cells["Total"].Style.BackColor = Color.Red;
                }
                else
                {
                    row.Cells["Total"].Style.BackColor = row.Cells["Alarm"].Style.BackColor;
                }
            }
        }


        private void refreshStock(DataGridViewRow row)
        {
            String a = row.Cells["Total"].Value.ToString();
            String b = row.Cells["Alarm"].Value.ToString();
            if (float.Parse(a) < float.Parse(b))
            {
                row.Cells["Total"].Style.BackColor = Color.Red;
            }
            else
            {
                row.Cells["Total"].Style.BackColor = row.Cells["Alarm"].Style.BackColor;
            }
        }



        bool first = true;
        private void GoodList_Enter(object sender, EventArgs e)
        {
            if (!first)
                btnSearch_Click(sender, e);
            else
                first = false;
        }

        private void varKeywords_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(sender, null);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int current = int.Parse(varCurrent.Text);
            int pageCount = int.Parse(varPageCount.Text.Replace("共", "").Replace("页", ""));
            if (current + 1 > pageCount) return;

            SearchPaper(current + 1);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            int current = int.Parse(varCurrent.Text);
            int pageCount = int.Parse(varPageCount.Text.Replace("共", "").Replace("页", ""));
            if (current - 1 < 1) return;

            SearchPaper(current - 1);
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            SearchPaper(1);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            int pageCount = int.Parse(varPageCount.Text.Replace("共", "").Replace("页", ""));
            SearchPaper(pageCount);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            if (rows.Count > 0)
            {
                if (MessageBox.Show("确定要删除选中商品吗？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (r.DelGoods(rows[0].Cells["ID"].Value.ToString()))
                    {
                        bindingSource1.RemoveCurrent();
                        MessageBox.Show("删除成功！");
                    }
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;

            if (rows.Count > 0)
            {
                GoodMng frm = new GoodMng(rows[0].Cells["BarCode"].Value.ToString());
                frm.gridView = dataGridView1;
                frm.BSource = bindingSource1;

                Funs.ControlUtil.ShowForm(frm);
                Funs.GridUtil.UpdateRow(bindingSource1, r.GetGoodsByID(rows[0].Cells["ID"].Value.ToString()));
                refreshStock(rows[0]);
            }
        }

        private void btnGoodsIn_Click(object sender, EventArgs e)
        {
            GoodIn frm = new GoodIn("");
            Funs.ControlUtil.ShowForm(frm);
        }





    }
}
