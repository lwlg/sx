using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sxpos.Funs
{
    public class Constant
    {
        #region 日志
        public static NDolls.Core.Log loger
        {
            get { return Constant.loger; }
            set { Constant.loger = value; }
        }
        #endregion


        #region 登录用户信息

        private static String _userName = "";
        /// <summary>
        /// 1 用户名
        /// </summary>
        public static String UserName
        {
            get { return Constant._userName; }
            set { Constant._userName = value; }
        }

        private static String _userRole = "Admin";
        /// <summary>
        /// 2 用户角色
        /// </summary>
        public static String UserRole
        {
            get { return Constant._userRole; }
            set { Constant._userRole = value; }
        }

        //public static String UserAccount
        //{
        //    get
        //    {
        //        if (String.IsNullOrEmpty(useraccount))
        //        {
        //            SettingService s = new SettingService();
        //            try
        //            {
        //                useraccount = s.GetSetting("useraccount").SValue;
        //            }
        //            catch { }
        //        }
        //        return useraccount;
        //    }
        //    set
        //    {
        //        useraccount = value;
        //    }
        //}

        //       public static Dictionary<String, String> RolePermission
        //       {
        //           get 
        //           { 
        //               return 
        //           }
        //       }

        #endregion
    }
}
