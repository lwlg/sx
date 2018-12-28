using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Core;
using NDolls.Data;
using NDolls.Data.Entity;

namespace sx.Service
{
   public class ServiceBase<T> where T:EntityBase
    {
       public static IRepository<T> r = RepositoryFactory<T>.CreateRepository(typeof(T).ToString());

       private static NDolls.Core.Log loger = new NDolls.Core.Log("../log", LogMod.Day);

       public bool Add(T model)
       {
           try
           {
               return r.Add(model);

           }
           catch (Exception)
           {
               loger.WriteLog("数据库插入表" + typeof(T).ToString() + "异常~");
               return false;
           }
           
       }

       public bool Update(T model)
       {
           try
           {
                return r.Update(model);
           }
           catch (Exception)
           {
               loger.WriteLog("数据库更新表" + typeof(T).ToString() + "异常~");
               return false;
           }
       }

       public bool Delete(String pk)
       {
           try
           {
            return r.Delete(pk);

           }
           catch (Exception)
           {
               loger.WriteLog("数据库删除表" + typeof(T).ToString() + "异常~");
               return false;   
           }
       }

       public List<T> Find(List<Item> list)
       {
           return r.FindByCondition(list);
       }

       public List<T> Find(T model)
       {
           return r.Find(model);
       }

       public T GetModel(String pk)
       {
           return r.FindByPK(pk);
       }

       public int GetCount()
       {
           return r.GetCount("");
       }

    }
}
