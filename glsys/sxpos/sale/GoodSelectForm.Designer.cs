namespace sxpos.sale
{
    partial class GoodSelectForm
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
            this.Promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alarm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPromotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsOnSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Promotion,
            this.BarCode,
            this.GoodsName,
            this.RetailPrice,
            this.MemberPrice,
            this.Unit,
            this.ShortCode,
            this.Category,
            this.Brand,
            this.Supplier,
            this.StockNo,
            this.BuyingPrice,
            this.Total,
            this.Sales,
            this.Alarm,
            this.IsPromotion,
            this.IsOnSale,
            this.Memo,
            this.CreateTime,
            this.UpdateTime,
            this.Modifier,
            this.Status,
            this.MemberPName});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(825, 157);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "系统编号";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // Promotion
            // 
            this.Promotion.DataPropertyName = "Promotion";
            this.Promotion.HeaderText = "会员优惠说明";
            this.Promotion.Name = "Promotion";
            this.Promotion.Visible = false;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.HeaderText = "编码/条码";
            this.BarCode.Name = "BarCode";
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.HeaderText = "商品名称";
            this.GoodsName.Name = "GoodsName";
            // 
            // RetailPrice
            // 
            this.RetailPrice.DataPropertyName = "RetailPrice";
            this.RetailPrice.HeaderText = "零售价";
            this.RetailPrice.Name = "RetailPrice";
            // 
            // MemberPrice
            // 
            this.MemberPrice.DataPropertyName = "MemberPrice";
            this.MemberPrice.HeaderText = "会员价";
            this.MemberPrice.Name = "MemberPrice";
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "商品单位";
            this.Unit.Name = "Unit";
            // 
            // ShortCode
            // 
            this.ShortCode.DataPropertyName = "ShortCode";
            this.ShortCode.HeaderText = "简拼";
            this.ShortCode.Name = "ShortCode";
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "商品类别";
            this.Category.Name = "Category";
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "品牌";
            this.Brand.Name = "Brand";
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "供应商";
            this.Supplier.Name = "Supplier";
            this.Supplier.Visible = false;
            // 
            // StockNo
            // 
            this.StockNo.DataPropertyName = "StockNo";
            this.StockNo.HeaderText = "货号";
            this.StockNo.Name = "StockNo";
            // 
            // BuyingPrice
            // 
            this.BuyingPrice.DataPropertyName = "BuyingPrice";
            this.BuyingPrice.HeaderText = "最近进价";
            this.BuyingPrice.Name = "BuyingPrice";
            this.BuyingPrice.Visible = false;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "库存量";
            this.Total.Name = "Total";
            this.Total.Visible = false;
            // 
            // Sales
            // 
            this.Sales.DataPropertyName = "Sales";
            this.Sales.HeaderText = "销售量";
            this.Sales.Name = "Sales";
            this.Sales.Visible = false;
            // 
            // Alarm
            // 
            this.Alarm.DataPropertyName = "Alarm";
            this.Alarm.HeaderText = "预警值";
            this.Alarm.Name = "Alarm";
            this.Alarm.Visible = false;
            // 
            // IsPromotion
            // 
            this.IsPromotion.DataPropertyName = "IsPromotion";
            this.IsPromotion.HeaderText = "是否促销";
            this.IsPromotion.Name = "IsPromotion";
            // 
            // IsOnSale
            // 
            this.IsOnSale.DataPropertyName = "IsOnSale";
            this.IsOnSale.HeaderText = "是否在售";
            this.IsOnSale.Name = "IsOnSale";
            this.IsOnSale.Visible = false;
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "Memo";
            this.Memo.HeaderText = "备注";
            this.Memo.Name = "Memo";
            this.Memo.Visible = false;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.Visible = false;
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
            // MemberPName
            // 
            this.MemberPName.DataPropertyName = "MemberPName";
            this.MemberPName.HeaderText = "优惠策略";
            this.MemberPName.Name = "MemberPName";
            this.MemberPName.Visible = false;
            // 
            // GoodSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 157);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GoodSelectForm";
            this.Text = "GoodSelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sales;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alarm;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPromotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsOnSale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPName;

    }
}