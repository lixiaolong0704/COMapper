using COMapper.Converters;
using DevExpress.XtraEditors;

namespace DevExpressSupport
{
    public class SupLookUpEdit : BaseSupport
    {

        public override BaseConverter GetDefConverter()
        {
            return null;
        }

        public override bool IsAssignControl(object c)
        {
            return c is LookUpEdit;
        }

      
    }
}