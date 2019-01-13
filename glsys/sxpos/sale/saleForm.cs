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
        //public static IRepository<sx.Model.Sys_User> r =
        //    RepositoryFactory<sx.Model.Sys_User>.CreateRepository("Sys_User");

        private sx.Service.GoodsService gs = new sx.Service.GoodsService();

        private sx.Service.OrderService os = new sx.Service.OrderService();


        string sale_id = DateTime.Now.ToString("yyMMddHHmmssff");//销售流水号


        int goodnum = 0;
        int grid_index_num = 0;
        decimal goodprice = (Decimal)0.0;     //正常价
        decimal price_member = (Decimal)0.0;  //会员价
        decimal price_zk = (Decimal)0.0;      //折扣价

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

        //放弃此单
        private void btnDrop_Click(object sender, EventArgs e)
        {
            truncatedetail();
        }

        // 初始化界面
        public void truncatedetail()
        {
            goodnum = 0;                        //记录数量
            goodprice = 0;                      //记录总价
            price_member = 0;                   //记录会员总价
            ismember = 0;                       //是否会员
            grid_index_num = 0;                 //订单明细的序列数
            dataGridView1.Rows.Clear();
            sale_id = DateTime.Now.ToString("yyMMddHHmmssff");
            varDiscount.Text = "100";

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
                    List<sx.Model.posGoods> list = gs.GetGoods(varBarCode.Text);
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
                        GoodSelectForm frm = new GoodSelectForm();
                        frm.dataGridView1.DataSource = list;
                        frm.ShowDialog(this);
                    }
                    varBarCode.Text = "";
                    varBarCode.Focus();
                }
            }
        }

        //结账
        private void btnBill_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount > 0)
            {
                payForm payfrm = new payForm();
                payfrm.varreceivable.Text = this.lblyingshou.Text;
                payfrm.varReceived.Text = this.lblyingshou.Text;
                payfrm.ShowDialog(this);
                if (payfrm.DialogResult == DialogResult.OK)
                {
                    //结算成功

                }
                else
                {
                    //结算不成功
                }
            }
            else
            {
                varBarCode.Focus();
                varBarCode.SelectAll();
            }
        }

        private void saleForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                MessageBox.Show("F2");
            }
        }

        public void goodSelectEnter(sx.Model.pos_OrderDetail saledetail)
        {
            saledetail.ID = sale_id + grid_index_num.ToString("000");
            saledetail.OrderID = sale_id;
            Funs.GridUtil.AppendRow(this.bindingSource1, saledetail);
            goodnum += saledetail.GoodsNum;
            goodprice = goodprice + saledetail.SalePrice;
            price_member += saledetail.MemberPrice * saledetail.GoodsNum;

        }

        // 回调传值
        public void changeGoodsNum(int singlegoodnum, bool isgift)
        {
            int i = 0;
            int GoodsNum = singlegoodnum;
            decimal OriginalPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["OriginalPrice"].Value);
            decimal DiscountRate = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["DiscountRate"].Value);
            decimal UnitPrice, MemberPrice;
            if (isgift)
            {
                UnitPrice = 0;
                MemberPrice = 0;
                dataGridView1.CurrentRow.Cells["UnitPrice"].Value = (decimal)0;
                dataGridView1.CurrentRow.Cells["MemberPrice"].Value = (decimal)0;
                dataGridView1.CurrentRow.Cells["Memo"].Value = "赠品";
            }
            else
            {
                sx.Model.posGoods goods = gs.GetGoodsByBarCode_MustOne(
                    dataGridView1.CurrentRow.Cells["GoodsID"].Value.ToString());
                if (goods == null)
                {
                    UnitPrice = 0;
                    MemberPrice = 0;
                    dataGridView1.CurrentRow.Cells["UnitPrice"].Value = (decimal)0;
                    dataGridView1.CurrentRow.Cells["MemberPrice"].Value = (decimal)0;
                    dataGridView1.CurrentRow.Cells["Memo"].Value = "";
                }
                else
                {
                    if (goods.MemberPrice == 0)
                    {
                        goods.MemberPrice = goods.RetailPrice;
                    }

                    dataGridView1.CurrentRow.Cells["UnitPrice"].Value = goods.RetailPrice;
                    dataGridView1.CurrentRow.Cells["MemberPrice"].Value = goods.MemberPrice;

                    UnitPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["UnitPrice"].Value);
                    MemberPrice = Convert.ToDecimal(dataGridView1.CurrentRow.Cells["MemberPrice"].Value);
                    dataGridView1.CurrentRow.Cells["Memo"].Value = "";
                }
            }
            // 
            dataGridView1.CurrentRow.Cells["GoodsNum"].Value = GoodsNum;

            dataGridView1.CurrentRow.Cells["CostPrice"].Value = GoodsNum * OriginalPrice;

            dataGridView1.CurrentRow.Cells["Discount"].Value = (decimal)GoodsNum * (UnitPrice - MemberPrice);

            dataGridView1.CurrentRow.Cells["SalePrice"].Value = GoodsNum * UnitPrice;

            dataGridView1.CurrentRow.Cells["Profit"].Value = GoodsNum * UnitPrice - GoodsNum * OriginalPrice;

            goodprice = (decimal)0;
            goodnum = 0;
            price_member = 0;

            for (i = 0; i < dataGridView1.RowCount; i++)
            {
                goodprice += (decimal)dataGridView1.Rows[i].Cells["SalePrice"].Value;
                goodnum += (int)dataGridView1.Rows[i].Cells["GoodsNum"].Value;
                price_member += (decimal)dataGridView1.Rows[i].Cells["MemberPrice"].Value * (int)(dataGridView1.Rows[i].Cells["GoodsNum"].Value);
            }

        }

        // 按钮_修改单间数量
        private void btnModifyCount_Click(object sender, EventArgs e)
        {
            goodsNumChange();
        }

        // 修改单件数量
        private void goodsNumChange()
        {
            if (dataGridView1.RowCount > 0)
            {
                ChangeGoodsNum frm = new ChangeGoodsNum();
                frm.lblGoodsName.Text = dataGridView1.CurrentRow.Cells["GoodsName"].Value.ToString();
                frm.txtGoodsNum.Text = dataGridView1.CurrentRow.Cells["GoodsNum"].Value.ToString();
                frm.ShowDialog(this);
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            goodsNumChange();
        }

        // 挂单
        private void btnGuaDan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount < 1)
            {
                return;
            }

            string namelist = "";
            //遍历一条订单项暂存
            for (int iii = 0; iii < dataGridView1.RowCount; iii++)
            {
                sx.Model.pos_OrderDetail sd = new sx.Model.pos_OrderDetail();
                sd.ID = dataGridView1.Rows[iii].Cells["ID"].Value.ToString();
                sd.OrderID = dataGridView1.Rows[iii].Cells["OrderID"].Value.ToString();
                sd.GoodsID = dataGridView1.Rows[iii].Cells["GoodsID"].Value.ToString();
                sd.GoodsName = dataGridView1.Rows[iii].Cells["GoodsName"].Value.ToString();

                sd.UnitPrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["UnitPrice"].Value);       //单价（元）      
                sd.GoodsNum = Convert.ToInt32(dataGridView1.Rows[iii].Cells["GoodsNum"].Value);           //购买数量        
                sd.Unit = Convert.ToString(dataGridView1.Rows[iii].Cells["Unit"].Value);                         //商品单位        
                sd.OriginalPrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["OriginalPrice"].Value);       //总原始价格（单件进价）
                sd.DiscountRate = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["DiscountRate"].Value);             //折扣率          
                sd.Discount = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["Discount"].Value);                     //总折扣金额（元）
                sd.SalePrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["SalePrice"].Value);            //总销售价格（元）
                sd.CostPrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["CostPrice"].Value);            //总成本价格（元）
                sd.Profit = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["Profit"].Value);      //总利润          
                sd.Supplier = Convert.ToString(dataGridView1.Rows[iii].Cells["Supplier"].Value);                             //供应商          
                sd.Status = Convert.ToInt32(dataGridView1.Rows[iii].Cells["Status"].Value);                              //数据状态        
                sd.Memo = Convert.ToString(dataGridView1.Rows[iii].Cells["Memo"].Value);                                 //备注            
                sd.CreateTime = Convert.ToDateTime(dataGridView1.Rows[iii].Cells["CreateTime"].Value);                          //创建时间        
                sd.UpdateTime = Convert.ToDateTime(dataGridView1.Rows[iii].Cells["UpdateTime"].Value);                         //最近修改时间    
                sd.Modifier = Convert.ToString(dataGridView1.Rows[iii].Cells["Modifier"].Value);             //最近修改人      
                sd.Category = Convert.ToString(dataGridView1.Rows[iii].Cells["Category"].Value);             //商品分类   
                sd.MemberPrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["MemberPrice"].Value);
                sd.Promotion = Convert.ToString(dataGridView1.Rows[iii].Cells["Promotion"].Value);

                namelist = namelist + sd.GoodsName + "|";
                Funs.Constant.list_puase.Add(sd);
            }

            sx.Model.pos_Order p_orderlist = new sx.Model.pos_Order();
            p_orderlist.FlowNo = sale_id;
            p_orderlist.Memo = namelist;
            p_orderlist.GoodsNum = this.goodnum;
            p_orderlist.ReceivablePrice = this.goodprice;
            p_orderlist.Status = this.grid_index_num;           //状态，临时存挂单的明细流水序列数
            p_orderlist.CreateTime = DateTime.Now;
            p_orderlist.Received = this.price_member;           //实收金额，这里临时存放挂单的会员总价
            p_orderlist.ValueCard = ismember;                   //存放是否会员
            //p_orderlist.ValueCardNo = label6.Text;              //存放会员名称
            //p_orderlist.MemberNo = textBox3.Text;               //存放会员号

            Funs.Constant.pause_order_list.Add(p_orderlist);

            truncatedetail();

        }

        //取消挂单
        private void btnQXGuaDan_Click(object sender, EventArgs e)
        {
            #region 无挂单情况
            if (Funs.Constant.pause_order_list.Count < 1)
            {
                MessageBox.Show("没有挂单数据。");
                if (dataGridView1.RowCount > 0)
                {
                    varBarCode.Focus();
                    varBarCode.SelectAll();
                }
                else
                {

                }
                return;
            }


            #endregion

            #region 当前有单情况取消单

            if (dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("当前订单未完成，是否挂单？", "确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    btnGuaDan_Click(null, EventArgs.Empty);
                }
                else
                {
                    //选择否，继续收银
                    varBarCode.Focus();
                    varBarCode.SelectAll();
                    return;
                }
            }
            #endregion

            #region 有挂单情况
            if (Funs.Constant.pause_order_list.Count == 1)
            {
                for (int i = 0; i < Funs.Constant.list_puase.Count; i++)
                {
                    Funs.GridUtil.AppendRow(bindingSource1, Funs.Constant.list_puase[i]);
                }
                this.sale_id = Funs.Constant.pause_order_list[0].FlowNo;
                this.goodnum = Funs.Constant.pause_order_list[0].GoodsNum;
                this.goodprice = Funs.Constant.pause_order_list[0].ReceivablePrice;
                this.grid_index_num = Funs.Constant.pause_order_list[0].Status;
                this.price_member = Funs.Constant.pause_order_list[0].Received;
                this.ismember = (int)Funs.Constant.pause_order_list[0].ValueCard;


                lblMemberInfo.Text = Funs.Constant.pause_order_list[0].ValueCardNo;
                varMemInfo.Text = Funs.Constant.pause_order_list[0].MemberNo;

                Funs.Constant.pause_order_list.Clear();
                Funs.Constant.list_puase.Clear();
                varBarCode.Focus();
                varBarCode.SelectAll();

            }
            else
            {
                //调取显示所有挂单项界面
                getpauseorderForm frm = new getpauseorderForm();
                frm.dataGridView1.DataSource = Funs.Constant.pause_order_list;
                frm.ShowDialog(this);

                varBarCode.Focus();
                varBarCode.SelectAll();
            }
            #endregion


        }

        //删除选中物品
        private void btnDelete_Click(object sender, EventArgs e)
        {
            goodsdelfromgrid();
        }

        private void goodsdelfromgrid()
        {
            if (dataGridView1.RowCount > 0)
            {
                if (MessageBox.Show("确定要删除当前商品吗?", "确认删除", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    goodnum -= (int)dataGridView1.CurrentRow.Cells["GoodsNum"].Value;
                    goodprice -= (decimal)dataGridView1.CurrentRow.Cells["SalePrice"].Value;
                    price_member -= (decimal)dataGridView1.CurrentRow.Cells["MemberPrice"].Value *
                        (int)dataGridView1.CurrentRow.Cells["GoodsNum"].Value;

                    freshtext();
                    this.dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }
            }

            //
            varBarCode.Focus();
            varBarCode.SelectAll();
        }

        //刷新界面+舍零
        private void freshtext()
        {
            lblGoodsNum.Text = goodnum.ToString(); // 商品数量
            lblGoodsPrice.Text = goodprice.ToString("0.00"); // 商品原价

            try
            {
                if (String.IsNullOrEmpty(varDiscount.Text))
                {
                    //varDiscount.Focus();
                    varDiscount.Text = "100";
                }

                if (ismember == 1)
                {
                    price_zk = price_member * (Convert.ToDecimal(varDiscount.Text)) * (decimal)0.01;
                }
                else
                {
                    price_zk = goodprice * (Convert.ToDecimal(varDiscount.Text)) * (decimal)0.01;
                }
            }
            catch
            {

            }

            //舍零_0.5元
            if (rbtn_0_5.Checked == true)
            {

            }

            //舍零_1元
            if (rbtn_1.Checked == true)
            {

            }
            //舍零_5元
            if (rbtn_5.Checked == true)
            {

            }
            //舍零_10元
            if (rbtn_10.Checked == true)
            {

            }
            //舍零_10元
            if (rbtn_none.Checked == true)
            {

            }
        }

        //多条挂单数据,选择处理
        public void orderSelectEnter(int orderIndex)
        {
            this.sale_id = Funs.Constant.pause_order_list[orderIndex].FlowNo;
            this.goodnum = Funs.Constant.pause_order_list[orderIndex].GoodsNum;
            this.goodprice = Funs.Constant.pause_order_list[orderIndex].ReceivablePrice;
            this.grid_index_num = Funs.Constant.pause_order_list[orderIndex].Status;
            this.price_member = Funs.Constant.pause_order_list[orderIndex].Received;
            this.ismember = (int)Funs.Constant.pause_order_list[orderIndex].ValueCard;

            lblMemberInfo.Text = Funs.Constant.pause_order_list[orderIndex].ValueCardNo;
            varMemInfo.Text = Funs.Constant.pause_order_list[orderIndex].MemberNo;

            bindingSource1.DataSource = Funs.Constant.list_puase.FindAll(delegate(sx.Model.pos_OrderDetail pp) { return pp.OrderID == this.sale_id; });

            Funs.Constant.pause_order_list.RemoveAt(orderIndex);
            Funs.Constant.list_puase.RemoveAll(
                delegate(sx.Model.pos_OrderDetail pp)
                {
                    return pp.OrderID == this.sale_id;
                });

        }

        //保存订单数据存库

        public void saveData(decimal receivedMoney, decimal changeMoney, int iscash)
        {
            //订单与订单详情
            decimal tot_costprice = (decimal)0.0;
            List<sx.Model.posGoods> listgoods = new List<sx.Model.posGoods>();

            for (int iii = 0; iii < dataGridView1.RowCount; iii++)
            {
                sx.Model.pos_OrderDetail saledetail = new sx.Model.pos_OrderDetail();
                sx.Model.posGoods salegoods = new sx.Model.posGoods();
                //
                salegoods = gs.GetGoodsByBarCode_MustOne(dataGridView1.Rows[iii].Cells["GoodsID"].Value.ToString());
                salegoods.Alarm = Convert.ToInt32(dataGridView1.Rows[iii].Cells["GoodsNum"].Value);

                saledetail.ID = dataGridView1.Rows[iii].Cells["ID"].Value.ToString();                       //销售明细系统编号 
                saledetail.OrderID = dataGridView1.Rows[iii].Cells["OrderID"].Value.ToString();                  //订单编号        
                saledetail.GoodsID = dataGridView1.Rows[iii].Cells["GoodsID"].Value.ToString();                  //商品编号        
                saledetail.GoodsName = dataGridView1.Rows[iii].Cells["GoodsName"].Value.ToString();              //商品名称        
                saledetail.Unit = Convert.ToString(dataGridView1.Rows[iii].Cells["Unit"].Value);                         //商品单位        
                saledetail.UnitPrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["UnitPrice"].Value);       //单价（元）      
                saledetail.MemberPrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["MemberPrice"].Value);    //会员单价
                saledetail.GoodsNum = Convert.ToInt32(dataGridView1.Rows[iii].Cells["GoodsNum"].Value);           //购买数量        
                saledetail.OriginalPrice = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["OriginalPrice"].Value);       //单件进价
                saledetail.Stock = salegoods.Total;                     //售后库存

                if (ismember == 1)
                    saledetail.SalePrice = saledetail.MemberPrice * saledetail.GoodsNum;         //总销售价格（元） 会员总价      
                else
                    saledetail.SalePrice = saledetail.UnitPrice * saledetail.GoodsNum;           //总销售价格（元） 正常总价
                saledetail.SalePrice *= decimal.Parse(varDiscount.Text.Trim()) / (decimal)100;//每个单件商品计算整单折扣后的价格
                saledetail.CostPrice = saledetail.OriginalPrice * saledetail.GoodsNum;            //总成本价格（元）
                saledetail.DiscountRate = Convert.ToDecimal(dataGridView1.Rows[iii].Cells["DiscountRate"].Value);             //会员价折扣率          
                saledetail.Profit = saledetail.SalePrice - saledetail.CostPrice;               //改为实际利润  20150321
                saledetail.Supplier = Convert.ToString(dataGridView1.Rows[iii].Cells["Supplier"].Value);                             //供应商          
                saledetail.Status = Convert.ToInt32(dataGridView1.Rows[iii].Cells["Status"].Value);                              //数据状态        
                saledetail.Memo = Convert.ToString(dataGridView1.Rows[iii].Cells["Memo"].Value);                                 //备注            
                saledetail.CreateTime = Convert.ToDateTime(dataGridView1.Rows[iii].Cells["CreateTime"].Value);                          //创建时间        
                saledetail.UpdateTime = Convert.ToDateTime(dataGridView1.Rows[iii].Cells["UpdateTime"].Value);                         //最近修改时间    
                //saledetail.Modifier     = dataGridView1.Rows[iii].Cells["Modifier"].Value.ToString();             //最近修改人      
                saledetail.Modifier = Funs.Constant.UserName;             //最近修改人      
                saledetail.Category = Convert.ToString(dataGridView1.Rows[iii].Cells["Category"].Value);
                saledetail.Promotion = Convert.ToString(dataGridView1.Rows[iii].Cells["Promotion"].Value);
                saledetail.Discount = saledetail.UnitPrice * saledetail.GoodsNum - saledetail.SalePrice;               //总折扣

                tot_costprice += saledetail.CostPrice;

                list2.Add(saledetail);
                listgoods.Add(salegoods);
            }

            sx.Model.pos_Order order = new sx.Model.pos_Order();
            order.ID = sale_id;
            order.FlowNo = sale_id;
            order.GoodsNum = goodnum;
            order.OriginalPrice = goodprice;                            //原始价格
            order.ReceivablePrice = Convert.ToDecimal(lblyingshou.Text.ToString());    //应收
            order.Received = receivedMoney;          //实收
            order.Change = changeMoney;            //找零
            order.Discount = order.OriginalPrice - order.ReceivablePrice;    //优惠金额
            order.Profit = order.ReceivablePrice - tot_costprice;           //利润
            order.DiscountRate = Convert.ToDecimal(varDiscount.Text.Trim());
            order.Memo = "";                                               //备注            
            order.CreateTime = DateTime.Now;                          //创建时间        
            order.UpdateTime = DateTime.Now;                          //最近修改时间    
            order.Modifier = Funs.Constant.UserName;                                //最近修改人     
            order.MemberNo = varMemInfo.Text.Trim();
            order.Status = 1;                                 //状态1表示已经进行过积分处理，不管成功与否
            if (ismember == 1)
                order.Scores = Convert.ToInt32(Math.Floor(order.ReceivablePrice));
            else
                order.Scores = 0;
            if (iscash == 1)    //银行卡
                order.BandCard = 1;
            else
                order.Cash = 1;

            order.Details = list2;
            if (os.AddTest(order))
            {
                try
                {
                    for (int iii = 0; iii < listgoods.Count; iii++)
                    {
                        string sql = "update pos_Goods set total = total -" + listgoods[iii].Alarm + " where id='" + listgoods[iii].ID + "' and barcode='" + listgoods[iii].BarCode + "'";
                        int resp = NDolls.Data.RepositoryBase<sx.Model.posGoods>.Excute(sql);
                    }
                    if (ismember == 1)
                    {
                        List<sx.Model.pos_Member> members = new List<sx.Model.pos_Member>();
                        sx.Service.MemberService mmm = new sx.Service.MemberService();
                        members = mmm.GetMemberNoPhone(varMemInfo.Text.Trim());
                        if (members.Count == 1)
                        {
                            members[0].Scores += Convert.ToInt32(Math.Floor(order.ReceivablePrice));
                            mmm.UpdateMember(members[0]);
                        }
                        else if (members.Count < 1)
                            MessageBox.Show("会员号不存在，无法积分");
                        else
                            MessageBox.Show("会员号重复，无法积分");
                    }
                }
                catch
                {
                }
                MessageBox.Show("结算完成");
            }
            else
                MessageBox.Show("记录销售信息错误,结算失败");

        }

    }
}
