# COMapper
WINFORM��DEVEXPRESS�ؼ���ʵ�����󶨿��

��.net WPF��ʹ����MVVMģʽ�� ����ʹ�ø������ݰ󶨡�

��.net WINForm �д�ͳ�ķ�ʽ��ʹ�ø�ֵ�ķ�����

                        this.No.Text = item["Xno"] == null ? "" : item["Xno"].ToString();//��Ʒ���
                        this.GoodsEnrolNo.Text = item["GoodsEnrolNo"] == null ? "" : item["GoodsEnrolNo"].ToString();//�������
                        this.GoodsMaterialNo.Text = item["MaterialNo"] == null ? "" : item["MaterialNo"].ToString();//�����Ϻ�
                        this.OriginCode.Text = item["OriginCode"] == null ? "" : item["OriginCode"].ToString();//ԭ����
                        this.DutyMode.Text = item["DutyMode"] == null ? "" : item["DutyMode"].ToString();//����
                        this.HsCode.Text = item["HsCode"] == null ? "" : item["HsCode"].ToString();//��Ʒ���
                        this.GoodsName.Text = item["GoodsName"] == null ? "" : item["GoodsName"].ToString();//��Ʒ����
                        this.Use.Text = item["UseCode"] == null ? "" : item["UseCode"].ToString();//��;
                        this.Model.Text = item["Model"] == null ? "" : item["Model"].ToString();//���
                        this.QuantityUnit.Text = item["QuantityUnit"] == null ? "" : item["QuantityUnit"].ToString().PadLeft(3, '0');//�ɽ���λ
                        this.FirstUnit.Text = item["FirstUnit"] == null ? "" : item["FirstUnit"].ToString().PadLeft(3, '0');//������λ
                        this.SecondUnit.Text = item["SecondUnit"] == null ? "" : item["SecondUnit"].ToString();//�ڶ���λ
                        this.Currency.Text = item["Currency"] == null ? "" : item["Currency"].ToString();//��ֵ
                        this.GoodsVersion.Text = item["GoodsVersion"] == null ? "" : item["GoodsVersion"].ToString();//�汾��
                        this.Note.Text = item["Note"] == null ? "" : item["Note"].ToString();//��ע 
                        this.GoodNature.Text = item["GoodsNature"] == null ? "" : item["GoodsNature"].ToString();//�������� 
                        ID = Convert.ToInt32(item["ID"]);

д�˴����ظ��Ĵ��롣


��Ȼ��Ҳ�����ݰ󶨵Ĺ��� .bindings.add(...) ������ʹ�õ�ʱ��Ƚ��鷳�����˸о��е㹦�ܲ���ȫ��
�����ҿ�����COMapper
DEVEXPRESS֧��
1.��ʼ��=============================================================================
    COGlobal.RegisterConfigPath("EMSinfoHeader", @"COMapper\Configs\template.xml");
    COGlobal.RegisterConfigPath("emsdetail", @"COMapper\Configs\emsdetail.xml");
    COGlobal.Supports = new List<BaseSupport>()
    {
        //new SupCustomGridLookUpEdit(),
        new SupLookUpEdit(),
        new SupTextEdit(new TestConverter())
    };
2.��===============================================================================
   ͬ�� �����ļ��� Panel�еĿؼ�ֵ�Զ���ֵ�����󣬰��տؼ�Name�Ͷ��������Զ���Ӧ

 DevExpressCOMapper.SetControlByProperties(this.PanelMN, item, COGlobal.GetConfig("emsdetail"));
3.��===============================================================================
 �����б������ʱ���Զ��������
 DevExpressCOMapper.SetPropertiesByControl(this.PanelMN, MaterialNumbercurrentItem, COGlobal.GetConfig("emsdetail"));