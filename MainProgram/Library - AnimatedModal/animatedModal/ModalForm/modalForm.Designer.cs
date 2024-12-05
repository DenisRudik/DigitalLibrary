
namespace modal
{
    partial class FrmModalForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModalForm));
            this.TmodalEffect_Timer = new System.Windows.Forms.Timer(this.components);
            this.TLoadAccessProcess_Timer = new System.Windows.Forms.Timer(this.components);
            this.LblTextMessage = new System.Windows.Forms.Label();
            this.LblMsgForUser = new System.Windows.Forms.Label();
            this.RTxtBoxLicenseAgreement = new System.Windows.Forms.RichTextBox();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.BtnOK = new MetroFramework.Controls.MetroButton();
            this.LblLoadProgress = new System.Windows.Forms.Label();
            this.MChckBoxConfirmReadLicenseAgreement = new MetroFramework.Controls.MetroCheckBox();
            this.BtnExitApp = new MetroFramework.Controls.MetroButton();
            this.BtnRestartApp = new MetroFramework.Controls.MetroButton();
            this.ComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.PictLogoForm = new System.Windows.Forms.PictureBox();
            this.PictMainLogo = new System.Windows.Forms.PictureBox();
            this.PictBackgroundGif = new System.Windows.Forms.PictureBox();
            this.BtnBuySub = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictLogoForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMainLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBackgroundGif)).BeginInit();
            this.SuspendLayout();
            // 
            // TmodalEffect_Timer
            // 
            this.TmodalEffect_Timer.Enabled = true;
            this.TmodalEffect_Timer.Interval = 1;
            this.TmodalEffect_Timer.Tick += new System.EventHandler(this.modalEffect_Timer_Tick);
            // 
            // TLoadAccessProcess_Timer
            // 
            this.TLoadAccessProcess_Timer.Interval = 1;
            this.TLoadAccessProcess_Timer.Tick += new System.EventHandler(this.loadAccessProcess_Timer_Tick);
            // 
            // LblTextMessage
            // 
            this.LblTextMessage.AutoEllipsis = true;
            this.LblTextMessage.AutoSize = true;
            this.LblTextMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTextMessage.ForeColor = System.Drawing.Color.White;
            this.LblTextMessage.Location = new System.Drawing.Point(12, 70);
            this.LblTextMessage.Name = "LblTextMessage";
            this.LblTextMessage.Size = new System.Drawing.Size(127, 20);
            this.LblTextMessage.TabIndex = 16;
            this.LblTextMessage.Text = "lbl_text_message";
            // 
            // LblMsgForUser
            // 
            this.LblMsgForUser.AutoSize = true;
            this.LblMsgForUser.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsgForUser.ForeColor = System.Drawing.Color.White;
            this.LblMsgForUser.Location = new System.Drawing.Point(12, 20);
            this.LblMsgForUser.Name = "LblMsgForUser";
            this.LblMsgForUser.Size = new System.Drawing.Size(185, 37);
            this.LblMsgForUser.TabIndex = 15;
            this.LblMsgForUser.Text = "msg_for_user";
            // 
            // RTxtBoxLicenseAgreement
            // 
            this.RTxtBoxLicenseAgreement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.RTxtBoxLicenseAgreement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RTxtBoxLicenseAgreement.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RTxtBoxLicenseAgreement.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.RTxtBoxLicenseAgreement.Location = new System.Drawing.Point(-2, 94);
            this.RTxtBoxLicenseAgreement.Name = "RTxtBoxLicenseAgreement";
            this.RTxtBoxLicenseAgreement.ReadOnly = true;
            this.RTxtBoxLicenseAgreement.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.RTxtBoxLicenseAgreement.Size = new System.Drawing.Size(704, 238);
            this.RTxtBoxLicenseAgreement.TabIndex = 18;
            this.RTxtBoxLicenseAgreement.Text = resources.GetString("RTxtBoxLicenseAgreement.Text");
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(-2, 374);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 19;
            this.BtnCancel.Text = "Отмена";
            this.BtnCancel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(617, 372);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 20;
            this.BtnOK.Text = "OK";
            this.BtnOK.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // LblLoadProgress
            // 
            this.LblLoadProgress.AutoSize = true;
            this.LblLoadProgress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblLoadProgress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblLoadProgress.Location = new System.Drawing.Point(450, 372);
            this.LblLoadProgress.Name = "LblLoadProgress";
            this.LblLoadProgress.Size = new System.Drawing.Size(161, 25);
            this.LblLoadProgress.TabIndex = 21;
            this.LblLoadProgress.Text = "LblLoadProgress";
            this.LblLoadProgress.Visible = false;
            // 
            // MChckBoxConfirmReadLicenseAgreement
            // 
            this.MChckBoxConfirmReadLicenseAgreement.AutoSize = true;
            this.MChckBoxConfirmReadLicenseAgreement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(42)))));
            this.MChckBoxConfirmReadLicenseAgreement.Checked = true;
            this.MChckBoxConfirmReadLicenseAgreement.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MChckBoxConfirmReadLicenseAgreement.CustomBackground = true;
            this.MChckBoxConfirmReadLicenseAgreement.CustomForeColor = true;
            this.MChckBoxConfirmReadLicenseAgreement.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.MChckBoxConfirmReadLicenseAgreement.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.MChckBoxConfirmReadLicenseAgreement.ForeColor = System.Drawing.Color.White;
            this.MChckBoxConfirmReadLicenseAgreement.Location = new System.Drawing.Point(0, 349);
            this.MChckBoxConfirmReadLicenseAgreement.Name = "MChckBoxConfirmReadLicenseAgreement";
            this.MChckBoxConfirmReadLicenseAgreement.Size = new System.Drawing.Size(656, 19);
            this.MChckBoxConfirmReadLicenseAgreement.TabIndex = 23;
            this.MChckBoxConfirmReadLicenseAgreement.Text = "Я прочитал(а) лицензионное соглашение и согласен(а) с предоставленными условиями:" +
    " ";
            this.MChckBoxConfirmReadLicenseAgreement.UseVisualStyleBackColor = false;
            this.MChckBoxConfirmReadLicenseAgreement.CheckedChanged += new System.EventHandler(this.MChckBoxConfirmReadLicenseAgreement_CheckedChanged);
            this.MChckBoxConfirmReadLicenseAgreement.MouseEnter += new System.EventHandler(this.MChckBoxConfirmReadLicenseAgreement_MouseEnter);
            this.MChckBoxConfirmReadLicenseAgreement.MouseLeave += new System.EventHandler(this.MChckBoxConfirmReadLicenseAgreement_MouseLeave);
            // 
            // BtnExitApp
            // 
            this.BtnExitApp.Location = new System.Drawing.Point(617, 372);
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.Size = new System.Drawing.Size(75, 23);
            this.BtnExitApp.TabIndex = 25;
            this.BtnExitApp.Text = "ExitApp";
            this.BtnExitApp.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            // 
            // BtnRestartApp
            // 
            this.BtnRestartApp.Location = new System.Drawing.Point(617, 372);
            this.BtnRestartApp.Name = "BtnRestartApp";
            this.BtnRestartApp.Size = new System.Drawing.Size(75, 23);
            this.BtnRestartApp.TabIndex = 26;
            this.BtnRestartApp.Text = "RestartApp";
            this.BtnRestartApp.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnRestartApp.Click += new System.EventHandler(this.BtnRestartApp_Click);
            // 
            // ComponentTile
            // 
            this.ComponentTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.ComponentTile.CustomBackground = true;
            this.ComponentTile.CustomForeColor = true;
            this.ComponentTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComponentTile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ComponentTile.Location = new System.Drawing.Point(0, 0);
            this.ComponentTile.Name = "ComponentTile";
            this.ComponentTile.Size = new System.Drawing.Size(695, 23);
            this.ComponentTile.TabIndex = 27;
            this.ComponentTile.Text = "Цифровая настольная библиотека";
            this.ComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(14)))), ((int)(((byte)(69)))));
            this.LowerComponentTile.CustomBackground = true;
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LowerComponentTile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LowerComponentTile.Location = new System.Drawing.Point(0, 394);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(695, 23);
            this.LowerComponentTile.TabIndex = 28;
            this.LowerComponentTile.Text = "Окно уведомления";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // PictLogoForm
            // 
            this.PictLogoForm.BackColor = System.Drawing.Color.Transparent;
            this.PictLogoForm.Location = new System.Drawing.Point(647, 20);
            this.PictLogoForm.Name = "PictLogoForm";
            this.PictLogoForm.Size = new System.Drawing.Size(48, 48);
            this.PictLogoForm.TabIndex = 24;
            this.PictLogoForm.TabStop = false;
            // 
            // PictMainLogo
            // 
            this.PictMainLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictMainLogo.Location = new System.Drawing.Point(230, 112);
            this.PictMainLogo.Name = "PictMainLogo";
            this.PictMainLogo.Size = new System.Drawing.Size(256, 256);
            this.PictMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictMainLogo.TabIndex = 22;
            this.PictMainLogo.TabStop = false;
            // 
            // PictBackgroundGif
            // 
            this.PictBackgroundGif.BackColor = System.Drawing.Color.Transparent;
            this.PictBackgroundGif.Image = ((System.Drawing.Image)(resources.GetObject("PictBackgroundGif.Image")));
            this.PictBackgroundGif.Location = new System.Drawing.Point(-2, 0);
            this.PictBackgroundGif.Name = "PictBackgroundGif";
            this.PictBackgroundGif.Size = new System.Drawing.Size(704, 425);
            this.PictBackgroundGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictBackgroundGif.TabIndex = 14;
            this.PictBackgroundGif.TabStop = false;
            // 
            // BtnBuySub
            // 
            this.BtnBuySub.Location = new System.Drawing.Point(617, 372);
            this.BtnBuySub.Name = "BtnBuySub";
            this.BtnBuySub.Size = new System.Drawing.Size(75, 23);
            this.BtnBuySub.TabIndex = 29;
            this.BtnBuySub.Text = "Оформить";
            this.BtnBuySub.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnBuySub.Click += new System.EventHandler(this.BtnBuySub_Click);
            // 
            // FrmModalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(695, 417);
            this.Controls.Add(this.BtnBuySub);
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.ComponentTile);
            this.Controls.Add(this.BtnRestartApp);
            this.Controls.Add(this.BtnExitApp);
            this.Controls.Add(this.PictLogoForm);
            this.Controls.Add(this.MChckBoxConfirmReadLicenseAgreement);
            this.Controls.Add(this.PictMainLogo);
            this.Controls.Add(this.LblLoadProgress);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.RTxtBoxLicenseAgreement);
            this.Controls.Add(this.LblTextMessage);
            this.Controls.Add(this.LblMsgForUser);
            this.Controls.Add(this.PictBackgroundGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmModalForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Цифровая настольная библиотека";
            this.Activated += new System.EventHandler(this.FrmModalForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmModalForm_FormClosed);
            this.Load += new System.EventHandler(this.modalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictLogoForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMainLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictBackgroundGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TmodalEffect_Timer;
        private System.Windows.Forms.Timer TLoadAccessProcess_Timer;
        private System.Windows.Forms.PictureBox PictBackgroundGif;
        private System.Windows.Forms.Label LblTextMessage;
        private System.Windows.Forms.Label LblMsgForUser;
        private System.Windows.Forms.RichTextBox RTxtBoxLicenseAgreement;
        private MetroFramework.Controls.MetroButton BtnCancel;
        private MetroFramework.Controls.MetroButton BtnOK;
        private System.Windows.Forms.Label LblLoadProgress;
        private System.Windows.Forms.PictureBox PictMainLogo;
        private MetroFramework.Controls.MetroCheckBox MChckBoxConfirmReadLicenseAgreement;
        private System.Windows.Forms.PictureBox PictLogoForm;
        private MetroFramework.Controls.MetroButton BtnExitApp;
        private MetroFramework.Controls.MetroButton BtnRestartApp;
        private MetroFramework.Controls.MetroTile ComponentTile;
        private MetroFramework.Controls.MetroTile LowerComponentTile;
        private MetroFramework.Controls.MetroButton BtnBuySub;
    }
}