using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using COMapper.Entity;

namespace COMapper
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
