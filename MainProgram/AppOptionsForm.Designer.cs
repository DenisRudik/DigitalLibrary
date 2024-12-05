namespace online_library_for_educ_inst
{
    partial class FmAppOptionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmAppOptionsForm));
            this.PictLogo = new System.Windows.Forms.PictureBox();
            this.LblSoundInfo = new System.Windows.Forms.Label();
            this.LblMessageForSound = new System.Windows.Forms.Label();
            this.MToggleSoundOptions = new MetroFramework.Controls.MetroToggle();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.TopComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.PictCloseForm = new System.Windows.Forms.PictureBox();
            this.ToolTipHelpUser = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictCloseForm)).BeginInit();
            this.SuspendLayout();
            // 
            // PictLogo
            // 
            this.PictLogo.Image = global::online_library_for_educ_inst.Properties.Resources.GifGears;
            this.PictLogo.Location = new System.Drawing.Point(418, 49);
            this.PictLogo.Name = "PictLogo";
            this.PictLogo.Size = new System.Drawing.Size(48, 48);
            this.PictLogo.TabIndex = 0;
            this.PictLogo.TabStop = false;
            // 
            // LblSoundInfo
            // 
            this.LblSoundInfo.AutoSize = true;
            this.LblSoundInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblSoundInfo.ForeColor = System.Drawing.Color.Black;
            this.LblSoundInfo.Location = new System.Drawing.Point(53, 50);
            this.LblSoundInfo.Name = "LblSoundInfo";
            this.LblSoundInfo.Size = new System.Drawing.Size(46, 21);
            this.LblSoundInfo.TabIndex = 1;
            this.LblSoundInfo.Text = "Звук";
            // 
            // LblMessageForSound
            // 
            this.LblMessageForSound.AutoSize = true;
            this.LblMessageForSound.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblMessageForSound.ForeColor = System.Drawing.Color.Black;
            this.LblMessageForSound.Location = new System.Drawing.Point(54, 80);
            this.LblMessageForSound.Name = "LblMessageForSound";
            this.LblMessageForSound.Size = new System.Drawing.Size(209, 17);
            this.LblMessageForSound.TabIndex = 2;
            this.LblMessageForSound.Text = "выключить звуковые эффекты...";
            // 
            // MToggleSoundOptions
            // 
            this.MToggleSoundOptions.AutoSize = true;
            this.MToggleSoundOptions.Location = new System.Drawing.Point(269, 80);
            this.MToggleSoundOptions.Name = "MToggleSoundOptions";
            this.MToggleSoundOptions.Size = new System.Drawing.Size(80, 17);
            this.MToggleSoundOptions.TabIndex = 3;
            this.MToggleSoundOptions.Text = "Off";
            this.MToggleSoundOptions.UseVisualStyleBackColor = true;
            this.MToggleSoundOptions.CheckedChanged += new System.EventHandler(this.MToggleSoundOptions_CheckedChanged);
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
            this.TopComponentTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TopComponentTile.Location = new System.Drawing.Point(-1, 4);
            this.TopComponentTile.Name = "TopComponentTile";
            this.TopComponentTile.Size = new System.Drawing.Size(467, 27);
            this.TopComponentTile.TabIndex = 4;
            this.TopComponentTile.Text = "Цифровая настольная библиотека";
            this.TopComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TopComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.BackColor = System.Drawing.Color.Black;
            this.LowerComponentTile.CustomBackground = true;
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.Location = new System.Drawing.Point(-1, 274);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(467, 27);
            this.LowerComponentTile.TabIndex = 5;
            this.LowerComponentTile.Text = "настройки приложения";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // PictCloseForm
            // 
            this.PictCloseForm.Image = global::online_library_for_educ_inst.Properties.Resources.GifBackForm;
            this.PictCloseForm.Location = new System.Drawing.Point(-1, 50);
            this.PictCloseForm.Name = "PictCloseForm";
            this.PictCloseForm.Size = new System.Drawing.Size(48, 48);
            this.PictCloseForm.TabIndex = 6;
            this.PictCloseForm.TabStop = false;
            this.PictCloseForm.Click += new System.EventHandler(this.PictCloseForm_Click);
            this.PictCloseForm.MouseEnter += new System.EventHandler(this.PictCloseForm_MouseEnter);
            // 
            // AppOptionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 300);
            this.Controls.Add(this.PictCloseForm);
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.TopComponentTile);
            this.Controls.Add(this.MToggleSoundOptions);
            this.Controls.Add(this.LblMessageForSound);
            this.Controls.Add(this.LblSoundInfo);
            this.Controls.Add(this.PictLogo);
            this.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(464, 300);
            this.MinimumSize = new System.Drawing.Size(464, 300);
            this.Name = "AppOptionsForm";
            this.Opacity = 0D;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Load += new System.EventHandler(this.AppOptionsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictCloseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox PictLogo;
        public System.Windows.Forms.Label LblSoundInfo;
        public System.Windows.Forms.Label LblMessageForSound;
        public MetroFramework.Controls.MetroToggle MToggleSoundOptions;
        public System.Windows.Forms.Timer TimerToAnimationForm;
        public MetroFramework.Controls.MetroTile TopComponentTile;
        public MetroFramework.Controls.MetroTile LowerComponentTile;
        public System.Windows.Forms.PictureBox PictCloseForm;
        public MetroFramework.Components.MetroToolTip ToolTipHelpUser;
    }
}