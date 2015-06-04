using System;
using COMapper.Entity;
using DevExpress.XtraEditors;

namespace DevExpressSupport
{
    public class SupCheckedListBoxControl:BaseSupport
    {
        private CheckedListBoxControl te;

        public override void Init(object control,string cfgcontrolName, BindConfig config, Type type, object obj)
        {
            base.Init(control, cfgcontrolName,config, type, obj);
            te = control as CheckedListBoxControl;
        }

        public override bool IsAssignControl(object c)
        {
            return c is CheckedListBoxControl;
        }

        public override void OnSetControlByProperties()
        {
            //PropertyInfo pi = TCSControlHelper.GetDefaultPropByControlName(te.Name, "Text", type, config);
            //te.Text = pi == null ? "" : pi.GetValue(obj, null).ToString();
        }

        public override void OnSetPropertiesByControl()
        {
            //PropertyInfo pi = TCSControlHelper.GetDefaultPropByControlName(te.Name, "Text", type, config);
            //if (pi != null)
            //{
            //    object v = Convert.ChangeType(te.Text.Trim(), pi.PropertyType);
            //    pi.SetValue(obj, v, null);
            //}
        }
    }
}
