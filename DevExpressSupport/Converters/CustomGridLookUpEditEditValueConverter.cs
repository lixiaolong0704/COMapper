using COMapper.Converters;

namespace DevExpressSupport.Converters
{
    public class CustomGridLookUpEditEditValueConverter:BaseConverter
    {
        public void SetCtlPropByObjProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            //CustomGridLookUpEdit te= ctl as CustomGridLookUpEdit;
            //te.EditValue = objProp == null ? "" : objProp.GetValue(obj, null);
        }

        public void SetObjPropByCtlProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            //CustomGridLookUpEdit te = ctl as CustomGridLookUpEdit;
            //if (objProp != null)
            //{
            //    object v = CConverter.ChangeType(te.EditValue, objProp.PropertyType);
            //    if (v.ToString().StartsWith("请输入"))
            //    {
            //        v = string.Empty;
            //    }
            //    else
            //    {
            //        objProp.SetValue(obj, v, null);
            //    }
           
            //}
        }
    }
}
