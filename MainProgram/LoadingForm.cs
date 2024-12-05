
using System;
using CustomLibraryClass;

namespace online_library_for_educ_inst
{
    public partial class FmLoadingForm : MetroFramework.Forms.MetroForm
    {
        public FmLoadingForm()
        {
            InitializeComponent();
  
            LoadingFormClass.GetFormParameters(this);

            LoadingFormClass.GetComponentsParameters(this);

            CustomClass.GetRoundedShapeForm(this);      
        }

        private void TmTimeToLoad_Tick(object sender, EventArgs e)
        {
             LoadingFormClass.CallLoadChooseRoleForm(this);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this,TmTimerToAnimationForm);
        }
        
    }
}
