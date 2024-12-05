
using System;
using CustomLibraryClass;
using online_library_for_educ_inst;

namespace yt_DesignUI
{
    public partial class FmFormSubcription : MetroFramework.Forms.MetroForm
    {
        public FmFormSubcription()
        {
            InitializeComponent();

            Animator.Start();
        }

        private async void FormSubcription_Load(object sender, EventArgs e)
        {
            CustomClass.GetRoundedShapeForm(this);

            FormSubscriptionClass.GetComponentTile(this);

            FormSubscriptionClass.GetTopMessage(this);

            FormSubscriptionClass.CallAnimatedDrawText(this);

            await CustomClass.GetConnToDBAsync(CustomClass.sConnStrToDB, true);

            await FormSubscriptionClass.GetDataSubscription(this);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this,TimerToAnimationForm);
        }

        private void egoldsCard1_MouseEnter(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseEnterEgoldsCard1(this);
        }

        private void egoldsCard1_MouseLeave(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseLeaveEgoldsCard1(this);
        }

        private void egoldsCard2_MouseEnter(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseEnterEgoldsCard2(this);
        }

        private void egoldsCard2_MouseLeave(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseLeaveEgoldsCard2(this);
        }

        private void egoldsCard3_MouseEnter(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseEnterEgoldsCard3(this);
        }

        private void egoldsCard3_MouseLeave(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseLeaveEgoldsCard3(this);
        }

        private void PictAnswerEgolds1_MouseEnter(object sender, EventArgs e)
        {
            ToolTipHelpUser.SetToolTip(PictAnswerEgolds1, "подписка,предоставляющая доступ ко всей литературе в системе на месяц...");
            PictAnswerEgolds1.Image = online_library_for_educ_inst.Properties.Resources.QuestionMarkCursored;
        }

        private void PictAnswerEgolds1_MouseLeave(object sender, EventArgs e)
        {
            PictAnswerEgolds1.Image = online_library_for_educ_inst.Properties.Resources.QuestionMark;
        }

        private void PictAnswerEgolds2_MouseEnter(object sender, EventArgs e)
        {
            ToolTipHelpUser.SetToolTip(PictAnswerEgolds2, "подписка, предоставляющая доступ только к художественной литературе на месяц...");
            PictAnswerEgolds2.Image = online_library_for_educ_inst.Properties.Resources.QuestionMarkCursored;
        }

        private void PictAnswerEgolds2_MouseLeave(object sender, EventArgs e)
        {
            PictAnswerEgolds2.Image = online_library_for_educ_inst.Properties.Resources.QuestionMark;
        }

        private void PictAnswerEgolds3_MouseEnter(object sender, EventArgs e)
        {
            ToolTipHelpUser.SetToolTip(PictAnswerEgolds3, "подписка, предоставляющая доступ только к учебным материалам на месяц...");
            PictAnswerEgolds3.Image = online_library_for_educ_inst.Properties.Resources.QuestionMarkCursored;
        }

        private void PictAnswerEgolds3_MouseLeave(object sender, EventArgs e)
        {
            PictAnswerEgolds3.Image = online_library_for_educ_inst.Properties.Resources.QuestionMark;
        }

        private void PictBuySubEgolds1_MouseEnter(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseEnterPictBuySubEgolds1(this);
        }

        private void PictBuySubEgolds1_MouseLeave(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseLeavePictBuySubEgolds1(this);
        }

        private void PictBuySubEgolds2_MouseEnter(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseEnterPictBuySubEgolds2(this);
        }

        private void PictBuySubEgolds2_MouseLeave(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseLeavePictBuySubEgolds2(this);
        }

        private void PictBuySubEgolds3_MouseEnter(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseEnterPictBuySubEgolds3(this);
        }

        private void PictBuySubEgolds3_MouseLeave(object sender, EventArgs e)
        {
            FormSubscriptionClass.CallOnMouseLeavePictBuySubEgolds3(this);
        }

        private void PictCloseForm_Click(object sender, EventArgs e)
        {
            CustomClass.CallAnimationCloseForm(this);
        }

        private void PictCloseForm_MouseEnter(object sender, EventArgs e)
        {
            ToolTipHelpUser.SetToolTip(PictCloseForm, "закрыть форму доступных подписок...");
        }

        private async void PictBuySubEgolds1_Click(object sender, EventArgs e)
        {
            await FormSubscriptionClass.GetBuySubcriptionOnMonth(this);
        } 
        
        private async void PictBuySubEgolds2_Click(object sender, EventArgs e)
        {
            await FormSubscriptionClass.GetBuyArtisticSubcription(this);
        }

        private async void PictBuySubEgolds3_Click(object sender, EventArgs e)
        {
            await FormSubscriptionClass.GetBuyScientificSubcription(this);
        }

        private async void FormSubcription_Activated(object sender, EventArgs e)
        {
            await FormSubscriptionClass.GetUserAction(this);
        }     
    }
}
