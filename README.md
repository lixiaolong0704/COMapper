# COMapper
WINFORM和DEVEXPRESS控件和实体对象绑定框架

在.net WPF中使用了MVVM模式， 并且使用各种数据绑定。

在.net WINForm 中传统的方式是使用赋值的方法：

                        this.No.Text = item["Xno"] == null ? "" : item["Xno"].ToString();//商品序号
                        this.GoodsEnrolNo.Text = item["GoodsEnrolNo"] == null ? "" : item["GoodsEnrolNo"].ToString();//备案序号
                        this.GoodsMaterialNo.Text = item["MaterialNo"] == null ? "" : item["MaterialNo"].ToString();//备案料号
                        this.OriginCode.Text = item["OriginCode"] == null ? "" : item["OriginCode"].ToString();//原产地
                        this.DutyMode.Text = item["DutyMode"] == null ? "" : item["DutyMode"].ToString();//征免
                        this.HsCode.Text = item["HsCode"] == null ? "" : item["HsCode"].ToString();//商品序号
                        this.GoodsName.Text = item["GoodsName"] == null ? "" : item["GoodsName"].ToString();//商品名称
                        this.Use.Text = item["UseCode"] == null ? "" : item["UseCode"].ToString();//用途
                        this.Model.Text = item["Model"] == null ? "" : item["Model"].ToString();//规格
                        this.QuantityUnit.Text = item["QuantityUnit"] == null ? "" : item["QuantityUnit"].ToString().PadLeft(3, '0');//成交单位
                        this.FirstUnit.Text = item["FirstUnit"] == null ? "" : item["FirstUnit"].ToString().PadLeft(3, '0');//法定单位
                        this.SecondUnit.Text = item["SecondUnit"] == null ? "" : item["SecondUnit"].ToString();//第二单位
                        this.Currency.Text = item["Currency"] == null ? "" : item["Currency"].ToString();//币值
                        this.GoodsVersion.Text = item["GoodsVersion"] == null ? "" : item["GoodsVersion"].ToString();//版本号
                        this.Note.Text = item["Note"] == null ? "" : item["Note"].ToString();//备注 
                        this.GoodNature.Text = item["GoodsNature"] == null ? "" : item["GoodsNature"].ToString();//材料性质 
                        ID = Convert.ToInt32(item["ID"]);

写了大量重复的代码。


当然中也有数据绑定的功能 .bindings.add(...) 但是在使用的时候比较麻烦，个人感觉有点功能不完全。
所以我开发了COMapper
DEVEXPRESS支持
1.初始化=============================================================================
    COGlobal.RegisterConfigPath("EMSinfoHeader", @"COMapper\Configs\template.xml");
    COGlobal.RegisterConfigPath("emsdetail", @"COMapper\Configs\emsdetail.xml");
    COGlobal.Supports = new List<BaseSupport>()
    {
        //new SupCustomGridLookUpEdit(),
        new SupLookUpEdit(),
        new SupTextEdit(new TestConverter())
    };
2.绑定===============================================================================
   同过 配置文件将 Panel中的控件值自动赋值给对象，按照控件Name和对象名字自动对应

 DevExpressCOMapper.SetControlByProperties(this.PanelMN, item, COGlobal.GetConfig("emsdetail"));
3.绑定===============================================================================
 当进行保存操作时候，自动反射回来
 DevExpressCOMapper.SetPropertiesByControl(this.PanelMN, MaterialNumbercurrentItem, COGlobal.GetConfig("emsdetail"));