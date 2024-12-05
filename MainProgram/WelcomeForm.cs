using System;
using System.Drawing;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{   
    public partial class FmWelcomeForm : Form
    {
        public static Form FRM_Welcome_Form_Instance;
        public FmWelcomeForm()
        {
            InitializeComponent();   
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            FRM_Welcome_Form_Instance = this;

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            WelcomeFormClass.ActivatedTransparentComponent(this);

            WelcomeFormClass.CallUserMessage(this);

            CustomClass.GetRoundedShapeForm(this);

            WelcomeFormClass.CallAnimatedDrawText(this);

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundFormOpen.ToString());
              
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this, TimerToAnimationForm);
        }
      

        private void PictBackToChoose_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictBackToChoose.Image = Properties.Resources.ArrowBackCursor;
            ToolTipHelpUser.SetToolTip(PictBackToChoose, "Вернутся в приветсвенное окно");
        }

        private void PictBackToChoose_MouseLeave(object sender, EventArgs e)
        {
            PictBackToChoose.Image = Properties.Resources.ArrowBackDefault;
        }

        private void PictBackToChoose_Click(object sender, EventArgs e)
        {
            WelcomeFormClass.CallReturnChooseForm(this);
        }

        private void PictExitApp_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictExitApp.Image = Properties.Resources.IconCursorExit;
            ToolTipHelpUser.SetToolTip(PictExitApp, "Выйти из приложения");
        }

        private void PictExitApp_MouseLeave(object sender, EventArgs e)
        {
            PictExitApp.Image = Properties.Resources.IconDefaultExitWelcomForm;
        }
        private void PictExitApp_Click(object sender, EventArgs e)
        {
            WelcomeFormClass.CallExitApplicaton(this);
        }
   

        private void PictBtnAuthorization_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictBtnAuthorization.Image = Properties.Resources.IconCursorAuth;
            LblSubText.ForeColor = Color.DarkGreen;
            ToolTipHelpUser.SetToolTip(PictBtnAuthorization, "Перейти к форме авторизации");
        }


        private void PictBtnAuthorization_MouseLeave(object sender, EventArgs e)
        {
            PictBtnAuthorization.Image = Properties.Resources.IconDefaultAuth;
            LblSubText.ForeColor = Color.Azure;
        }

        private void PictBtnAuthorization_Click(object sender, EventArgs e)
        {
            WelcomeFormClass.CallAuthorizationForm(this);
        }

        private void PictBtnReg_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            PictBtnReg.Image = Properties.Resources.IconCursorReg;
            LblNewSubText.ForeColor = Color.DarkGreen;
            ToolTipHelpUser.SetToolTip(PictBtnReg, "Перейти к форме регистрации");
        }

        private void PictBtnReg_MouseLeave(object sender, EventArgs e)
        {
            PictBtnReg.Image = Properties.Resources.IconDefaultReg;
            LblNewSubText.ForeColor= Color.Azure;
        }

        private void PictBtnReg_Click(object sender, EventArgs e)
        {
            WelcomeFormClass.CallRegistrationForm(this);
        }

        private void WelcomeForm_Activated(object sender, EventArgs e)
        {
            WelcomeFormClass.CheckedCompleteAuthorization(this);
        }

        private void WelcomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            WelcomeFormClass.CallFreeMemoryVoid(this);

            if (CustomClass.isCompleteAuthorization)
            {
                CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClose.ToString());
            }
        }
    }
}
