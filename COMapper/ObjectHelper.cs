using System;
using COMapper.Entity;

namespace COMapper
{
    public static class ObjectHelper
    {
      
        public static void SetPropertiesByControl(IEnumPanel panelControl, object obj, BindConfig config = null)
        {
            Type type = obj.GetType();
            if (panelControl.HasChildren)
            {
                panelControl.EnumAllChildrens(c =>
                {

                    foreach (BaseSupport baseSupport in COGlobal.Supports)
                    {
                        if (baseSupport.IsAssignControl(c))
                        {
                            string[] ts = baseSupport.GetControlName(c).Split('_');
                            string cfgControlName = ts[ts.Length - 1];
                            baseSupport.Init(c, cfgControlName, config, type, obj);
                            if (!TCSControlHelper.IsIgnore(cfgControlName, config))
                            {
                                baseSupport.OnSetPropertiesByControl();
                            }

                            break;
                        }
                    }
                    

                });
            }
        }


        public static void SetControlByProperties(IEnumPanel panelControl, object obj, BindConfig config = null)
        {
            Type type = obj.GetType();
            if (panelControl.HasChildren)
            {
                panelControl.EnumAllChildrens(c =>
                {

                    foreach (BaseSupport baseSupport in COGlobal.Supports)
                    {
                        if (baseSupport.IsAssignControl(c))
                        {
                            string[] ts = baseSupport.GetControlName(c).Split('_');
                            string cfgControlName = ts[ts.Length - 1];
                            baseSupport.Init(c, cfgControlName, config, type, obj);
                            if (!TCSControlHelper.IsIgnore(cfgControlName, config))
                            {
                                baseSupport.OnSetControlByProperties();
                            }

                            break;
                                
                        }
                    }
                    
                });
            }
        }
    }
}