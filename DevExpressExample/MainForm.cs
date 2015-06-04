using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevExpressSupport;

namespace DevExpressExample
{
    public partial class MainForm : DevComponents.DotNetBar.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MainFormModel mModel=new MainFormModel();
            ObjectHelper.SetPropertiesByControl(this.pc, mModel);
            MessageBox.Show(mModel.UserName);
        }
    }
}