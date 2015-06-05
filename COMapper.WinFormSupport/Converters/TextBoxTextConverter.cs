using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMapper.Core.Converters;

namespace COMapper.WinFormSupport.Converters
{
    public class TextEditDefaultConverter : BaseConverter
    {

        public void SetCtlPropByObjProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            TextBox te = ctl as TextBox;
            te.Text = objProp == null || objProp.GetValue(obj, null) == null ? "" : objProp.GetValue(obj, null).ToString();
        }

        public void SetObjPropByCtlProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            TextBox te = ctl as TextBox;
            if (objProp != null)
            {
                object v = CConverter.ChangeType(te.Text.Trim(), objProp.PropertyType);
                objProp.SetValue(obj, v, null);
            }
        }
    }
}
