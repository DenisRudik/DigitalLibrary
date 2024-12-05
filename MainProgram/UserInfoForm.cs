
using System;
using CustomLibraryClass;
using CustomAlertBoxDemo;

namespace online_library_for_educ_inst
{
    public partial class FmUserInfoForm : MetroFramework.Forms.MetroForm
    {
        public FmUserInfoForm()
        {
            InitializeComponent();
        }

        private void User_Info_Form_Load(object sender, EventArgs e)
        {
            UserInfoFormClass.GetDataUser(this);

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            CustomClass.GetRoundedShapeForm(this);

            UserInfoFormClass.GetLowerComponentTile(this);
      
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this, TimerToAnimationForm);
        }

      
        private void PictRecordBook_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterPictRecordBook(this);
        }

        private void PictRecordBook_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeavePictRecordBook(this);
        }

        private void LblRecordBook_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterLblRecordBook(this);
        }

        private void LblRecordBook_MouseLeave(object sender, EventArgs e)
        {

            UserInfoFormClass.CallOnMouseLeaveLblRecordBook(this);
        }

        private void PictNickname_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterPictNickname(this);
        }

        private void PictNickname_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeavePictNickname(this);
        }

        private void LblNickName_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterLblNickName(this);
        }

        private void LblNickName_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeaveLblNickName(this);
        }

        private void PictSexUser_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterPictSexUser(this);
        }

        private void PictSexUser_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeavePictSexUser(this);
        }

        private void LblSexUser_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterLblSexUser(this);
        }

        private void LblSexUser_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeaveLblSexUser(this);
        }

        private void PictBankDetails_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterPictBankDetails(this);
        }

        private void PictBankDetails_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeavePictBankDetails(this);
        }

        private void LblBankDetails_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterLblBankDetails(this);
        }

        private void LblBankDetails_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeaveLblBankDetails(this);
        }

        private void PictCVVCode_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterPictCVVCode(this);
        }

        private void PictCVVCode_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeavePictCVVCode(this);
        }

        private void LblCVVCode_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterLblCVVCode(this);
        }

        private void LblCVVCode_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeaveLblCVVCode(this);
        }

        private void PictBalanceUser_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterPictBalanceUser(this);
        }

        private void PictBalanceUser_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeavePictBalanceUser(this);
        }

        private void LblBalanceUser_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterLblBalanceUser(this);
        }

        private void LblBalanceUser_MouseLeave(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseLeaveLblBalanceUser(this);
        }

        private void PictCloseForm_Click(object sender, EventArgs e)
        {
            CustomClass.CallAnimationCloseForm(this);
        }

        private void PictCloseForm_MouseEnter(object sender, EventArgs e)
        {
            ToolTipHelpUser.SetToolTip(PictCloseForm, "закрыть форму профиля...");
        }

        private void PictRubSign_MouseEnter(object sender, EventArgs e)
        {
            UserInfoFormClass.CallOnMouseEnterPictRubSign(this);
        }

        private void PictRubSign_MouseLeave(object sender, EventArgs e)
        {
            PictRubSign.Image = Properties.Resources.RubSign;
        }   
    }
}
