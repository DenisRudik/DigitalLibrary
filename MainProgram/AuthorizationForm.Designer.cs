namespace online_library_for_educ_inst
{
    partial class FmAuthorizationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAuthorizationForm));
            this.TxtRecordBook = new MetroFramework.Controls.MetroTextBox();
            this.TxtPass = new MetroFramework.Controls.MetroTextBox();
            this.TxtConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.PictConfirmPass = new System.Windows.Forms.PictureBox();
            this.PictTxtPass = new System.Windows.Forms.PictureBox();
            this.PictTxtRecordBook = new System.Windows.Forms.PictureBox();
            this.BtnAuth = new System.Windows.Forms.Button();
            this.PictTopLogo = new System.Windows.Forms.PictureBox();
            this.LblTopMessage = new System.Windows.Forms.Label();
            this.TopComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.ToolTipHelpUser = new MetroFramework.Components.MetroToolTip();
            this.LblGotoLostAcc = new System.Windows.Forms.Label();
            this.LblGotoReg = new System.Windows.Forms.Label();
            this.LblGotoWelcomeForm = new System.Windows.Forms.Label();
            this.PictEyePassToTxtPass = new System.Windows.Forms.PictureBox();
            this.PictTxtConfirmPass = new System.Windows.Forms.PictureBox();
            this.PictDelTxtRecordBook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtRecordBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTopLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEyePassToTxtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtConfirmPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtRecordBook)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRecordBook
            // 
            this.TxtRecordBook.CustomForeColor = true;
            this.TxtRecordBook.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRecordBook.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtRecordBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(200)))), ((int)(((byte)(95)))));
            this.TxtRecordBook.Location = new System.Drawing.Point(70, 122);
            this.TxtRecordBook.MaxLength = 7;
            this.TxtRecordBook.Name = "TxtRecordBook";
            this.TxtRecordBook.PromptText = "№ Зачётки...";
            this.TxtRecordBook.Size = new System.Drawing.Size(250, 25);
            this.TxtRecordBook.TabIndex = 1;
            this.TxtRecordBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtRecordBook.TextChanged += new System.EventHandler(this.TxtRecordBook_TextChanged);
            this.TxtRecordBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecordBook_KeyPress);
            // 
            // TxtPass
            // 
            this.TxtPass.CustomForeColor = true;
            this.TxtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(200)))), ((int)(((byte)(95)))));
            this.TxtPass.Location = new System.Drawing.Point(70, 194);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PromptText = "пароль...";
            this.TxtPass.Size = new System.Drawing.Size(250, 25);
            this.TxtPass.TabIndex = 2;
            this.TxtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // TxtConfirmPass
            // 
            this.TxtConfirmPass.CustomForeColor = true;
            this.TxtConfirmPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtConfirmPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtConfirmPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(200)))), ((int)(((byte)(95)))));
            this.TxtConfirmPass.Location = new System.Drawing.Point(70, 274);
            this.TxtConfirmPass.Name = "TxtConfirmPass";
            this.TxtConfirmPass.PromptText = "подтвердите пароль...";
            this.TxtConfirmPass.Size = new System.Drawing.Size(250, 25);
            this.TxtConfirmPass.TabIndex = 3;
            this.TxtConfirmPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtConfirmPass.TextChanged += new System.EventHandler(this.TxtConfirmPass_TextChanged);
            this.TxtConfirmPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConfirmPass_KeyPress);
            // 
            // TimerToAnimationForm
            // 
            this.TimerToAnimationForm.Enabled = true;
            this.TimerToAnimationForm.Interval = 1;
            this.TimerToAnimationForm.Tick += new System.EventHandler(this.TimerToAnimationForm_Tick);
            // 
            // PictConfirmPass
            // 
            this.PictConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.PictConfirmPass.BackgroundImage = global::online_library_for_educ_inst.Properties.Resources.PictRegPassCursored;
            this.PictConfirmPass.Location = new System.Drawing.Point(0, 252);
            this.PictConfirmPass.Name = "PictConfirmPass";
            this.PictConfirmPass.Size = new System.Drawing.Size(64, 64);
            this.PictConfirmPass.TabIndex = 31;
            this.PictConfirmPass.TabStop = false;
            this.PictConfirmPass.MouseEnter += new System.EventHandler(this.PictConfirmPass_MouseEnter);
            this.PictConfirmPass.MouseLeave += new System.EventHandler(this.PictConfirmPass_MouseLeave);
            // 
            // PictTxtPass
            // 
            this.PictTxtPass.BackColor = System.Drawing.Color.Transparent;
            this.PictTxtPass.BackgroundImage = global::online_library_for_educ_inst.Properties.Resources.PictRegPassCursored;
            this.PictTxtPass.Location = new System.Drawing.Point(0, 173);
            this.PictTxtPass.Name = "PictTxtPass";
            this.PictTxtPass.Size = new System.Drawing.Size(64, 64);
            this.PictTxtPass.TabIndex = 6;
            this.PictTxtPass.TabStop = false;
            this.PictTxtPass.MouseEnter += new System.EventHandler(this.PictTxtPass_MouseEnter);
            this.PictTxtPass.MouseLeave += new System.EventHandler(this.PictTxtPass_MouseLeave);
            // 
            // PictTxtRecordBook
            // 
            this.PictTxtRecordBook.BackColor = System.Drawing.Color.Transparent;
            this.PictTxtRecordBook.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegRecordBookCursored;
            this.PictTxtRecordBook.Location = new System.Drawing.Point(0, 97);
            this.PictTxtRecordBook.Name = "PictTxtRecordBook";
            this.PictTxtRecordBook.Size = new System.Drawing.Size(64, 64);
            this.PictTxtRecordBook.TabIndex = 5;
            this.PictTxtRecordBook.TabStop = false;
            this.PictTxtRecordBook.MouseEnter += new System.EventHandler(this.PictTxtRecordBook_MouseEnter);
            this.PictTxtRecordBook.MouseLeave += new System.EventHandler(this.PictTxtRecordBook_MouseLeave);
            // 
            // BtnAuth
            // 
            this.BtnAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(211)))));
            this.BtnAuth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAuth.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnAuth.ForeColor = System.Drawing.Color.White;
            this.BtnAuth.Location = new System.Drawing.Point(152, 341);
            this.BtnAuth.Name = "BtnAuth";
            this.BtnAuth.Size = new System.Drawing.Size(383, 38);
            this.BtnAuth.TabIndex = 4;
            this.BtnAuth.Text = "Войти...";
            this.BtnAuth.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnAuth.UseVisualStyleBackColor = false;
            this.BtnAuth.Click += new System.EventHandler(this.BtnAuthorization_Click);
            this.BtnAuth.Enter += new System.EventHandler(this.BtnAuth_Enter);
            this.BtnAuth.Leave += new System.EventHandler(this.BtnAuthorization_Leave);
            // 
            // PictTopLogo
            // 
            this.PictTopLogo.BackColor = System.Drawing.Color.Black;
            this.PictTopLogo.Image = global::online_library_for_educ_inst.Properties.Resources.IconCursorAuth;
            this.PictTopLogo.Location = new System.Drawing.Point(570, 17);
            this.PictTopLogo.Name = "PictTopLogo";
            this.PictTopLogo.Size = new System.Drawing.Size(128, 128);
            this.PictTopLogo.TabIndex = 1;
            this.PictTopLogo.TabStop = false;
            // 
            // LblTopMessage
            // 
            this.LblTopMessage.AutoSize = true;
            this.LblTopMessage.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold);
            this.LblTopMessage.ForeColor = System.Drawing.Color.White;
            this.LblTopMessage.Location = new System.Drawing.Point(0, 26);
            this.LblTopMessage.Name = "LblTopMessage";
            this.LblTopMessage.Size = new System.Drawing.Size(310, 50);
            this.LblTopMessage.TabIndex = 35;
            this.LblTopMessage.Text = "Авторизация...";
            // 
            // TopComponentTile
            // 
            this.TopComponentTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(200)))), ((int)(((byte)(95)))));
            this.TopComponentTile.CustomBackground = true;
            this.TopComponentTile.CustomForeColor = true;
            this.TopComponentTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopComponentTile.ForeColor = System.Drawing.Color.Black;
            this.TopComponentTile.Location = new System.Drawing.Point(0, 0);
            this.TopComponentTile.Name = "TopComponentTile";
            this.TopComponentTile.Size = new System.Drawing.Size(698, 23);
            this.TopComponentTile.TabIndex = 36;
            this.TopComponentTile.Text = "Цифровая настольная библиотека";
            this.TopComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TopComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(200)))), ((int)(((byte)(95)))));
            this.LowerComponentTile.CustomBackground = true;
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LowerComponentTile.ForeColor = System.Drawing.Color.Black;
            this.LowerComponentTile.Location = new System.Drawing.Point(0, 404);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(698, 23);
            this.LowerComponentTile.TabIndex = 37;
            this.LowerComponentTile.Text = "Форма авторизации";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // LblGotoLostAcc
            // 
            this.LblGotoLostAcc.AutoSize = true;
            this.LblGotoLostAcc.BackColor = System.Drawing.Color.Transparent;
            this.LblGotoLostAcc.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGotoLostAcc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(129)))));
            this.LblGotoLostAcc.Location = new System.Drawing.Point(384, 304);
            this.LblGotoLostAcc.Name = "LblGotoLostAcc";
            this.LblGotoLostAcc.Size = new System.Drawing.Size(159, 21);
            this.LblGotoLostAcc.TabIndex = 5;
            this.LblGotoLostAcc.Text = "Забыли пароль...?";
            this.LblGotoLostAcc.Click += new System.EventHandler(this.LblGotoLostAcc_Click);
            this.LblGotoLostAcc.MouseEnter += new System.EventHandler(this.LblGotoLostAcc_MouseEnter);
            this.LblGotoLostAcc.MouseLeave += new System.EventHandler(this.LblGotoLostAcc_MouseLeave);
            // 
            // LblGotoReg
            // 
            this.LblGotoReg.AutoSize = true;
            this.LblGotoReg.BackColor = System.Drawing.Color.Transparent;
            this.LblGotoReg.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.LblGotoReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(129)))));
            this.LblGotoReg.Location = new System.Drawing.Point(3, 382);
            this.LblGotoReg.Name = "LblGotoReg";
            this.LblGotoReg.Size = new System.Drawing.Size(190, 21);
            this.LblGotoReg.TabIndex = 6;
            this.LblGotoReg.Text = "Зарегистрироваться...";
            this.LblGotoReg.Click += new System.EventHandler(this.LblGotoReg_Click);
            this.LblGotoReg.MouseEnter += new System.EventHandler(this.LblGotoReg_MouseEnter);
            this.LblGotoReg.MouseLeave += new System.EventHandler(this.LblGotoReg_MouseLeave);
            // 
            // LblGotoWelcomeForm
            // 
            this.LblGotoWelcomeForm.AutoSize = true;
            this.LblGotoWelcomeForm.BackColor = System.Drawing.Color.Transparent;
            this.LblGotoWelcomeForm.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.LblGotoWelcomeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(28)))), ((int)(((byte)(129)))));
            this.LblGotoWelcomeForm.Location = new System.Drawing.Point(500, 382);
            this.LblGotoWelcomeForm.Name = "LblGotoWelcomeForm";
            this.LblGotoWelcomeForm.Size = new System.Drawing.Size(198, 21);
            this.LblGotoWelcomeForm.TabIndex = 7;
            this.LblGotoWelcomeForm.Text = "выйти с авторизации...";
            this.LblGotoWelcomeForm.Click += new System.EventHandler(this.LblGotoWelcomeForm_Click);
            this.LblGotoWelcomeForm.MouseEnter += new System.EventHandler(this.LblGotoWelcomeForm_MouseEnter);
            this.LblGotoWelcomeForm.MouseLeave += new System.EventHandler(this.LblGotoWelcomeForm_MouseLeave);
            // 
            // PictEyePassToTxtPass
            // 
            this.PictEyePassToTxtPass.BackColor = System.Drawing.Color.Transparent;
            this.PictEyePassToTxtPass.Image = global::online_library_for_educ_inst.Properties.Resources.PictAuthShowPass;
            this.PictEyePassToTxtPass.Location = new System.Drawing.Point(314, 173);
            this.PictEyePassToTxtPass.Name = "PictEyePassToTxtPass";
            this.PictEyePassToTxtPass.Size = new System.Drawing.Size(64, 64);
            this.PictEyePassToTxtPass.TabIndex = 41;
            this.PictEyePassToTxtPass.TabStop = false;
            this.PictEyePassToTxtPass.MouseEnter += new System.EventHandler(this.PictEyePassToTxtPass_MouseEnter);
            this.PictEyePassToTxtPass.MouseLeave += new System.EventHandler(this.PictEyePassToTxtPass_MouseLeave);
            // 
            // PictTxtConfirmPass
            // 
            this.PictTxtConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.PictTxtConfirmPass.Image = global::online_library_for_educ_inst.Properties.Resources.PictAuthShowPass;
            this.PictTxtConfirmPass.Location = new System.Drawing.Point(314, 243);
            this.PictTxtConfirmPass.Name = "PictTxtConfirmPass";
            this.PictTxtConfirmPass.Size = new System.Drawing.Size(64, 64);
            this.PictTxtConfirmPass.TabIndex = 42;
            this.PictTxtConfirmPass.TabStop = false;
            this.PictTxtConfirmPass.MouseEnter += new System.EventHandler(this.PictTxtConfirmPass_MouseEnter);
            this.PictTxtConfirmPass.MouseLeave += new System.EventHandler(this.PictTxtConfirmPass_MouseLeave);
            // 
            // PictDelTxtRecordBook
            // 
            this.PictDelTxtRecordBook.BackColor = System.Drawing.Color.Transparent;
            this.PictDelTxtRecordBook.Image = global::online_library_for_educ_inst.Properties.Resources.TrashCanAuth;
            this.PictDelTxtRecordBook.Location = new System.Drawing.Point(314, 113);
            this.PictDelTxtRecordBook.Name = "PictDelTxtRecordBook";
            this.PictDelTxtRecordBook.Size = new System.Drawing.Size(48, 48);
            this.PictDelTxtRecordBook.TabIndex = 43;
            this.PictDelTxtRecordBook.TabStop = false;
            this.PictDelTxtRecordBook.Click += new System.EventHandler(this.PictDelTxtRecordBook_Click);
            this.PictDelTxtRecordBook.MouseEnter += new System.EventHandler(this.PictDelTxtRecordBook_MouseEnter);
            this.PictDelTxtRecordBook.MouseLeave += new System.EventHandler(this.PictDelTxtRecordBook_MouseLeave);
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::online_library_for_educ_inst.Properties.Resources.BackGroundAuthForm;
            this.ClientSize = new System.Drawing.Size(698, 427);
            this.Controls.Add(this.PictDelTxtRecordBook);
            this.Controls.Add(this.PictTxtConfirmPass);
            this.Controls.Add(this.PictEyePassToTxtPass);
            this.Controls.Add(this.LblGotoWelcomeForm);
            this.Controls.Add(this.LblGotoReg);
            this.Controls.Add(this.LblGotoLostAcc);
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.TopComponentTile);
            this.Controls.Add(this.LblTopMessage);
            this.Controls.Add(this.TxtConfirmPass);
            this.Controls.Add(this.PictConfirmPass);
            this.Controls.Add(this.PictTxtPass);
            this.Controls.Add(this.PictTxtRecordBook);
            this.Controls.Add(this.BtnAuth);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtRecordBook);
            this.Controls.Add(this.PictTopLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AuthorizationForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма Авторизации";
            this.Activated += new System.EventHandler(this.Authorization_Form_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Authorization_Form_FormClosing);
            this.Load += new System.EventHandler(this.Authorization_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtRecordBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTopLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEyePassToTxtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtConfirmPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtRecordBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox PictTopLogo;
        public MetroFramework.Controls.MetroTextBox TxtRecordBook;
        public MetroFramework.Controls.MetroTextBox TxtPass;
        public System.Windows.Forms.Button BtnAuth;
        public System.Windows.Forms.PictureBox PictTxtRecordBook;
        public System.Windows.Forms.PictureBox PictTxtPass;
        public System.Windows.Forms.PictureBox PictConfirmPass;
        public MetroFramework.Controls.MetroTextBox TxtConfirmPass;
        public System.Windows.Forms.Timer TimerToAnimationForm;
        public System.Windows.Forms.Label LblTopMessage;
        public MetroFramework.Controls.MetroTile TopComponentTile;
        public MetroFramework.Controls.MetroTile LowerComponentTile;
        public MetroFramework.Components.MetroToolTip ToolTipHelpUser;
        public System.Windows.Forms.Label LblGotoLostAcc;
        public System.Windows.Forms.Label LblGotoReg;
        public System.Windows.Forms.Label LblGotoWelcomeForm;
        public System.Windows.Forms.PictureBox PictEyePassToTxtPass;
        public System.Windows.Forms.PictureBox PictTxtConfirmPass;
        public System.Windows.Forms.PictureBox PictDelTxtRecordBook;
    }
}