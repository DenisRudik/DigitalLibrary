namespace online_library_for_educ_inst
{
    partial class FrmPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPass));
            this.TxtPass = new MetroFramework.Controls.MetroTextBox();
            this.BtnOK = new MetroFramework.Controls.MetroButton();
            this.TimerToAnimationForm = new System.Windows.Forms.Timer(this.components);
            this.TopComponentTile = new MetroFramework.Controls.MetroTile();
            this.BtnCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // TxtPass
            // 
            this.TxtPass.BackColor = System.Drawing.Color.Black;
            this.TxtPass.CustomBackground = true;
            this.TxtPass.CustomForeColor = true;
            this.TxtPass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtPass.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.TxtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.TxtPass.Location = new System.Drawing.Point(23, 63);
            this.TxtPass.MaxLength = 7;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(297, 23);
            this.TxtPass.TabIndex = 1;
            this.TxtPass.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // BtnOK
            // 
            this.BtnOK.Location = new System.Drawing.Point(284, 119);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.Style = MetroFramework.MetroColorStyle.White;
            this.BtnOK.TabIndex = 2;
            this.BtnOK.Text = "OK";
            this.BtnOK.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // TimerToAnimationForm
            // 
            this.TimerToAnimationForm.Enabled = true;
            this.TimerToAnimationForm.Interval = 1;
            this.TimerToAnimationForm.Tick += new System.EventHandler(this.TimerToAnimationForm_Tick);
            // 
            // TopComponentTile
            // 
            this.TopComponentTile.Location = new System.Drawing.Point(0, 4);
            this.TopComponentTile.Name = "TopComponentTile";
            this.TopComponentTile.Size = new System.Drawing.Size(359, 25);
            this.TopComponentTile.TabIndex = 3;
            this.TopComponentTile.Text = "Цифровая настольная библиотека";
            this.TopComponentTile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.TopComponentTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(0, 119);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.Style = MetroFramework.MetroColorStyle.Red;
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "закрыть";
            this.BtnCancel.Theme = MetroFramework.MetroThemeStyle.Light;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // FrmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 142);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TopComponentTile);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.TxtPass);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(359, 142);
            this.MinimumSize = new System.Drawing.Size(359, 142);
            this.Name = "FrmPass";
            this.Opacity = 0D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Введите пароль от аккаунта:";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_password_FormClosing);
            this.Load += new System.EventHandler(this.FrmPass_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox TxtPass;
        private MetroFramework.Controls.MetroButton BtnOK;
        private System.Windows.Forms.Timer TimerToAnimationForm;
        private MetroFramework.Controls.MetroTile TopComponentTile;
        private MetroFramework.Controls.MetroButton BtnCancel;
    }
}