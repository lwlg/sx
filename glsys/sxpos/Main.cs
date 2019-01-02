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
            //菜单一
            rb.btnCash.Click += btnCash_Click;           //商品销售
            rb.btnGoods.Click += btnGoods_Click;         //商品管理
            rb.btnMember.Click += btnMember_Click;       //会员管理   
            rb.btnIns.Click += btnIns_Click;             //入库记录
            rb.btnSale.Click += btnSale_Click;           //销售记录

            rb.btnChangePwd.Click += btnChangePwd_Click; //修改密码
            rb.btnRestart.Click += btnRestart_Click;     //系统注销
            rb.btnExit.Click += btnExit_Click;           //退出系统

            //菜单二
            rb.btnPrintSetting.Click += btnPrintSetting_Click;
            rb.btnSysSetting.Click += btnSysSetting_Click; ;
            rb.btnSupplier.Click += btnSupplier_Click;

            rb.btnUserAdd.Click += btnUserAdd_Click;
            rb.btnUserList.Click += btnUserList_Click;

            rb.btnGoodsType.Click += btnGoodsType_Click;      //商品种类管理
            rb.btnBrandType.Click += btnBrandType_Click;      //品牌管理
            rb.btnUnitType.Click += btnUnitType_Click;        //单位类型管理
            #endregion
        }

        void btnUserList_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnUserAdd_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnSysSetting_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 供应商管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnSupplier_Click(object sender, RoutedEventArgs e)
        {
            BaseForm frm = new Manage.SupplierList();
            showSubForm(frm, "供应商管理");

        }

        void btnPrintSetting_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnRestart_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnChangePwd_Click(object sender, RoutedEventArgs e)
        {

        }

        void btnIns_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void btnMember_Click(object sender, RoutedEventArgs e)
        {

        }

        void btnSale_Click(object sender, RoutedEventArgs e)
        {

        }

        /// <summary>
        /// 单位类型管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnUnitType_Click(object sender, RoutedEventArgs e)
        {
            Settings.DicList frm = new Settings.DicList("商品单位");
            showSubForm(frm, "商品单位管理");

        }
        /// <summary>
        /// 品牌管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void btnBrandType_Click(object sender, RoutedEventArgs e)
        {
            Settings.DicList frm = new Settings.DicList("商品品牌");
            showSubForm(frm, "商品品牌管理");
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

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void dockPanel1_Click(object sender, EventArgs e)
        {

        }


        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    btnCash_Click(this, null);
                    break;
                case Keys.F2:
                    btnGoods_Click(this, null);
                    break;
                case Keys.F3:
                    btnMember_Click(this, null);
                    break;
                case Keys.F4:
                    btnIns_Click(this, null);
                    break;
                case Keys.F5:
                    //btnSales_Click(this, null);
                    break;
            }
        }

    }
}
