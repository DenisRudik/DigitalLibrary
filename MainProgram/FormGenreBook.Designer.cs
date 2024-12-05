namespace online_library_for_educ_inst
{
    partial class FmFormGenreBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmFormGenreBook));
            this.TopComponentTile = new MetroFramework.Controls.MetroTile();
            this.LowerComponentTile = new MetroFramework.Controls.MetroTile();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.ToolTipHelpUser = new MetroFramework.Components.MetroToolTip();
            this.mComBoxGenreNovel = new MetroFramework.Controls.MetroComboBox();
            this.LblTopText = new System.Windows.Forms.Label();
            this.LblForNovel = new System.Windows.Forms.Label();
            this.LblTextArtisticSub = new System.Windows.Forms.Label();
            this.LblForStory = new System.Windows.Forms.Label();
            this.mComBoxGenreStory = new MetroFramework.Controls.MetroComboBox();
            this.LblForPoem = new System.Windows.Forms.Label();
            this.mComBoxGenrePoem = new MetroFramework.Controls.MetroComboBox();
            this.LblForHorrors = new System.Windows.Forms.Label();
            this.mComBoxGenreHorrors = new MetroFramework.Controls.MetroComboBox();
            this.PictSub = new System.Windows.Forms.PictureBox();
            this.PictCloseForm = new System.Windows.Forms.PictureBox();
            this.PictSeparator = new System.Windows.Forms.PictureBox();
            this.LblTextScientificSub = new System.Windows.Forms.Label();
            this.LblForBooks = new System.Windows.Forms.Label();
            this.mComBoxGenreBooks = new MetroFramework.Controls.MetroComboBox();
            this.LblForArticle = new System.Windows.Forms.Label();
            this.mComBoxGenreArticle = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictSeparator)).BeginInit();
            this.SuspendLayout();
            // 
            // TopComponentTile
            // 
            this.TopComponentTile.CustomForeColor = true;
            this.TopComponentTile.Location = new System.Drawing.Point(-2, 2);
            this.TopComponentTile.Name = "TopComponentTile";
            this.TopComponentTile.Size = new System.Drawing.Size(892, 27);
            this.TopComponentTile.TabIndex = 3;
            this.TopComponentTile.Text = "Цифровая настольная библиотека";
            this.TopComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TopComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // LowerComponentTile
            // 
            this.LowerComponentTile.CustomForeColor = true;
            this.LowerComponentTile.Location = new System.Drawing.Point(-2, 412);
            this.LowerComponentTile.Name = "LowerComponentTile";
            this.LowerComponentTile.Size = new System.Drawing.Size(892, 27);
            this.LowerComponentTile.TabIndex = 4;
            this.LowerComponentTile.Text = "metroTile1";
            this.LowerComponentTile.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.LowerComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.LowerComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            // 
            // TimerToAnimationForm
            // 
            this.TimerToAnimationForm.Enabled = true;
            this.TimerToAnimationForm.Interval = 1;
            this.TimerToAnimationForm.Tick += new System.EventHandler(this.TimerToAnimationForm_Tick);
            // 
            // mComBoxGenreNovel
            // 
            this.mComBoxGenreNovel.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mComBoxGenreNovel.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.mComBoxGenreNovel.FormattingEnabled = true;
            this.mComBoxGenreNovel.ItemHeight = 29;
            this.mComBoxGenreNovel.Location = new System.Drawing.Point(8, 182);
            this.mComBoxGenreNovel.Name = "mComBoxGenreNovel";
            this.mComBoxGenreNovel.Size = new System.Drawing.Size(200, 35);
            this.mComBoxGenreNovel.TabIndex = 14;
            this.mComBoxGenreNovel.SelectedIndexChanged += new System.EventHandler(this.mComBoxGenre_SelectedIndexChanged);
            this.mComBoxGenreNovel.MouseEnter += new System.EventHandler(this.mComBoxGenreNovel_MouseEnter);
            this.mComBoxGenreNovel.MouseLeave += new System.EventHandler(this.mComBoxGenreNovel_MouseLeave);
            // 
            // LblTopText
            // 
            this.LblTopText.AutoSize = true;
            this.LblTopText.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTopText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LblTopText.Location = new System.Drawing.Point(52, 44);
            this.LblTopText.Name = "LblTopText";
            this.LblTopText.Size = new System.Drawing.Size(138, 32);
            this.LblTopText.TabIndex = 15;
            this.LblTopText.Text = "LblTopText";
            // 
            // LblForNovel
            // 
            this.LblForNovel.AutoSize = true;
            this.LblForNovel.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblForNovel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblForNovel.Location = new System.Drawing.Point(3, 143);
            this.LblForNovel.Name = "LblForNovel";
            this.LblForNovel.Size = new System.Drawing.Size(147, 25);
            this.LblForNovel.TabIndex = 16;
            this.LblForNovel.Text = "Жанр \"Роман\"";
            // 
            // LblTextArtisticSub
            // 
            this.LblTextArtisticSub.AutoSize = true;
            this.LblTextArtisticSub.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTextArtisticSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LblTextArtisticSub.Location = new System.Drawing.Point(3, 108);
            this.LblTextArtisticSub.Name = "LblTextArtisticSub";
            this.LblTextArtisticSub.Size = new System.Drawing.Size(335, 25);
            this.LblTextArtisticSub.TabIndex = 17;
            this.LblTextArtisticSub.Text = "Художественная литература...";
            // 
            // LblForStory
            // 
            this.LblForStory.AutoSize = true;
            this.LblForStory.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblForStory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblForStory.Location = new System.Drawing.Point(3, 242);
            this.LblForStory.Name = "LblForStory";
            this.LblForStory.Size = new System.Drawing.Size(168, 25);
            this.LblForStory.TabIndex = 18;
            this.LblForStory.Text = "Жанр \"Повесть\"";
            // 
            // mComBoxGenreStory
            // 
            this.mComBoxGenreStory.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mComBoxGenreStory.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.mComBoxGenreStory.FormattingEnabled = true;
            this.mComBoxGenreStory.ItemHeight = 29;
            this.mComBoxGenreStory.Location = new System.Drawing.Point(8, 279);
            this.mComBoxGenreStory.Name = "mComBoxGenreStory";
            this.mComBoxGenreStory.Size = new System.Drawing.Size(200, 35);
            this.mComBoxGenreStory.TabIndex = 19;
            this.mComBoxGenreStory.SelectedIndexChanged += new System.EventHandler(this.mComBoxGenreStory_SelectedIndexChanged);
            this.mComBoxGenreStory.MouseEnter += new System.EventHandler(this.mComBoxGenreStory_MouseEnter);
            this.mComBoxGenreStory.MouseLeave += new System.EventHandler(this.mComBoxGenreStory_MouseLeave);
            // 
            // LblForPoem
            // 
            this.LblForPoem.AutoSize = true;
            this.LblForPoem.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblForPoem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblForPoem.Location = new System.Drawing.Point(224, 143);
            this.LblForPoem.Name = "LblForPoem";
            this.LblForPoem.Size = new System.Drawing.Size(146, 25);
            this.LblForPoem.TabIndex = 20;
            this.LblForPoem.Text = "Жанр \"Поэма\"";
            // 
            // mComBoxGenrePoem
            // 
            this.mComBoxGenrePoem.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mComBoxGenrePoem.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.mComBoxGenrePoem.FormattingEnabled = true;
            this.mComBoxGenrePoem.ItemHeight = 29;
            this.mComBoxGenrePoem.Location = new System.Drawing.Point(227, 182);
            this.mComBoxGenrePoem.Name = "mComBoxGenrePoem";
            this.mComBoxGenrePoem.Size = new System.Drawing.Size(200, 35);
            this.mComBoxGenrePoem.TabIndex = 21;
            this.mComBoxGenrePoem.SelectedIndexChanged += new System.EventHandler(this.mComBoxGenrePoem_SelectedIndexChanged);
            this.mComBoxGenrePoem.MouseEnter += new System.EventHandler(this.mComBoxGenrePoem_MouseEnter);
            this.mComBoxGenrePoem.MouseLeave += new System.EventHandler(this.mComBoxGenrePoem_MouseLeave);
            // 
            // LblForHorrors
            // 
            this.LblForHorrors.AutoSize = true;
            this.LblForHorrors.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblForHorrors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblForHorrors.Location = new System.Drawing.Point(224, 242);
            this.LblForHorrors.Name = "LblForHorrors";
            this.LblForHorrors.Size = new System.Drawing.Size(148, 25);
            this.LblForHorrors.TabIndex = 22;
            this.LblForHorrors.Text = "Жанр \"Ужасы\"";
            // 
            // mComBoxGenreHorrors
            // 
            this.mComBoxGenreHorrors.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mComBoxGenreHorrors.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.mComBoxGenreHorrors.FormattingEnabled = true;
            this.mComBoxGenreHorrors.ItemHeight = 29;
            this.mComBoxGenreHorrors.Location = new System.Drawing.Point(227, 279);
            this.mComBoxGenreHorrors.Name = "mComBoxGenreHorrors";
            this.mComBoxGenreHorrors.Size = new System.Drawing.Size(200, 35);
            this.mComBoxGenreHorrors.TabIndex = 23;
            this.mComBoxGenreHorrors.SelectedIndexChanged += new System.EventHandler(this.mComBoxGenreHorrors_SelectedIndexChanged);
            this.mComBoxGenreHorrors.MouseEnter += new System.EventHandler(this.mComBoxGenreHorrors_MouseEnter);
            this.mComBoxGenreHorrors.MouseLeave += new System.EventHandler(this.mComBoxGenreHorrors_MouseLeave);
            // 
            // PictSub
            // 
            this.PictSub.Location = new System.Drawing.Point(826, 35);
            this.PictSub.Name = "PictSub";
            this.PictSub.Size = new System.Drawing.Size(64, 64);
            this.PictSub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictSub.TabIndex = 13;
            this.PictSub.TabStop = false;
            this.PictSub.MouseEnter += new System.EventHandler(this.PictSub_MouseEnter);
            // 
            // PictCloseForm
            // 
            this.PictCloseForm.Image = global::online_library_for_educ_inst.Properties.Resources.GifBackForm;
            this.PictCloseForm.Location = new System.Drawing.Point(-2, 44);
            this.PictCloseForm.Name = "PictCloseForm";
            this.PictCloseForm.Size = new System.Drawing.Size(48, 48);
            this.PictCloseForm.TabIndex = 7;
            this.PictCloseForm.TabStop = false;
            this.PictCloseForm.Click += new System.EventHandler(this.PictCloseForm_Click);
            this.PictCloseForm.MouseEnter += new System.EventHandler(this.PictCloseForm_MouseEnter);
            // 
            // PictSeparator
            // 
            this.PictSeparator.BackColor = System.Drawing.Color.Transparent;
            this.PictSeparator.Image = global::online_library_for_educ_inst.Properties.Resources.Separator;
            this.PictSeparator.Location = new System.Drawing.Point(433, 83);
            this.PictSeparator.Name = "PictSeparator";
            this.PictSeparator.Size = new System.Drawing.Size(188, 304);
            this.PictSeparator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictSeparator.TabIndex = 24;
            this.PictSeparator.TabStop = false;
            // 
            // LblTextScientificSub
            // 
            this.LblTextScientificSub.AutoSize = true;
            this.LblTextScientificSub.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LblTextScientificSub.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.LblTextScientificSub.Location = new System.Drawing.Point(622, 108);
            this.LblTextScientificSub.Name = "LblTextScientificSub";
            this.LblTextScientificSub.Size = new System.Drawing.Size(251, 25);
            this.LblTextScientificSub.TabIndex = 25;
            this.LblTextScientificSub.Text = "Научная литература...";
            // 
            // LblForBooks
            // 
            this.LblForBooks.AutoSize = true;
            this.LblForBooks.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblForBooks.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblForBooks.Location = new System.Drawing.Point(622, 154);
            this.LblForBooks.Name = "LblForBooks";
            this.LblForBooks.Size = new System.Drawing.Size(101, 25);
            this.LblForBooks.TabIndex = 26;
            this.LblForBooks.Text = "Учебники";
            // 
            // mComBoxGenreBooks
            // 
            this.mComBoxGenreBooks.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mComBoxGenreBooks.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.mComBoxGenreBooks.FormattingEnabled = true;
            this.mComBoxGenreBooks.ItemHeight = 29;
            this.mComBoxGenreBooks.Location = new System.Drawing.Point(627, 182);
            this.mComBoxGenreBooks.Name = "mComBoxGenreBooks";
            this.mComBoxGenreBooks.Size = new System.Drawing.Size(251, 35);
            this.mComBoxGenreBooks.TabIndex = 27;
            this.mComBoxGenreBooks.SelectedIndexChanged += new System.EventHandler(this.mComBoxGenreBooks_SelectedIndexChanged);
            this.mComBoxGenreBooks.MouseEnter += new System.EventHandler(this.mComBoxGenreBooks_MouseEnter);
            this.mComBoxGenreBooks.MouseLeave += new System.EventHandler(this.mComBoxGenreBooks_MouseLeave);
            // 
            // LblForArticle
            // 
            this.LblForArticle.AutoSize = true;
            this.LblForArticle.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.LblForArticle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblForArticle.Location = new System.Drawing.Point(622, 251);
            this.LblForArticle.Name = "LblForArticle";
            this.LblForArticle.Size = new System.Drawing.Size(91, 25);
            this.LblForArticle.TabIndex = 28;
            this.LblForArticle.Text = "Статьи";
            // 
            // mComBoxGenreArticle
            // 
            this.mComBoxGenreArticle.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.mComBoxGenreArticle.FontWeight = MetroFramework.MetroLinkWeight.Bold;
            this.mComBoxGenreArticle.FormattingEnabled = true;
            this.mComBoxGenreArticle.ItemHeight = 29;
            this.mComBoxGenreArticle.Location = new System.Drawing.Point(627, 279);
            this.mComBoxGenreArticle.Name = "mComBoxGenreArticle";
            this.mComBoxGenreArticle.Size = new System.Drawing.Size(251, 35);
            this.mComBoxGenreArticle.TabIndex = 29;
            this.mComBoxGenreArticle.SelectedIndexChanged += new System.EventHandler(this.mComBoxGenreArticle_SelectedIndexChanged);
            this.mComBoxGenreArticle.MouseEnter += new System.EventHandler(this.mComBoxGenreArticle_MouseEnter);
            this.mComBoxGenreArticle.MouseLeave += new System.EventHandler(this.mComBoxGenreArticle_MouseLeave);
            // 
            // FormGenreBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 438);
            this.Controls.Add(this.mComBoxGenreArticle);
            this.Controls.Add(this.LblForArticle);
            this.Controls.Add(this.mComBoxGenreBooks);
            this.Controls.Add(this.LblForBooks);
            this.Controls.Add(this.LblTextScientificSub);
            this.Controls.Add(this.PictSeparator);
            this.Controls.Add(this.mComBoxGenreHorrors);
            this.Controls.Add(this.LblForHorrors);
            this.Controls.Add(this.mComBoxGenrePoem);
            this.Controls.Add(this.LblForPoem);
            this.Controls.Add(this.mComBoxGenreStory);
            this.Controls.Add(this.LblForStory);
            this.Controls.Add(this.LblTextArtisticSub);
            this.Controls.Add(this.LblForNovel);
            this.Controls.Add(this.LblTopText);
            this.Controls.Add(this.mComBoxGenreNovel);
            this.Controls.Add(this.PictSub);
            this.Controls.Add(this.PictCloseForm);
            this.Controls.Add(this.LowerComponentTile);
            this.Controls.Add(this.TopComponentTile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(888, 438);
            this.MinimumSize = new System.Drawing.Size(888, 438);
            this.Name = "FormGenreBook";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.SelectBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictSeparator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public MetroFramework.Controls.MetroTile TopComponentTile;
        public MetroFramework.Controls.MetroTile LowerComponentTile;
        public System.Windows.Forms.Timer TimerToAnimationForm;
        public MetroFramework.Components.MetroToolTip ToolTipHelpUser;
        public System.Windows.Forms.PictureBox PictCloseForm;
        public System.Windows.Forms.PictureBox PictSub;
        public MetroFramework.Controls.MetroComboBox mComBoxGenreNovel;
        public System.Windows.Forms.Label LblTopText;
        public System.Windows.Forms.Label LblForNovel;
        public System.Windows.Forms.Label LblTextArtisticSub;
        public System.Windows.Forms.Label LblForStory;
        public MetroFramework.Controls.MetroComboBox mComBoxGenreStory;
        public System.Windows.Forms.Label LblForPoem;
        public MetroFramework.Controls.MetroComboBox mComBoxGenrePoem;
        public System.Windows.Forms.Label LblForHorrors;
        public MetroFramework.Controls.MetroComboBox mComBoxGenreHorrors;
        public System.Windows.Forms.PictureBox PictSeparator;
        public System.Windows.Forms.Label LblTextScientificSub;
        public System.Windows.Forms.Label LblForBooks;
        public MetroFramework.Controls.MetroComboBox mComBoxGenreBooks;
        public System.Windows.Forms.Label LblForArticle;
        public MetroFramework.Controls.MetroComboBox mComBoxGenreArticle;
    }
}