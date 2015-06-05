using System.Collections.Generic;
using COMapper.Core.Entity;

namespace COMapper.Core
{
    public class COGlobal
    {

        public static List<BaseSupport> Supports = null;
        public static void RegisterConfigPath(string key, string path)
        {
             ConfigLoader.RegisterConfigPath(key,path);
        }

        public static BindConfig GetConfig(string key)
        {
            return ConfigLoader.GetConfig(key);
        }
    }
}
