﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Core;
using NDolls.Data;
using NDolls.Data.Entity;

using System.Data;
namespace sx.Service
{
   public class SupplierService:ServiceBase<sx.Model.pos_Supplier>
    {
       
        public List<sx.Model.pos_Supplier> GetModels(string keywords)
        {
//           keywords = NDolls.Core.Util.ValidateUtil.FilterIllegal(keywords);
//           return r.Find("SName LIKE '%"+keywords+"%' OR ShortCode LIKE '%"+keywords+"%'");

          keywords = NDolls.Core.Util.ValidateUtil.FilterIllegal(keywords);
          string sql = "SName LIKE '%" + keywords + "%' OR ShortCode LIKE '%" + keywords + "%'";
          return r.Find(sql);
            //return r.Find("SName LIKE '%" + keywords + "%' OR ShortCode LIKE '%" + keywords + "%'");
        }
       
        public DataTable GetAll()
        {
            return NDolls.Data.RepositoryBase<EntityBase>.Query("SELECT * FROM pos_Supplier");
        }
    }
}
