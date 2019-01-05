using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using NDolls.Data;
using NDolls.Data.Entity;

namespace sx.Service
{
    public class GoodsService
    {
        public static IRepository<Model.posGoods> r = RepositoryFactory<Model.posGoods>.CreateRepository("sx.Model.posGoods");

        public static IRepository<Model.posGoodsIn> ir = RepositoryFactory<Model.posGoodsIn>.CreateRepository("NShop.Model.sdpost_GoodsIn");


        public List<sx.Model.posGoods> GetGoods(string key)
        {
            key = NDolls.Core.Util.ValidateUtil.FilterIllegal(key);
            return r.Find("BarCode like '%" + key + "%' or StockNo like '%" + key + "%' or ShortCode like '%" + key + "%'");
        }


        public List<sx.Model.posGoods> SearchGoods(List<Item> conditions)
        {
            return r.FindByCondition(conditions);

        }

        public List<sx.Model.posGoods> SearchGoods(string key)
        {
            key = NDolls.Core.Util.ValidateUtil.FilterIllegal(key);
            return r.Find("BarCode='" + key + "' OR StockNo LIKE '%" + key + "%' OR ShortCode LIKE '%" + key + "%'" + " OR GoodsName LIKE '%" + key + "%'");
        }


        public DataTable CustomSearch(string fields, List<Item> conditions)
        {

            return r.FindByCustom(fields, conditions);
        }

        public sx.Model.posGoods GetGoodsByID(string id)
        {
            return r.FindByPK(id);
        }

        public List<sx.Model.posGoods> GetGoodsByBarCode(string code)
        {
            ConditionItem item = new ConditionItem("BarCode", code, SearchType.Accurate);
            List<Model.posGoods> list = r.FindByCondition(item);
            return list;
        }

        public sx.Model.posGoods GetGoodsByBarCode_MustOne(string code)
        {
            ConditionItem item = new ConditionItem("BarCode", code, SearchType.Accurate);
            List<Model.posGoods> list = r.FindByCondition(item);
            if (list.Count > 0)
            {
                return (sx.Model.posGoods)list[0];
            }
            else
            {
                return null;
            }
        }


        public bool DelGoods(string id)
        {
            return r.Delete(id);
        }

    }
}
