using System;
using System.Drawing;
using CustomLibraryClass;
using CustomAlertBoxDemo;

namespace online_library_for_educ_inst
{

    public partial class FmFormGenreBook : MetroFramework.Forms.MetroForm
    {
        public FmFormGenreBook()
        {
            InitializeComponent();
            FormGenreBookClass.SetStyleForm(this);
        }

        private async void SelectBookForm_Load(object sender, EventArgs e)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundFormOpen.ToString());

            CustomClass.GetRoundedShapeForm(this);

            FormGenreBookClass.ShowComponentTile(this);

            CenterToScreen();

            FormGenreBookClass.LoadCurrentSubscriptionPicture(this);

            FormGenreBookClass.LoadLblMessage(this);

            FormGenreBookClass.GetComponentsForm(this);

            await FormGenreBookClass.GetDataGenre(this);

        }

        private async void mComBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FormGenreBookClass.GetNovelBooks(this);
        }

        private async void mComBoxGenrePoem_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FormGenreBookClass.GetPoemBooks(this);
        }

        private async void mComBoxGenreStory_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FormGenreBookClass.GetStoryBooks(this);
        }

        private async void mComBoxGenreHorrors_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FormGenreBookClass.GetHorrorBooks(this);
        }

        private async void mComBoxGenreBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FormGenreBookClass.GetScientificBooks(this);
        }

        private async void mComBoxGenreArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
            await FormGenreBookClass.GetScientificArticles(this);
        }

        private void PictSub_MouseEnter(object sender, EventArgs e)
        {
            FormGenreBookClass.CallOnMouseEnterPictSub(this);
        }


        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            CustomClass.CallAnimationAppearanceForm(this, TimerToAnimationForm);
        }

        private void PictCloseForm_Click(object sender, EventArgs e)
        {
            CustomClass.CallAnimationCloseForm(this);
        }

        private void PictCloseForm_MouseEnter(object sender, EventArgs e)
        {
            ToolTipHelpUser.SetToolTip(PictCloseForm, "закрыть форму...");
        }

        private void mComBoxGenreNovel_MouseEnter(object sender, EventArgs e)
        {
            FormGenreBookClass.CallOnMouseEntermComBoxGenreNovel(this);
        }

        private void mComBoxGenreNovel_MouseLeave(object sender, EventArgs e)
        {
            LblForNovel.ForeColor = SystemColors.ControlLightLight;
        }

        private void mComBoxGenrePoem_MouseEnter(object sender, EventArgs e)
        {
            FormGenreBookClass.CallOnMouseEntermComBoxGenrePoem(this);
        }

        private void mComBoxGenrePoem_MouseLeave(object sender, EventArgs e)
        {
            LblForPoem.ForeColor = SystemColors.ControlLightLight;
        }

        private void mComBoxGenreStory_MouseEnter(object sender, EventArgs e)
        {
            FormGenreBookClass.CallOnMouseEntermComBoxGenreStory(this);
        }

        private void mComBoxGenreStory_MouseLeave(object sender, EventArgs e)
        {
            LblForStory.ForeColor = SystemColors.ControlLightLight;
        }

        private void mComBoxGenreHorrors_MouseLeave(object sender, EventArgs e)
        {
            LblForHorrors.ForeColor = SystemColors.ControlLightLight;
        }

        private void mComBoxGenreHorrors_MouseEnter(object sender, EventArgs e)
        {
            FormGenreBookClass.CallOnMouseEntermComBoxGenreHorrors(this);   
        }

        private void mComBoxGenreBooks_MouseEnter(object sender, EventArgs e)
        {
            FormGenreBookClass.CallOnMouseEntermComBoxGenreBooks(this);
        }

        private void mComBoxGenreBooks_MouseLeave(object sender, EventArgs e)
        {
            LblForBooks.ForeColor= SystemColors.ControlLightLight;  
        }

        private void mComBoxGenreArticle_MouseEnter(object sender, EventArgs e)
        {
            FormGenreBookClass.CallOnMouseEntermComBoxGenreArticle(this);
        }

        private void mComBoxGenreArticle_MouseLeave(object sender, EventArgs e)
        {
            LblForArticle.ForeColor= SystemColors.ControlLightLight;
        } 

    } 
    
    }

