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
    public partial class MemberSelect : Form
    {
        private List<sx.Model.pos_Member> members;
        /// <summary>
        /// 传出参数
        /// </summary>
        public sx.Model.pos_Member member;
        public MemberSelect(List<sx.Model.pos_Member> members)
        {
            this.members = members;
            InitializeComponent();
        }

        private void MemberSelect_Load(object sender, EventArgs e)
        {
            List<NDolls.Data.Attribute.CustomAttribute> cols = sx.Service.MemberService.r.GetCustomFieldsByType("SCol");

            Funs.GridUtil.InitDataGrid(dataGridView1, cols);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            member = bindingSource1.Current as sx.Model.pos_Member;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnSelect_Click(sender, e);
            }
        }

        private void MemberSelect_Enter(object sender, EventArgs e)
        {
            btnSelect_Click(sender, e);
        }
    }
}
