using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NDolls.Data.Attribute;
namespace sxpos.Manage
{
    public partial class SelectSupplier : BaseForm
    {

        private List<sx.Model.pos_Supplier> lst = new List<sx.Model.pos_Supplier>();
        private sx.Service.SupplierService ss = new sx.Service.SupplierService();

        private String sid;
        private String sname;
        public String SID
        {
            get { return sid; }
            set { sid = value; }
        }

        public String SName
        {
            get { return sname; }
            set { sname = value; }
        }


        public SelectSupplier()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
            {
                MessageBox.Show("请选择供应商!");
                return;
            }
            else
            {
                this.sid = dataGridView1.SelectedRows[0].Cells["SID"].Value.ToString();
                this.sname = dataGridView1.SelectedRows[0].Cells["SName"].Value.ToString();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            this.Close();
        }

        private void SelectSupplier_Load(object sender, EventArgs e)
        {
            DataTable dt = ss.GetAll();
            List<CustomAttribute> cols = sx.Service.SupplierService.r.GetCustomFieldsByType("GridCol");
            Funs.GridUtil.InitDataGrid(dataGridView1, cols);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = dt;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(varShortCode.Text))
            {
                DataTable dt = ss.GetAll();
                dataGridView1.DataSource = dt;
            }
            else
            {
                bindingSource1.DataSource = ss.GetModels(varShortCode.Text);
                dataGridView1.DataSource = bindingSource1.DataSource;
            }
        }
    }
}
