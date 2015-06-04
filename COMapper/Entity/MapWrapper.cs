using System.Reflection;
using COMapper.Converters;

namespace COMapper.Entity
{
    public class MapWrapper
    {
       public PropertyInfo ObjPropertyInfo { get; set; }
       public BaseConverter MapConverter { get; set; }
    }
}
