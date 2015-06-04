using COMapper.Converters;

namespace DevExpressSupport.Converters
{
    public class CustomGridLookUpEditDefaultConverter : BaseConverter
    {

        public void SetCtlPropByObjProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            //CustomGridLookUpEdit te = ctl as CustomGridLookUpEdit;
            //te.Text = objProp == null || objProp.GetValue(obj, null) ==null? "" : objProp.GetValue(obj, null).ToString();
        }

        public void SetObjPropByCtlProp(System.Reflection.PropertyInfo objProp, object obj, object ctl)
        {
            //CustomGridLookUpEdit te = ctl as CustomGridLookUpEdit;
            //if (objProp != null )
            //{
            //    object v = CConverter.ChangeType(te.Text.Trim(), objProp.PropertyType);
            //    objProp.SetValue(obj, v, null);
            //}
        }
    }
}
