using System;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{
    public partial class FmAppOptionsForm : MetroFramework.Forms.MetroForm
    {       
        public FmAppOptionsForm()
        {
            InitializeComponent();
            
        }

        private void AppOptionsForm_Load(object sender, EventArgs e)
        {
            CustomClass.GetRoundedShapeForm(this);

            AppOptionsFormClass.CallShowNotificationMessage(this);
        }
     
        private void MToggleSoundOptions_CheckedChanged(object sender, EventArgs e)
        {
            AppOptionsFormClass.GetOffOrOnSound(this);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this,TimerToAnimationForm);
        }

        private void PictCloseForm_MouseEnter(object sender, EventArgs e)
        {
            ToolTipHelpUser.SetToolTip(PictCloseForm, "закрыть форму настроек...");
        }

        private void PictCloseForm_Click(object sender, EventArgs e)
        {
            CustomClass.CallAnimationCloseForm(this);
        }
    }
}
