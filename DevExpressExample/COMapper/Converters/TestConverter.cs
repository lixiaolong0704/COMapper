using System;
using COMapper.Converters;
using DevExpress.XtraEditors;

namespace DevExpressExample.COMapper.Converters
{
    public class TestConverter : BaseConverter
    {
        public void SetCtlPropByObjProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            TextEdit te = ctl as TextEdit;
            te.Text = objProp == null ? "" : objProp.GetValue(obj, null).ToString()+"xx";
        }

        public void SetObjPropByCtlProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            TextEdit te = ctl as TextEdit;
            if (objProp != null)
            {
                object v = CConverter.ChangeType(te.Text.Trim()+"hehe", objProp.PropertyType);
                objProp.SetValue(obj, v, null);
            }
        }
    }
}
