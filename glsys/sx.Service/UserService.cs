using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Core;
using NDolls.Data.Entity;

namespace sx.Service
{
    public partial class  UserService: ServiceBase<Model.Sys_User>
    {
        public bool AddUser(Model.Sys_User user)
        {
            return r.Add(user);
        }

        public bool DeleteUser(String userName)
        {
            return r.Delete(userName);
        }

        public bool UpdateUser(Model.Sys_User user)
        {
            return r.Update(user);
        }

        public bool SaverUser(Model.Sys_User user)
        {
            return r.AddOrUpdate(user);
        }

        public IList<Model.Sys_User> GetUsers(List<Item> list)
        {
            return r.FindByCondition(list);
        }

        public Model.Sys_User GetUser(String userName)
        {
            return r.FindByPK(userName);
        }

        public Model.Sys_User GetUser(String userName, String password)
        {

            List<Item> list = new List<Item>();
            list.Add(new ConditionItem("UserName", userName, SearchType.Accurate));
            list.Add(new ConditionItem("Password", password, SearchType.Accurate));
            List<Model.Sys_User> uList = r.FindByCondition(list);
            if (uList != null && uList.Count >0)
            {
                return uList[0];
            }
            else
            {
                return null;
            }

        }

    }
}
