namespace online_library_for_educ_inst
{
    partial class FmLoadingForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLoadingForm));
            this.LblMsgAboutDeveloper = new MetroFramework.Controls.MetroLabel();
            this.PnLoading_Bar = new System.Windows.Forms.Panel();
            this.PnLoadingBar = new System.Windows.Forms.Panel();
            this.TmTimeToLoad = new System.Windows.Forms.Timer(this.components);
            this.LblMsgAboutProg = new System.Windows.Forms.Label();
            this.LblMsgForUser = new MetroFramework.Controls.MetroLabel();
            this.LblMsgForLoadProgress = new System.Windows.Forms.Label();
            this.TmTimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.PictBxPictrurePC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictBxPictrurePC)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMsgAboutDeveloper
            // 
            this.LblMsgAboutDeveloper.AutoSize = true;
            this.LblMsgAboutDeveloper.CustomBackground = true;
            this.LblMsgAboutDeveloper.CustomForeColor = true;
            this.LblMsgAboutDeveloper.FontSize = MetroFramework.MetroLabelSize.Small;
            this.LblMsgAboutDeveloper.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblMsgAboutDeveloper.ForeColor = System.Drawing.Color.White;
            this.LblMsgAboutDeveloper.Location = new System.Drawing.Point(572, 8);
            this.LblMsgAboutDeveloper.Name = "LblMsgAboutDeveloper";
            this.LblMsgAboutDeveloper.Size = new System.Drawing.Size(139, 15);
            this.LblMsgAboutDeveloper.Style = MetroFramework.MetroColorStyle.Lime;
            this.LblMsgAboutDeveloper.TabIndex = 1;
            this.LblMsgAboutDeveloper.Text = "LblMsgAboutDeveloper";
            // 
            // PnLoading_Bar
            // 
            this.PnLoading_Bar.Location = new System.Drawing.Point(-5, 428);
            this.PnLoading_Bar.Name = "PnLoading_Bar";
            this.PnLoading_Bar.Size = new System.Drawing.Size(764, 21);
            this.PnLoading_Bar.TabIndex = 2;
            // 
            // PnLoadingBar
            // 
            this.PnLoadingBar.Location = new System.Drawing.Point(2, 428);
            this.PnLoadingBar.Name = "PnLoadingBar";
            this.PnLoadingBar.Size = new System.Drawing.Size(14, 21);
            this.PnLoadingBar.TabIndex = 0;
            // 
            // TmTimeToLoad
            // 
            this.TmTimeToLoad.Interval = 15;
            this.TmTimeToLoad.Tick += new System.EventHandler(this.TmTimeToLoad_Tick);
            // 
            // LblMsgAboutProg
            // 
            this.LblMsgAboutProg.AutoSize = true;
            this.LblMsgAboutProg.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblMsgAboutProg.ForeColor = System.Drawing.Color.White;
            this.LblMsgAboutProg.Location = new System.Drawing.Point(7, 8);
            this.LblMsgAboutProg.Name = "LblMsgAboutProg";
            this.LblMsgAboutProg.Size = new System.Drawing.Size(167, 25);
            this.LblMsgAboutProg.TabIndex = 3;
            this.LblMsgAboutProg.Text = "LblMsgAboutProg";
            // 
            // LblMsgForUser
            // 
            this.LblMsgForUser.AutoSize = true;
            this.LblMsgForUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.LblMsgForUser.CustomBackground = true;
            this.LblMsgForUser.CustomForeColor = true;
            this.LblMsgForUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblMsgForUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblMsgForUser.ForeColor = System.Drawing.Color.White;
            this.LblMsgForUser.Location = new System.Drawing.Point(12, 400);
            this.LblMsgForUser.Name = "LblMsgForUser";
            this.LblMsgForUser.Size = new System.Drawing.Size(138, 25);
            this.LblMsgForUser.TabIndex = 4;
            this.LblMsgForUser.Text = "LblMsgForUser";
            // 
            // LblMsgForLoadProgress
            // 
            this.LblMsgForLoadProgress.AutoSize = true;
            this.LblMsgForLoadProgress.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblMsgForLoadProgress.ForeColor = System.Drawing.Color.White;
            this.LblMsgForLoadProgress.Location = new System.Drawing.Point(110, 400);
            this.LblMsgForLoadProgress.Name = "LblMsgForLoadProgress";
            this.LblMsgForLoadProgress.Size = new System.Drawing.Size(0, 25);
            this.LblMsgForLoadProgress.TabIndex = 5;
            // 
            // TmTimerToAnimationForm
            // 
            this.TmTimerToAnimationForm.Enabled = true;
            this.TmTimerToAnimationForm.Interval = 1;
            this.TmTimerToAnimationForm.Tick += new System.EventHandler(this.TimerToAnimationForm_Tick);
            // 
            // PictBxPictrurePC
            // 
            this.PictBxPictrurePC.BackColor = System.Drawing.Color.Transparent;
            this.PictBxPictrurePC.Location = new System.Drawing.Point(2, 36);
            this.PictBxPictrurePC.Name = "PictBxPictrurePC";
            this.PictBxPictrurePC.Size = new System.Drawing.Size(502, 335);
            this.PictBxPictrurePC.TabIndex = 0;
            this.PictBxPictrurePC.TabStop = false;
            // 
            // FmLoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LblMsgForLoadProgress);
            this.Controls.Add(this.LblMsgForUser);
            this.Controls.Add(this.LblMsgAboutProg);
            this.Controls.Add(this.PnLoadingBar);
            this.Controls.Add(this.PnLoading_Bar);
            this.Controls.Add(this.LblMsgAboutDeveloper);
            this.Controls.Add(this.PictBxPictrurePC);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 450);
            this.MinimumSize = new System.Drawing.Size(750, 450);
            this.Name = "FmLoadingForm";
            this.Opacity = 0D;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.PictBxPictrurePC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox PictBxPictrurePC;
        public MetroFramework.Controls.MetroLabel LblMsgAboutDeveloper;
        public System.Windows.Forms.Panel PnLoading_Bar;
        public System.Windows.Forms.Label LblMsgAboutProg;
        public MetroFramework.Controls.MetroLabel LblMsgForUser;
        public System.Windows.Forms.Panel PnLoadingBar;
        public System.Windows.Forms.Timer TmTimeToLoad;
        public System.Windows.Forms.Label LblMsgForLoadProgress;
        public System.Windows.Forms.Timer TmTimerToAnimationForm;
    }
}

