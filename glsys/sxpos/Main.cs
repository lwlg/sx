using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using CustomUIControls;
/*using SHDocVw;*/
using System.Reflection;
using System.Diagnostics;
namespace sxpos
{
    public partial class Main : BaseForm
    {
        //protected TaskbarNotifier notifier;
        public Main()
        {
            InitializeComponent();
            //启动数据库备份任务

            
            #region 事件注册
            sx.Controls.Ribbon rb = elementHost1.Child as sx.Controls.Ribbon;

            rb.btnCash.Click += btnCash_Click;
            rb.btnGoods.Click += btnGoods_Click;
            rb.btnExit.Click += btnExit_Click;

            rb.btnGoodsType.Click += btnGoodsType_Click;
            #endregion
        }

        /// <summary>
        /// 商品类别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnGoodsType_Click(object sender, RoutedEventArgs e)
        {
            Settings.DicList frm = new Settings.DicList("商品类别");
            showSubForm(frm, "商品类别管理");
        }

        void btnExit_Click(object sender, RoutedEventArgs e)
        {
            Main_FormClosing(sender, new FormClosingEventArgs(CloseReason.None, false));
        }

        /// <summary>
        /// 商品管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnGoods_Click(object sender, RoutedEventArgs e)
        {
            BaseForm frm = new Manage.GoodList();
            showSubForm(frm, "商品管理");
        }
        /// <summary>
        /// 销售界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnCash_Click(object sender, RoutedEventArgs e)
        {
            sale.saleForm frm = new sale.saleForm();
            frm.ShowDialog();
        }

        private void showSubForm(BaseForm frm, String caption)
        {
            foreach (WeifenLuo.WinFormsUI.Docking.DockContent c in dockPanel1.Contents)
            {
                if (c.Text == caption)
                {
                    c.Activate();
                    return;
                }
            }
            try
            {
                frm.Text = caption;
                frm.BringToFront();
                frm.Show(dockPanel1);
                dockPanel1.Visible = true;
                panel2.Visible = false;
            }
            catch (Exception)
            {
                Console.WriteLine("showSubForm Exception.");
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                System.Windows.Forms.Application.Exit();
            }

            if (DialogResult.OK == System.Windows.Forms.MessageBox.Show("您确定要关闭系统吗?",
                "关闭提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
            {
                this.FormClosing -= new FormClosingEventHandler(this.Main_FormClosing);
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        

    }
}
