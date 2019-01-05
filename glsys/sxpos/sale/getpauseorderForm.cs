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
    public partial class getpauseorderForm : Form
    {
        public getpauseorderForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                orderConfirm();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }


        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            orderConfirm();
        }

        private void orderConfirm()
        {
            saleForm frm = (saleForm)this.Owner;
            frm.orderSelectEnter(dataGridView1.CurrentRow.Index);
            this.Close();
            
        }
    }
}
