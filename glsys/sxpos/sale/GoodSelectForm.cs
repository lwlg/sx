using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sxpos.sale
{
    public partial class GoodSelectForm : Form
    {
        public GoodSelectForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goodsconfirm();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            goodsconfirm();
        }

        private void goodsconfirm()
        {
            sx.Model.pos_OrderDetail saledetail = new sx.Model.pos_OrderDetail();

            saledetail.GoodsID = dataGridView1.CurrentRow.Cells["BarCode"].Value.ToString();
            saledetail.GoodsName = dataGridView1.CurrentRow.Cells["GoodsName"].Value.ToString();
            saledetail.GoodsNum = 1;
            saledetail.UnitPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["RetailPrice"].Value);
            if (Convert.ToDecimal(dataGridView1.CurrentRow.Cells["MemberPrice"].Value) == 0)
            {
                saledetail.MemberPrice = saledetail.UnitPrice;
            }
            else
            {
                saledetail.MemberPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["MemberPrice"].Value);
            }

            saledetail.Unit = Convert.ToString(dataGridView1.CurrentRow.Cells["Unit"].Value);
            saledetail.OriginalPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["BuyingPrice"].Value);
            saledetail.Discount = 0;

            saledetail.SalePrice = saledetail.GoodsNum * saledetail.UnitPrice;  //总销售价格（元）
            saledetail.CostPrice = saledetail.GoodsNum * saledetail.OriginalPrice;       //总成本价格（元）
            saledetail.Profit = (saledetail.SalePrice - saledetail.CostPrice);     //总利润          
            saledetail.Supplier = Convert.ToString(dataGridView1.CurrentRow.Cells["Supplier"].Value);                        //供应商          
            saledetail.Status = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Status"].Value);                     //数据状态        
            saledetail.Memo = "";                                               //备注            
            saledetail.CreateTime = DateTime.Now;                          //创建时间        
            saledetail.UpdateTime = DateTime.Now;                          //最近修改时间    
            saledetail.Modifier = "system";                                //最近修改人      
            saledetail.Category = Convert.ToString(dataGridView1.CurrentRow.Cells["Category"].Value);
            saledetail.Promotion = Convert.ToString(dataGridView1.CurrentRow.Cells["Promotion"].Value);
            if (saledetail.UnitPrice <= 0)
                saledetail.DiscountRate = 0;
            else
                saledetail.DiscountRate = saledetail.MemberPrice / saledetail.UnitPrice;

            ///传参数
            saleForm fatherform = (saleForm)this.Owner;
            fatherform.goodSelectEnter(saledetail);
            this.Close();
        }
    }
}
