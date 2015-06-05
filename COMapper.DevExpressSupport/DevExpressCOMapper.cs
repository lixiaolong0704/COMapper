using System;
using COMapper.Core;
using COMapper.Core.Entity;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;

namespace COMapper.DevExpressSupport
{
    public class DevExpressCOMapper
    {

        public static void SetPropertiesByControl(PanelControl panelControl, object obj, BindConfig config = null)
        {
            ObjectHelper.SetPropertiesByControl(new PanelProxy(panelControl), obj,config);
        }


        public static void SetControlByProperties(PanelControl panelControl, object obj, BindConfig config = null)
        {
            ObjectHelper.SetControlByProperties(new PanelProxy(panelControl), obj, config);
        }
        public class PanelProxy : IEnumPanel
        {
            private DevExpress.XtraEditors.PanelControl pc = null;
            public PanelProxy(DevExpress.XtraEditors.PanelControl pc)
            {
                this.pc = pc;
            }

            public bool HasChildren
            {
                get { return this.pc.HasChildren; }
            }

            public void EnumAllChildrens(Action<object> child)
            {
                pc.EnumAllChildrens(c =>
                {
                    child(c);
                });
            }
        }
    }
}
