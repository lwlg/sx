namespace sxpos.sale
{
    partial class saleForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnModifyCount = new System.Windows.Forms.Button();
            this.btnGuaDan = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.varBarCode = new System.Windows.Forms.TextBox();
            this.varMemInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSN = new System.Windows.Forms.Label();
            this.lblMemberInfo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDrop = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnQXGuaDan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GoodsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Promotion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MemberPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GoodsNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Memo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.varDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblyingshou = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblGoodsPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblGoodsNum = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.rbtn_0_5 = new System.Windows.Forms.RadioButton();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_5 = new System.Windows.Forms.RadioButton();
            this.rbtn_10 = new System.Windows.Forms.RadioButton();
            this.rbtn_none = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnModifyCount
            // 
            this.btnModifyCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModifyCount.Location = new System.Drawing.Point(641, 29);
            this.btnModifyCount.Margin = new System.Windows.Forms.Padding(2);
            this.btnModifyCount.Name = "btnModifyCount";
            this.btnModifyCount.Size = new System.Drawing.Size(83, 42);
            this.btnModifyCount.TabIndex = 0;
            this.btnModifyCount.Text = "修改数量";
            this.btnModifyCount.UseVisualStyleBackColor = true;
            this.btnModifyCount.Click += new System.EventHandler(this.btnModifyCount_Click);
            // 
            // btnGuaDan
            // 
            this.btnGuaDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuaDan.Location = new System.Drawing.Point(740, 29);
            this.btnGuaDan.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuaDan.Name = "btnGuaDan";
            this.btnGuaDan.Size = new System.Drawing.Size(83, 42);
            this.btnGuaDan.TabIndex = 0;
            this.btnGuaDan.Text = "挂单";
            this.btnGuaDan.UseVisualStyleBackColor = true;
            this.btnGuaDan.Click += new System.EventHandler(this.btnGuaDan_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.varBarCode);
            this.panel1.Controls.Add(this.varMemInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblSN);
            this.panel1.Controls.Add(this.lblMemberInfo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnModifyCount);
            this.panel1.Controls.Add(this.btnDrop);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnQXGuaDan);
            this.panel1.Controls.Add(this.btnGuaDan);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1124, 80);
            this.panel1.TabIndex = 1;
            // 
            // varBarCode
            // 
            this.varBarCode.Location = new System.Drawing.Point(147, 48);
            this.varBarCode.Name = "varBarCode";
            this.varBarCode.Size = new System.Drawing.Size(119, 21);
            this.varBarCode.TabIndex = 0;
            this.varBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.varBarCode_KeyPress);
            // 
            // varMemInfo
            // 
            this.varMemInfo.Location = new System.Drawing.Point(147, 6);
            this.varMemInfo.Name = "varMemInfo";
            this.varMemInfo.Size = new System.Drawing.Size(119, 21);
            this.varMemInfo.TabIndex = 2;
            this.varMemInfo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.varMemInfo_KeyDown);
            this.varMemInfo.Leave += new System.EventHandler(this.varMemInfo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "商品代码/条码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(282, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "小票流水：";
            // 
            // lblSN
            // 
            this.lblSN.AutoSize = true;
            this.lblSN.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSN.Location = new System.Drawing.Point(370, 53);
            this.lblSN.Name = "lblSN";
            this.lblSN.Size = new System.Drawing.Size(98, 16);
            this.lblSN.TabIndex = 1;
            this.lblSN.Text = "----------";
            // 
            // lblMemberInfo
            // 
            this.lblMemberInfo.AutoSize = true;
            this.lblMemberInfo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMemberInfo.Location = new System.Drawing.Point(370, 9);
            this.lblMemberInfo.Name = "lblMemberInfo";
            this.lblMemberInfo.Size = new System.Drawing.Size(98, 16);
            this.lblMemberInfo.TabIndex = 1;
            this.lblMemberInfo.Text = "**********";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(282, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "会员信息：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "会员相关信息：";
            // 
            // btnDrop
            // 
            this.btnDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDrop.Location = new System.Drawing.Point(1030, 29);
            this.btnDrop.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrop.Name = "btnDrop";
            this.btnDrop.Size = new System.Drawing.Size(83, 42);
            this.btnDrop.TabIndex = 0;
            this.btnDrop.Text = "放弃此单";
            this.btnDrop.UseVisualStyleBackColor = true;
            this.btnDrop.Click += new System.EventHandler(this.btnDrop_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(928, 29);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(83, 42);
            this.btnDelete.TabIndex = 0;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnQXGuaDan
            // 
            this.btnQXGuaDan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnQXGuaDan.Location = new System.Drawing.Point(827, 29);
            this.btnQXGuaDan.Margin = new System.Windows.Forms.Padding(2);
            this.btnQXGuaDan.Name = "btnQXGuaDan";
            this.btnQXGuaDan.Size = new System.Drawing.Size(83, 42);
            this.btnQXGuaDan.TabIndex = 0;
            this.btnQXGuaDan.Text = "取消挂单";
            this.btnQXGuaDan.UseVisualStyleBackColor = true;
            this.btnQXGuaDan.Click += new System.EventHandler(this.btnQXGuaDan_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 451);
            this.panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GoodsID,
            this.Promotion,
            this.GoodsName,
            this.UnitPrice,
            this.MemberPrice,
            this.Unit,
            this.GoodsNum,
            this.ID,
            this.OrderID,
            this.SalePrice,
            this.DiscountRate,
            this.Category,
            this.Discount,
            this.CostPrice,
            this.OriginalPrice,
            this.Profit,
            this.Supplier,
            this.Status,
            this.Stock,
            this.Memo,
            this.CreateTime,
            this.UpdateTime,
            this.Modifier});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveBorder;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1124, 451);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // GoodsID
            // 
            this.GoodsID.DataPropertyName = "GoodsID";
            this.GoodsID.HeaderText = "编号/条码";
            this.GoodsID.Name = "GoodsID";
            this.GoodsID.ReadOnly = true;
            // 
            // Promotion
            // 
            this.Promotion.DataPropertyName = "Promotion";
            this.Promotion.HeaderText = "会员价说明";
            this.Promotion.Name = "Promotion";
            this.Promotion.ReadOnly = true;
            this.Promotion.Visible = false;
            // 
            // GoodsName
            // 
            this.GoodsName.DataPropertyName = "GoodsName";
            this.GoodsName.HeaderText = "商品名称";
            this.GoodsName.Name = "GoodsName";
            this.GoodsName.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "单价";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            // 
            // MemberPrice
            // 
            this.MemberPrice.DataPropertyName = "MemberPrice";
            this.MemberPrice.HeaderText = "会员价";
            this.MemberPrice.Name = "MemberPrice";
            this.MemberPrice.ReadOnly = true;
            // 
            // Unit
            // 
            this.Unit.DataPropertyName = "Unit";
            this.Unit.HeaderText = "单位";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            // 
            // GoodsNum
            // 
            this.GoodsNum.DataPropertyName = "GoodsNum";
            this.GoodsNum.HeaderText = "数量";
            this.GoodsNum.Name = "GoodsNum";
            this.GoodsNum.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "系统编号";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // OrderID
            // 
            this.OrderID.DataPropertyName = "OrderID";
            this.OrderID.HeaderText = "订单编号";
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Visible = false;
            // 
            // SalePrice
            // 
            this.SalePrice.DataPropertyName = "SalePrice";
            this.SalePrice.HeaderText = "总价";
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.ReadOnly = true;
            this.SalePrice.Visible = false;
            // 
            // DiscountRate
            // 
            this.DiscountRate.DataPropertyName = "DiscountRate";
            this.DiscountRate.HeaderText = "折扣率";
            this.DiscountRate.Name = "DiscountRate";
            this.DiscountRate.ReadOnly = true;
            this.DiscountRate.Visible = false;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "商品分类";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "总折扣金额";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Visible = false;
            // 
            // CostPrice
            // 
            this.CostPrice.DataPropertyName = "CostPrice";
            this.CostPrice.HeaderText = "总进价";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            this.CostPrice.Visible = false;
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.DataPropertyName = "OriginalPrice";
            this.OriginalPrice.HeaderText = "总原始价";
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.ReadOnly = true;
            this.OriginalPrice.Visible = false;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.HeaderText = "总利润";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Visible = false;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "供应商";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "数据状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // Stock
            // 
            this.Stock.DataPropertyName = "Stock";
            this.Stock.HeaderText = "售前库存";
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Visible = false;
            // 
            // Memo
            // 
            this.Memo.DataPropertyName = "Memo";
            this.Memo.HeaderText = "备注";
            this.Memo.Name = "Memo";
            this.Memo.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "创建时间";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Visible = false;
            // 
            // UpdateTime
            // 
            this.UpdateTime.DataPropertyName = "UpdateTime";
            this.UpdateTime.HeaderText = "修改时间";
            this.UpdateTime.Name = "UpdateTime";
            this.UpdateTime.ReadOnly = true;
            this.UpdateTime.Visible = false;
            // 
            // Modifier
            // 
            this.Modifier.DataPropertyName = "Modifier";
            this.Modifier.HeaderText = "修改人";
            this.Modifier.Name = "Modifier";
            this.Modifier.ReadOnly = true;
            this.Modifier.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.varDiscount);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lblyingshou);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.lblGoodsPrice);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.lblGoodsNum);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnBill);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 425);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 106);
            this.panel3.TabIndex = 3;
            // 
            // varDiscount
            // 
            this.varDiscount.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.varDiscount.ForeColor = System.Drawing.Color.Maroon;
            this.varDiscount.Location = new System.Drawing.Point(539, 58);
            this.varDiscount.Name = "varDiscount";
            this.varDiscount.Size = new System.Drawing.Size(86, 36);
            this.varDiscount.TabIndex = 2;
            this.varDiscount.Text = "100";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(180, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 31);
            this.label9.TabIndex = 2;
            this.label9.Text = "元";
            // 
            // lblyingshou
            // 
            this.lblyingshou.AutoSize = true;
            this.lblyingshou.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblyingshou.ForeColor = System.Drawing.Color.Maroon;
            this.lblyingshou.Location = new System.Drawing.Point(109, 16);
            this.lblyingshou.Name = "lblyingshou";
            this.lblyingshou.Size = new System.Drawing.Size(65, 31);
            this.lblyingshou.TabIndex = 2;
            this.lblyingshou.Text = "000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.ForeColor = System.Drawing.Color.Maroon;
            this.label16.Location = new System.Drawing.Point(631, 63);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 26);
            this.label16.TabIndex = 2;
            this.label16.Text = "%";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Maroon;
            this.label15.Location = new System.Drawing.Point(417, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 26);
            this.label15.TabIndex = 2;
            this.label15.Text = "整单折扣:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(360, 63);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 26);
            this.label14.TabIndex = 2;
            this.label14.Text = "元";
            // 
            // lblGoodsPrice
            // 
            this.lblGoodsPrice.AutoSize = true;
            this.lblGoodsPrice.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoodsPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblGoodsPrice.Location = new System.Drawing.Point(309, 63);
            this.lblGoodsPrice.Name = "lblGoodsPrice";
            this.lblGoodsPrice.Size = new System.Drawing.Size(51, 26);
            this.lblGoodsPrice.TabIndex = 2;
            this.lblGoodsPrice.Text = "000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Maroon;
            this.label12.Location = new System.Drawing.Point(228, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 26);
            this.label12.TabIndex = 2;
            this.label12.Text = "原价:";
            // 
            // lblGoodsNum
            // 
            this.lblGoodsNum.AutoSize = true;
            this.lblGoodsNum.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoodsNum.ForeColor = System.Drawing.Color.Maroon;
            this.lblGoodsNum.Location = new System.Drawing.Point(166, 63);
            this.lblGoodsNum.Name = "lblGoodsNum";
            this.lblGoodsNum.Size = new System.Drawing.Size(51, 26);
            this.lblGoodsNum.TabIndex = 2;
            this.lblGoodsNum.Text = "000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(14, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 26);
            this.label10.TabIndex = 2;
            this.label10.Text = "商品数量:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 23F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(13, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 31);
            this.label7.TabIndex = 2;
            this.label7.Text = "应收：";
            // 
            // btnBill
            // 
            this.btnBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBill.Font = new System.Drawing.Font("宋体", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnBill.Location = new System.Drawing.Point(980, 35);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(132, 59);
            this.btnBill.TabIndex = 0;
            this.btnBill.Text = "结账";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // rbtn_0_5
            // 
            this.rbtn_0_5.AutoSize = true;
            this.rbtn_0_5.Location = new System.Drawing.Point(21, 40);
            this.rbtn_0_5.Name = "rbtn_0_5";
            this.rbtn_0_5.Size = new System.Drawing.Size(53, 16);
            this.rbtn_0_5.TabIndex = 3;
            this.rbtn_0_5.TabStop = true;
            this.rbtn_0_5.Text = "抹5角";
            this.rbtn_0_5.UseVisualStyleBackColor = true;
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Location = new System.Drawing.Point(88, 40);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(53, 16);
            this.rbtn_1.TabIndex = 3;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.Text = "抹1元";
            this.rbtn_1.UseVisualStyleBackColor = true;
            // 
            // rbtn_5
            // 
            this.rbtn_5.AutoSize = true;
            this.rbtn_5.Location = new System.Drawing.Point(21, 68);
            this.rbtn_5.Name = "rbtn_5";
            this.rbtn_5.Size = new System.Drawing.Size(53, 16);
            this.rbtn_5.TabIndex = 3;
            this.rbtn_5.TabStop = true;
            this.rbtn_5.Text = "抹5元";
            this.rbtn_5.UseVisualStyleBackColor = true;
            // 
            // rbtn_10
            // 
            this.rbtn_10.AutoSize = true;
            this.rbtn_10.Location = new System.Drawing.Point(88, 68);
            this.rbtn_10.Name = "rbtn_10";
            this.rbtn_10.Size = new System.Drawing.Size(59, 16);
            this.rbtn_10.TabIndex = 3;
            this.rbtn_10.TabStop = true;
            this.rbtn_10.Text = "抹10元";
            this.rbtn_10.UseVisualStyleBackColor = true;
            // 
            // rbtn_none
            // 
            this.rbtn_none.AutoSize = true;
            this.rbtn_none.Location = new System.Drawing.Point(21, 18);
            this.rbtn_none.Name = "rbtn_none";
            this.rbtn_none.Size = new System.Drawing.Size(59, 16);
            this.rbtn_none.TabIndex = 4;
            this.rbtn_none.TabStop = true;
            this.rbtn_none.Text = "不抹零";
            this.rbtn_none.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_5);
            this.groupBox1.Controls.Add(this.rbtn_10);
            this.groupBox1.Controls.Add(this.rbtn_none);
            this.groupBox1.Controls.Add(this.rbtn_0_5);
            this.groupBox1.Controls.Add(this.rbtn_1);
            this.groupBox1.Location = new System.Drawing.Point(695, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 90);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // saleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 531);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "saleForm";
            this.Text = "saleForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.saleForm_FormClosing);
            this.Load += new System.EventHandler(this.saleForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.saleForm_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnModifyCount;
        private System.Windows.Forms.Button btnGuaDan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox varBarCode;
        private System.Windows.Forms.TextBox varMemInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSN;
        private System.Windows.Forms.Label lblMemberInfo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnDrop;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnQXGuaDan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox varDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblyingshou;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblGoodsPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGoodsNum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Promotion;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MemberPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn GoodsNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscountRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Memo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modifier;
        private System.Windows.Forms.RadioButton rbtn_10;
        private System.Windows.Forms.RadioButton rbtn_5;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_0_5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_none;
    }
}