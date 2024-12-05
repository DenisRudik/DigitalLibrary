namespace online_library_for_educ_inst
{
    partial class FmPasswordRecoveryAssistantForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmPasswordRecoveryAssistantForm));
            this.TxtRecordBook = new MetroFramework.Controls.MetroTextBox();
            this.PictTxtRecordBook = new System.Windows.Forms.PictureBox();
            this.PictRecoveryCode = new System.Windows.Forms.PictureBox();
            this.TxtRecoveryCode = new MetroFramework.Controls.MetroTextBox();
            this.BtnToFindPass = new MetroFramework.Controls.MetroButton();
            this.ComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.PictTopLogo = new System.Windows.Forms.PictureBox();
            this.LblCloseRecoveryForm = new System.Windows.Forms.Label();
            this.ToolTipHelpUser = new MetroFramework.Components.MetroToolTip();
            this.PictEyeRecoveryCodeShow = new System.Windows.Forms.PictureBox();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtRecordBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictRecoveryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTopLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEyeRecoveryCodeShow)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRecordBook
            // 
            this.TxtRecordBook.CustomForeColor = true;
            this.TxtRecordBook.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRecordBook.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtRecordBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(157)))), ((int)(((byte)(123)))));
            this.TxtRecordBook.Location = new System.Drawing.Point(70, 86);
            this.TxtRecordBook.MaxLength = 7;
            this.TxtRecordBook.Name = "TxtRecordBook";
            this.TxtRecordBook.PromptText = "№ Зачётки...";
            this.TxtRecordBook.Size = new System.Drawing.Size(250, 25);
            this.TxtRecordBook.TabIndex = 1;
            this.TxtRecordBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtRecordBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUserNumberDocument_KeyPress);
            // 
            // PictTxtRecordBook
            // 
            this.PictTxtRecordBook.BackColor = System.Drawing.Color.Transparent;
            this.PictTxtRecordBook.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegRecordBookCursored;
            this.PictTxtRecordBook.Location = new System.Drawing.Point(0, 60);
            this.PictTxtRecordBook.Name = "PictTxtRecordBook";
            this.PictTxtRecordBook.Size = new System.Drawing.Size(64, 64);
            this.PictTxtRecordBook.TabIndex = 6;
            this.PictTxtRecordBook.TabStop = false;
            this.PictTxtRecordBook.MouseEnter += new System.EventHandler(this.PictTxtRecordBook_MouseEnter);
            this.PictTxtRecordBook.MouseLeave += new System.EventHandler(this.PictTxtRecordBook_MouseLeave);
            // 
            // PictRecoveryCode
            // 
            this.PictRecoveryCode.BackColor = System.Drawing.Color.Transparent;
            this.PictRecoveryCode.BackgroundImage = global::online_library_for_educ_inst.Properties.Resources.PictRegSecretPassCursored;
            this.PictRecoveryCode.Location = new System.Drawing.Point(0, 130);
            this.PictRecoveryCode.Name = "PictRecoveryCode";
            this.PictRecoveryCode.Size = new System.Drawing.Size(64, 64);
            this.PictRecoveryCode.TabIndex = 7;
            this.PictRecoveryCode.TabStop = false;
            this.PictRecoveryCode.MouseEnter += new System.EventHandler(this.PictRecoveryCode_MouseEnter);
            this.PictRecoveryCode.MouseLeave += new System.EventHandler(this.PictRecoveryCode_MouseLeave);
            // 
            // TxtRecoveryCode
            // 
            this.TxtRecoveryCode.CustomForeColor = true;
            this.TxtRecoveryCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRecoveryCode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtRecoveryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(157)))), ((int)(((byte)(123)))));
            this.TxtRecoveryCode.Location = new System.Drawing.Point(70, 152);
            this.TxtRecoveryCode.Name = "TxtRecoveryCode";
            this.TxtRecoveryCode.PasswordChar = '*';
            this.TxtRecoveryCode.PromptText = "секретный пароль...";
            this.TxtRecoveryCode.Size = new System.Drawing.Size(250, 25);
            this.TxtRecoveryCode.TabIndex = 2;
            this.TxtRecoveryCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // BtnToFindPass
            // 
            this.BtnToFindPass.Location = new System.Drawing.Point(216, 183);
            this.BtnToFindPass.Name = "BtnToFindPass";
            this.BtnToFindPass.Size = new System.Drawing.Size(104, 23);
            this.BtnToFindPass.TabIndex = 3;
            this.BtnToFindPass.Text = "Найти аккаунт...";
            this.BtnToFindPass.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnToFindPass.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // ComponentTile
            // 
            this.ComponentTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(157)))), ((int)(((byte)(123)))));
            this.ComponentTile.CustomBackground = true;
            this.ComponentTile.CustomForeColor = true;
            this.ComponentTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.ComponentTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(43)))), ((int)(((byte)(244)))));
            this.ComponentTile.Location = new System.Drawing.Point(0, 0);
            this.ComponentTile.Name = "ComponentTile";
            this.ComponentTile.Size = new System.Drawing.Size(397, 23);
            this.ComponentTile.TabIndex = 36;
            this.ComponentTile.Text = "Цифровая настольная библиотека";
            this.ComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.ComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(243)))));
            this.LowerComponentTile.CustomBackground = true;
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LowerComponentTile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(213)))), ((int)(((byte)(246)))));
            this.LowerComponentTile.Location = new System.Drawing.Point(0, 236);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(397, 23);
            this.LowerComponentTile.TabIndex = 37;
            this.LowerComponentTile.Text = "Мастер восстановления аккаунтов";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LowerComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // PictTopLogo
            // 
            this.PictTopLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictTopLogo.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegSecretPassCursored;
            this.PictTopLogo.Location = new System.Drawing.Point(333, 29);
            this.PictTopLogo.Name = "PictTopLogo";
            this.PictTopLogo.Size = new System.Drawing.Size(64, 64);
            this.PictTopLogo.TabIndex = 38;
            this.PictTopLogo.TabStop = false;
            // 
            // LblCloseRecoveryForm
            // 
            this.LblCloseRecoveryForm.AutoSize = true;
            this.LblCloseRecoveryForm.BackColor = System.Drawing.Color.Transparent;
            this.LblCloseRecoveryForm.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblCloseRecoveryForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(255)))), ((int)(((byte)(48)))));
            this.LblCloseRecoveryForm.Location = new System.Drawing.Point(67, 216);
            this.LblCloseRecoveryForm.Name = "LblCloseRecoveryForm";
            this.LblCloseRecoveryForm.Size = new System.Drawing.Size(331, 17);
            this.LblCloseRecoveryForm.TabIndex = 39;
            this.LblCloseRecoveryForm.Text = "закрыть мастер восстановления аккаунтов...";
            this.LblCloseRecoveryForm.Click += new System.EventHandler(this.LblCloseRecoveryForm_Click);
            this.LblCloseRecoveryForm.MouseEnter += new System.EventHandler(this.LblCloseRecoveryForm_MouseEnter);
            this.LblCloseRecoveryForm.MouseLeave += new System.EventHandler(this.LblCloseRecoveryForm_MouseLeave);
            // 
            // PictEyeRecoveryCodeShow
            // 
            this.PictEyeRecoveryCodeShow.BackColor = System.Drawing.Color.Transparent;
            this.PictEyeRecoveryCodeShow.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegShowPass;
            this.PictEyeRecoveryCodeShow.Location = new System.Drawing.Point(333, 130);
            this.PictEyeRecoveryCodeShow.Name = "PictEyeRecoveryCodeShow";
            this.PictEyeRecoveryCodeShow.Size = new System.Drawing.Size(64, 64);
            this.PictEyeRecoveryCodeShow.TabIndex = 40;
            this.PictEyeRecoveryCodeShow.TabStop = false;
            this.PictEyeRecoveryCodeShow.MouseEnter += new System.EventHandler(this.PictEyeRecoveryCodeShow_MouseEnter);
            this.PictEyeRecoveryCodeShow.MouseLeave += new System.EventHandler(this.PictEyeRecoveryCodeShow_MouseLeave);
            // 
            // TimerToAnimationForm
            // 
            this.TimerToAnimationForm.Enabled = true;
            this.TimerToAnimationForm.Interval = 1;
            this.TimerToAnimationForm.Tick += new System.EventHandler(this.TimerToAnimationForm_Tick);
            // 
            // PasswordRecoveryAssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::online_library_for_educ_inst.Properties.Resources.BackGroundPasswrodRecoveryAssistent;
            this.ClientSize = new System.Drawing.Size(397, 259);
            this.Controls.Add(this.PictEyeRecoveryCodeShow);
            this.Controls.Add(this.LblCloseRecoveryForm);
            this.Controls.Add(this.PictTopLogo);
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.ComponentTile);
            this.Controls.Add(this.BtnToFindPass);
            this.Controls.Add(this.TxtRecoveryCode);
            this.Controls.Add(this.PictRecoveryCode);
            this.Controls.Add(this.PictTxtRecordBook);
            this.Controls.Add(this.TxtRecordBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(397, 259);
            this.MinimumSize = new System.Drawing.Size(397, 259);
            this.Name = "PasswordRecoveryAssistantForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма мастера восстановления пароля";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PasswordRecoveryAssistantForm_FormClosing);
            this.Load += new System.EventHandler(this.PasswordRecoveryAssistantForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtRecordBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictRecoveryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTopLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEyeRecoveryCodeShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroTextBox TxtRecordBook;
        public System.Windows.Forms.PictureBox PictTxtRecordBook;
        public System.Windows.Forms.PictureBox PictRecoveryCode;
        public MetroFramework.Controls.MetroTextBox TxtRecoveryCode;
        public MetroFramework.Controls.MetroButton BtnToFindPass;
        public MetroFramework.Controls.MetroTile ComponentTile;
        public MetroFramework.Controls.MetroTile LowerComponentTile;
        public System.Windows.Forms.PictureBox PictTopLogo;
        public System.Windows.Forms.Label LblCloseRecoveryForm;
        public MetroFramework.Components.MetroToolTip ToolTipHelpUser;
        public System.Windows.Forms.PictureBox PictEyeRecoveryCodeShow;
        public System.Windows.Forms.Timer TimerToAnimationForm;
    }
}