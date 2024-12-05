namespace online_library_for_educ_inst
{
    partial class FmRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmRegistrationForm));
            this.TxtRecordBook = new MetroFramework.Controls.MetroTextBox();
            this.TxtNickName = new MetroFramework.Controls.MetroTextBox();
            this.McBoxSex = new MetroFramework.Controls.MetroComboBox();
            this.McHcKAgreeRules = new MetroFramework.Controls.MetroCheckBox();
            this.BtnReg = new System.Windows.Forms.Button();
            this.TxtPass = new MetroFramework.Controls.MetroTextBox();
            this.TxtRecoveryCode = new MetroFramework.Controls.MetroTextBox();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.TopComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.ToolTipHelpUser = new MetroFramework.Components.MetroToolTip();
            this.LblTopMessage = new System.Windows.Forms.Label();
            this.PictDelTxtRecoveryCode = new System.Windows.Forms.PictureBox();
            this.PictDelTxtPass = new System.Windows.Forms.PictureBox();
            this.PictDelTxtNickName = new System.Windows.Forms.PictureBox();
            this.PictDelTxtRecordBook = new System.Windows.Forms.PictureBox();
            this.PictToTxtSecretPass = new System.Windows.Forms.PictureBox();
            this.PictEyePassToTxtPass = new System.Windows.Forms.PictureBox();
            this.PictRecoveryCode = new System.Windows.Forms.PictureBox();
            this.PictSex = new System.Windows.Forms.PictureBox();
            this.PictTxtPass = new System.Windows.Forms.PictureBox();
            this.PictNickname = new System.Windows.Forms.PictureBox();
            this.PictTxtRecordBook = new System.Windows.Forms.PictureBox();
            this.PictTopLogo = new System.Windows.Forms.PictureBox();
            this.LblSex = new System.Windows.Forms.Label();
            this.LblHaveAccount = new System.Windows.Forms.Label();
            this.LblGotoFormAuth = new System.Windows.Forms.Label();
            this.LblGotoWelcomeForm = new System.Windows.Forms.Label();
            this.LblGenerateSecretPass = new System.Windows.Forms.Label();
            this.LblGeneratePas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtRecoveryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtNickName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtRecordBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictToTxtSecretPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEyePassToTxtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictRecoveryCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictSex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictNickname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtRecordBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTopLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtRecordBook
            // 
            this.TxtRecordBook.CustomForeColor = true;
            this.TxtRecordBook.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRecordBook.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtRecordBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(228)))));
            this.TxtRecordBook.Location = new System.Drawing.Point(66, 114);
            this.TxtRecordBook.MaxLength = 7;
            this.TxtRecordBook.Name = "TxtRecordBook";
            this.TxtRecordBook.PromptText = "№ Зачётки...";
            this.TxtRecordBook.Size = new System.Drawing.Size(250, 25);
            this.TxtRecordBook.TabIndex = 1;
            this.TxtRecordBook.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtRecordBook.TextChanged += new System.EventHandler(this.TxtRecordBook_TextChanged);
            this.TxtRecordBook.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecordBook_KeyPress);
            // 
            // TxtNickName
            // 
            this.TxtNickName.CustomForeColor = true;
            this.TxtNickName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtNickName.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtNickName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(228)))));
            this.TxtNickName.Location = new System.Drawing.Point(66, 182);
            this.TxtNickName.Name = "TxtNickName";
            this.TxtNickName.PromptText = "введите логин...";
            this.TxtNickName.Size = new System.Drawing.Size(250, 25);
            this.TxtNickName.TabIndex = 2;
            this.TxtNickName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtNickName.TextChanged += new System.EventHandler(this.TxtNickName_TextChanged);
            this.TxtNickName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNickName_KeyPress);
            this.TxtNickName.Leave += new System.EventHandler(this.TxtNickName_Leave);
            // 
            // McBoxSex
            // 
            this.McBoxSex.FormattingEnabled = true;
            this.McBoxSex.ItemHeight = 23;
            this.McBoxSex.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.McBoxSex.Location = new System.Drawing.Point(70, 403);
            this.McBoxSex.Name = "McBoxSex";
            this.McBoxSex.Size = new System.Drawing.Size(250, 29);
            this.McBoxSex.TabIndex = 5;
            this.McBoxSex.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.McBoxSex.MouseEnter += new System.EventHandler(this.McBoxSex_MouseEnter);
            // 
            // McHcKAgreeRules
            // 
            this.McHcKAgreeRules.AutoSize = true;
            this.McHcKAgreeRules.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(24)))), ((int)(((byte)(197)))));
            this.McHcKAgreeRules.CustomBackground = true;
            this.McHcKAgreeRules.CustomForeColor = true;
            this.McHcKAgreeRules.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.McHcKAgreeRules.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.McHcKAgreeRules.ForeColor = System.Drawing.Color.White;
            this.McHcKAgreeRules.Location = new System.Drawing.Point(22, 467);
            this.McHcKAgreeRules.Name = "McHcKAgreeRules";
            this.McHcKAgreeRules.Size = new System.Drawing.Size(532, 19);
            this.McHcKAgreeRules.TabIndex = 6;
            this.McHcKAgreeRules.Text = "Я даю согласие на обработку и хранение своих персональных данных ";
            this.McHcKAgreeRules.UseVisualStyleBackColor = false;
            this.McHcKAgreeRules.MouseEnter += new System.EventHandler(this.McHcKAgreeRules_MouseEnter);
            this.McHcKAgreeRules.MouseLeave += new System.EventHandler(this.McHcKAgreeRules_MouseLeave);
            // 
            // BtnReg
            // 
            this.BtnReg.BackColor = System.Drawing.Color.ForestGreen;
            this.BtnReg.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReg.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnReg.ForeColor = System.Drawing.Color.White;
            this.BtnReg.Location = new System.Drawing.Point(104, 508);
            this.BtnReg.Name = "BtnReg";
            this.BtnReg.Size = new System.Drawing.Size(383, 38);
            this.BtnReg.TabIndex = 7;
            this.BtnReg.Text = "Зарегистрироваться";
            this.BtnReg.UseVisualStyleBackColor = false;
            this.BtnReg.Click += new System.EventHandler(this.BtnReg_Click);
            this.BtnReg.MouseEnter += new System.EventHandler(this.BtnReg_MouseEnter);
            // 
            // TxtPass
            // 
            this.TxtPass.CustomForeColor = true;
            this.TxtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(228)))));
            this.TxtPass.Location = new System.Drawing.Point(66, 256);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PromptText = "введите пароль...";
            this.TxtPass.Size = new System.Drawing.Size(250, 25);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged);
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // TxtRecoveryCode
            // 
            this.TxtRecoveryCode.CustomForeColor = true;
            this.TxtRecoveryCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtRecoveryCode.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtRecoveryCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(112)))), ((int)(((byte)(228)))));
            this.TxtRecoveryCode.Location = new System.Drawing.Point(66, 319);
            this.TxtRecoveryCode.Name = "TxtRecoveryCode";
            this.TxtRecoveryCode.PromptText = "введите секр. пароль...";
            this.TxtRecoveryCode.Size = new System.Drawing.Size(250, 25);
            this.TxtRecoveryCode.TabIndex = 4;
            this.TxtRecoveryCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtRecoveryCode.TextChanged += new System.EventHandler(this.TxtRecoveryCode_TextChanged);
            this.TxtRecoveryCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRecoveryCode_KeyPress);
            // 
            // TimerToAnimationForm
            // 
            this.TimerToAnimationForm.Enabled = true;
            this.TimerToAnimationForm.Interval = 1;
            this.TimerToAnimationForm.Tick += new System.EventHandler(this.TimerToAnimationForm_Tick);
            // 
            // TopComponentTile
            // 
            this.TopComponentTile.BackColor = System.Drawing.Color.Teal;
            this.TopComponentTile.CustomBackground = true;
            this.TopComponentTile.CustomForeColor = true;
            this.TopComponentTile.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopComponentTile.ForeColor = System.Drawing.Color.Azure;
            this.TopComponentTile.Location = new System.Drawing.Point(0, 0);
            this.TopComponentTile.Name = "TopComponentTile";
            this.TopComponentTile.Size = new System.Drawing.Size(578, 23);
            this.TopComponentTile.TabIndex = 37;
            this.TopComponentTile.Text = "Цифровая настольная библиотека";
            this.TopComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TopComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.BackColor = System.Drawing.Color.Teal;
            this.LowerComponentTile.CustomBackground = true;
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LowerComponentTile.ForeColor = System.Drawing.Color.Azure;
            this.LowerComponentTile.Location = new System.Drawing.Point(0, 593);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(578, 23);
            this.LowerComponentTile.TabIndex = 38;
            this.LowerComponentTile.Text = "Форма регистрации";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // LblTopMessage
            // 
            this.LblTopMessage.AutoSize = true;
            this.LblTopMessage.BackColor = System.Drawing.Color.Transparent;
            this.LblTopMessage.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTopMessage.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.LblTopMessage.Location = new System.Drawing.Point(3, 26);
            this.LblTopMessage.Name = "LblTopMessage";
            this.LblTopMessage.Size = new System.Drawing.Size(295, 50);
            this.LblTopMessage.TabIndex = 36;
            this.LblTopMessage.Text = "Регистрация...";
            // 
            // PictDelTxtRecoveryCode
            // 
            this.PictDelTxtRecoveryCode.BackColor = System.Drawing.Color.Transparent;
            this.PictDelTxtRecoveryCode.Image = global::online_library_for_educ_inst.Properties.Resources.TrashCan;
            this.PictDelTxtRecoveryCode.Location = new System.Drawing.Point(316, 268);
            this.PictDelTxtRecoveryCode.Name = "PictDelTxtRecoveryCode";
            this.PictDelTxtRecoveryCode.Size = new System.Drawing.Size(48, 48);
            this.PictDelTxtRecoveryCode.TabIndex = 44;
            this.PictDelTxtRecoveryCode.TabStop = false;
            this.PictDelTxtRecoveryCode.Click += new System.EventHandler(this.PictDelTxtRecoveryCode_Click);
            this.PictDelTxtRecoveryCode.MouseEnter += new System.EventHandler(this.PictDelTxtRecoveryCode_MouseEnter);
            this.PictDelTxtRecoveryCode.MouseLeave += new System.EventHandler(this.PictDelTxtRecoveryCode_MouseLeave);
            // 
            // PictDelTxtPass
            // 
            this.PictDelTxtPass.BackColor = System.Drawing.Color.Transparent;
            this.PictDelTxtPass.Image = global::online_library_for_educ_inst.Properties.Resources.TrashCan;
            this.PictDelTxtPass.Location = new System.Drawing.Point(316, 204);
            this.PictDelTxtPass.Name = "PictDelTxtPass";
            this.PictDelTxtPass.Size = new System.Drawing.Size(48, 48);
            this.PictDelTxtPass.TabIndex = 43;
            this.PictDelTxtPass.TabStop = false;
            this.PictDelTxtPass.Click += new System.EventHandler(this.PictDelTxtPass_Click);
            this.PictDelTxtPass.MouseEnter += new System.EventHandler(this.PictDelTxtPass_MouseEnter);
            this.PictDelTxtPass.MouseLeave += new System.EventHandler(this.PictDelTxtPass_MouseLeave);
            // 
            // PictDelTxtNickName
            // 
            this.PictDelTxtNickName.BackColor = System.Drawing.Color.Transparent;
            this.PictDelTxtNickName.Image = global::online_library_for_educ_inst.Properties.Resources.TrashCan;
            this.PictDelTxtNickName.Location = new System.Drawing.Point(316, 128);
            this.PictDelTxtNickName.Name = "PictDelTxtNickName";
            this.PictDelTxtNickName.Size = new System.Drawing.Size(48, 48);
            this.PictDelTxtNickName.TabIndex = 42;
            this.PictDelTxtNickName.TabStop = false;
            this.PictDelTxtNickName.Click += new System.EventHandler(this.PictDelTxtNickName_Click);
            this.PictDelTxtNickName.MouseEnter += new System.EventHandler(this.PictDelTxtNickName_MouseEnter);
            this.PictDelTxtNickName.MouseLeave += new System.EventHandler(this.PictDelTxtNickName_MouseLeave);
            // 
            // PictDelTxtRecordBook
            // 
            this.PictDelTxtRecordBook.BackColor = System.Drawing.Color.Transparent;
            this.PictDelTxtRecordBook.Image = global::online_library_for_educ_inst.Properties.Resources.TrashCan;
            this.PictDelTxtRecordBook.Location = new System.Drawing.Point(316, 60);
            this.PictDelTxtRecordBook.Name = "PictDelTxtRecordBook";
            this.PictDelTxtRecordBook.Size = new System.Drawing.Size(48, 48);
            this.PictDelTxtRecordBook.TabIndex = 41;
            this.PictDelTxtRecordBook.TabStop = false;
            this.PictDelTxtRecordBook.Click += new System.EventHandler(this.PictDelTxtRecordBook_Click);
            this.PictDelTxtRecordBook.MouseEnter += new System.EventHandler(this.PictDelTxtRecordBook_MouseEnter);
            this.PictDelTxtRecordBook.MouseLeave += new System.EventHandler(this.PictDelTxtRecordBook_MouseLeave);
            // 
            // PictToTxtSecretPass
            // 
            this.PictToTxtSecretPass.BackColor = System.Drawing.Color.Transparent;
            this.PictToTxtSecretPass.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegShowPass;
            this.PictToTxtSecretPass.Location = new System.Drawing.Point(390, 298);
            this.PictToTxtSecretPass.Name = "PictToTxtSecretPass";
            this.PictToTxtSecretPass.Size = new System.Drawing.Size(64, 64);
            this.PictToTxtSecretPass.TabIndex = 40;
            this.PictToTxtSecretPass.TabStop = false;
            this.PictToTxtSecretPass.MouseEnter += new System.EventHandler(this.PictToTxtSecretPass_MouseEnter);
            this.PictToTxtSecretPass.MouseLeave += new System.EventHandler(this.PictToTxtSecretPass_MouseLeave);
            // 
            // PictEyePassToTxtPass
            // 
            this.PictEyePassToTxtPass.BackColor = System.Drawing.Color.Transparent;
            this.PictEyePassToTxtPass.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegShowPass;
            this.PictEyePassToTxtPass.Location = new System.Drawing.Point(390, 228);
            this.PictEyePassToTxtPass.Name = "PictEyePassToTxtPass";
            this.PictEyePassToTxtPass.Size = new System.Drawing.Size(64, 64);
            this.PictEyePassToTxtPass.TabIndex = 39;
            this.PictEyePassToTxtPass.TabStop = false;
            this.PictEyePassToTxtPass.MouseEnter += new System.EventHandler(this.PictEyePassToTxtPass_MouseEnter);
            this.PictEyePassToTxtPass.MouseLeave += new System.EventHandler(this.PictEyePassToTxtPass_MouseLeave);
            // 
            // PictRecoveryCode
            // 
            this.PictRecoveryCode.BackColor = System.Drawing.Color.Transparent;
            this.PictRecoveryCode.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegSecretPass;
            this.PictRecoveryCode.Location = new System.Drawing.Point(0, 298);
            this.PictRecoveryCode.Name = "PictRecoveryCode";
            this.PictRecoveryCode.Size = new System.Drawing.Size(64, 64);
            this.PictRecoveryCode.TabIndex = 32;
            this.PictRecoveryCode.TabStop = false;
            this.PictRecoveryCode.MouseEnter += new System.EventHandler(this.PictRecoveryCode_MouseEnter);
            this.PictRecoveryCode.MouseLeave += new System.EventHandler(this.PictRecoveryCode_MouseLeave);
            // 
            // PictSex
            // 
            this.PictSex.BackColor = System.Drawing.Color.Transparent;
            this.PictSex.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegSex;
            this.PictSex.Location = new System.Drawing.Point(0, 368);
            this.PictSex.Name = "PictSex";
            this.PictSex.Size = new System.Drawing.Size(64, 64);
            this.PictSex.TabIndex = 13;
            this.PictSex.TabStop = false;
            this.PictSex.MouseEnter += new System.EventHandler(this.PictSex_MouseEnter);
            this.PictSex.MouseLeave += new System.EventHandler(this.PictSex_MouseLeave);
            // 
            // PictTxtPass
            // 
            this.PictTxtPass.BackColor = System.Drawing.Color.Transparent;
            this.PictTxtPass.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegPass;
            this.PictTxtPass.Location = new System.Drawing.Point(0, 228);
            this.PictTxtPass.Name = "PictTxtPass";
            this.PictTxtPass.Size = new System.Drawing.Size(64, 64);
            this.PictTxtPass.TabIndex = 12;
            this.PictTxtPass.TabStop = false;
            this.PictTxtPass.MouseEnter += new System.EventHandler(this.PictTxtPass_MouseEnter);
            this.PictTxtPass.MouseLeave += new System.EventHandler(this.PictTxtPass_MouseLeave);
            // 
            // PictNickname
            // 
            this.PictNickname.BackColor = System.Drawing.Color.Transparent;
            this.PictNickname.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegNickName;
            this.PictNickname.Location = new System.Drawing.Point(0, 158);
            this.PictNickname.Name = "PictNickname";
            this.PictNickname.Size = new System.Drawing.Size(64, 64);
            this.PictNickname.TabIndex = 6;
            this.PictNickname.TabStop = false;
            this.PictNickname.MouseEnter += new System.EventHandler(this.PictNickname_MouseEnter);
            this.PictNickname.MouseLeave += new System.EventHandler(this.PictNickname_MouseLeave);
            // 
            // PictTxtRecordBook
            // 
            this.PictTxtRecordBook.BackColor = System.Drawing.Color.Transparent;
            this.PictTxtRecordBook.Image = global::online_library_for_educ_inst.Properties.Resources.PictRegRecordBook;
            this.PictTxtRecordBook.Location = new System.Drawing.Point(-4, 89);
            this.PictTxtRecordBook.Name = "PictTxtRecordBook";
            this.PictTxtRecordBook.Size = new System.Drawing.Size(64, 64);
            this.PictTxtRecordBook.TabIndex = 3;
            this.PictTxtRecordBook.TabStop = false;
            this.PictTxtRecordBook.MouseEnter += new System.EventHandler(this.PictTxtRecordBook_MouseEnter);
            this.PictTxtRecordBook.MouseLeave += new System.EventHandler(this.PictTxtRecordBook_MouseLeave);
            // 
            // PictTopLogo
            // 
            this.PictTopLogo.BackColor = System.Drawing.Color.Transparent;
            this.PictTopLogo.Image = global::online_library_for_educ_inst.Properties.Resources.IconCursorReg;
            this.PictTopLogo.Location = new System.Drawing.Point(444, 26);
            this.PictTopLogo.Name = "PictTopLogo";
            this.PictTopLogo.Size = new System.Drawing.Size(129, 127);
            this.PictTopLogo.TabIndex = 1;
            this.PictTopLogo.TabStop = false;
            // 
            // LblSex
            // 
            this.LblSex.AutoSize = true;
            this.LblSex.BackColor = System.Drawing.Color.Transparent;
            this.LblSex.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSex.ForeColor = System.Drawing.Color.White;
            this.LblSex.Location = new System.Drawing.Point(70, 379);
            this.LblSex.Name = "LblSex";
            this.LblSex.Size = new System.Drawing.Size(130, 21);
            this.LblSex.TabIndex = 45;
            this.LblSex.Text = "выберите пол:";
            // 
            // LblHaveAccount
            // 
            this.LblHaveAccount.AutoSize = true;
            this.LblHaveAccount.BackColor = System.Drawing.Color.Transparent;
            this.LblHaveAccount.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblHaveAccount.ForeColor = System.Drawing.Color.White;
            this.LblHaveAccount.Location = new System.Drawing.Point(3, 573);
            this.LblHaveAccount.Name = "LblHaveAccount";
            this.LblHaveAccount.Size = new System.Drawing.Size(129, 17);
            this.LblHaveAccount.TabIndex = 46;
            this.LblHaveAccount.Text = "Уже есть аккаунт?:";
            // 
            // LblGotoFormAuth
            // 
            this.LblGotoFormAuth.AutoSize = true;
            this.LblGotoFormAuth.BackColor = System.Drawing.Color.Transparent;
            this.LblGotoFormAuth.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGotoFormAuth.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.LblGotoFormAuth.Location = new System.Drawing.Point(128, 570);
            this.LblGotoFormAuth.Name = "LblGotoFormAuth";
            this.LblGotoFormAuth.Size = new System.Drawing.Size(155, 21);
            this.LblGotoFormAuth.TabIndex = 47;
            this.LblGotoFormAuth.Text = "авторизоваться...";
            this.LblGotoFormAuth.Click += new System.EventHandler(this.LblGotoFormAuth_Click);
            this.LblGotoFormAuth.MouseEnter += new System.EventHandler(this.LblGotoFormAuth_MouseEnter);
            this.LblGotoFormAuth.MouseLeave += new System.EventHandler(this.LblGotoFormAuth_MouseLeave);
            // 
            // LblGotoWelcomeForm
            // 
            this.LblGotoWelcomeForm.AutoSize = true;
            this.LblGotoWelcomeForm.BackColor = System.Drawing.Color.Transparent;
            this.LblGotoWelcomeForm.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGotoWelcomeForm.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.LblGotoWelcomeForm.Location = new System.Drawing.Point(352, 574);
            this.LblGotoWelcomeForm.Name = "LblGotoWelcomeForm";
            this.LblGotoWelcomeForm.Size = new System.Drawing.Size(226, 17);
            this.LblGotoWelcomeForm.TabIndex = 48;
            this.LblGotoWelcomeForm.Text = "выйти в приветственное меню...";
            this.LblGotoWelcomeForm.Click += new System.EventHandler(this.LblGotoWelcomeForm_Click);
            this.LblGotoWelcomeForm.MouseEnter += new System.EventHandler(this.LblGotoWelcomeForm_MouseEnter);
            this.LblGotoWelcomeForm.MouseLeave += new System.EventHandler(this.LblGotoWelcomeForm_MouseLeave);
            // 
            // LblGenerateSecretPass
            // 
            this.LblGenerateSecretPass.AutoSize = true;
            this.LblGenerateSecretPass.BackColor = System.Drawing.Color.Transparent;
            this.LblGenerateSecretPass.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblGenerateSecretPass.ForeColor = System.Drawing.Color.White;
            this.LblGenerateSecretPass.Location = new System.Drawing.Point(67, 303);
            this.LblGenerateSecretPass.Name = "LblGenerateSecretPass";
            this.LblGenerateSecretPass.Size = new System.Drawing.Size(207, 13);
            this.LblGenerateSecretPass.TabIndex = 50;
            this.LblGenerateSecretPass.Text = "Сгенерировать секретное слово...";
            this.LblGenerateSecretPass.Click += new System.EventHandler(this.LblGenerateSecretPass_Click);
            this.LblGenerateSecretPass.MouseEnter += new System.EventHandler(this.LblGenerateSecretPass_MouseEnter);
            this.LblGenerateSecretPass.MouseLeave += new System.EventHandler(this.LblGenerateSecretPass_MouseLeave);
            // 
            // LblGeneratePas
            // 
            this.LblGeneratePas.AutoSize = true;
            this.LblGeneratePas.BackColor = System.Drawing.Color.Transparent;
            this.LblGeneratePas.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblGeneratePas.ForeColor = System.Drawing.Color.White;
            this.LblGeneratePas.Location = new System.Drawing.Point(67, 239);
            this.LblGeneratePas.Name = "LblGeneratePas";
            this.LblGeneratePas.Size = new System.Drawing.Size(217, 13);
            this.LblGeneratePas.TabIndex = 49;
            this.LblGeneratePas.Text = "Сгенерировать надежный пароль...";
            this.LblGeneratePas.Click += new System.EventHandler(this.LblGeneratePas_Click);
            this.LblGeneratePas.MouseEnter += new System.EventHandler(this.LblGeneratePas_MouseEnter);
            this.LblGeneratePas.MouseLeave += new System.EventHandler(this.LblGeneratePas_MouseLeave);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::online_library_for_educ_inst.Properties.Resources.BackGroundFormReg;
            this.ClientSize = new System.Drawing.Size(578, 616);
            this.Controls.Add(this.LblGenerateSecretPass);
            this.Controls.Add(this.LblGeneratePas);
            this.Controls.Add(this.LblGotoWelcomeForm);
            this.Controls.Add(this.LblGotoFormAuth);
            this.Controls.Add(this.LblHaveAccount);
            this.Controls.Add(this.LblSex);
            this.Controls.Add(this.PictDelTxtRecoveryCode);
            this.Controls.Add(this.PictDelTxtPass);
            this.Controls.Add(this.PictDelTxtNickName);
            this.Controls.Add(this.PictDelTxtRecordBook);
            this.Controls.Add(this.PictToTxtSecretPass);
            this.Controls.Add(this.PictEyePassToTxtPass);
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.TopComponentTile);
            this.Controls.Add(this.LblTopMessage);
            this.Controls.Add(this.TxtRecoveryCode);
            this.Controls.Add(this.PictRecoveryCode);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.BtnReg);
            this.Controls.Add(this.McHcKAgreeRules);
            this.Controls.Add(this.McBoxSex);
            this.Controls.Add(this.PictSex);
            this.Controls.Add(this.PictTxtPass);
            this.Controls.Add(this.TxtNickName);
            this.Controls.Add(this.PictNickname);
            this.Controls.Add(this.PictTxtRecordBook);
            this.Controls.Add(this.TxtRecordBook);
            this.Controls.Add(this.PictTopLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(578, 616);
            this.MinimumSize = new System.Drawing.Size(578, 616);
            this.Name = "RegistrationForm";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Форма Регистрации";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_Form_FormClosing);
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtRecoveryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtNickName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictDelTxtRecordBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictToTxtSecretPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictEyePassToTxtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictRecoveryCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictSex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictNickname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTxtRecordBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictTopLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox PictTopLogo;
        public MetroFramework.Controls.MetroTextBox TxtRecordBook;
        public System.Windows.Forms.PictureBox PictTxtRecordBook;
        public System.Windows.Forms.PictureBox PictNickname;
        public MetroFramework.Controls.MetroTextBox TxtNickName;
        public System.Windows.Forms.PictureBox PictTxtPass;
        public System.Windows.Forms.PictureBox PictSex;
        public MetroFramework.Controls.MetroComboBox McBoxSex;
        public MetroFramework.Controls.MetroCheckBox McHcKAgreeRules;
        public System.Windows.Forms.Button BtnReg;
        public MetroFramework.Controls.MetroTextBox TxtPass;
        public System.Windows.Forms.PictureBox PictRecoveryCode;
        public MetroFramework.Controls.MetroTextBox TxtRecoveryCode;
        public System.Windows.Forms.Timer TimerToAnimationForm;
        public MetroFramework.Controls.MetroTile TopComponentTile;
        public MetroFramework.Controls.MetroTile LowerComponentTile;
        public MetroFramework.Components.MetroToolTip ToolTipHelpUser;
        public System.Windows.Forms.PictureBox PictEyePassToTxtPass;
        public System.Windows.Forms.PictureBox PictToTxtSecretPass;
        public System.Windows.Forms.Label LblTopMessage;
        public System.Windows.Forms.PictureBox PictDelTxtRecordBook;
        public System.Windows.Forms.PictureBox PictDelTxtNickName;
        public System.Windows.Forms.PictureBox PictDelTxtPass;
        public System.Windows.Forms.PictureBox PictDelTxtRecoveryCode;
        public System.Windows.Forms.Label LblSex;
        public System.Windows.Forms.Label LblHaveAccount;
        public System.Windows.Forms.Label LblGotoFormAuth;
        public System.Windows.Forms.Label LblGotoWelcomeForm;
        public System.Windows.Forms.Label LblGenerateSecretPass;
        public System.Windows.Forms.Label LblGeneratePas;
    }
}