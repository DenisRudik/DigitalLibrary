/// <summary>
/// Название файла - ChooseRoleFormClass.cs.
/// !--------------------------------Описание---------------------------!:
/// Файл для описания бэкенд логики формы выбора роли в информационной системе
/// Файл делится на две части:
/// Часть 1 - Описание поведения компонентов на форме и то как с ними взаимодействует пользователь (различные анимации появления, передвижения объектов)
/// Часть 2 - Описание логики данных компонентов
/// </summary>
/// <param name="fmChooseRoleForm"></param>
/// 


using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using modal;

namespace online_library_for_educ_inst
{ 
    public class ChooseRoleFormClass
    {
    
        //Часть 1 - Описание поведения компонентов на форме и то как с ними взаимодействует пользователь

        public static void GetActivatedTransparentComponent(FmChooseRoleForm fmChooseRoleForm)
        {
            fmChooseRoleForm.LblMainText.Parent = fmChooseRoleForm.PictBackgroundGif;
            // Make your label transparent
            fmChooseRoleForm.LblMainText.BackColor = Color.Transparent;

            fmChooseRoleForm.LblSubText.Parent = fmChooseRoleForm.PictBackgroundGif;

            fmChooseRoleForm.LblSubText.BackColor = Color.Transparent;

            fmChooseRoleForm.PictExitApp.Parent = fmChooseRoleForm.PictBackgroundGif;
            // Make PictureBox transparent

            fmChooseRoleForm.PictExitApp.BackColor = Color.Transparent;

            fmChooseRoleForm.Picture.Parent = fmChooseRoleForm.PictBackgroundGif;

            fmChooseRoleForm.Picture.BackColor = Color.Transparent;

            fmChooseRoleForm.PictLicense.Parent = fmChooseRoleForm.PictBackgroundGif;

            fmChooseRoleForm.PictLicense.BackColor = Color.Transparent;

            fmChooseRoleForm.PictUserIcon.Parent = fmChooseRoleForm.PictBackgroundGif;

            fmChooseRoleForm.PictUserIcon.BackColor = Color.Transparent;

            fmChooseRoleForm.PictAdminIcon.Parent = fmChooseRoleForm.PictBackgroundGif;

            fmChooseRoleForm.PictAdminIcon.BackColor = Color.Transparent;
        } // Присвоение всем компонентам на форме эффекта прозрачности

        public static void CallWelcomeMessage(FmChooseRoleForm fmChooseRoleForm)
        {
            fmChooseRoleForm.LblMainText.Text = "Добро пожаловать в Цифровой Уголок Знаний," + CustomClass.sSysUserName + "!.\n" +
                               "Рады видеть вас здесь! Наша библиотека предлагает широкий выбор книг на любой вкус. Ищите, читайте и наслаждайтесь увлекательными произведениями литературы \n" +
                               "прямо здесь, в удобном цифровом формате.Не забудьте воспользоваться поиском для быстрого доступа к нужным книгам. \n " +
                               "А если у вас возникнут вопросы или пожелания, обращайтесь \n" +
                               "— мы всегда готовы помочь. \n" +
                                "Приятного чтения!\n";

            fmChooseRoleForm.LblSubText.Text = CustomClass.sSysUserName + ",кем вы являетесь в цифровой библиотеке?";
        }

        public static void GetAnimationChangePict(FmChooseRoleForm fmChooseRoleForm) 
        {
            Random rnd = new Random();

            int rCountImages = rnd.Next(0, CustomClass.AMOUNT_PICTURES);

            fmChooseRoleForm.Picture.Image = fmChooseRoleForm.ImListSetPictures.Images[rCountImages++];
            rCountImages++;

            if (rCountImages < 0 || rCountImages >= CustomClass.AMOUNT_PICTURES)
            {
                rCountImages = 0;
            }
        }  /// Реализация появления различных иконок книг

        public static void GetAnimatedPanel(FmChooseRoleForm fmChooseRoleForm)
        {
            const int MS_DELAY = 1;
            bool isExpectation = false;
            bool isCheck = false;

            isCheck = !isCheck; /// WTF?

            fmChooseRoleForm.PanelSecondSide.MouseEnter += async (s, a) =>
            {
                while (!isExpectation && fmChooseRoleForm.PanelSecondSide.Location.X > fmChooseRoleForm.PanelFirstSide.Location.X + 10)
                {
                    isExpectation = true;
                    await Task.Delay(MS_DELAY);
                    fmChooseRoleForm.PanelSecondSide.Location = isCheck ? new Point(fmChooseRoleForm.PanelSecondSide.Location.X - 1, fmChooseRoleForm.PanelSecondSide.Location.Y) :
                    new Point(fmChooseRoleForm.PanelSecondSide.Location.X - 10, fmChooseRoleForm.PanelSecondSide.Location.Y);
                    isExpectation = false;
                }
            };
            fmChooseRoleForm.PanelFirstSide.MouseEnter += async (s, a) =>
            {
                while (!isExpectation && fmChooseRoleForm.PanelSecondSide.Location.X < fmChooseRoleForm.PanelFirstSide.Width)
                {
                    isExpectation = true;
                    await Task.Delay(MS_DELAY);
                    fmChooseRoleForm.PanelSecondSide.Location = isCheck ? new Point(fmChooseRoleForm.PanelSecondSide.Location.X + 10, fmChooseRoleForm.PanelSecondSide.Location.Y) :
                    new Point(fmChooseRoleForm.PanelSecondSide.Location.X + 10, fmChooseRoleForm.PanelSecondSide.Location.Y);
                    isExpectation = false;
                }
            };
        } /// Реализация плавного передвижения панели при навигации на нее курсором мыши

        public async static void GetAnimatedDrawText(FmChooseRoleForm fmChooseRoleForm)
        {
            byte shateOfRed = 19;
            byte shateOfGreen = 61;
            byte shateOfBlue = 101;
            byte desiredShateColor = 245;

            for (byte r = shateOfRed, g = shateOfGreen, b = shateOfBlue; r <= desiredShateColor & g <= desiredShateColor & b <= desiredShateColor; r += 5, g += 5, b += 5)
            {
                await Task.Delay(CustomClass.TIME_TO_DRAWING);
                fmChooseRoleForm.LblMainText.ForeColor = Color.FromArgb(r, g, b);
                fmChooseRoleForm.LblSubText.ForeColor = Color.FromArgb(r, g, b);
            }
        } /// Метод для появления плавного эффекта "выцветания" текста





        // Часть 2 - Описание логики компонентов
        public static void ExitFromApplication(FmChooseRoleForm fmChooseRoleForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            CustomClass.bUserWantCloseApp = true;
            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Выход с приложения...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Вы уверены что хотите выйти?";
                FrmModalForm.FRM_Btn_Cancel.Text = "Назад";
                FrmModalForm.FRM_Btn_Exit_App.Text = "Выйти";
                FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = true;
                FrmModalForm.FRM_Btn_OK.Visible = false;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.ExitAppGif;
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmChooseRoleForm.Size;
                modalBackground.Location = fmChooseRoleForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
            if (CustomClass.bUserWantCloseApp)
            {
                CustomClass.CallAnimationCloseForm(fmChooseRoleForm);
                Application.Exit();
            }
        } /// Вызов формы выхода из приложения 

        public static void CallWelcomeForm(FmChooseRoleForm fmChooseRoleForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            fmChooseRoleForm.ForeColor = Color.Aqua;
            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Пользователь...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "При нажатии на кнопку 'OK' откроется пользовательская форма.Продолжить?";
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = true;
                FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_Btn_Exit_App.Visible = false;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.UserGif;
                CustomClass.isBtnOkClicked = false;
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmChooseRoleForm.Size;
                modalBackground.Location = fmChooseRoleForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        } /// Вызов приветственной формы 

        public static void CallLicenseAgreement(FmChooseRoleForm fmChooseRoleForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClicked.ToString());
            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Лицензионное соглашение...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Ознакомьтесь с лицензионным соглашением перед тем как продолжить:";
                FrmModalForm.FRM_Btn_Cancel.Text = "Закрыть";
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Text = File.ReadAllText(CustomClass.sPathToFileLic);
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = true;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = false;
                FrmModalForm.FRM_Btn_OK.Visible = false;
                FrmModalForm.FRM_Btn_Exit_App.Visible = false;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.DocGif;
                modalBackground.StartPosition = FormStartPosition.CenterScreen;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmChooseRoleForm.Size;
                modalBackground.Location = fmChooseRoleForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                modal.Owner = modalBackground;

                modal.ShowDialog();
                modalBackground.Dispose();

            }
        }/// Вызов формы с лицензионным соглашением конечного пользователя

        public static void GetActivateWelcomeForm(FmChooseRoleForm fmChooseRoleForm)
        {
            if (CustomClass.isOpenedWelcomeForm)
            {
                CustomClass.CallAnimationCloseForm(fmChooseRoleForm);
                CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundClose.ToString());
                Form Welcome_Form = new FmWelcomeForm();
                Welcome_Form.Show();
                fmChooseRoleForm.Close();
            }
        } /// Переход на приветственную форму

        

        

    }
}
