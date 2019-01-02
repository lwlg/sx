namespace sxpos.Manage
{
    partial class GoodList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnUpdate = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnGoodsIn = new System.Windows.Forms.ToolStripButton();
            this.btnInList = new System.Windows.Forms.ToolStripButton();
            this.btnOutput = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.varBrand = new System.Windows.Forms.ComboBox();
            this.varCategory = new System.Windows.Forms.ComboBox();
            this.varTotalEx = new System.Windows.Forms.TextBox();
            this.varTotal = new System.Windows.Forms.TextBox();
            this.varKeywords = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.varCurrent = new System.Windows.Forms.TextBox();
            this.varDataCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.varPageCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.varStock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.varSummary = new System.Windows.Forms.ToolStripStatusLabel();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnUpdate,
            this.btnDelete,
            this.btnGoodsIn,
            this.btnInList,
            this.btnOutput});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 24);
            this.btnAdd.Text = "添加商品(&A)";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 24);
            this.btnUpdate.Text = "修改商品(&M)";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(97, 24);
            this.btnDelete.Text = "删除商品(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGoodsIn
            // 
            this.btnGoodsIn.Image = ((System.Drawing.Image)(resources.GetObject("btnGoodsIn.Image")));
            this.btnGoodsIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoodsIn.Name = "btnGoodsIn";
            this.btnGoodsIn.Size = new System.Drawing.Size(101, 24);
            this.btnGoodsIn.Text = "商品入库(F2)";
            this.btnGoodsIn.Click += new System.EventHandler(this.btnGoodsIn_Click);
            // 
            // btnInList
            // 
            this.btnInList.Image = ((System.Drawing.Image)(resources.GetObject("btnInList.Image")));
            this.btnInList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInList.Name = "btnInList";
            this.btnInList.Size = new System.Drawing.Size(116, 24);
            this.btnInList.Text = "库存变动情况(&I)";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(100, 24);
            this.btnOutput.Text = "导出excel(&0)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.varBrand);
            this.panel1.Controls.Add(this.varCategory);
            this.panel1.Controls.Add(this.varTotalEx);
            this.panel1.Controls.Add(this.varTotal);
            this.panel1.Controls.Add(this.varKeywords);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 40);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(664, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // varBrand
            // 
            this.varBrand.FormattingEnabled = true;
            this.varBrand.Location = new System.Drawing.Point(400, 6);
            this.varBrand.Margin = new System.Windows.Forms.Padding(2);
            this.varBrand.Name = "varBrand";
            this.varBrand.Size = new System.Drawing.Size(92, 20);
            this.varBrand.TabIndex = 2;
            // 
            // varCategory
            // 
            this.varCategory.FormattingEnabled = true;
            this.varCategory.Location = new System.Drawing.Point(258, 6);
            this.varCategory.Margin = new System.Windows.Forms.Padding(2);
            this.varCategory.Name = "varCategory";
            this.varCategory.Size = new System.Drawing.Size(92, 20);
            this.varCategory.TabIndex = 2;
            // 
            // varTotalEx
            // 
            this.varTotalEx.Location = new System.Drawing.Point(603, 6);
            this.varTotalEx.Margin = new System.Windows.Forms.Padding(2);
            this.varTotalEx.Name = "varTotalEx";
            this.varTotalEx.Size = new System.Drawing.Size(41, 21);
            this.varTotalEx.TabIndex = 1;
            // 
            // varTotal
            // 
            this.varTotal.Location = new System.Drawing.Point(536, 6);
            this.varTotal.Margin = new System.Windows.Forms.Padding(2);
            this.varTotal.Name = "varTotal";
            this.varTotal.Size = new System.Drawing.Size(41, 21);
            this.varTotal.TabIndex = 1;
            // 
            // varKeywords
            // 
            this.varKeywords.Location = new System.Drawing.Point(110, 6);
            this.varKeywords.Margin = new System.Windows.Forms.Padding(2);
            this.varKeywords.Name = "varKeywords";
            this.varKeywords.Size = new System.Drawing.Size(95, 21);
            this.varKeywords.TabIndex = 1;
            this.varKeywords.KeyDown += new System.Windows.Forms.KeyEventHandler(this.varKeywords_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(587, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "库存";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "品牌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "分类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名称/条码/助记符";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.varCurrent);
            this.panel2.Controls.Add(this.varDataCount);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.varPageCount);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPre);
            this.panel2.Controls.Add(this.btnFirst);
            this.panel2.Controls.Add(this.btnEnd);
            this.panel2.Location = new System.Drawing.Point(400, 303);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(442, 42);
            this.panel2.TabIndex = 2;
            // 
            // varCurrent
            // 
            this.varCurrent.Location = new System.Drawing.Point(234, 14);
            this.varCurrent.Margin = new System.Windows.Forms.Padding(2);
            this.varCurrent.Name = "varCurrent";
            this.varCurrent.Size = new System.Drawing.Size(29, 21);
            this.varCurrent.TabIndex = 7;
            this.varCurrent.Text = "1";
            // 
            // varDataCount
            // 
            this.varDataCount.AutoSize = true;
            this.varDataCount.ForeColor = System.Drawing.Color.Red;
            this.varDataCount.Location = new System.Drawing.Point(44, 18);
            this.varDataCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.varDataCount.Name = "varDataCount";
            this.varDataCount.Size = new System.Drawing.Size(23, 12);
            this.varDataCount.TabIndex = 6;
            this.varDataCount.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 18);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "条记录";
            // 
            // varPageCount
            // 
            this.varPageCount.AutoSize = true;
            this.varPageCount.Location = new System.Drawing.Point(288, 18);
            this.varPageCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.varPageCount.Name = "varPageCount";
            this.varPageCount.Size = new System.Drawing.Size(35, 12);
            this.varPageCount.TabIndex = 5;
            this.varPageCount.Text = "共1页";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 18);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "页/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(212, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = "第";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 18);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "共";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(323, 10);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(52, 26);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(158, 11);
            this.btnPre.Margin = new System.Windows.Forms.Padding(2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(52, 26);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "上一页";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(108, 14);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(48, 21);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "首页";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(378, 14);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(48, 21);
            this.btnEnd.TabIndex = 4;
            this.btnEnd.Text = "尾页";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.statusStrip1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 27);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(850, 345);
            this.panel11.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(850, 298);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeight = 38;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(850, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.varStock,
            this.toolStripStatusLabel3,
            this.varSummary});
            this.statusStrip1.Location = new System.Drawing.Point(0, 298);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(850, 47);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(74, 42);
            this.toolStripStatusLabel2.Text = "总库存:";
            // 
            // varStock
            // 
            this.varStock.ForeColor = System.Drawing.Color.Red;
            this.varStock.Name = "varStock";
            this.varStock.Size = new System.Drawing.Size(23, 42);
            this.varStock.Text = "---";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 42);
            this.toolStripStatusLabel3.Text = "汇总查询：";
            // 
            // varSummary
            // 
            this.varSummary.ForeColor = System.Drawing.Color.Red;
            this.varSummary.Name = "varSummary";
            this.varSummary.Size = new System.Drawing.Size(23, 42);
            this.varSummary.Text = "---";
            // 
            // GoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 372);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GoodList";
            this.Text = "GoodList";
            this.Load += new System.EventHandler(this.GoodList_Load);
            this.Enter += new System.EventHandler(this.GoodList_Enter);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnUpdate;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnGoodsIn;
        private System.Windows.Forms.ToolStripButton btnInList;
        private System.Windows.Forms.ToolStripButton btnOutput;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox varBrand;
        private System.Windows.Forms.ComboBox varCategory;
        private System.Windows.Forms.TextBox varTotalEx;
        private System.Windows.Forms.TextBox varTotal;
        private System.Windows.Forms.TextBox varKeywords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel varStock;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel varSummary;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.TextBox varCurrent;
        private System.Windows.Forms.Label varDataCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label varPageCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;

    }
}