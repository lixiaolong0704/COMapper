using System;

namespace COMapper.Converters
{
    public static class CConverter
    {
        public static object ChangeType(object s,Type targetType)
        {
            if (targetType == typeof (string))
            {
                if (s == null)
                {
                    return string.Empty;
                }
                else
                {
                    return s.ToString();
                }
              
            }
            else
            {
                if (s == null)
                {
                    return null;
                }
                else
                {
                    return Convert.ChangeType(s, targetType);
                }
 
            }
           
        }
    }
}
