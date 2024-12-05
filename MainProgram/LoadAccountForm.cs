
using System;
using CustomLibraryClass;

namespace online_library_for_educ_inst
{ 
    public partial class FmLoadAccountForm : MetroFramework.Forms.MetroForm
    {
        public FmLoadAccountForm()
        {
            InitializeComponent();

            LoadAccountFormClass.GetParametrsForm(this);
        }
        private void TimeLoad_Tick(object sender, EventArgs e)
        {
            LoadAccountFormClass.GetLoadProcessBar(this);
        }

        private void LoadAccountForm_Load(object sender, EventArgs e)
        {
            LoadAccountFormClass.CallMainFormApplication(this);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this,TimerToAnimationForm);
        }

       
    }
}
