/*
 * 1、填写详细供应商信息项
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sxpos.Manage
{
    public partial class SupplierMng : BaseForm
    {
        public BindingSource BSource { get; set; }

        private sx.Service.SupplierService s = new sx.Service.SupplierService();
        private sx.Model.pos_Supplier m = new sx.Model.pos_Supplier();
        private String id;
        public SupplierMng(String id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void SupplierMng_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(id))
            {
                m = s.GetModel(id);
                NDolls.Forms.WinUtil.SetObject(groupBox1, m, "var");
                ///Funs.GridUtil.InitDataGrid();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool ret = false;
            NDolls.Forms.WinUtil.GetModel(groupBox1, m, "var");
            if (String.IsNullOrEmpty(id))
            {
                m.SID = Guid.NewGuid().ToString("N");
                m.CreateTime = m.UpdateTime = DateTime.Now;
                ret = s.Add(m);
                if (ret)
                {
                    Funs.GridUtil.AppendRow<sx.Model.pos_Supplier>(BSource, m);
                }
                else
                {
                    m.UpdateTime = DateTime.Now;
                    ret = s.Update(m);
                }

                if (ret)
                    MessageBox.Show("保存成功");
                else
                    MessageBox.Show("保存失败");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void varSName_Leave(object sender, EventArgs e)
        {
            varShortCode.Text = Funs.SpellingUtil.GetPrefixLetters(varSName.Text);
        }

       
    }
}
