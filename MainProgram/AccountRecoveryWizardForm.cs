using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomLibraryClass;

namespace online_library_for_educ_inst
{
    public partial class FmPasswordRecoveryAssistantForm : Form
    {
        public FmPasswordRecoveryAssistantForm()
        {
            InitializeComponent();
        }

        private void PasswordRecoveryAssistantForm_Load(object sender, EventArgs e)
        {
            CustomClass.GetRoundedShapeForm(this);

            AccountRecoveryWizardFormClass.CallPromptText(this);

            AccountRecoveryWizardFormClass.GetPasteNumberDocument(this);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this,TimerToAnimationForm);
        }

      
        private void PictTxtRecordBook_MouseEnter(object sender, EventArgs e)
        {
            AccountRecoveryWizardFormClass.CallOnMouseEnterPictTxtRecordBook(this);
        }

        private void PictTxtRecordBook_MouseLeave(object sender, EventArgs e)
        {
            PictTxtRecordBook.Image = Properties.Resources.PictRegRecordBookCursored;
        }

        private void PictRecoveryCode_MouseEnter(object sender, EventArgs e)
        {
            AccountRecoveryWizardFormClass.CallOnMouseEnterPictRecoveryCode(this);
        }

        private void PictRecoveryCode_MouseLeave(object sender, EventArgs e)
        {
            PictRecoveryCode.Image = Properties.Resources.PictRegSecretPassCursored;
        }

        private void PictEyeRecoveryCodeShow_MouseEnter(object sender, EventArgs e)
        {
            AccountRecoveryWizardFormClass.CallOnMouseEnterPictEyeRecoveryCodeShow(this);
        }

        private void PictEyeRecoveryCodeShow_MouseLeave(object sender, EventArgs e)
        {
            TxtRecoveryCode.PasswordChar = '*';
            PictEyeRecoveryCodeShow.Image = Properties.Resources.PictRegShowPass;
        }

        private void LblCloseRecoveryForm_MouseEnter(object sender, EventArgs e)
        {
            AccountRecoveryWizardFormClass.CallOnMouseEnterLblCloseRecoveryForm(this);
        }

        private void LblCloseRecoveryForm_MouseLeave(object sender, EventArgs e)
        {
            LblCloseRecoveryForm.ForeColor = Color.FromArgb(151, 255, 48);
        }

        private void LblCloseRecoveryForm_Click(object sender, EventArgs e)
        {
            CustomClass.CallAnimationCloseForm(this);
        }

             
        private async void BtnOK_Click(object sender, EventArgs e)
        {
            AccountRecoveryWizardFormClass.GetCheckNullTxtBox(this);

            AccountRecoveryWizardFormClass.GetCheckNumberCharacters(this);

            await AccountRecoveryWizardFormClass.GetCheckDataUser(this);

            await AccountRecoveryWizardFormClass.GetCheckPrimaryKeyUser(this);

        }
        private void TxtUserNumberDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomClass.OnlyNum(e);
        }

        private void PasswordRecoveryAssistantForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            AccountRecoveryWizardFormClass.CallFreeMemoryVoid(this);
        }

    }
}
