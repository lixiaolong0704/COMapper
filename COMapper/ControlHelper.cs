using COMapper.Entity;

namespace COMapper
{
    public class TCSControlHelper
    {

        public static bool IsIgnore(string cfgControlName, BindConfig config)
        {
          
            if (config != null && config.Maps.maps.Count != 0)
            {
                Map map = config.Maps.maps.Find(m =>cfgControlName==m.CTL && !string.IsNullOrEmpty(m.Ignore));
                if (map != null)
                {
                    return true;
                }
               
            }
            return false;
    
        }
        
    
    }
}
