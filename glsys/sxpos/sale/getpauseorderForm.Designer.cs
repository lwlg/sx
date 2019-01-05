namespace sxpos.sale
{
    partial class getpauseorderForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlowNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCSC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceivablePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BandCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPostCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coupon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueCardNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Scores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.MemberNo,
            this.FlowNo,
            this.GoodsNum,
            this.OriginalPrice,
            this.Discount,
            this.NCSC,
            this.ReceivablePrice,
            this.Received,
            this.Change,
            this.DiscountRate,
            this.Profit,
            this.PayType,
            this.Cash,
            this.BandCard,
            this.IsPostCard,
            this.Coupon,
            this.ValueCard,
            this.ValueCardNo,
            this.CreateTime,
            this.Memo,
            this.UpdateTime,
            this.Modifier,
            this.Status,
            this.Scores});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(937, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "订单号";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // MemberNo
            // 
            this.MemberNo.DataPropertyName = "MemberNo";
            this.MemberNo.HeaderText = "会员号";
            this.MemberNo.Name = "MemberNo";
            this.MemberNo.Visible = false;
            // 
            // FlowNo
            // 
            this.FlowNo.DataPropertyName = "FlowNo";
            this.FlowNo.HeaderText = "订单流水号";
            this.FlowNo.Name = "FlowNo";
            // 
            // GoodsNum
            // 
            this.GoodsNum.DataPropertyName = "GoodsNum";
            this.GoodsNum.HeaderText = "商品数量";
            this.GoodsNum.Name = "GoodsNum";
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.DataPropertyName = "OriginalPrice";
            this.OriginalPrice.HeaderText = "原始价格";
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.Visible = false;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "总优惠金额";
            this.Discount.Name = "Discount";
            this.Discount.Visible = false;
            // 
            // NCSC
            // 
            this.NCSC.DataPropertyName = "NCSC";
            this.NCSC.HeaderText = "抹零";
            this.NCSC.Name = "NCSC";
            this.NCSC.Visible = false;
            // 
            // ReceivablePrice
            // 
            this.ReceivablePrice.DataPropertyName = "ReceivablePrice";
            this.ReceivablePrice.HeaderText = "订单金额";
            this.ReceivablePrice.Name = "ReceivablePrice";
            // 
            // Received
            // 
            this.Received.DataPropertyName = "Received";
            this.Received.HeaderText = "实收金额";
            this.Received.Name = "Received";
            this.Received.Visible = false;
            // 
            // Change
            // 
            this.Change.DataPropertyName = "Change";
            this.Change.HeaderText = "找零";
            this.Change.Name = "Change";
            this.Change.Visible = false;
            // 
            // DiscountRate
            // 
            this.DiscountRate.DataPropertyName = "DiscountRate";
            this.DiscountRate.HeaderText = "整单折扣率";
            this.DiscountRate.Name = "DiscountRate";
            this.DiscountRate.Visible = false;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.HeaderText = "利润额";
            this.Profit.Name = "Profit";
            this.Profit.Visible = false;
            // 
            // PayType
            // 
            this.PayType.DataPropertyName = "PayType";
            this.PayType.HeaderText = "支付类型";
            this.PayType.Name = "PayType";
            this.PayType.Visible = false;
            // 
            // Cash
            // 
            this.Cash.DataPropertyName = "Cash";
            this.Cash.HeaderText = "现金";
            this.Cash.Name = "Cash";
            this.Cash.Visible = false;
            // 
            // BandCard
            // 
            this.BandCard.DataPropertyName = "BandCard";
            this.BandCard.HeaderText = "银行卡";
            this.BandCard.Name = "BandCard";
            this.BandCard.Visible = false;
            // 
            // IsPostCard
            // 
            this.IsPostCard.DataPropertyName = "IsPostCard";
            this.IsPostCard.HeaderText = "是否绿卡";
            this.IsPostCard.Name = "IsPostCard";
            this.IsPostCard.Visible = false;
            // 
            // Coupon
            // 
            this.Coupon.DataPropertyName = "Coupon";
            this.Coupon.HeaderText = "优惠卷";
            this.Coupon.Name = "Coupon";
            this.Coupon.Visible = false;
            // 
            // ValueCard
            // 
            this.ValueCard.DataPropertyName = "ValueCard";
            this.ValueCard.HeaderText = "储值卡";
            this.ValueCard.Name = "ValueCard";
            this.ValueCard.Visible = false;
            // 
            // ValueCardNo
            // 
            this.ValueCardNo.DataPropertyName = "ValueCardNo";
            this.ValueCardNo.HeaderText = "储值卡号";
            this.ValueCardNo.Name = "ValueCardNo";
            this.ValueCardNo.Visible = false;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "挂单时间";
            this.CreateTime.Name = "CreateTime";
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "Memo";
            this.Memo.HeaderText = "备注";
            this.Memo.Name = "Memo";
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "修改时间";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.Visible = false;
            // 
            // Modifier
            // 
            this.Modifier.DataPropertyName = "Modifier";
            this.Modifier.HeaderText = "修改人";
            this.Modifier.Name = "Modifier";
            this.Modifier.Visible = false;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.Visible = false;
            // 
            // Scores
            // 
            this.Scores.DataPropertyName = "Scores";
            this.Scores.HeaderText = "积分";
            this.Scores.Name = "Scores";
            this.Scores.Visible = false;
            // 
            // getpauseorderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 261);
            this.Controls.Add(this.dataGridView1);
            this.Name = "getpauseorderForm";
            this.Text = "选择代售订单";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCSC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceivablePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Received;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn PayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cash;
        private System.Windows.Forms.DataGridViewTextBoxColumn BandCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPostCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coupon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueCardNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Scores;
    }
}