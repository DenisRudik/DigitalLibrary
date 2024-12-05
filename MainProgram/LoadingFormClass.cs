/// <summary>
/// Название файла - LoadingFormClass.cs.
/// !--------------------------------Описание---------------------------!:
/// Файл для описания предварительного этапа загрузки программы. При нажатии на исполняемый файл происходят следующие процессы:
/// 1) Метод GetFormParameters - Задает предварительные параметры для загрузочной формы приложения
/// 2) Метод GetComponentsParameters - Описует компоненты и их свойства на загрузочной форме 
/// 3) Метод CallLoadChooseRoleForm - Имитирует процесс загрузки программы путем приостановки потока на заданной количество миллисекунд в конструкции Case.
///    По достижению определенного значенния начинается этап запуска формы выбора роли в программе.
/// </summary>
/// <param name="fmLoadingForm"></param>
/// 

using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using CustomAlertBoxDemo;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{
  public class LoadingFormClass
    {    
        public static void GetFormParameters(FmLoadingForm fmLoadingForm)
        {
            fmLoadingForm.Size = new Size(750, 450);
            fmLoadingForm.StartPosition = FormStartPosition.CenterScreen;
            fmLoadingForm.Style = MetroFramework.MetroColorStyle.Green;
            fmLoadingForm.Theme = MetroFramework.MetroThemeStyle.Dark;
            fmLoadingForm.MaximumSize = new Size(750, 450);
            fmLoadingForm.MinimumSize = new Size(750, 450);
            fmLoadingForm.ControlBox = false;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundStartApp.ToString());
            fmLoadingForm.PictBxPictrurePC.Image = Properties.Resources.loading_screen__png_;
        }

        public static void GetComponentsParameters(FmLoadingForm fmLoadingForm)
        {
            fmLoadingForm.LblMsgAboutDeveloper.BackColor = Color.FromArgb(17, 17, 17);
            fmLoadingForm.LblMsgAboutDeveloper.ForeColor = Color.FromArgb(255, 255, 255);
            fmLoadingForm.LblMsgAboutDeveloper.Text = "Developed by Denis Rudakov";

            fmLoadingForm.LblMsgAboutProg.BackColor = Color.FromArgb(17, 17, 17);
            fmLoadingForm.LblMsgAboutProg.ForeColor = Color.FromArgb(255, 255, 255);
            fmLoadingForm.LblMsgAboutProg.Text = "Цифровая библиотека для учебного заведения";

            fmLoadingForm.LblMsgForUser.BackColor = Color.FromArgb(17, 17, 17);
            fmLoadingForm.LblMsgForUser.ForeColor = Color.FromArgb(255, 255, 255);
            fmLoadingForm.LblMsgForUser.Text = "Загрузка:";

            fmLoadingForm.PnLoadingBar.BackColor = Color.FromArgb(0, 177, 89);
            fmLoadingForm.TmTimeToLoad.Enabled = true;
        }
        
        public static void CallLoadChooseRoleForm(FmLoadingForm fmLoadingForm)
        {
            fmLoadingForm.PnLoadingBar.Width += 2;

            switch (fmLoadingForm.PnLoadingBar.Width)
            {
                case 100:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.LoadingBar);
                    fmLoadingForm.LblMsgForLoadProgress.Text = "Загрузка нужных компонентов...";
                    break;

                case 300:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.LoadingBar);
                    fmLoadingForm.LblMsgForLoadProgress.Text = "Загрузка форм...";
                    break;

                case 450:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.LoadingBar);
                    fmLoadingForm.LblMsgForLoadProgress.Text = "Построение к базе данных запросов...";
                    break;

                case 550:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.LoadingBar);
                    fmLoadingForm.LblMsgForLoadProgress.Text = "Проверка на наличие библиотек...";
                    break;

                case 650:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.LoadingBar);
                    fmLoadingForm.LblMsgForLoadProgress.Text = "Запуск приложения..."; ;
                    break;

                case 750:
                    fmLoadingForm.TmTimeToLoad.Enabled = false;
                    fmLoadingForm.TmTimeToLoad.Stop();
                    CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClose.ToString());
                    CustomClass.CallAnimationCloseForm(fmLoadingForm);
                    CustomClass.isOpenedChooseRoleForm = true;
                    break;
            }
        }
            
    }
}

