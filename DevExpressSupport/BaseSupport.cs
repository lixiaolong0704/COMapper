using System;
using System.Collections.Generic;
using COMapper.Converters;
using COMapper.Entity;
using DevExpress.XtraEditors;

namespace DevExpressSupport
{
    public class BaseSupport
    {
        public static List<Type> SupportControlTypes = new List<Type>()
        {
            //typeof (CustomGridLookUpEdit),
            typeof (LookUpEdit),
            typeof (TextEdit)
        };

        public static List<BaseSupport> Supports = new List<BaseSupport>()
        {
            //new SupCustomGridLookUpEdit(),
            new SupLookUpEdit(),
            new SupTextEdit()
        };

        protected object control { get; set; }
        protected BindConfig config { get; set; }
        protected Type type { get; set; }
        protected object obj { get; set; }
        protected string cfgcontrolName { get; set; }

        public virtual void Init(object control, string cfgcontrolName, BindConfig config, Type type, object obj)
        {
            this.control = control;
            this.config = config;
            this.type = type;
            this.obj = obj;
            this.cfgcontrolName = cfgcontrolName;
        }


        public virtual bool IsAssignControl(object c)
        {
            return false;
        }

        //public Dictionary<string, BaseConverter> defConverter = new Dictionary<string, BaseConverter>();
        public Dictionary<string, BaseConverter> otherdefConverters = new Dictionary<string, BaseConverter>( );

        public virtual string GetDefCtlPropName()
        {
            return "Text";
        }

        public virtual BaseConverter GetDefConverter()
        {
            return null;
        }

        public virtual void OnSetControlByProperties()
        {
            GetDefaultPropByControlName(mw => { mw.MapConverter.SetCtlPropByObjProp(mw.ObjPropertyInfo, obj, control); });

            GetOtherPropByControlName(mw => { mw.MapConverter.SetCtlPropByObjProp(mw.ObjPropertyInfo, obj, control); });
        }


        public virtual void OnSetPropertiesByControl()
        {
            GetDefaultPropByControlName(mw => { mw.MapConverter.SetObjPropByCtlProp(mw.ObjPropertyInfo, obj, control); });
            GetOtherPropByControlName(mw => { mw.MapConverter.SetObjPropByCtlProp(mw.ObjPropertyInfo, obj, control); });
        }

        public void GetDefaultPropByControlName(Action<MapWrapper> mapAciton)
        {
            MapWrapper mapWrapper = new MapWrapper();
            mapWrapper.MapConverter = GetDefConverter();
            //DefaultProp
            if (config != null && config.Maps.maps.Count != 0)
            {
                List<Map> maps = config.Maps.maps.FindAll(m => cfgcontrolName == m.CTL);
                Map defaultMap = maps.Find(m1 => string.IsNullOrEmpty(m1.CTL_PROP) || m1.CTL_PROP == GetDefCtlPropName());
                if (defaultMap != null)
                {
                    mapWrapper.ObjPropertyInfo = type.GetProperty(defaultMap.PROP);
                    if (!string.IsNullOrEmpty(defaultMap.Converter))
                    {
                        mapWrapper.MapConverter =
                            (BaseConverter) Activator.CreateInstance(System.Type.GetType(defaultMap.Converter));
                    }
                }
                else
                {
                    mapWrapper.ObjPropertyInfo = type.GetProperty(cfgcontrolName);
                }
            }
            else
            {
                mapWrapper.ObjPropertyInfo = type.GetProperty(cfgcontrolName);
            }
            mapAciton(mapWrapper);
        }


        public void GetOtherPropByControlName(Action<MapWrapper> mapAciton)
        {
            //OtherProp
            if (config != null && config.Maps.maps.Count != 0)
            {
                MapWrapper mapWrapper = new MapWrapper();
                List<Map> maps = config.Maps.maps.FindAll(m => m.CTL == cfgcontrolName);
                maps = maps.FindAll(m1 => !string.IsNullOrEmpty(m1.CTL_PROP) && m1.CTL_PROP != GetDefCtlPropName());

                foreach (Map map in maps)
                {
                    mapWrapper.ObjPropertyInfo = type.GetProperty(map.PROP);
                    if (!string.IsNullOrEmpty(map.Converter))
                    {
                        mapWrapper.MapConverter = (BaseConverter)
                            Activator.CreateInstance(System.Type.GetType(map.Converter));
                    }
                    else
                    {
                        mapWrapper.MapConverter = otherdefConverters[map.CTL_PROP];
                    }
                    mapAciton(mapWrapper);
                }
            }
        }
    }
}