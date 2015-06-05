using System.Reflection;

namespace COMapper.Core.Converters
{
    public interface BaseConverter
    {
     
        void SetCtlPropByObjProp(PropertyInfo objProp, object obj, object ctl);


        void SetObjPropByCtlProp(PropertyInfo objProp, object obj, object ctl);

    }
}
