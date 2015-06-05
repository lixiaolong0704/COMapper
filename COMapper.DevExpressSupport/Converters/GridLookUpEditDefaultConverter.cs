using COMapper.Core.Converters;

namespace COMapper.DevExpressSupport.Converters
{
    public class GridLookUpEditDefaultConverter : BaseConverter
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
