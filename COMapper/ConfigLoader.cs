using System;
using System.Collections.Generic;
using COMapper.Entity;
using COMapper.Utility;

namespace COMapper
{
    public class BindConfigWrap
    {
        public string Path { get; set; }
        public BindConfig Config { get; set; }
    }
    public static class ConfigLoader
    {
        private static Dictionary<string, BindConfigWrap> pathMaps = new Dictionary<string, BindConfigWrap>();

        private static void AddPath(string key,string path)
        {
            pathMaps.Add(key, new BindConfigWrap()
            {
                Path =  path
            });
        }
        static ConfigLoader()
        {

            AddPath("EMSinfoHeader", @"Util\ControlMapper\Configs\template.xml");
            AddPath("emsdetail", @"Util\ControlMapper\Configs\emsdetail.xml");
        }

        public static BindConfig GetConfig(string key)
        {
            if (pathMaps.ContainsKey(key))
            {
                if (pathMaps[key].Config == null)
                {
                    pathMaps[key].Config = XmlHelper.DeSerialize<BindConfig>(pathMaps[key].Path);
                }
                return pathMaps[key].Config;
            }
            else
            {
                throw new Exception("no Config");
            }
        }
       
    }
}
