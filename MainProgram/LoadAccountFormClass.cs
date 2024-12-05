/// <summary>
/// Название файла - LoadAccountFormClass.cs.
/// !--------------------------------Описание---------------------------!:
/// Файл для описания загрузки аккаунта пользователя в приложении. После успешной авторизации в системе происходят следующие этапы выполнения программы:
/// 1) Метод GetParametrsForm - Задает предварительные параметры для загрузочной формы аккаунта приложения
/// 2) Метод GetLoadProcessBar - Запускает процесс анимации загрузки аккаунта. В случае успеха, переменная isLoadAccount, становится true  
/// 3) Метод CallMainFormApplication - Осуществляется выборка конкретных данных пользователя с БД и передается отправка на сторону бэкенд кода приложения.
///    // Проигрываются звуковые эффекты при появлении формы загрузки аккаунта
/// </summary>
/// <param name="fmAccountForm"></param>
/// 

using System;
using System.Drawing;
using System.Threading;
using CustomAlertBoxDemo;
using CustomLibraryClass;

namespace online_library_for_educ_inst
{
    public class LoadAccountFormClass
    {
        public static void GetParametrsForm(FmLoadAccountForm fmLoadAccountForm)
        {
            CustomClass.GetRoundedShapeForm(fmLoadAccountForm);

            fmLoadAccountForm.Tload.Enabled = true;
            fmLoadAccountForm.PanelLoadProcess.BackColor = Color.FromArgb(0, 176, 186);
            fmLoadAccountForm.PictLogo.Image = Properties.Resources.LoadingGif;
            FmAuthorizationForm.FRM_Authorization_Form_Insatnce.Dispose(); /// при появлении этой формы, вызываем метод Dispose() который удалит
                                                                           /// экземляры форм
            FmWelcomeForm.FRM_Welcome_Form_Instance.Dispose();
        }

        public static void GetLoadProcessBar(FmLoadAccountForm fmLoadAccountForm)
        {
            fmLoadAccountForm.PanelLoadProcess.Width += 2;

            switch (fmLoadAccountForm.PanelLoadProcess.Width) /// код, отвечающий за иммитацию загрузки при помощи задержки текущего потока
            {
                case 100:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.UpLoadingAccount);
                    break;

                case 300:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.UpLoadingAccount);
                    break;

                case 450:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.UpLoadingAccount);
                    break;

                case 550:
                    Thread.Sleep((int)CustomClass.enmTimeToClose.UpLoadingAccount);
                    break;

                case 790:
                    fmLoadAccountForm.Tload.Enabled = false;
                    fmLoadAccountForm.Tload.Stop();
                    CustomClass.CallAnimationCloseForm(fmLoadAccountForm);
                    CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClose.ToString());
                    CustomClass.isLoadAccount = true;
                    break;
            }
        }

        public static void CallMainFormApplication(FmLoadAccountForm fmLoadAccountForm)
        {
            
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundStartApp.ToString());

            string sUserNickname = CustomClass.sNickNameNewUser;

            fmLoadAccountForm.LblNewUser.Text = sUserNickname;

            fmLoadAccountForm.LowerComponentTile.Text = "Аккаунт " + string.Format("({0})", sUserNickname) + " - платформа " + Environment.OSVersion;
        }
    }
}
