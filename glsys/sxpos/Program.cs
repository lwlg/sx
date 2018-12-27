using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using NDolls.Core;
using NDolls.Data;
using NDolls.Data.Entity;

namespace sxpos
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            NDolls.Data.DataConfig.ConnectionString = "Data Source = sx.db;Pooling =False; Max Pool Size =100;";
            NDolls.Data.DataConfig.DatabaseType = DBType.SQLite;
            //【数据库连接】
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //【启动界面】
            //启用后vs调试会出现崩溃情况
//             StartForm.Instance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular,
//                 System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//             StartForm.SetBackgroundImage(sxpos.Properties.Resources.splashbg);
//             StartForm.SetTitleString("正在启动三星管理系统");
//             StartForm.BeginDisplay();
//             StartForm.SetCommentaryString("准备启动......");
//             //Thread.Sleep(2000);//延时模拟启动画面
//             StartForm.EndDisplay();

            Application.Run(new Main());
        }
    }
}
