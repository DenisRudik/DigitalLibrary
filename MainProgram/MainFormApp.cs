using System;
using System.Drawing;
using CustomAlertBoxDemo;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{
    public partial class FmMainFormApp : MetroFramework.Forms.MetroForm
    {
        public FmMainFormApp()
        {
            InitializeComponent();

            CustomClass.bSidebarStretch = true;

            MainFormAppClass.GetPictureLogoLocation(this);   
        }

        private void MainFormApp_Load(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundStartApp.ToString());

            CustomClass.bSidebarStretch = false;

            CustomClass.isOpenedChooseRoleForm = false;

            CustomClass.GetRoundedShapeForm(this);

            CenterToScreen();

            MainFormAppClass.GetBalanceDataUser();

            MainFormAppClass.GetSexDataUser(this);

            MainFormAppClass.GetShowStartMessage();

            MainFormAppClass.GetLowerComponentTile(this);

            MainFormAppClass.CallUpdateDataUser();
        }

        private void PictSub_MouseEnter(object sender, EventArgs e)
        {
            MainFormAppClass.CallOnMouseEnterPictSub(this);
        }

        private void MainFormApp_Activated(object sender, EventArgs e)
        {
            MainFormAppClass.CallUpdateDataUser();

            MainFormAppClass.GetLowerComponentTile(this);

            MainFormAppClass.GetCurrentSubscription(this);
        }

         
        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this, TimerToAnimationForm);
        }
    
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            MainFormAppClass.CallAnimationSideBar(this);

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        }

        private void MenuBtn_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            MainFormAppClass.CallOnMouseEnterMenuBtn(this); 

        }

        private void BtnOpenBook_Click(object sender, EventArgs e)
        {
            MainFormAppClass.CallFormAvailableSub(this);    

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        }

        private void BtnOpenBooks_MouseEnter(object sender, EventArgs e)
        {
            MainFormAppClass.CallOnMouseEnterBtnOpenBooks(this);
        }

        private void BtnOpenBooks_MouseLeave(object sender, EventArgs e)
        {
            BtnOpenBooks.ForeColor = Color.White;
        }

        private void BtnUserProfile_Click(object sender, EventArgs e)
        {
            MainFormAppClass.CallFormUserProfile(this);
        }

        private void BtnUserProfile_MouseEnter(object sender, EventArgs e)
        {
            MainFormAppClass.CallOnMouseEnterBtnUserProfile(this);
        }

        private void BtnUserProfile_MouseLeave(object sender, EventArgs e)
        {
            BtnUserProfile.ForeColor = Color.White;
        }

        private void BtnExitApp_Click(object sender, EventArgs e)
        {
            MainFormAppClass.CallFormExitApplication(this);
        }

        private void BtnExitApp_MouseEnter(object sender, EventArgs e)
        {
            MainFormAppClass.CallOnMouseEnterBtnExitApp(this);
        }

        private void BtnExitApp_MouseLeave(object sender, EventArgs e)
        {
            BtnExitApp.ForeColor = Color.White;
        }

        private void BtnShowSub_Click(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            MainFormAppClass.GetCheckSubscriptionUser(this);
        }

        private void BtnShowSub_MouseEnter(object sender, EventArgs e)
        {
            MainFormAppClass.CallOnMouseEnterBtnShowSub(this); 
        }

        private void BtnShowSub_MouseLeave(object sender, EventArgs e)
        {
            BtnShowSub.ForeColor = Color.White;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            MainFormAppClass.CallFormSettingsApplication(this);
        }

        private void BtnSettings_MouseEnter(object sender, EventArgs e)
        {
            MainFormAppClass.CallOnMouseEnterBtnSettings(this);
        }

        private void BtnSettings_MouseLeave(object sender, EventArgs e)
        {
            BtnSettings.ForeColor = Color.White;
        }

        private void BtnReturnBack_Click(object sender, EventArgs e)
        {
            MainFormAppClass.CallFormRestartApplication(this);

        }

        private void BtnReturnBack_MouseEnter(object sender, EventArgs e)
        {
            MainFormAppClass.CallOnMouseEnterBtnReturnBack(this);
        }

        private void BtnReturnBack_MouseLeave(object sender, EventArgs e)
        {
            BtnReturnBack.ForeColor = Color.White;
        }
    }
}
