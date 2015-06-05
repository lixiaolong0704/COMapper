using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMapper.Core;
using COMapper.Core.Entity;

namespace COMapper.WinFormSupport
{
    public class WinFormCOMapper
    {
        public static void SetPropertiesByControl(Panel panelControl, object obj, BindConfig config = null)
        {
            ObjectHelper.SetPropertiesByControl(new PanelProxy(panelControl), obj, config);
        }


        public static void SetControlByProperties(Panel panelControl, object obj, BindConfig config = null)
        {
            ObjectHelper.SetControlByProperties(new PanelProxy(panelControl), obj, config);
        }
        public class PanelProxy : IEnumPanel
        {
            private Panel pc = null;
            public PanelProxy(Panel pc)
            {
                this.pc = pc;
            }

            public bool HasChildren
            {
                get { return this.pc.HasChildren; }
            }

            public void EnumAllChildrens(Action<object> child)
            {
                foreach (Control c in pc.Controls)
                {
                    child(c);
                }
            }
        }
    }
}
