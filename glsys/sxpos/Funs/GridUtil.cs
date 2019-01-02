using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using NDolls.Data.Attribute;
using System.Windows.Forms;
using System.Reflection;
namespace sxpos.Funs
{

    public class GridUtil
    {
        public static void InitDataGrid(DataGridView grid, List<CustomAttribute> cols)
        {
            grid.AutoGenerateColumns = false;
            grid.Columns.Clear();
            foreach (CustomAttribute col in cols)
            {
                DataGridViewTextBoxColumn c = new DataGridViewTextBoxColumn();
                c.Name = col.CusName;
                c.HeaderText = col.CusValue;
                c.DataPropertyName = col.CusName;
                if (col.CusMemo == "invisible")
                {
                    c.Visible = false;
                }
                else if (col.CusMemo == "sortble")
                {
                    c.SortMode = DataGridViewColumnSortMode.Automatic;
                }
                grid.Columns.Add(c);
            }


        }

        public static void AppendRow<T>(BindingSource bingSource, T model)
        {
            try
            {
                bingSource.Add(model);
                bingSource.MoveLast();
            }
            catch (Exception)
            {
                throw;

            }

        }

        public static void UpdateRow(BindingSource bindSource, object o)
        {
            try
            {
                Type t = o.GetType();
                PropertyInfo[] propertys = t.GetProperties();
                object p = bindSource.Current;
                foreach (PropertyInfo item in propertys)
                {
                    object value = item.GetValue(0, null);
                    item.SetValue(item, value, null);
                }
                bindSource.ResetCurrentItem();
            }
            catch
            {

            }

        }

        public static void DataToExcel(DataGridView grid)
        {

        }
    }
}
