using System;
using COMapper;
using COMapper.Entity;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;

namespace DevExpressSupport
{
    public static class ObjectHelper
    {

      
        public static void SetPropertiesByControl(PanelControl panelControl, object obj, BindConfig config = null)
        {
            Type type = obj.GetType();
            if (panelControl.HasChildren)
            {
                panelControl.EnumAllChildrens(c =>
                {
                    if (BaseSupport.SupportControlTypes.Contains(c.GetType()))
                    {
                        foreach (BaseSupport baseSupport in BaseSupport.Supports)
                        {
                            if (baseSupport.IsAssignControl(c))
                            {
                                string[] ts = c.Name.Split('_');
                                string cfgControlName = ts[ts.Length - 1];
                                baseSupport.Init(c, cfgControlName, config, type, obj);
                                if (!TCSControlHelper.IsIgnore(cfgControlName, config))
                                {
                                    baseSupport.OnSetPropertiesByControl();
                                }

                                break;
                            }
                        }
                    }

                });
            }
        }
        

        public static void SetControlByProperties(PanelControl panelControl, object obj, BindConfig config = null)
        {
            Type type = obj.GetType();
            if (panelControl.HasChildren)
            {
                panelControl.EnumAllChildrens(c =>
                {
                    if (BaseSupport.SupportControlTypes.Contains(c.GetType()))
                    {
                        foreach (BaseSupport baseSupport in BaseSupport.Supports)
                        {
                            if (baseSupport.IsAssignControl(c))
                            {
                                string [] ts = c.Name.Split('_');
                                string cfgControlName = ts[ts.Length - 1];
                                baseSupport.Init(c, cfgControlName, config, type, obj);
                                if (!TCSControlHelper.IsIgnore(cfgControlName, config))
                                {
                                    baseSupport.OnSetControlByProperties();
                                }

                                break;
                                
                            }
                        }
                    }
                });
            }
        }
    }
}