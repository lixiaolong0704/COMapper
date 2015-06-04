using System;
using COMapper.Converters;
using COMapper.Entity;
using DevExpressSupport.Converters;

namespace DevExpressSupport
{
    public class SupCustomGridLookUpEdit : BaseSupport
    {
    

        public override void Init(object control,string cfgcontrolName, BindConfig config, Type type, object obj)
        {
            base.Init(control,cfgcontrolName, config, type, obj);
            if (!otherdefConverters.ContainsKey("EditValue"))
            otherdefConverters.Add("EditValue",new CustomGridLookUpEditEditValueConverter());
        }
        public override BaseConverter GetDefConverter()
        {
            return new CustomGridLookUpEditDefaultConverter();
        }

   
        public override bool IsAssignControl(object c)
        {
            //return c is CustomGridLookUpEdit;
            return false;
        }

    }
}