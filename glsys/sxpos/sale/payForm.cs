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
    public partial class payForm : Form
    {
        public payForm()
        {
            InitializeComponent();

            varReceived.Focus();
            this.KeyPreview = true;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (Convert.ToDecimal(varReceived.Text) < Convert.ToDecimal(varreceivable.Text))
            {
                MessageBox.Show("实收金额不足");
                varReceived.Focus();
            }
            else
            {
                //默认不打印小票
                saleForm frm = (saleForm)this.Owner;

                frm.saveData(Convert.ToDecimal(varReceived.Text), Convert.ToDecimal(varChange.Text), 0);

                frm.truncatedetail();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnESC_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void varReceived_Enter(object sender, EventArgs e)
        {
            varReceived.SelectAll();
        }

        private void varReceived_Leave(object sender, EventArgs e)
        {
            if (varReceived.Text.Trim() == string.Empty)
            {
                varReceived.Text = "0.00";
            }

            if (varReceived.Text.Equals("0.00"))
            {
                varChange.Text = "0.00";
            }
            else
            {
                varReceived.Text = (Convert.ToDecimal(varReceived.Text).ToString("f2"));
                varChange.Text = (Convert.ToDecimal(varReceived.Text) - Convert.ToDecimal(varreceivable.Text)).ToString("f2");
            }

        }
    }
}
