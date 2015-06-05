using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using COMapper.Core;
using COMapper.WinFormSupport;
using COMapper.WinFormSupport.Sups;

namespace WinFormExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            COGlobal.RegisterConfigPath("EMSinfoHeader", @"COMapperEx\Configs\template.xml");
            COGlobal.RegisterConfigPath("emsdetail", @"COMapperEx\Configs\emsdetail.xml");


            COGlobal.Supports = new List<BaseSupport>()
            {
                new SupTextBox()
            };
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
        MainFormModel m = new MainFormModel();
        private void btnSave_Click(object sender, EventArgs e)
        {
            WinFormCOMapper.SetPropertiesByControl(this.panel1,m);
            MessageBox.Show(m.UserName);
        }
        public class MainFormModel
        {
            public string UserName { get; set; }
            public string Password { get; set; }

            public int AreaCode { get; set; }

            public string AreaName { get; set; }
        }

    }
}
