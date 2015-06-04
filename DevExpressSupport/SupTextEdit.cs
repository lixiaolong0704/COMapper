using COMapper.Converters;
using DevExpress.XtraEditors;
using DevExpressSupport.Converters;

namespace DevExpressSupport
{
    public class SupTextEdit : BaseSupport
    {
      

        public override BaseConverter GetDefConverter()
        {
            return new TextEditDefaultConverter();
        }

        public override bool IsAssignControl(object c)
        {
            return c is TextEdit;
        }

    
    }
}