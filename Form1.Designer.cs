namespace WindowsFormsApp3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbCitizenship = new ComboBox();
            cmbPurpose = new ComboBox();
            dtpDateOfEntry = new DateTimePicker();
            chkPolicy = new CheckBox();
            btnRegister = new Button();
            btnViewRoadmap = new Button();
            lblCitizenship = new Label();
            lblPurpose = new Label();
            lblDateOfEntry = new Label();
            lblPolicy = new Label();
            chkLongStay = new CheckBox();
            lblLongStay = new Label();
            SuspendLayout();
            // 
            // cmbCitizenship
            // 
            cmbCitizenship.FormattingEnabled = true;
            cmbCitizenship.Location = new Point(124, 28);
            cmbCitizenship.Name = "cmbCitizenship";
            cmbCitizenship.Size = new Size(200, 28);
            cmbCitizenship.TabIndex = 0;
            // 
            // cmbPurpose
            // 
            cmbPurpose.FormattingEnabled = true;
            cmbPurpose.Location = new Point(124, 66);
            cmbPurpose.Name = "cmbPurpose";
            cmbPurpose.Size = new Size(200, 28);
            cmbPurpose.TabIndex = 1;
            // 
            // dtpDateOfEntry
            // 
            dtpDateOfEntry.Location = new Point(124, 104);
            dtpDateOfEntry.Name = "dtpDateOfEntry";
            dtpDateOfEntry.Size = new Size(200, 27);
            dtpDateOfEntry.TabIndex = 2;
            // 
            // chkPolicy
            // 
            chkPolicy.AutoSize = true;
            chkPolicy.Location = new Point(285, 149);
            chkPolicy.Name = "chkPolicy";
            chkPolicy.Size = new Size(18, 17);
            chkPolicy.TabIndex = 3;
            chkPolicy.UseVisualStyleBackColor = true;
            chkPolicy.CheckedChanged += chkPolicy_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(124, 244);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 35);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Регистрация";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnViewRoadmap
            // 
            btnViewRoadmap.Location = new Point(124, 285);
            btnViewRoadmap.Name = "btnViewRoadmap";
            btnViewRoadmap.Size = new Size(140, 31);
            btnViewRoadmap.TabIndex = 5;
            btnViewRoadmap.Text = "Дорожная карта";
            btnViewRoadmap.UseVisualStyleBackColor = true;
            btnViewRoadmap.Click += btnViewRoadmap_Click;
            // 
            // lblCitizenship
            // 
            lblCitizenship.AutoSize = true;
            lblCitizenship.Location = new Point(16, 28);
            lblCitizenship.Name = "lblCitizenship";
            lblCitizenship.Size = new Size(102, 20);
            lblCitizenship.TabIndex = 6;
            lblCitizenship.Text = "Гражданство:";
            // 
            // lblPurpose
            // 
            lblPurpose.AutoSize = true;
            lblPurpose.Location = new Point(16, 66);
            lblPurpose.Name = "lblPurpose";
            lblPurpose.Size = new Size(108, 20);
            lblPurpose.TabIndex = 7;
            lblPurpose.Text = "Цель поездки:";
            // 
            // lblDateOfEntry
            // 
            lblDateOfEntry.AutoSize = true;
            lblDateOfEntry.Location = new Point(12, 104);
            lblDateOfEntry.Name = "lblDateOfEntry";
            lblDateOfEntry.Size = new Size(96, 20);
            lblDateOfEntry.TabIndex = 8;
            lblDateOfEntry.Text = "Дата въезда:";
            // 
            // lblPolicy
            // 
            lblPolicy.AutoSize = true;
            lblPolicy.Location = new Point(12, 146);
            lblPolicy.Name = "lblPolicy";
            lblPolicy.Size = new Size(233, 20);
            lblPolicy.TabIndex = 9;
            lblPolicy.Text = "Отметьте, если у Вас есть полис:";
            // 
            // chkLongStay
            // 
            chkLongStay.AutoSize = true;
            chkLongStay.Location = new Point(285, 196);
            chkLongStay.Name = "chkLongStay";
            chkLongStay.Size = new Size(18, 17);
            chkLongStay.TabIndex = 3;
            chkLongStay.UseVisualStyleBackColor = true;
            chkLongStay.CheckedChanged += chkLongStay_CheckedChanged;
            // 
            // lblLongStay
            // 
            lblLongStay.AutoSize = true;
            lblLongStay.Location = new Point(12, 182);
            lblLongStay.Name = "lblLongStay";
            lblLongStay.Size = new Size(246, 40);
            lblLongStay.TabIndex = 10;
            lblLongStay.Text = "Отметьте, если прибыли на\n длительный срок(более 90 дней):";
            // 
            // Form1
            // 
            ClientSize = new Size(378, 362);
            Controls.Add(lblPolicy);
            Controls.Add(lblLongStay);
            Controls.Add(lblDateOfEntry);
            Controls.Add(lblPurpose);
            Controls.Add(lblCitizenship);
            Controls.Add(btnViewRoadmap);
            Controls.Add(btnRegister);
            Controls.Add(chkPolicy);
            Controls.Add(dtpDateOfEntry);
            Controls.Add(cmbPurpose);
            Controls.Add(cmbCitizenship);
            Controls.Add(chkLongStay);
            Name = "Form1";
            Text = "Регистрация пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cmbCitizenship;
        private System.Windows.Forms.ComboBox cmbPurpose;
        private System.Windows.Forms.DateTimePicker dtpDateOfEntry;
        private System.Windows.Forms.CheckBox chkPolicy;
        private System.Windows.Forms.CheckBox chkLongStay;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnViewRoadmap;
        private System.Windows.Forms.Label lblCitizenship;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblDateOfEntry;
        private System.Windows.Forms.Label lblPolicy;
        private System.Windows.Forms.Label lblLongStay;
    }
}
