using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NDolls.Data.Entity;

namespace sx.Service
{
    public class MemberService
    {
        public static NDolls.Data.IRepository<sx.Model.pos_Member> r =
            NDolls.Data.RepositoryFactory<sx.Model.pos_Member>.CreateRepository("sx.Model.pos_Member");

        public static NDolls.Data.IRepository<sx.Model.pos_MemberCostume> r1 =
           NDolls.Data.RepositoryFactory<sx.Model.pos_MemberCostume>.CreateRepository("sx.Model.pos_MemberCostume");

        public bool SaveMemberCostume(sx.Model.pos_MemberCostume m)
        {
            return r1.AddOrUpdate(m);
        }

        public sx.Model.pos_MemberCostume GetMemberCostume(string id)
        {
            return r1.FindByPK(id);
        }

        public bool AddMember(sx.Model.pos_Member m)
        {
            return r.Add(m);
        }

        public bool UpdateMember(sx.Model.pos_Member m)
        {
            return r.Update(m);
        }

        public bool SaveMember(sx.Model.pos_Member m)
        {
            return r.AddOrUpdate(m);
        }

        public sx.Model.pos_Member GetMember(string id)
        {
            return r.FindByPK(id);
        }

        public sx.Model.pos_Member GetMemberByMemberNo(string memberNo)
        {
            List<Item> list = new List<Item>();
            list.Add(new ConditionItem("MemberNo", memberNo, SearchType.Accurate));
            return r.FindByCondition(list)[0];
        }

        public List<sx.Model.pos_Member> GetMembers(sx.Model.pos_Member m)
        {
            return r.Find(m);
        }

        public List<sx.Model.pos_Member> GetMemberNoPhone(string key)
        {
            key = NDolls.Core.Util.ValidateUtil.FilterIllegal(key);
            return r.Find("MemberNo='" + key + "' OR PhoneNo='" + key + "' OR MemberName LIKE '" + key + "%' OR ShortCode LIKE '" + key + "%'");
        }

        public String ValidateUnique(sx.Model.pos_Member m)
        {
            List<Item> list = new List<Item>();
            list.Add(new ConditionItem("MemberNo", m.MemberNo, SearchType.Accurate));
            list.Add(new ConditionItem("ID", m.ID, SearchType.Unequal));
            if (r.Exist(list))
            {
                return "已经存在该会员号，不允许重复";
            }
            list = new List<Item>();
            list.Add(new ConditionItem("PhoneNo", m.PhoneNo, SearchType.Accurate));
            list.Add(new ConditionItem("ID", m.ID, SearchType.Unequal));
            if (r.Exist(list))
            {
                return "已经存在该手机号，不允许重复";
            }
            return "";


        }

        public String Validate(sx.Model.pos_Member m)
        {
            String err = r.Validate(m);

            if (String.IsNullOrEmpty(err))
            {
                err = ValidateUnique(m);
            }
            return err;
        }
    }
}
