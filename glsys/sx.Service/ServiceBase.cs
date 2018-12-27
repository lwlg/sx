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

       public bool Add(T model)
       {
           return r.Add(model);
       }

       public bool Update(T model)
       {
           return r.Update(model);
       }

       public bool Delete(String pk)
       {
           return r.Delete(pk);
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
