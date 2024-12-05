using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Diagnostics;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using System.Drawing.Drawing2D;
using online_library_for_educ_inst;


namespace modal
{
    public partial class FrmModalForm : Form
    {
        #region /// to determine objects in fields for CustomLibraryClass
        public static Label FRM_modalForm_lbl_msg_for_user;
        public static Label FRM_modalForm_lbl_text_message;
        public static Label FRM_modalForm_lbl_load_progress;
        public static PictureBox FRM_modalForm_logo;
        public static PictureBox FRM_modalForm_PictLogo_Form;
        public static RichTextBox FRM_modalForm_richtxt_license_agreement;
        public static MetroFramework.Controls.MetroCheckBox FRM_modalForm_mchckbox_confirm_read_license_agreement;
        public static MetroFramework.Controls.MetroButton FRM_Btn_Cancel;
        public static MetroFramework.Controls.MetroButton FRM_Btn_OK;
        public static MetroFramework.Controls.MetroButton FRM_Btn_Exit_App;
        public static MetroFramework.Controls.MetroButton FRM_Btn_Res_App;
        public static MetroFramework.Controls.MetroButton FRM_Btn_Buy_Sub;
        int iParentX, iParentY;
        #endregion

        public FrmModalForm()
        {
            InitializeComponent();
            #region /// assign objects to determine fields
            FRM_modalForm_lbl_msg_for_user = LblMsgForUser;
            FRM_modalForm_lbl_text_message = LblTextMessage;
            FRM_modalForm_lbl_load_progress = LblLoadProgress;
            FRM_modalForm_logo = PictMainLogo;
            FRM_modalForm_PictLogo_Form = PictLogoForm;
            FRM_modalForm_richtxt_license_agreement = RTxtBoxLicenseAgreement;
            FRM_modalForm_mchckbox_confirm_read_license_agreement = MChckBoxConfirmReadLicenseAgreement;
            FRM_Btn_Cancel = BtnCancel;
            FRM_Btn_OK = BtnOK;  
            FRM_Btn_Exit_App = BtnExitApp;
            FRM_Btn_Res_App = BtnRestartApp;
            FRM_Btn_Buy_Sub = BtnBuySub;
            #endregion

        }

        private void GetRoundedShape()
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            this.Region = new Region(path);
        }

        private void modalEffect_Timer_Tick(object sender, EventArgs e)
        {
            int w = ClientSize.Width;
            int h = ClientSize.Height;

            if (Opacity >= 1)
            {
                TmodalEffect_Timer.Stop();
            }
            else {
                Opacity += .20;
            }

            int y = Form1.parentY += 0; //INCREMENT
            this.Location = new Point((w / 2), (h / 2) );
            if (y >= i) {
                TmodalEffect_Timer.Stop();
            }
        }
        int i;
        private void modalForm_Load(object sender, EventArgs e)
        {
            #region//// Transparent Component
            LblMsgForUser.Parent = PictBackgroundGif;

            LblMsgForUser.BackColor = Color.Transparent;

            LblTextMessage.Parent = PictBackgroundGif;

            LblTextMessage.BackColor = Color.Transparent;

            LblLoadProgress.Parent = PictBackgroundGif;

            LblLoadProgress.BackColor = Color.Transparent;

            PictMainLogo.Parent = PictBackgroundGif;

            PictMainLogo.BackColor = Color.Transparent;

            PictLogoForm.Parent = PictBackgroundGif;

            PictLogoForm.BackColor = Color.Transparent;
            #endregion

            GetRoundedShape();

            i = Form1.parentY + 150;
            Location = new Point(Form1.parentX + 0, Form1.parentY + 0);
            LowerComponentTile.Text = "Окно уведомления для пользователя " + string.Format("({0})", CustomClass.sSysUserName);

            CustomClass.isBtnOkClicked = false;
            MChckBoxConfirmReadLicenseAgreement.Checked = false;

            if (CustomClass.isOpenedChooseRoleForm)
            {
                PictMainLogo.Image = Properties.Resources.FormGif;
            }

            if (MChckBoxConfirmReadLicenseAgreement.Checked)
            {
                MChckBoxConfirmReadLicenseAgreement.ForeColor = Color.ForestGreen;
            }

            if (CustomClass.bUserWantCloseApp)
            {
               PictMainLogo.Image = Properties.Resources.icon_close_app_256x256_png_;
               PictMainLogo.BackgroundImage= Properties.Resources.icon_close_app_256x256_png_;
            }

            if (CustomClass.isLoadAdminRole) 
            {
                PictMainLogo.Image = Properties.Resources.database_256x256;
                TLoadAccessProcess_Timer.Enabled = true;       
            }

            if (CustomClass.isLoadAccount)
                LowerComponentTile.Text = "Окно уведомления для пользователя " + string.Format("({0})", CustomClass.sNickNameNewUser);
        }
        private void AnimationCloseForm()
        {
            for (int i = 0; i < CustomClass.MAX_UNIT_OPACITY; i++)
            {
                Thread.Sleep(((int)CustomClass.enmTimeToClose.Form));
                Opacity -= CustomClass.UNIT_TRANSPARENCY;
            }
            Close();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            AnimationCloseForm();
            CustomClass.bUserWantCloseApp = false;
            CustomClass.bUserWantResApp = false;
            CustomClass.bWantSubToMonth = false;
            CustomClass.bWantSubArtistic = false;
            CustomClass.bWantSubScientific = false;

        }

        private void BtnRestartApp_Click(object sender, EventArgs e)
        {
            CustomClass.bUserWantResApp = true;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            AnimationCloseForm();
            Application.Restart();
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());

            if (CustomClass.bUserWantCloseApp)
            {
                AnimationCloseForm();
                CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClose.ToString());
                GC.Collect();
            }
        }

        private void BtnOK_Click (object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());

            if (CustomClass.isOpenedChooseRoleForm)
            {
                AnimationCloseForm();
                CustomClass.isOpenedWelcomeForm = true;
                Dispose();
            }
      
            if (CustomClass.isOpenedFormRegistration)
            {

                if (MChckBoxConfirmReadLicenseAgreement.Checked == false)
                {
                    CustomClass.Alert("Подтвердите,что вы прочитали лицензионное соглашение", Form_Alert.enmType.Info);
                }
                else if (MChckBoxConfirmReadLicenseAgreement.Checked)
                {
                    AnimationCloseForm();
                    CustomClass.isOpenedWelcomeForm = true;
                    CustomClass.isOpenedFormRegistration = true;
                    CustomClass.isRegistrationIsBeingCompleted = true;
                    CustomClass.isBtnOkClicked = true;
                }
                Dispose();
            }
        }

        private void BtnBuySub_Click(object sender, EventArgs e)
        {
            
            Form modalBackground = new Form();
            using (FrmPass frm = new FrmPass())
            {
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = Size;
                modalBackground.Location = this.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                iParentX = this.Location.X;
                iParentY = this.Location.Y;

                frm.ShowDialog();
                modalBackground.Dispose();

            }
        }

        private void MChckBoxConfirmReadLicenseAgreement_MouseEnter(object sender, EventArgs e)
        {
            MChckBoxConfirmReadLicenseAgreement.ForeColor = Color.ForestGreen;
        }

        private void MChckBoxConfirmReadLicenseAgreement_MouseLeave(object sender, EventArgs e)
        {
            MChckBoxConfirmReadLicenseAgreement.ForeColor =Color.White;

            if (MChckBoxConfirmReadLicenseAgreement.Checked)
            {
                MChckBoxConfirmReadLicenseAgreement.ForeColor = Color.ForestGreen;
            }
            else
            {
                MChckBoxConfirmReadLicenseAgreement.ForeColor = Color.White;
            }
        }

        private void MChckBoxConfirmReadLicenseAgreement_CheckedChanged(object sender, EventArgs e)
        {
            //CustomLibraryClass.CustomClass.PlaySoundForMessageBox();
        }

        private void loadAccessProcess_Timer_Tick(object sender, EventArgs e)
        {
            TLoadAccessProcess_Timer.Interval += 1;
            LblLoadProgress.Text = TLoadAccessProcess_Timer.Interval.ToString() + "%";
            
            if (TLoadAccessProcess_Timer.Interval == 100)
            {
                TLoadAccessProcess_Timer.Enabled = false;
                Dispose();
                Process.Start("DB_for_online_library.accdb");
            }  
        }

        private void FrmModalForm_Activated(object sender, EventArgs e)
        {
            if (CustomClass.bUserWantSub)
                Close();
        }

        private void FrmModalForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
        }

        
    }
    }

