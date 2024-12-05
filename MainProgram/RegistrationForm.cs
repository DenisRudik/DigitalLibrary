using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CustomAlertBoxDemo;
using CustomLibraryClass;



namespace online_library_for_educ_inst
{
    public partial class FmRegistrationForm : Form
    {
  
        #region /// to determine objects in fields for CustomLibraryClass
        public static Form FRM_Registration_Form_Instance;
        public static MetroFramework.Controls.MetroTextBox FRM_Registration_Form_txt_number_document;
        public static MetroFramework.Controls.MetroTextBox FRM_Registraiton_Form_txt_nickname;
        public static MetroFramework.Controls.MetroTextBox FRM_Registration_Form_txt_password_user;
        public static MetroFramework.Controls.MetroTextBox FRM_Registration_Form_txt_secret_user_password;
        public static MetroFramework.Controls.MetroComboBox FRM_Registration_Form_mcbox_select_sex_user; /// <summary>
        ///  CHECK THIS!!!
        /// </summary>
        #endregion
        public FmRegistrationForm()
        {
            InitializeComponent();

            RegistrationFormClass.IsOpenedFormRegistration(this);

            #region /// assign objects to determine fields for CustomLibraryClass
            FRM_Registration_Form_Instance = this;
            FRM_Registration_Form_txt_number_document = TxtRecordBook;
            FRM_Registraiton_Form_txt_nickname = TxtNickName;
            FRM_Registration_Form_txt_password_user = TxtPass;
            FRM_Registration_Form_txt_secret_user_password = TxtRecoveryCode;
            FRM_Registration_Form_mcbox_select_sex_user = McBoxSex;
            #endregion

        }

        private async void RegistrationForm_Load(object sender, EventArgs e)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                         
            RegistrationFormClass.ActivatedTransparentComponent(this);
       
            CustomClass.GetRoundedShapeForm(this);

            await RegistrationFormClass.CallAnimatedDrawText(this);

            RegistrationFormClass.CallPromptText(this);

            await CustomClass.GetConnToDBAsync(CustomClass.sConnStrToDB, true);

            RegistrationFormClass.CallPasswordChar(this);

            if (CustomClass.isCompleteAuthorization) Dispose();
        }
        
        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this,TimerToAnimationForm);
        }

        private void PictTxtRecordBook_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterRecordBook(this);
        }

        private void PictTxtRecordBook_MouseLeave(object sender, EventArgs e)
        {
            PictTxtRecordBook.Image = Properties.Resources.PictRegRecordBook;
        }

        private void PictNickname_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictNickname(this);
        }

        private void PictNickname_MouseLeave(object sender, EventArgs e)
        {
            PictNickname.Image = Properties.Resources.PictRegNickName;
        }

        private void PictTxtPass_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictTxtPass(this);
        }

        private void PictTxtPass_MouseLeave(object sender, EventArgs e)
        {
            PictTxtPass.Image = Properties.Resources.PictRegPass;
        }

        private void PictRecoveryCode_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictRecoveryCode(this);
        }

        private void PictRecoveryCode_MouseLeave(object sender, EventArgs e)
        {
            PictRecoveryCode.Image = Properties.Resources.PictRegSecretPass;
        }

        private void PictSex_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictSex(this);
        }

        private void PictSex_MouseLeave(object sender, EventArgs e)
        {
            PictSex.Image = Properties.Resources.PictRegSex;
        }

        private void PictEyePassToTxtPass_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictEyePassToTxtPass(this);
        }

        private void PictEyePassToTxtPass_MouseLeave(object sender, EventArgs e)
        {
            TxtPass.PasswordChar = '*';
            PictEyePassToTxtPass.Image = Properties.Resources.PictRegShowPass;
        }

        private void PictToTxtSecretPass_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictToTxtSecretPass(this);
        }

        private void PictToTxtSecretPass_MouseLeave(object sender, EventArgs e)
        {
            TxtRecoveryCode.PasswordChar = '*';
            PictToTxtSecretPass.Image = Properties.Resources.PictRegShowPass;
        }

        private void LblGotoFormAuth_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterLblGotoFormAuth(this);
        }

        private void LblGotoFormAuth_MouseLeave(object sender, EventArgs e)
        {
            LblGotoFormAuth.ForeColor = Color.Aqua;
        }

        private void LblGotoFormAuth_Click(object sender, EventArgs e)
        {
            RegistrationFormClass.CallAuthorizationForm(this);
        }

        private void PictDelTxtRecordBook_MouseLeave(object sender, EventArgs e)
        {
            RegistrationFormClass.CallStopAnimationTrashCan(this);
        }


        private void PictDelTxtRecordBook_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictDelTxtRecordBook(this);
        }

        private void PictDelTxtRecordBook_Click(object sender, EventArgs e)
        {
            TxtRecordBook.Text = null;
            CustomClass.Alert("Данные о зачётки успешно удалены!", Form_Alert.enmType.Info);
        }

        private void PictDelTxtNickName_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictDelTxtNickName(this);
        }

        private void PictDelTxtNickName_MouseLeave(object sender, EventArgs e)
        {
            RegistrationFormClass.CallStopAnimationTrashCan(this);
        }

        private void PictDelTxtNickName_Click(object sender, EventArgs e)
        {
            RegistrationFormClass.CallDeleteDataTxtNickName(this);
        }

        private void PictDelTxtPass_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictDelTxtPass(this);
        }

        private void PictDelTxtPass_MouseLeave(object sender, EventArgs e)
        {
            RegistrationFormClass.CallStopAnimationTrashCan(this);
        }

        private void PictDelTxtPass_Click(object sender, EventArgs e)
        {
            RegistrationFormClass.CallDeleteDataTxtPass(this);
        }

        private void PictDelTxtRecoveryCode_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterPictDelTxtRecoveryCode(this);
        }

        private void PictDelTxtRecoveryCode_MouseLeave(object sender, EventArgs e)
        {
            RegistrationFormClass.CallStopAnimationTrashCan(this);
        }

        private void PictDelTxtRecoveryCode_Click(object sender, EventArgs e)
        {
            RegistrationFormClass.CallDeleteDataTxtRecoveryCode(this);
        }

        private void BtnReg_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        }
        
        private void BtnReg_Click(object sender, EventArgs e)
        {
            RegistrationFormClass.GetConfirmInsertQuery(this);
        }

        private void McBoxSex_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        }

        private void McHcKAgreeRules_MouseLeave(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseLeaveMcHcKAgreeRules(this);
        }

        private void McHcKAgreeRules_MouseEnter(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            McHcKAgreeRules.ForeColor = Color.ForestGreen;
        }

        private async void TxtRecordBook_TextChanged(object sender, EventArgs e)
        {
            RegistrationFormClass.GetPasswordEntryBan(this);

            await RegistrationFormClass.GetCheckForDuplicateRecordAsync(this,false);
        }

        private void TxtRecordBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            RegistrationFormClass.GetDisabledCharacters(e);
        }

        private async void TxtNickName_TextChanged(object sender, EventArgs e)
        {
            TxtNickName.Text = Regex.Replace(TxtNickName.Text, @"\s+", "-"); /// меняет символ пробела на тире

            RegistrationFormClass.CheckInputLength(this);

            await RegistrationFormClass.GetCheckForDuplicateRecordAsync(this, false);
        }

        private void TxtNickName_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomClass.DisableSpace(e);         
        }

        private void TxtNickName_Leave(object sender, EventArgs e)
        {
            RegistrationFormClass.GetCheckingObsceneWords(this);    
        }

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            TxtPass.Text = Regex.Replace(TxtPass.Text, @"\s+", "-"); /// меняет символ пробела на тире
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomClass.DisableSpace(e);
        }

        private void TxtRecoveryCode_TextChanged(object sender, EventArgs e)
        {
            TxtRecoveryCode.Text = Regex.Replace(TxtRecoveryCode.Text, @"\s+", "-"); /// меняет символ пробела на тире
        }

        private void TxtRecoveryCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomClass.DisableSpace(e);
        }

        private void LblGotoWelcomeForm_Click(object sender, EventArgs e)
        {
            CustomClass.CallAnimationCloseForm(this);
        }

        private void LblGotoWelcomeForm_MouseEnter(object sender, EventArgs e)
        {

            RegistrationFormClass.CallOnMouseEnterLblGotoWelcomeForm(this);
        }

        private void LblGotoWelcomeForm_MouseLeave(object sender, EventArgs e)
        {
            LblGotoWelcomeForm.ForeColor = Color.Aqua;
        }

        private void LblGeneratePas_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterLblGeneratePas(this);
        }

        private void LblGeneratePas_MouseLeave(object sender, EventArgs e)
        {
            LblGeneratePas.ForeColor = Color.White;
        }

        private void LblGenerateSecretPass_MouseEnter(object sender, EventArgs e)
        {
            RegistrationFormClass.CallOnMouseEnterLblGenerateSecretPass(this);
        }

        private void LblGenerateSecretPass_MouseLeave(object sender, EventArgs e)
        {
            LblGenerateSecretPass.ForeColor = Color.White;
        }

        private void LblGeneratePas_Click(object sender, EventArgs e)
        {
            RegistrationFormClass.GetGenerateRandomPassword(this);
        }

        private void LblGenerateSecretPass_Click(object sender, EventArgs e)
        {
            RegistrationFormClass.GetGenerateSecretWord(this);
        }

        private async void Registration_Form_FormClosing(object sender, FormClosingEventArgs e)
        {      
            await CustomClass.GetConnToDBAsync(CustomClass.sConnStrToDB, false);
            RegistrationFormClass.CallFreeMemoryVoid(this);
        }
        
    }
}



