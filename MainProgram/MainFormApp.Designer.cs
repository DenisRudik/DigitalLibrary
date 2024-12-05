namespace online_library_for_educ_inst
{
    partial class FmMainFormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMainFormApp));
            this.SideBarPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SecondPanel = new System.Windows.Forms.Panel();
            this.LblMenuText = new MetroFramework.Controls.MetroLabel();
            this.ThirdPanel = new System.Windows.Forms.Panel();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.TopComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.ToolTipHelpUser = new MetroFramework.Components.MetroToolTip();
            this.PictSub = new System.Windows.Forms.PictureBox();
            this.PictMenu = new System.Windows.Forms.PictureBox();
            this.BtnOpenBooks = new System.Windows.Forms.Button();
            this.BtnUserProfile = new System.Windows.Forms.Button();
            this.BtnShowSub = new System.Windows.Forms.Button();
            this.BtnReturnBack = new System.Windows.Forms.Button();
            this.BtnExitApp = new System.Windows.Forms.Button();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.PictLogoApp = new System.Windows.Forms.PictureBox();
            this.SideBarPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.ThirdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictLogoApp)).BeginInit();
            this.SuspendLayout();
            // 
            // SideBarPanel
            // 
            this.SideBarPanel.BackColor = System.Drawing.Color.Black;
            this.SideBarPanel.Controls.Add(this.SecondPanel);
            this.SideBarPanel.Controls.Add(this.ThirdPanel);
            this.SideBarPanel.Location = new System.Drawing.Point(-1, -4);
            this.SideBarPanel.MaximumSize = new System.Drawing.Size(227, 679);
            this.SideBarPanel.MinimumSize = new System.Drawing.Size(47, 679);
            this.SideBarPanel.Name = "SideBarPanel";
            this.SideBarPanel.Size = new System.Drawing.Size(47, 679);
            this.SideBarPanel.TabIndex = 8;
            // 
            // SecondPanel
            // 
            this.SecondPanel.BackColor = System.Drawing.Color.Black;
            this.SecondPanel.Controls.Add(this.PictMenu);
            this.SecondPanel.Controls.Add(this.LblMenuText);
            this.SecondPanel.Location = new System.Drawing.Point(3, 3);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.Size = new System.Drawing.Size(219, 100);
            this.SecondPanel.TabIndex = 0;
            // 
            // LblMenuText
            // 
            this.LblMenuText.AutoSize = true;
            this.LblMenuText.BackColor = System.Drawing.Color.Black;
            this.LblMenuText.CustomBackground = true;
            this.LblMenuText.CustomForeColor = true;
            this.LblMenuText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LblMenuText.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LblMenuText.ForeColor = System.Drawing.Color.White;
            this.LblMenuText.Location = new System.Drawing.Point(51, 48);
            this.LblMenuText.Name = "LblMenuText";
            this.LblMenuText.Size = new System.Drawing.Size(71, 25);
            this.LblMenuText.TabIndex = 8;
            this.LblMenuText.Text = "Меню:";
            // 
            // ThirdPanel
            // 
            this.ThirdPanel.Controls.Add(this.BtnOpenBooks);
            this.ThirdPanel.Controls.Add(this.BtnUserProfile);
            this.ThirdPanel.Controls.Add(this.BtnShowSub);
            this.ThirdPanel.Controls.Add(this.BtnReturnBack);
            this.ThirdPanel.Controls.Add(this.BtnExitApp);
            this.ThirdPanel.Controls.Add(this.BtnSettings);
            this.ThirdPanel.Location = new System.Drawing.Point(3, 109);
            this.ThirdPanel.Name = "ThirdPanel";
            this.ThirdPanel.Size = new System.Drawing.Size(222, 386);
            this.ThirdPanel.TabIndex = 9;
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
            this.TopComponentTile.Location = new System.Drawing.Point(-1, 0);
            this.TopComponentTile.Name = "TopComponentTile";
            this.TopComponentTile.Size = new System.Drawing.Size(951, 27);
            this.TopComponentTile.TabIndex = 10;
            this.TopComponentTile.Text = "Цифровая настольная библиотека";
            this.TopComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TopComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.BackColor = System.Drawing.Color.Black;
            this.LowerComponentTile.CustomBackground = true;
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.LowerComponentTile.Location = new System.Drawing.Point(-1, 652);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(951, 27);
            this.LowerComponentTile.TabIndex = 11;
            this.LowerComponentTile.Text = "metroTile1";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            // 
            // PictSub
            // 
            this.PictSub.Location = new System.Drawing.Point(886, 33);
            this.PictSub.Name = "PictSub";
            this.PictSub.Size = new System.Drawing.Size(64, 64);
            this.PictSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictSub.TabIndex = 12;
            this.PictSub.TabStop = false;
            this.PictSub.MouseEnter += new System.EventHandler(this.PictSub_MouseEnter);
            // 
            // PictMenu
            // 
            this.PictMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictMenu.Image = global::online_library_for_educ_inst.Properties.Resources.GifMenu;
            this.PictMenu.Location = new System.Drawing.Point(-3, 34);
            this.PictMenu.Name = "PictMenu";
            this.PictMenu.Size = new System.Drawing.Size(48, 48);
            this.PictMenu.TabIndex = 10;
            this.PictMenu.TabStop = false;
            this.PictMenu.Click += new System.EventHandler(this.MenuBtn_Click);
            this.PictMenu.MouseEnter += new System.EventHandler(this.MenuBtn_MouseEnter);
            // 
            // BtnOpenBooks
            // 
            this.BtnOpenBooks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOpenBooks.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnOpenBooks.ForeColor = System.Drawing.Color.White;
            this.BtnOpenBooks.Image = global::online_library_for_educ_inst.Properties.Resources.IcoOpenBook;
            this.BtnOpenBooks.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnOpenBooks.Location = new System.Drawing.Point(0, 9);
            this.BtnOpenBooks.Name = "BtnOpenBooks";
            this.BtnOpenBooks.Size = new System.Drawing.Size(224, 58);
            this.BtnOpenBooks.TabIndex = 4;
            this.BtnOpenBooks.Text = "показать книги...";
            this.BtnOpenBooks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnOpenBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnOpenBooks.UseVisualStyleBackColor = true;
            this.BtnOpenBooks.Visible = false;
            this.BtnOpenBooks.Click += new System.EventHandler(this.BtnOpenBook_Click);
            this.BtnOpenBooks.MouseEnter += new System.EventHandler(this.BtnOpenBooks_MouseEnter);
            this.BtnOpenBooks.MouseLeave += new System.EventHandler(this.BtnOpenBooks_MouseLeave);
            // 
            // BtnUserProfile
            // 
            this.BtnUserProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnUserProfile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnUserProfile.ForeColor = System.Drawing.Color.White;
            this.BtnUserProfile.Image = global::online_library_for_educ_inst.Properties.Resources.ShowMaleProfile;
            this.BtnUserProfile.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnUserProfile.Location = new System.Drawing.Point(-5, 137);
            this.BtnUserProfile.Name = "BtnUserProfile";
            this.BtnUserProfile.Size = new System.Drawing.Size(227, 58);
            this.BtnUserProfile.TabIndex = 5;
            this.BtnUserProfile.Text = "открыть профиль...";
            this.BtnUserProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUserProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnUserProfile.UseVisualStyleBackColor = true;
            this.BtnUserProfile.Visible = false;
            this.BtnUserProfile.Click += new System.EventHandler(this.BtnUserProfile_Click);
            this.BtnUserProfile.MouseEnter += new System.EventHandler(this.BtnUserProfile_MouseEnter);
            this.BtnUserProfile.MouseLeave += new System.EventHandler(this.BtnUserProfile_MouseLeave);
            // 
            // BtnShowSub
            // 
            this.BtnShowSub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShowSub.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnShowSub.ForeColor = System.Drawing.Color.White;
            this.BtnShowSub.Image = global::online_library_for_educ_inst.Properties.Resources.IcoSubscrtiption;
            this.BtnShowSub.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnShowSub.Location = new System.Drawing.Point(-3, 73);
            this.BtnShowSub.Name = "BtnShowSub";
            this.BtnShowSub.Size = new System.Drawing.Size(227, 58);
            this.BtnShowSub.TabIndex = 10;
            this.BtnShowSub.Text = "перейти к подпискам...";
            this.BtnShowSub.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnShowSub.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnShowSub.UseVisualStyleBackColor = true;
            this.BtnShowSub.Visible = false;
            this.BtnShowSub.Click += new System.EventHandler(this.BtnShowSub_Click);
            this.BtnShowSub.MouseEnter += new System.EventHandler(this.BtnShowSub_MouseEnter);
            this.BtnShowSub.MouseLeave += new System.EventHandler(this.BtnShowSub_MouseLeave);
            // 
            // BtnReturnBack
            // 
            this.BtnReturnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReturnBack.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.BtnReturnBack.ForeColor = System.Drawing.Color.White;
            this.BtnReturnBack.Image = global::online_library_for_educ_inst.Properties.Resources.GifBackForm;
            this.BtnReturnBack.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnReturnBack.Location = new System.Drawing.Point(0, 261);
            this.BtnReturnBack.Name = "BtnReturnBack";
            this.BtnReturnBack.Size = new System.Drawing.Size(227, 58);
            this.BtnReturnBack.TabIndex = 10;
            this.BtnReturnBack.Text = "к стартовой форме...";
            this.BtnReturnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnReturnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnReturnBack.UseVisualStyleBackColor = true;
            this.BtnReturnBack.Visible = false;
            this.BtnReturnBack.Click += new System.EventHandler(this.BtnReturnBack_Click);
            this.BtnReturnBack.MouseEnter += new System.EventHandler(this.BtnReturnBack_MouseEnter);
            this.BtnReturnBack.MouseLeave += new System.EventHandler(this.BtnReturnBack_MouseLeave);
            // 
            // BtnExitApp
            // 
            this.BtnExitApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExitApp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnExitApp.ForeColor = System.Drawing.Color.White;
            this.BtnExitApp.Image = global::online_library_for_educ_inst.Properties.Resources.ExitAppGif;
            this.BtnExitApp.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnExitApp.Location = new System.Drawing.Point(-3, 325);
            this.BtnExitApp.Name = "BtnExitApp";
            this.BtnExitApp.Size = new System.Drawing.Size(227, 58);
            this.BtnExitApp.TabIndex = 7;
            this.BtnExitApp.Text = "выйти c программы...";
            this.BtnExitApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExitApp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExitApp.UseVisualStyleBackColor = true;
            this.BtnExitApp.Visible = false;
            this.BtnExitApp.Click += new System.EventHandler(this.BtnExitApp_Click);
            this.BtnExitApp.MouseEnter += new System.EventHandler(this.BtnExitApp_MouseEnter);
            this.BtnExitApp.MouseLeave += new System.EventHandler(this.BtnExitApp_MouseLeave);
            // 
            // BtnSettings
            // 
            this.BtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSettings.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnSettings.ForeColor = System.Drawing.Color.White;
            this.BtnSettings.Image = global::online_library_for_educ_inst.Properties.Resources.GifGears;
            this.BtnSettings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnSettings.Location = new System.Drawing.Point(0, 201);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(224, 54);
            this.BtnSettings.TabIndex = 6;
            this.BtnSettings.Text = "открыть настройки...";
            this.BtnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Visible = false;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            this.BtnSettings.MouseEnter += new System.EventHandler(this.BtnSettings_MouseEnter);
            this.BtnSettings.MouseLeave += new System.EventHandler(this.BtnSettings_MouseLeave);
            // 
            // PictLogoApp
            // 
            this.PictLogoApp.Image = global::online_library_for_educ_inst.Properties.Resources.loading_screen__png_;
            this.PictLogoApp.Location = new System.Drawing.Point(280, 63);
            this.PictLogoApp.Name = "PictLogoApp";
            this.PictLogoApp.Size = new System.Drawing.Size(512, 512);
            this.PictLogoApp.TabIndex = 0;
            this.PictLogoApp.TabStop = false;
            // 
            // MainFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 678);
            this.ControlBox = false;
            this.Controls.Add(this.PictSub);
            this.Controls.Add(this.TopComponentTile);
            this.Controls.Add(this.SideBarPanel);
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.PictLogoApp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(950, 678);
            this.MinimumSize = new System.Drawing.Size(950, 678);
            this.Name = "MainFormApp";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Activated += new System.EventHandler(this.MainFormApp_Activated);
            this.Load += new System.EventHandler(this.MainFormApp_Load);
            this.SideBarPanel.ResumeLayout(false);
            this.SecondPanel.ResumeLayout(false);
            this.SecondPanel.PerformLayout();
            this.ThirdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictLogoApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox PictLogoApp;
        public System.Windows.Forms.Button BtnOpenBooks;
        public System.Windows.Forms.Button BtnUserProfile;
        public System.Windows.Forms.Button BtnSettings;
        public System.Windows.Forms.Button BtnExitApp;
        public System.Windows.Forms.FlowLayoutPanel SideBarPanel;
        public System.Windows.Forms.Panel SecondPanel;
        public System.Windows.Forms.PictureBox PictMenu;
        public MetroFramework.Controls.MetroLabel LblMenuText;
        public System.Windows.Forms.Panel ThirdPanel;
        public System.Windows.Forms.Timer TimerToAnimationForm;
        public MetroFramework.Controls.MetroTile TopComponentTile;
        public MetroFramework.Controls.MetroTile LowerComponentTile;
        public System.Windows.Forms.Button BtnReturnBack;
        public System.Windows.Forms.Button BtnShowSub;
        public MetroFramework.Components.MetroToolTip ToolTipHelpUser;
        public System.Windows.Forms.PictureBox PictSub;
    }
}