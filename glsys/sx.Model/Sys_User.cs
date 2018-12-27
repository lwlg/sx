using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Core;
using NDolls.Data.Attribute;
using NDolls.Data.Entity;

namespace sx.Model
{
    [Entity("Sys_User","UserName")]
  public  class Sys_User : EntityBase
    {
        [DataField("UserName","nvarchar")]
        [Validate("用户名不能为空")]
        [Custom("GridCol","UserName","用户账号")]
        public string UserName { get; set; }


        [DataField("Password", "nvarchar")]
        [Validate("用密码不能为空")]
        public string Password { get; set; }


        [DataField("RealName", "nvarchar")]
        [Custom("GridCol", "RealName", "店员姓名")]
        public string RealName { get; set; }


        [DataField("Phone", "nvarchar")]
        [Custom("GridCol", "Phone", "店员手机号")]
        public string Phone { get; set; }


        [DataField("UserRole", "nvarchar")]
        [Validate("用户角色不能为空")]
        public string UserRole { get; set; }

        [DataField("Memo", "nvarchar")]
        public string Memo { get; set; }

        [DataField("CreateTime", "nvarchar")]
        public DateTime CreateTime { get; set; }


        [DataField("Modifier", "nvarchar")]
        public string Modifier { get; set; }

        [DataField("Status", "int")]
        public string Status { get; set; }
    }
}
