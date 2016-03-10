namespace DevExpress.MailClient.Win.Forms
{
    partial class EmailAccountForm
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtEditYourName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditEmailAdd = new DevExpress.XtraEditors.TextEdit();
            this.txtEditIncomingM = new DevExpress.XtraEditors.TextEdit();
            this.txtEditOutgoingM = new DevExpress.XtraEditors.TextEdit();
            this.txtEditUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.chkEditRememberPass = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditYourName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditEmailAdd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditIncomingM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOutgoingM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditRememberPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(162, 365);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(244, 365);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(12, 28);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "User Information";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(56, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Your Name:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 83);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "E-mail Address:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(12, 227);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(109, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Server Information";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 263);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(139, 13);
            this.labelControl5.TabIndex = 5;
            this.labelControl5.Text = "Incoming mail server (POP3):";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 288);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(137, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Outgoing mail server(SMTP):";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl7.Location = new System.Drawing.Point(12, 123);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(105, 13);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "Logon Information";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 156);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(56, 13);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "User Name:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(12, 182);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(50, 13);
            this.labelControl9.TabIndex = 5;
            this.labelControl9.Text = "Password:";
            // 
            // txtEditYourName
            // 
            this.txtEditYourName.Location = new System.Drawing.Point(94, 55);
            this.txtEditYourName.Name = "txtEditYourName";
            this.txtEditYourName.Size = new System.Drawing.Size(174, 20);
            this.txtEditYourName.TabIndex = 0;
            // 
            // txtEditEmailAdd
            // 
            this.txtEditEmailAdd.Location = new System.Drawing.Point(94, 80);
            this.txtEditEmailAdd.Name = "txtEditEmailAdd";
            this.txtEditEmailAdd.Size = new System.Drawing.Size(174, 20);
            this.txtEditEmailAdd.TabIndex = 1;
            // 
            // txtEditIncomingM
            // 
            this.txtEditIncomingM.Location = new System.Drawing.Point(163, 260);
            this.txtEditIncomingM.Name = "txtEditIncomingM";
            this.txtEditIncomingM.Size = new System.Drawing.Size(156, 20);
            this.txtEditIncomingM.TabIndex = 4;
            // 
            // txtEditOutgoingM
            // 
            this.txtEditOutgoingM.Location = new System.Drawing.Point(163, 285);
            this.txtEditOutgoingM.Name = "txtEditOutgoingM";
            this.txtEditOutgoingM.Properties.PasswordChar = '*';
            this.txtEditOutgoingM.Size = new System.Drawing.Size(156, 20);
            this.txtEditOutgoingM.TabIndex = 5;
            // 
            // txtEditUserName
            // 
            this.txtEditUserName.Location = new System.Drawing.Point(94, 153);
            this.txtEditUserName.Name = "txtEditUserName";
            this.txtEditUserName.Size = new System.Drawing.Size(174, 20);
            this.txtEditUserName.TabIndex = 2;
            // 
            // txtEditPassword
            // 
            this.txtEditPassword.Location = new System.Drawing.Point(94, 179);
            this.txtEditPassword.Name = "txtEditPassword";
            this.txtEditPassword.Size = new System.Drawing.Size(174, 20);
            this.txtEditPassword.TabIndex = 3;
            // 
            // chkEditRememberPass
            // 
            this.chkEditRememberPass.Location = new System.Drawing.Point(173, 311);
            this.chkEditRememberPass.Name = "chkEditRememberPass";
            this.chkEditRememberPass.Properties.Caption = "Remember password";
            this.chkEditRememberPass.Size = new System.Drawing.Size(136, 19);
            this.chkEditRememberPass.TabIndex = 7;
            // 
            // EmailAccountForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(331, 400);
            this.Controls.Add(this.chkEditRememberPass);
            this.Controls.Add(this.txtEditPassword);
            this.Controls.Add(this.txtEditUserName);
            this.Controls.Add(this.txtEditOutgoingM);
            this.Controls.Add(this.txtEditIncomingM);
            this.Controls.Add(this.txtEditEmailAdd);
            this.Controls.Add(this.txtEditYourName);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmailAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E-mail Account";
            ((System.ComponentModel.ISupportInitialize)(this.txtEditYourName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditEmailAdd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditIncomingM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditOutgoingM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEditPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkEditRememberPass.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.SimpleButton btnSave;
        private XtraEditors.SimpleButton btnCancel;
        private XtraEditors.LabelControl labelControl1;
        private XtraEditors.LabelControl labelControl2;
        private XtraEditors.LabelControl labelControl3;
        private XtraEditors.LabelControl labelControl4;
        private XtraEditors.LabelControl labelControl5;
        private XtraEditors.LabelControl labelControl6;
        private XtraEditors.LabelControl labelControl7;
        private XtraEditors.LabelControl labelControl8;
        private XtraEditors.LabelControl labelControl9;
        private XtraEditors.TextEdit txtEditYourName;
        private XtraEditors.TextEdit txtEditEmailAdd;
        private XtraEditors.TextEdit txtEditIncomingM;
        private XtraEditors.TextEdit txtEditOutgoingM;
        private XtraEditors.TextEdit txtEditUserName;
        private XtraEditors.TextEdit txtEditPassword;
        private XtraEditors.CheckEdit chkEditRememberPass;
    }
}