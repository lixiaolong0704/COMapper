using COMapper.Core.Converters;
using DevExpress.XtraEditors;

namespace COMapper.DevExpressSupport.Converters
{
    public class TextEditDefaultConverter:BaseConverter
    {

        public void SetCtlPropByObjProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            TextEdit te = ctl as TextEdit;
            te.Text = objProp == null || objProp.GetValue(obj, null)==null ? "" : objProp.GetValue(obj, null).ToString();
        }

        public void SetObjPropByCtlProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            TextEdit te = ctl as TextEdit;
            if (objProp != null)
            {
                object v = CConverter.ChangeType(te.Text.Trim(), objProp.PropertyType);
                objProp.SetValue(obj, v, null);
            }
        }
    }
}
