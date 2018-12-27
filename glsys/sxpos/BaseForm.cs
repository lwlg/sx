using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using CustomUIControls;
using System.Reflection;

namespace sxpos
{
    public partial class BaseForm : DockContent
    {
        public BaseForm()
        {
            //权限判断
            InitializeComponent();
            /*this.KeyPreview = true;*/
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }

        private void BaseForm_KeyDown(object sender, KeyEventArgs e)
        {

        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                e.Handled = true;
                this.Close();
            }
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (!this.GetType().FullName.Contains("sxpos.sale") && keyData == Keys.Enter)
            {
                keyData = Keys.Tab;
            }
            return base.ProcessDialogKey(keyData);
        }

        private void setPermission(Control ctrl, String cls)
        {
 
        }

        private void checkToolStrip(Control ctrl, String cls)
        { 
        
        }

        protected static void ClearEvents(object ctl, string eventname = "All")
        { 
        
             if (ctl == null) return;
            if (string.IsNullOrEmpty(eventname)) return;

            BindingFlags bindingFlags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.IgnoreCase | BindingFlags.Static;
            Type cType = ctl.GetType();
            PropertyInfo propertyInfo = cType.GetProperty("Events", bindingFlags);
            EventHandlerList handlerList = (EventHandlerList)propertyInfo.GetValue(ctl, null);
            EventInfo[] events = ctl.GetType().GetEvents(bindingFlags);

            foreach (EventInfo ei in events)
            {
                try
                {
                    if (eventname != "All" && eventname != ei.Name) continue;

                    FieldInfo fi = ei.DeclaringType.GetField("Event" + ei.Name, bindingFlags);
                    Delegate d = handlerList[fi.GetValue(ctl)];

                    if (d == null) continue;

                    foreach (Delegate dx in d.GetInvocationList())
                        ei.RemoveEventHandler(ctl, dx);
                }
                catch { }
            }
        }


    }
}
