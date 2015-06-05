namespace DevExpressExample
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserName = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new System.Windows.Forms.Button();
            this.pc = new DevExpress.XtraEditors.PanelControl();
            this.Area = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).BeginInit();
            this.pc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Area.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(101, 32);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 20);
            this.UserName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(209, 355);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pc
            // 
            this.pc.Controls.Add(this.label2);
            this.pc.Controls.Add(this.label1);
            this.pc.Controls.Add(this.Area);
            this.pc.Controls.Add(this.UserName);
            this.pc.Location = new System.Drawing.Point(209, 81);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(391, 268);
            this.pc.TabIndex = 2;
            // 
            // Area
            // 
            this.Area.Location = new System.Drawing.Point(101, 76);
            this.Area.Name = "Area";
            this.Area.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Area.Properties.View = this.gridLookUpEdit1View;
            this.Area.Size = new System.Drawing.Size(177, 20);
            this.Area.TabIndex = 1;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Area";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(704, 440);
            this.Controls.Add(this.pc);
            this.Controls.Add(this.btnSave);
            this.Name = "MainForm";
            this.Text = "RibbonForm1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).EndInit();
            this.pc.ResumeLayout(false);
            this.pc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Area.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UserName;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.PanelControl pc;
        private DevExpress.XtraEditors.GridLookUpEdit Area;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}