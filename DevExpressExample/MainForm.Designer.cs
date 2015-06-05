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
            ((System.ComponentModel.ISupportInitialize)(this.UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc)).BeginInit();
            this.pc.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(24, 30);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(100, 20);
            this.UserName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(102, 218);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pc
            // 
            this.pc.Controls.Add(this.UserName);
            this.pc.Location = new System.Drawing.Point(209, 81);
            this.pc.Name = "pc";
            this.pc.Size = new System.Drawing.Size(391, 268);
            this.pc.TabIndex = 2;
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UserName;
        private System.Windows.Forms.Button btnSave;
        private DevExpress.XtraEditors.PanelControl pc;
    }
}