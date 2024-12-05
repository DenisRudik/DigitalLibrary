using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CustomAlertBoxDemo;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{
    public partial class FmAuthorizationForm : Form
    {
       #region /// to determine objects in fields for MyClass
        public static Form FRM_Authorization_Form_Insatnce;
        public static MetroFramework.Controls.MetroTextBox FRM_Authorization_txt_user_number_document;
        public static MetroFramework.Controls.MetroTextBox FRM_Authorization_txt_user_password;
        public static MetroFramework.Controls.MetroTextBox FRM_Authorization_txt_confirm_user_password;
        #endregion

        public FmAuthorizationForm()
        {
            InitializeComponent();

            #region /// assign objects to determine fields for MyClass
            FRM_Authorization_Form_Insatnce = this;
            FRM_Authorization_txt_user_number_document = TxtRecordBook;
            FRM_Authorization_txt_user_password = TxtPass;
            FRM_Authorization_txt_confirm_user_password = TxtConfirmPass;
            #endregion

            CustomClass.isShowMessageRecoveredPassword = false;

            AuthorizationFormClass.CallPasswordChar(this);
           
        }

        private async void Authorization_Form_Load(object sender, EventArgs e)
        {
            
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            AuthorizationFormClass.ActivatedTransparentComponent(this);

            CustomClass.GetRoundedShapeForm(this);

            AuthorizationFormClass.CallPromptText(this);

            await AuthorizationFormClass.CallAnimatedDrawText(this); 

            await CustomClass.GetConnToDBAsync(CustomClass.sConnStrToDB,true);
        }

      
        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this, TimerToAnimationForm);
        }

        private void PictTxtRecordBook_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterPictTxtRecordBook(this);
        }

        private void PictTxtRecordBook_MouseLeave(object sender, EventArgs e)
        {
            PictTxtRecordBook.Image = Properties.Resources.PictRegRecordBookCursored;
        }

        private void PictTxtPass_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterPictTxtPass(this);
        }

        private void PictTxtPass_MouseLeave(object sender, EventArgs e)
        {
            PictTxtPass.Image = Properties.Resources.PictRegPassCursored;
        }

        private void PictConfirmPass_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterPictConfirmPass(this);
        }

        private void PictConfirmPass_MouseLeave(object sender, EventArgs e)
        {
            PictConfirmPass.Image = Properties.Resources.PictRegPassCursored;
        }

        private void PictEyePassToTxtPass_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterPictEyePassToTxtPass(this);
        }

        private void PictEyePassToTxtPass_MouseLeave(object sender, EventArgs e)
        {
            TxtPass.PasswordChar = '*';
            PictEyePassToTxtPass.Image = Properties.Resources.PictAuthShowPass;
        }

        private void PictTxtConfirmPass_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterPictTxtConfirmPass(this);
        }

        private void PictTxtConfirmPass_MouseLeave(object sender, EventArgs e)
        {
            TxtConfirmPass.PasswordChar = '*';
            PictTxtConfirmPass.Image = Properties.Resources.PictAuthShowPass;
        }


        private void LblGotoWelcomeForm_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterLblGotoWelcomeForm(this);
        }

        private void LblGotoWelcomeForm_MouseLeave(object sender, EventArgs e)
        {
            LblGotoWelcomeForm.ForeColor = Color.FromArgb(13, 28, 129);
        }

        private void LblGotoWelcomeForm_Click(object sender, EventArgs e)
        {
            LblGotoWelcomeForm.ForeColor = Color.FromArgb(20, 144, 27);

            CustomClass.CallAnimationCloseForm(this);
        }

        private void LblGotoReg_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterLblGotoReg(this);
        }

        private void LblGotoReg_MouseLeave(object sender, EventArgs e)
        {
            LblGotoReg.ForeColor = Color.FromArgb(13, 28, 129);
        }

        private void LblGotoReg_Click(object sender, EventArgs e)
        {
            AuthorizationFormClass.GetRegistrationForm(this);
        }

        private void LblGotoLostAcc_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterLblGotoLostAcc(this);
        }

        private void LblGotoLostAcc_MouseLeave(object sender, EventArgs e)
        {
            LblGotoLostAcc.ForeColor = Color.FromArgb(13, 28, 129);
        }

        private void LblGotoLostAcc_Click(object sender, EventArgs e)
        {
            AuthorizationFormClass.GetLostAccountForm(this);
        }

        public void StopAnimationTrashCan()
        {
            PictDelTxtRecordBook.Image = Properties.Resources.TrashCanAuth;
        }

        private void PictDelTxtRecordBook_MouseEnter(object sender, EventArgs e)
        {
            AuthorizationFormClass.CallOnMouseEnterPictDelTxtRecordBook(this);
        }

        private void PictDelTxtRecordBook_MouseLeave(object sender, EventArgs e)
        {
            StopAnimationTrashCan();
        }

        private void PictDelTxtRecordBook_Click(object sender, EventArgs e)
        {
            AuthorizationFormClass.GetDeleteDataTxtRecordBook(this);
        }

        private void BtnAuth_Enter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            BtnAuth.ForeColor = Color.LimeGreen;
        }
     
        private async void BtnAuthorization_Click(object sender, EventArgs e)
        {
            AuthorizationFormClass.GetCheckNumberCharacters(this);

            AuthorizationFormClass.GetComparisonPass(this);

            AuthorizationFormClass.GetCheckNullTxtBox(this);

            AuthorizationFormClass.CallPasswordRecoveryAssistantForm(this);

            await AuthorizationFormClass.GetCheckData(this);

            await AuthorizationFormClass.GetCheckPrimaryKeyUser(this);        
        }


        private void BtnAuthorization_Leave(object sender, EventArgs e)
        {
            BtnAuth.ForeColor = Color.White;
        }


        private void TxtRecordBook_TextChanged(object sender, EventArgs e)
        {
            TxtRecordBook.Text = Regex.Replace(TxtRecordBook.Text, @"\s+", ""); /// меняет символ пробела на пустоту
        }

        private void TxtRecordBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            AuthorizationFormClass.GetDisabledCharacters(e);    
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomClass.DisableSpace(e);
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            TxtPass.Text = Regex.Replace(TxtPass.Text, @"\s+", "-"); /// меняет символ пробела на тире
        }

        private void TxtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomClass.DisableSpace(e);
        }

        private void TxtConfirmPass_TextChanged(object sender, EventArgs e)
        {
            TxtConfirmPass.Text = Regex.Replace(TxtConfirmPass.Text, @"\s+", "-"); /// меняет символ пробела на тире
        }

        private void Authorization_Form_Activated(object sender, EventArgs e)
        {
            if (CustomClass.isShowMessageRecoveredPassword)
                AuthorizationFormClass.GetRecoveredPassword(this);
      
            CustomClass.isShowMessageRecoveredPassword = false;

        }

        private void Authorization_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomClass.isOpenedFormAuthorization = false;
            AuthorizationFormClass.CallFreeMemoryVoid(this);
        }
    }
}


 
