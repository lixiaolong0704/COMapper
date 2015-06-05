using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COMapper;
using COMapper.DevExpressSupport;
using COMapper.DevExpressSupport.Sups;
using DevExpress.Utils.Extensions;
using DevExpressExample.COMapper.Converters;

namespace DevExpressExample
{
    public partial class MainForm : DevComponents.DotNetBar.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
            COGlobal.RegisterConfigPath("EMSinfoHeader", @"COMapper\Configs\template.xml");
            COGlobal.RegisterConfigPath("emsdetail", @"COMapper\Configs\emsdetail.xml");
            COGlobal.Supports = new List<BaseSupport>()
            {
                //new SupCustomGridLookUpEdit(),
                new SupLookUpEdit(),
                new SupTextEdit(new TestConverter())
            };
        }
        MainFormModel mModel = new MainFormModel();
        private void btnSave_Click(object sender, EventArgs e)
        {

            DevExpressCOMapper.SetPropertiesByControl(this.pc, mModel);
            MessageBox.Show(mModel.UserName);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }

  
}