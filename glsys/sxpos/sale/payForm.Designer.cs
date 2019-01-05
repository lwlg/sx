namespace sxpos.sale
{
    partial class payForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.varreceivable = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.varReceived = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.varChange = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnESC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(27, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "应收：";
            // 
            // varreceivable
            // 
            this.varreceivable.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.varreceivable.Location = new System.Drawing.Point(129, 35);
            this.varreceivable.Name = "varreceivable";
            this.varreceivable.Size = new System.Drawing.Size(150, 38);
            this.varreceivable.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(27, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "实收：";
            // 
            // varReceived
            // 
            this.varReceived.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.varReceived.Location = new System.Drawing.Point(129, 86);
            this.varReceived.Name = "varReceived";
            this.varReceived.Size = new System.Drawing.Size(150, 38);
            this.varReceived.TabIndex = 1;
            this.varReceived.Enter += new System.EventHandler(this.varReceived_Enter);
            this.varReceived.Leave += new System.EventHandler(this.varReceived_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(27, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "找零：";
            // 
            // varChange
            // 
            this.varChange.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.varChange.Location = new System.Drawing.Point(129, 143);
            this.varChange.Name = "varChange";
            this.varChange.Size = new System.Drawing.Size(150, 38);
            this.varChange.TabIndex = 1;
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEnter.Location = new System.Drawing.Point(327, 29);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(139, 56);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "清算\r\nEnter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnESC
            // 
            this.btnESC.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnESC.Location = new System.Drawing.Point(327, 120);
            this.btnESC.Name = "btnESC";
            this.btnESC.Size = new System.Drawing.Size(139, 56);
            this.btnESC.TabIndex = 2;
            this.btnESC.Text = "取消\r\nESC";
            this.btnESC.UseVisualStyleBackColor = true;
            this.btnESC.Click += new System.EventHandler(this.btnESC_Click);
            // 
            // payForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 222);
            this.Controls.Add(this.btnESC);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.varChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.varReceived);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.varreceivable);
            this.Controls.Add(this.label1);
            this.Name = "payForm";
            this.Text = "收款";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnESC;
        public System.Windows.Forms.TextBox varreceivable;
        public System.Windows.Forms.TextBox varReceived;
        public System.Windows.Forms.TextBox varChange;
    }
}