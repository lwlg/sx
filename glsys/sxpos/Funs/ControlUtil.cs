using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sxpos.Funs
{
    public class ControlUtil
    {
        public static void ShowForm(BaseForm frm)
        {
            try
            {
                frm.ShowDialog();
            }
            catch
            { }
        }

    }
}
