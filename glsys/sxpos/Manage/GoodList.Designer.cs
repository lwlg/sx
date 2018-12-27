﻿namespace sxpos.Manage
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.varStock = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.varSummary = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1134, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(94, 24);
            this.btnAdd.Text = "添加商品(&A)";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Image")));
            this.btnUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 24);
            this.btnUpdate.Text = "修改商品(&M)";
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(114, 24);
            this.btnDelete.Text = "删除商品(&D)";
            // 
            // btnGoodsIn
            // 
            this.btnGoodsIn.Image = ((System.Drawing.Image)(resources.GetObject("btnGoodsIn.Image")));
            this.btnGoodsIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoodsIn.Name = "btnGoodsIn";
            this.btnGoodsIn.Size = new System.Drawing.Size(120, 24);
            this.btnGoodsIn.Text = "商品入库(F2)";
            // 
            // btnInList
            // 
            this.btnInList.Image = ((System.Drawing.Image)(resources.GetObject("btnInList.Image")));
            this.btnInList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInList.Name = "btnInList";
            this.btnInList.Size = new System.Drawing.Size(137, 24);
            this.btnInList.Text = "库存变动情况(&I)";
            // 
            // btnOutput
            // 
            this.btnOutput.Image = ((System.Drawing.Image)(resources.GetObject("btnOutput.Image")));
            this.btnOutput.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(120, 24);
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1134, 50);
            this.panel1.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(885, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // varBrand
            // 
            this.varBrand.FormattingEnabled = true;
            this.varBrand.Location = new System.Drawing.Point(534, 16);
            this.varBrand.Name = "varBrand";
            this.varBrand.Size = new System.Drawing.Size(121, 23);
            this.varBrand.TabIndex = 2;
            // 
            // varCategory
            // 
            this.varCategory.FormattingEnabled = true;
            this.varCategory.Location = new System.Drawing.Point(344, 13);
            this.varCategory.Name = "varCategory";
            this.varCategory.Size = new System.Drawing.Size(121, 23);
            this.varCategory.TabIndex = 2;
            // 
            // varTotalEx
            // 
            this.varTotalEx.Location = new System.Drawing.Point(804, 16);
            this.varTotalEx.Name = "varTotalEx";
            this.varTotalEx.Size = new System.Drawing.Size(53, 25);
            this.varTotalEx.TabIndex = 1;
            // 
            // varTotal
            // 
            this.varTotal.Location = new System.Drawing.Point(715, 16);
            this.varTotal.Name = "varTotal";
            this.varTotal.Size = new System.Drawing.Size(53, 25);
            this.varTotal.TabIndex = 1;
            // 
            // varKeywords
            // 
            this.varKeywords.Location = new System.Drawing.Point(147, 10);
            this.varKeywords.Name = "varKeywords";
            this.varKeywords.Size = new System.Drawing.Size(125, 25);
            this.varKeywords.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "~";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "库存";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(491, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "品牌";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "分类";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 15);
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
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(576, 385);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(546, 53);
            this.panel2.TabIndex = 2;
            // 
            // varCurrent
            // 
            this.varCurrent.Location = new System.Drawing.Point(312, 17);
            this.varCurrent.Name = "varCurrent";
            this.varCurrent.Size = new System.Drawing.Size(37, 25);
            this.varCurrent.TabIndex = 7;
            this.varCurrent.Text = "1";
            // 
            // varDataCount
            // 
            this.varDataCount.AutoSize = true;
            this.varDataCount.ForeColor = System.Drawing.Color.Red;
            this.varDataCount.Location = new System.Drawing.Point(85, 22);
            this.varDataCount.Name = "varDataCount";
            this.varDataCount.Size = new System.Drawing.Size(31, 15);
            this.varDataCount.TabIndex = 6;
            this.varDataCount.Text = "100";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 5;
            this.label8.Text = "条记录";
            // 
            // varPageCount
            // 
            this.varPageCount.AutoSize = true;
            this.varPageCount.Location = new System.Drawing.Point(384, 22);
            this.varPageCount.Name = "varPageCount";
            this.varPageCount.Size = new System.Drawing.Size(45, 15);
            this.varPageCount.TabIndex = 5;
            this.varPageCount.Text = "共1页";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(352, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 15);
            this.label10.TabIndex = 5;
            this.label10.Text = "页/";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(285, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "第";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "共";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(431, 18);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "下一页";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 18);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "上一页";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(171, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "首页";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "尾页";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel1);
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Controls.Add(this.panel3);
            this.panel11.Controls.Add(this.statusStrip1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 27);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1134, 438);
            this.panel11.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1134, 379);
            this.panel3.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1134, 379);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 379);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1134, 59);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(74, 54);
            this.toolStripStatusLabel2.Text = "总库存:";
            // 
            // varStock
            // 
            this.varStock.ForeColor = System.Drawing.Color.Red;
            this.varStock.Name = "varStock";
            this.varStock.Size = new System.Drawing.Size(27, 54);
            this.varStock.Text = "---";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(84, 54);
            this.toolStripStatusLabel3.Text = "汇总查询：";
            // 
            // varSummary
            // 
            this.varSummary.ForeColor = System.Drawing.Color.Red;
            this.varSummary.Name = "varSummary";
            this.varSummary.Size = new System.Drawing.Size(27, 54);
            this.varSummary.Text = "---";
            // 
            // GoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 465);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "GoodList";
            this.Text = "GoodList";
            this.Load += new System.EventHandler(this.GoodList_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox varCurrent;
        private System.Windows.Forms.Label varDataCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label varPageCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;

    }
}