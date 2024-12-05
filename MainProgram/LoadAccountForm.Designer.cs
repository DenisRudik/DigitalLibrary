namespace online_library_for_educ_inst
{
    partial class FmLoadAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmLoadAccountForm));
            this.LblMessage = new MetroFramework.Controls.MetroLabel();
            this.BarLoading = new System.Windows.Forms.Panel();
            this.PanelLoadProcess = new System.Windows.Forms.Panel();
            this.Tload = new System.Windows.Forms.Timer(this.components);
            this.PictLogo = new System.Windows.Forms.PictureBox();
            this.LblNewUser = new MetroFramework.Controls.MetroLabel();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.TopComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.BarLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // LblMessage
            // 
            this.LblMessage.AutoSize = true;
            this.LblMessage.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblMessage.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblMessage.Location = new System.Drawing.Point(2, 51);
            this.LblMessage.Name = "LblMessage";
            this.LblMessage.Size = new System.Drawing.Size(178, 25);
            this.LblMessage.TabIndex = 0;
            this.LblMessage.Text = "Загрузка аккаунта:";
            // 
            // BarLoading
            // 
            this.BarLoading.Controls.Add(this.PanelLoadProcess);
            this.BarLoading.Location = new System.Drawing.Point(2, 96);
            this.BarLoading.Name = "BarLoading";
            this.BarLoading.Size = new System.Drawing.Size(790, 21);
            this.BarLoading.TabIndex = 1;
            // 
            // PanelLoadProcess
            // 
            this.PanelLoadProcess.Location = new System.Drawing.Point(0, 0);
            this.PanelLoadProcess.Name = "PanelLoadProcess";
            this.PanelLoadProcess.Size = new System.Drawing.Size(14, 21);
            this.PanelLoadProcess.TabIndex = 2;
            // 
            // Tload
            // 
            this.Tload.Interval = 15;
            this.Tload.Tick += new System.EventHandler(this.TimeLoad_Tick);
            // 
            // PictLogo
            // 
            this.PictLogo.Location = new System.Drawing.Point(719, 37);
            this.PictLogo.Name = "PictLogo";
            this.PictLogo.Size = new System.Drawing.Size(48, 48);
            this.PictLogo.TabIndex = 3;
            this.PictLogo.TabStop = false;
            // 
            // LblNewUser
            // 
            this.LblNewUser.AutoSize = true;
            this.LblNewUser.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblNewUser.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblNewUser.Location = new System.Drawing.Point(186, 51);
            this.LblNewUser.Name = "LblNewUser";
            this.LblNewUser.Size = new System.Drawing.Size(118, 25);
            this.LblNewUser.TabIndex = 4;
            this.LblNewUser.Text = "lbl_new_user";
            // 
            // TimerToAnimationForm
            // 
            this.TimerToAnimationForm.Enabled = true;
            this.TimerToAnimationForm.Interval = 1;
            this.TimerToAnimationForm.Tick += new System.EventHandler(this.TimerToAnimationForm_Tick);
            // 
            // TopComponentTile
            // 
            this.TopComponentTile.BackColor = System.Drawing.Color.Black;
            this.TopComponentTile.CustomBackground = true;
            this.TopComponentTile.CustomForeColor = true;
            this.TopComponentTile.ForeColor = System.Drawing.Color.White;
            this.TopComponentTile.Location = new System.Drawing.Point(-1, 4);
            this.TopComponentTile.Name = "TopComponentTile";
            this.TopComponentTile.Size = new System.Drawing.Size(793, 27);
            this.TopComponentTile.TabIndex = 5;
            this.TopComponentTile.Text = "Цифровая настольная библиотека";
            this.TopComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TopComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.BackColor = System.Drawing.Color.Black;
            this.LowerComponentTile.CustomBackground = true;
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.ForeColor = System.Drawing.Color.White;
            this.LowerComponentTile.Location = new System.Drawing.Point(-1, 115);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(793, 26);
            this.LowerComponentTile.TabIndex = 6;
            this.LowerComponentTile.Text = "metroTile1";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // LoadAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 140);
            this.ControlBox = false;
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.TopComponentTile);
            this.Controls.Add(this.LblNewUser);
            this.Controls.Add(this.PictLogo);
            this.Controls.Add(this.BarLoading);
            this.Controls.Add(this.LblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(790, 140);
            this.MinimumSize = new System.Drawing.Size(790, 140);
            this.Name = "LoadAccountForm";
            this.Opacity = 0D;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Load += new System.EventHandler(this.LoadAccountForm_Load);
            this.BarLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLabel LblMessage;
        public System.Windows.Forms.Panel BarLoading;
        public System.Windows.Forms.Panel PanelLoadProcess;
        public System.Windows.Forms.Timer Tload;
        public System.Windows.Forms.PictureBox PictLogo;
        public MetroFramework.Controls.MetroLabel LblNewUser;
        public System.Windows.Forms.Timer TimerToAnimationForm;
        public MetroFramework.Controls.MetroTile TopComponentTile;
        public MetroFramework.Controls.MetroTile LowerComponentTile;
    }
}