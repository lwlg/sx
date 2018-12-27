using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NDolls.Core;
using NDolls.Data;
using NDolls.Data.Entity;


namespace sxpos.sale
{
    public partial class saleForm : Form
    {
        public static IRepository<sx.Model.Sys_User> r =
            RepositoryFactory<sx.Model.Sys_User>.CreateRepository("Sys_User");
            
        public saleForm()
        {
            InitializeComponent();
            NDolls.Data.DataConfig.ConnectionString = "Data Source = sx.db;Pooling =False; Max Pool Size =100;";
            NDolls.Data.DataConfig.DatabaseType = DBType.SQLite;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           sx.Model.Sys_User usr = r.FindByPK("baosight");
           if (usr != null)
           {
             Console.WriteLine("result:" + usr.UserName +"/"+ usr.Password);
           }
           else
           {
               Console.WriteLine("result: NULL" );
           }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sx.Model.Sys_User m_usr = new  sx.Model.Sys_User();
            m_usr.UserName = "11lisi_qi";
            m_usr.Password = "helo";
            
            if (r.Add(m_usr))
            {
                System.Windows.MessageBox.Show("插入成功");
            }

        }
    }
}
