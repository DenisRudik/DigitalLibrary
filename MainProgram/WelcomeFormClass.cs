/// <summary>
//Название файла - WelcomeFormClass.cs.
/// !--------------------------------Описание---------------------------!:
// В этом файле описывается вся программная логика формы "Welcome Form",которая представляет собой окно для выбора следующих шагов в системе.
// Файл поделен на две части:
// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
// Часть 2 - Программная логика заданных компонентов и последующая их обработка

/// <summary>
/// <param name="fmWelcomeFormClass"></param>

using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using modal;


namespace online_library_for_educ_inst
{
    public class WelcomeFormClass
    {
        // Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем

        public static void ActivatedTransparentComponent(FmWelcomeForm fmWelcomeForm)
        {
            fmWelcomeForm.BackColor = Color.Transparent;

            // Make your label transparent
            fmWelcomeForm.PictBackToChoose.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.PictBackToChoose.BackColor = Color.Transparent;

            fmWelcomeForm.PictGifLogo.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.PictGifLogo.BackColor = Color.Transparent;

            fmWelcomeForm.LblMainText.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.LblMainText.BackColor = Color.Transparent;

            fmWelcomeForm.LblSubText.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.LblSubText.BackColor = Color.Transparent;

            fmWelcomeForm.LblNewSubText.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.LblNewSubText.BackColor = Color.Transparent;

            fmWelcomeForm.PictBtnAuthorization.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.PictBtnAuthorization.BackColor = Color.Transparent;

            fmWelcomeForm.PictBtnReg.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.PictBtnReg.BackColor = Color.Transparent;

            fmWelcomeForm.PictExitApp.Parent = fmWelcomeForm.PictBackGroundGif;

            fmWelcomeForm.PictExitApp.BackColor = Color.Transparent;
        } /// Метод для реализации эффекта прозрачности у компонентов на форме

        public static void CallUserMessage(FmWelcomeForm fmWelcomeForm)
        {
            string sSysUserName = Environment.UserName; /// системное имя пользователя

            fmWelcomeForm.LblMainText.Text = "Дорогой(ая), " + sSysUserName + ". Добро пожаловать в нашу уютную цифровую библиотеку! Здесь тебя ждут интересные книги\n и " +
                                                        "многое другое для увлекательного чтения.Погрузись в мир знаний и открой для себя что-то новенькое!";

            fmWelcomeForm.LblSubText.Text = "Окунись в мир цифровой литературы пройдя авторизацию в приложении:";

            fmWelcomeForm.LblNewSubText.Text = "Или перейди на этап простой регистрации в системе:";
        } /// Вызов системных сообщение и приветствие пользователя 

        public static async void CallAnimatedDrawText(FmWelcomeForm fmWelcomeForm)
        {
            byte shateOfRed = 0;
            byte shateOfGreen = 0;
            byte shateOfBlue = 0;
            byte desiredShateColor = 245;

            for (byte r = shateOfRed, g = shateOfGreen, b = shateOfBlue; r <= desiredShateColor & g <= desiredShateColor & b <= desiredShateColor; r += 5, g += 5, b += 5)
            {
                await Task.Delay(CustomClass.TIME_TO_DRAWING);
                fmWelcomeForm.LblMainText.ForeColor = Color.FromArgb(r, g, b);
                fmWelcomeForm.LblSubText.ForeColor = Color.FromArgb(r, g, b);
                fmWelcomeForm.LblNewSubText.ForeColor = Color.FromArgb(r, g, b);
            }
        } /// Анимация появления текста








        // Часть 2 - Программная логика заданных компонентов и последующая их обработка
        public static void CallReturnChooseForm(FmWelcomeForm fmWelcomeForm)
        {
            try
            {
                CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
                Form modalBackground = new Form();
                using (FrmModalForm modal = new FrmModalForm())
                {
                    FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Возврат к предыдущей форме...";
                    FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Хотите открыть приветсвенную форму?. Для этого потребуется перезапуск\n приложения.";
                    FrmModalForm.FRM_Btn_Cancel.Text = "Назад";
                    FrmModalForm.FRM_Btn_Res_App.Text = "ОК";
                    FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                    FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                    FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                    FrmModalForm.FRM_modalForm_logo.Visible = false;
                    FrmModalForm.FRM_Btn_OK.Visible = false;
                    FrmModalForm.FRM_Btn_Exit_App.Visible = false;
                    FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                    FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.RestartGif;
                    modalBackground.StartPosition = FormStartPosition.CenterScreen;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = .50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = fmWelcomeForm.Size;
                    modalBackground.Location = fmWelcomeForm.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    modal.Owner = modalBackground;

                    modal.ShowDialog();
                    modalBackground.Dispose();
                }
                if (CustomClass.bUserWantResApp) CustomClass.CallAnimationCloseForm(fmWelcomeForm);
            }

            catch
            {
                CustomClass.Alert("Критическая ошибка в системе!", Form_Alert.enmType.Warning);
            }
        } /// Вызов приветсвеннной формы 

        public static void CallExitApplicaton(FmWelcomeForm fmWelcomeForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            CustomClass.bUserWantCloseApp = true;
            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Выход из приложения...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Вы уверены что хотите выйти?.";
                FrmModalForm.FRM_Btn_Cancel.Text = "Назад";
                FrmModalForm.FRM_Btn_Exit_App.Text = "Выйти";
                FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = true;
                FrmModalForm.FRM_Btn_OK.Visible = false;
                FrmModalForm.FRM_Btn_Exit_App.Visible = true;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.ExitAppGif;
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmWelcomeForm.Size;
                modalBackground.Location = fmWelcomeForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
            if (CustomClass.bUserWantCloseApp)
            {
                CustomClass.CallAnimationCloseForm(fmWelcomeForm);
                Application.Exit();
            }
        } // Вызов формы выхода с приложения

        public static void CallAuthorizationForm(FmWelcomeForm fmWelcomeForm)
        {
            int parentX, parentY;

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            CustomClass.bBtnGoToAuthorizationFormClicked = true;
            Form modalBackground = new Form();
            using (FmAuthorizationForm authorization_Form = new FmAuthorizationForm())
            {

                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmWelcomeForm.Size;
                modalBackground.Location = fmWelcomeForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                authorization_Form.Owner = modalBackground;

                parentX = fmWelcomeForm.Location.X;
                parentY = fmWelcomeForm.Location.Y;

                authorization_Form.ShowDialog();
                modalBackground.Dispose();
            }
        } /// Вызов формы авторизации

        public static void CallRegistrationForm(FmWelcomeForm fmWelcomeForm)
        {
            int parentX, parentY;

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            Form modalBackground = new Form();
            using (FmRegistrationForm registration_Form = new FmRegistrationForm())
            {
                CustomClass.isOpenedFormRegistration = true;
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmWelcomeForm.Size;
                modalBackground.Location = fmWelcomeForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                registration_Form.Owner = modalBackground;

                parentX = fmWelcomeForm.Location.X;
                parentY = fmWelcomeForm.Location.Y;

                registration_Form.ShowDialog();
                modalBackground.Dispose();
            }
        }   /// Вызов формы регистрации

        public static void CheckedCompleteAuthorization(FmWelcomeForm fmWelcomeForm)
        {
            if (CustomClass.isCompleteAuthorization)
            {
                CustomClass.CallAnimationCloseForm(fmWelcomeForm);
                fmWelcomeForm.Close();
                Form Load_account_Form = new FmLoadAccountForm();
                Load_account_Form.Show();
            }
        }  /// Реализации проверки на авторизацию нового или уже существующего пользователя

        public static void CallFreeMemoryVoid(FmWelcomeForm fmWelcomeForm)
        {
            if (CustomClass.bUserWantCloseApp)
            {
                fmWelcomeForm.Dispose();
                GC.Collect();
            }
        } /// Метод для освобождения памяти от занятой формы     
    }
}

