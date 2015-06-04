using System;
using COMapper.Converters;
using DevExpress.XtraEditors;

namespace DevExpressSupport.Converters
{
    public class TestConverter : BaseConverter
    {
        public void SetCtlPropByObjProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            TextEdit te = ctl as TextEdit;
            //te.Text = objProp == null ? "" : objProp.GetValue(obj, null).ToString()+"xx";
        }

        public void SetObjPropByCtlProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            throw new NotImplementedException();
        }
    }
}
