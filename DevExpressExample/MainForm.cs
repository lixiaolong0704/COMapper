using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using COMapper.Core;
using COMapper.DevExpressSupport;
using COMapper.DevExpressSupport.Sups;
using DevExpress.Utils.Extensions;
using DevExpress.XtraGrid.Columns;
using DevExpressExample.COMapperEx.Converters;

namespace DevExpressExample
{
    public partial class MainForm : DevComponents.DotNetBar.RibbonForm
    {
      
        public MainForm()
        {
            InitializeComponent();
            COGlobal.RegisterConfigPath("EMSinfoHeader", @"COMapperEx\Configs\template.xml");
            COGlobal.RegisterConfigPath("emsdetail", @"COMapperEx\Configs\emsdetail.xml");


            COGlobal.Supports = new List<BaseSupport>()
            {
                new SupGridLookUpEdit(),
                new SupLookUpEdit(),
                new SupTextEdit()
            };
        }
        MainFormModel mModel = new MainFormModel();
        private void btnSave_Click(object sender, EventArgs e)
        {

            DevExpressCOMapper.SetPropertiesByControl(this.pc, mModel, COGlobal.GetConfig("emsdetail"));
            MessageBox.Show(mModel.UserName);
            MessageBox.Show(mModel.AreaCode+"");
            MessageBox.Show(mModel.AreaName + "");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Area.Properties.ValueMember = "Code";
            Area.Properties.DisplayMember = "Name";
 
            Area.Properties.DataSource = AreaModel.GetAreas();
            Area.Properties.View.Columns.Add(new GridColumn()
            {
                Caption = "Ãû³Æ",
                VisibleIndex = 0,
                FieldName = "Name"
            });
            Area.Properties.View.Columns.Add(new GridColumn()
            {
                Caption = "±àÂë",
                VisibleIndex = 1,
                FieldName = "Code"
            });
            Area.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            Area.Properties.ImmediatePopup = true;
       
         
        }
    }

    public class AreaModel
    {
        public int Code { get; set; }

        public string Name { get; set; }

        public static List<AreaModel> GetAreas()
        {
            List<AreaModel> areas = new List<AreaModel>();

            for (int i = 0; i < 10; i++)
            {
                areas.Add(new AreaModel()
                {
                    Code = i,
                    Name = "Area" + i
                });
            }

            return areas;
        }
    }
}