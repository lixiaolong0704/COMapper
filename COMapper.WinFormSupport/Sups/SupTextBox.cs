using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMapper.Core;
using COMapper.Core.Converters;
using COMapper.WinFormSupport.Converters;

namespace COMapper.WinFormSupport.Sups
{
    public class SupTextBox : BaseSupport
    {

        public SupTextBox()
        {
            this.DefConverter = new TextEditDefaultConverter();
        }
        public SupTextBox(BaseConverter defConverter)
        {
            this.DefConverter = defConverter;
        }

        public override string GetControlName(object c)
        {
            return (c as TextBox).Name;
        }
        public override bool IsAssignControl(object c)
        {
            return c is TextBox;
        }


    }
}
