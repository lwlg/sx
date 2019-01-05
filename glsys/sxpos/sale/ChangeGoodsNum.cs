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
    public partial class ChangeGoodsNum : Form
    {
        public ChangeGoodsNum()
        {
            InitializeComponent();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtGoodsNum.Text))
            {
                MessageBox.Show("数量不能为空");
                txtGoodsNum.Focus();
            }
            else if (Convert.ToInt32(txtGoodsNum.Text) == 0)
            {
                MessageBox.Show("数量不能为0");
                txtGoodsNum.Focus();
            }
            else
            {
                saleForm fatherFrm = (saleForm)this.Owner;
                fatherFrm.changeGoodsNum(Convert.ToInt32(txtGoodsNum.Text), false);
                this.Close();
            }
        }

        private void txtGoodsNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOK_Click(null, EventArgs.Empty);
            }
            if (!((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar <= 31)
            {
                e.Handled = true;
            }
            else
            {
                if (e.KeyChar <= 31)
                {
                    e.Handled = false;
                }
            }
        }

        private void txtGoodsNum_Enter(object sender, EventArgs e)
        {
            this.txtGoodsNum.SelectAll();
        }
    }
}
