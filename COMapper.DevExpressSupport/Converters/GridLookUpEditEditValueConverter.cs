using COMapper.Core.Converters;
using DevExpress.XtraEditors;

namespace COMapper.DevExpressSupport.Converters
{
    public class GridLookUpEditEditValueConverter:BaseConverter
    {
        public void SetCtlPropByObjProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            GridLookUpEdit te = ctl as GridLookUpEdit;
            te.EditValue = objProp == null ? "" : objProp.GetValue(obj, null);
        }

        public void SetObjPropByCtlProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            GridLookUpEdit te = ctl as GridLookUpEdit;
            if (objProp != null)
            {
                object v = CConverter.ChangeType(te.EditValue, objProp.PropertyType);
                if (v.ToString().StartsWith("请输入"))
                {
                    v = string.Empty;
                }
                else
                {
                    objProp.SetValue(obj, v, null);
                }

            }
        }
    }
}
