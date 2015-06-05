using System.Reflection;
using COMapper.Core.Converters;

namespace COMapper.Core.Entity
{
    public class MapWrapper
    {
       public PropertyInfo ObjPropertyInfo { get; set; }
       public BaseConverter MapConverter { get; set; }
    }
}
