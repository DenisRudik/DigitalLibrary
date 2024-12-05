using System;
using System.Drawing;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{
    public partial class FmChooseRoleForm : Form
    {
        public static FmChooseRoleForm FRM_Choose_role_Form_Instanse;
        public FmChooseRoleForm()
        {
            InitializeComponent();

            FRM_Choose_role_Form_Instanse = this;
       }

        private void FmChooseRoleForm_Load(object sender, EventArgs e)
        {
            ChooseRoleFormClass.GetActivatedTransparentComponent(this);
            
            CustomClass.GetRoundedShapeForm(this);

            ChooseRoleFormClass.GetAnimatedDrawText(this);

            ChooseRoleFormClass.GetAnimatedPanel(this);
            
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundFormOpen.ToString());

            ChooseRoleFormClass.CallWelcomeMessage(this);
        }

        private void FmChooseRoleForm_Activated(object sender, EventArgs e)
        {
            CustomClass.isLoadAdminRole = false;

            ChooseRoleFormClass.GetActivateWelcomeForm(this);

        }
        
        private void TimerToAnimaitonPict_Tick(object sender, EventArgs e)
        {
            ChooseRoleFormClass.GetAnimationChangePict(this);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this, TimerToAnimationForm);
        }

        private void ExitApp_MouseLeave(object sender, EventArgs e)
        {
            PictExitApp.Image = Properties.Resources.IconDefaultExit;
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            ChooseRoleFormClass.ExitFromApplication(this);      
        }

        private void ExitApp_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictExitApp.Image = Properties.Resources.IconCursorExit;
            ToolTipHelpUser.SetToolTip(PictExitApp, "Выйти из приложения");
        }

        private void PictLicense_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictLicense.Image = Properties.Resources.LicenseAgreementClicked;
            ToolTipHelpUser.SetToolTip(PictLicense, "Лицензионное соглашение с конечным пользователем");
        }

        private void PictLicense_MouseLeave(object sender, EventArgs e)
        {
            PictLicense.Image = Properties.Resources.LicenseAgreementCursor;
        }

        private void LblUserText_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            LblUserText.ForeColor = Color.FromArgb(0, 174, 219);
            ToolTipHelpUser.SetToolTip(LblUserText, "Войти в приложение как пользователь");
        }

        private void LblUserText_MouseLeave(object sender, EventArgs e)
        {
            LblUserText.ForeColor = Color.WhiteSmoke;
        }

        private void LblAdminText_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            LblAdminText.ForeColor = Color.FromArgb(0, 174, 219);
            ToolTipHelpUser.SetToolTip(LblAdminText, "Войти в приложение как администратор");
        }

        private void LblAdminText_MouseLeave(object sender, EventArgs e)
        {
            LblAdminText.ForeColor = Color.WhiteSmoke;
        }
        private void LblAdminText_Click(object sender, EventArgs e)
        {

            LblAdminText.ForeColor = Color.Aqua;

            CustomClass.Alert("В процессе разработки!",Form_Alert.enmType.Warning);
        }

        private void LblUserText_Click(object sender, EventArgs e)
        {
            ChooseRoleFormClass.CallWelcomeForm(this);
        }

        private void PictLicense_Click(object sender, EventArgs e)
        {
            ChooseRoleFormClass.CallLicenseAgreement(this);
        }

        private void FmChooseRoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose();
            GC.Collect();
        }

    }
    }



