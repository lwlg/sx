using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NDolls.Data.Attribute;
namespace sxpos.Settings
{
    public partial class DicList : BaseForm
    {
        private String dicType = "";
        private sx.Service.DicService s = new sx.Service.DicService();

        public DicList()
        {
            InitializeComponent();
        }
        public DicList(String dicType)
        {
            this.dicType = dicType;
            InitializeComponent();
        }

        private void DicList_Load(object sender, EventArgs e)
        {
            if (initTree())
            {
                if (!String.IsNullOrEmpty(dicType))
                {
                    try
                    {
                        TreeNode[] tn = treeView1.Nodes.Find(dicType, true);
                        if(tn.Length != 0)
                        {
                            treeView1.SelectedNode = tn[0];
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            List<CustomAttribute> cols = sx.Service.DicService.r.GetCustomFieldsByType("GridCol");
            Funs.GridUtil.InitDataGrid(dataGridView1, cols);
            dataGridView1.Columns["DID"].Visible = false;           
        }

        private bool initTree()
        {
            treeView1.Visible = false;
            DataTable dt = s.GetDicTypes();
            treeView1.Nodes.Clear();
            if (dt.Rows.Count <= 0)
            {
                return false;
            }
            foreach (DataRow row in dt.Rows)
            {
                treeView1.Nodes.Add(row["DType"].ToString(), row["DType"].ToString());
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(dicType))
            {
                DicManage frm = new DicManage("", dicType);
                frm.BSource = bindingSource1;
                frm.ShowDialog();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            if (rows != null && rows.Count > 0)
            {
                DicManage frm = new DicManage(rows[0].Cells["DID"].Value.ToString(), treeView1.SelectedNode.Text);
                frm.BSource = bindingSource1;
                frm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除选中信息吗？", "提示", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
                if (rows != null && rows.Count >0)
                {
                    if (s.DeleteDic(rows[0].Cells["DID"].Value.ToString()))
                    {
                        treeView1_AfterSelect(sender, new TreeViewEventArgs(treeView1.SelectedNode));
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }    
                }
                
            }
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            Funs.GridUtil.DataToExcel(dataGridView1);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bindingSource1.DataSource = s.GetDicsByType(e.Node.Text);
            dataGridView1.DataSource = bindingSource1;
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            btnUpdate_Click(sender, e);
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                btnDelete_Click(sender, e);
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dataGridView1.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
               dataGridView1.RowHeadersDefaultCellStyle.Font,
               rectangle,
               dataGridView1.RowHeadersDefaultCellStyle.ForeColor,
               TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter);
        }

        private void DicList_Activated(object sender, EventArgs e)
        {
            this.DicList_Load(sender, e);
        }

    }
}
