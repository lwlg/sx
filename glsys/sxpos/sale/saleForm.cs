using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NDolls.Core;
using NDolls.Data;
using NDolls.Data.Entity;


namespace sxpos.sale
{
    public partial class saleForm : Form
    {
        private sx.Service.GoodsService us = new sx.Service.GoodsService();

        public static IRepository<sx.Model.Sys_User> r =
            RepositoryFactory<sx.Model.Sys_User>.CreateRepository("Sys_User");

        int goodnum = 0;
        int grid_index_num = 0;
        decimal goodprice = (Decimal)0.0;
        decimal price_member = (Decimal)0.0;
        decimal price_zk = (Decimal)0.0;


        string sale_id = DateTime.Now.ToString("yyMMddHHmmssff");
        int ismember = 0;                   //是否会员，0非会员，1普通会员

        List<sx.Model.pos_OrderDetail> list2 = new List<sx.Model.pos_OrderDetail>();

        public saleForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource1;

            this.KeyPreview = true;
        }

        private void saleForm_Load(object sender, EventArgs e)
        {
            lblSN.Text = sale_id;
            varBarCode.Focus();
        }

        private void varMemInfo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                memberEnter();
            }
        }

        private void memberEnter()
        {
            if (varMemInfo.Text.Trim() == string.Empty)
            {
                varMemInfo.Text = "";
                ismember = 0;
                lblMemberInfo.Text = "非会员";
            }
            else
            {
                List<sx.Model.pos_Member> members = new List<sx.Model.pos_Member>();
                sx.Service.MemberService mmm = new sx.Service.MemberService();

                members = mmm.GetMemberNoPhone(varMemInfo.Text.Trim());
                if (members == null || members.Count == 0)
                {
                    varMemInfo.Text = "";
                    ismember = 0;
                    lblMemberInfo.Text = "非会员";
                    varMemInfo.Focus();
                }
                else if (members.Count == 1)
                {
                    varMemInfo.Text = members[0].MemberNo;
                    ismember = 1;
                    lblMemberInfo.Text = members[0].MemberName.Trim() + "(当前积分:" +
                        members[0].Scores.ToString() + ")";

                }
                else
                {
                    MemberSelect frm = new MemberSelect(members);
                    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        varMemInfo.Text = frm.member.MemberNo;
                        lblMemberInfo.Text = frm.member.MemberName.Trim() +
                            "(当前积分:" + frm.member.Scores.ToString() + ")";
                        ismember = 1;
                    }
                }
            }
        }

        private void varMemInfo_Leave(object sender, EventArgs e)
        {
            memberEnter();
        }

        private void saleForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (dataGridView1.RowCount > 0 || Funs.Constant.pause_order_list.Count > 0)
            {
                if (MessageBox.Show("当前订单未完成或者有挂单，退出将放弃这些数据，是否继续？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnDrop_Click(object sender, EventArgs e)
        {
            truncatedetail();
        }

        /// <summary>
        /// 初始化界面
        /// </summary>
        private void truncatedetail()
        {

        }

        private void varBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)//enter
            {
                varBarCode.Text = varBarCode.Text.Trim();
                if (varBarCode.Text == "")
                {
                    btnBill_Click(null, EventArgs.Empty);
                }
                else
                {
                    sx.Model.posGoods goodsdetail = new sx.Model.posGoods();
                    List<sx.Model.posGoods> list = us.GetGoods(varBarCode.Text);
                    int sss = list.Count;
                    if (sss == 1)
                    {
                        grid_index_num++;
                        sx.Model.pos_OrderDetail saledetail = new sx.Model.pos_OrderDetail();
                        saledetail.ID = sale_id + grid_index_num.ToString("000");
                        saledetail.OrderID = sale_id;
                        saledetail.GoodsID = list[0].BarCode;
                        saledetail.GoodsName = list[0].GoodsName;
                        saledetail.UnitPrice = list[0].RetailPrice;
                        if (list[0].MemberPrice == 0)
                        {
                            saledetail.MemberPrice = list[0].RetailPrice;
                        }
                        else
                        {
                            saledetail.MemberPrice = list[0].MemberPrice;
                        }
                        saledetail.Promotion = list[0].MemberPName;
                        saledetail.GoodsNum = 1;
                        saledetail.Unit = list[0].Unit;
                        if (saledetail.UnitPrice <= 0)
                        {
                            saledetail.DiscountRate = 0;
                        }
                        else
                        {
                            saledetail.DiscountRate = (saledetail.MemberPrice / saledetail.UnitPrice);
                        }

                        saledetail.OriginalPrice = list[0].BuyingPrice;
                        saledetail.SalePrice = saledetail.GoodsNum * saledetail.UnitPrice;
                        saledetail.CostPrice = saledetail.GoodsNum * list[0].BuyingPrice;
                        saledetail.Profit = (saledetail.SalePrice - saledetail.CostPrice);

                        saledetail.Supplier = list[0].Supplier;
                        saledetail.Status = list[0].Status;
                        saledetail.Memo = "";
                        saledetail.CreateTime = DateTime.Now;                          //创建时间        
                        saledetail.UpdateTime = DateTime.Now;                          //最近修改时间    
                        saledetail.Modifier = "system";                                //最近修改人   
                        saledetail.Category = list[0].Category;             //商品分类

                        Funs.GridUtil.AppendRow(this.bindingSource1, saledetail);
                        goodnum += saledetail.GoodsNum;
                        goodprice = goodprice + saledetail.SalePrice;
                        price_member = saledetail.MemberPrice * saledetail.GoodsNum;
                    }
                    else if (sss > 1)
                    {
                        grid_index_num++;
                        //todo:: 商品选择界面


                    }
                }
            }
        }

        private void btnBill_Click(object sender, EventArgs e)
        {

        }

        private void saleForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                MessageBox.Show("F2");
            }
        }


    }
}
