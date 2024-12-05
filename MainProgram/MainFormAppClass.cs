

/// <summary>
//Название файла - MainFormAppClass.cs.
/// !--------------------------------Описание---------------------------!:
// Класс реализующий программную логику главной формы приложения "Digital Desktop Library". Описаны методы для работы с данными пользователей и получения их статусов в реальном времени. 

// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем. Реализицая различных анимаций объектов и изменения их состояний в зависимости от внешних факторов (p.s. изменений данных в БД)
// Часть 2 - Реализация методов для работы с данными пользователей.
/// <summary>
/// <param name="fmMainFormApp"></param>
/// 


using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using MySqlConnector;
using modal;
using yt_DesignUI;

namespace online_library_for_educ_inst
{
    public class MainFormAppClass
    {
        // Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем. Реализицая различных анимаций объектов и изменения их состояний в зависимости от внешних факторов (p.s. изменений данных в БД)

        public static void GetPictureLogoLocation(FmMainFormApp fmMainFormApp)
        {
            fmMainFormApp.PictLogoApp.Location = new Point(375, 77);
        }  /// Метод задающий положения изображения при появлении формы

        public static void GetShowStartMessage()
        {
            CustomClass.Alert("Добро пожаловать в электронную библиотеку: " + CustomClass.sNickNameNewUser + "!", Form_Alert.enmType.Info);
        } /// Вывод приветствующего сообщения при входе в систему

        public static void GetLowerComponentTile(FmMainFormApp fmMainFormApp)
        {
            fmMainFormApp.LowerComponentTile.Text = "Аккаунт: " + CustomClass.sNickNameNewUser + string.Format(" ({0}) ", " баланс аккаунта " + CustomClass.sBalance + " рублей ");
        } /// Вывод краткой информации об аккаунте: Никнейм пользователя,баланс на аккаунте

        public static void GetCurrentSubscription(FmMainFormApp fmMainFormApp)
        {
            if (CustomClass.sSubscriptionNewUser == "")
            {
                fmMainFormApp.PictSub.Image = Properties.Resources.EmptySubUser;
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictSub, "Похоже, вы не оформили подписку...");
            }
              
            if (CustomClass.sSubscriptionNewUser == "1")
            {
                fmMainFormApp.PictSub.Image = Properties.Resources.DigitalLibrary;
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictSub, "Действующая подписка на этом аккаунте - " + string.Format("({0})", "Подписка на месяц"));
            }
                

            if (CustomClass.sSubscriptionNewUser == "2")
            {
                fmMainFormApp.PictSub.Image = Properties.Resources.BookLove;
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictSub, "Действующая подписка на этом аккаунте - " + string.Format("({0})", "Художественная литература"));
            }
                

            if (CustomClass.sSubscriptionNewUser == "3")
            {
                fmMainFormApp.PictSub.Image = Properties.Resources.BookMap;
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictSub, "Действующая подписка на этом аккаунте - " + string.Format("({0})", "Учебная литература"));
            }
                
        } /// Реализация метода для получения статуса оформленной подписки пользователем

        public static void GetBalanceDataUser()
        {
            if (CustomClass.sBalance == null)
                CustomClass.sBalance = "0";
        } /// Метод для изъятия данных о балансе пользователя

        public static void GetSexDataUser(FmMainFormApp fmMainFormApp)
        {
            if (CustomClass.sSexNewUser == "Женщина")
                fmMainFormApp.BtnUserProfile.Image = Properties.Resources.ShowFemaleProfile;

            if (CustomClass.sSexNewUser == "Мужчина")
                fmMainFormApp.BtnUserProfile.Image = Properties.Resources.ShowMaleProfile;
        } /// Получение информации о гендере пользователя 

        public static void CallOnMouseEnterPictSub(FmMainFormApp fmMainFormApp)
        {
            if (CustomClass.sSubscriptionNewUser == "")
                GetCurrentSubscription(fmMainFormApp);

            if (CustomClass.sSubscriptionNewUser == "1")
                GetCurrentSubscription(fmMainFormApp);

            if (CustomClass.sSubscriptionNewUser == "2")
                GetCurrentSubscription(fmMainFormApp);

            if (CustomClass.sSubscriptionNewUser == "3")
                GetCurrentSubscription(fmMainFormApp);
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallAnimationSideBar(FmMainFormApp fmMainFormApp)
        {
            if (CustomClass.bActivateAnimation)
            {
                while (fmMainFormApp.SideBarPanel.Width != fmMainFormApp.SideBarPanel.MinimumSize.Width)
                {
                    fmMainFormApp.SideBarPanel.Width -= 10;
                    Thread.Sleep(10);
                }
                fmMainFormApp.BtnOpenBooks.Visible = false;
                fmMainFormApp.BtnUserProfile.Visible = false;
                fmMainFormApp.BtnSettings.Visible = false;
                fmMainFormApp.BtnExitApp.Visible = false;
                fmMainFormApp.BtnReturnBack.Visible = false;
                fmMainFormApp.BtnShowSub.Visible = false;
                CustomClass.bActivateAnimation = false;
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictMenu, "закрыть меню...");
                fmMainFormApp.PictLogoApp.Location = new Point(375, 77);
                fmMainFormApp.TopComponentTile.Size = new Size(951, 27);
                fmMainFormApp.TopComponentTile.Location = new Point(-1, 0);
            }
            else if (CustomClass.bActivateAnimation == false)
            {
                while (fmMainFormApp.SideBarPanel.Width != fmMainFormApp.SideBarPanel.MaximumSize.Width)
                {
                    fmMainFormApp.SideBarPanel.Width += 10;
                    Thread.Sleep(10);
                }
                fmMainFormApp.BtnOpenBooks.Visible = true;
                fmMainFormApp.BtnUserProfile.Visible = true;
                fmMainFormApp.BtnSettings.Visible = true;
                fmMainFormApp.BtnExitApp.Visible = true;
                fmMainFormApp.BtnReturnBack.Visible = true;
                fmMainFormApp.BtnShowSub.Visible = true;
                CustomClass.bActivateAnimation = true;
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictMenu, "открыть меню...");
                fmMainFormApp.PictLogoApp.Location = new Point(340, 77);
                fmMainFormApp.TopComponentTile.Size = new Size(727, 27);
                fmMainFormApp.TopComponentTile.Location = new Point(223, -1);
                fmMainFormApp.LowerComponentTile.Size = new Size(951, 27);
                fmMainFormApp.LowerComponentTile.Location = new Point(-1, 652);
            }
        } /// Вызов анимации для боковой панели на форме   

        public static void CallOnMouseEnterMenuBtn(FmMainFormApp fmMainFormApp)
        {
            if (CustomClass.bActivateAnimation)
            {
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictMenu, "закрыть меню...");
            }
            else
            {
                fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.PictMenu, "открыть меню...");
            }
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterBtnOpenBooks(FmMainFormApp fmMainFormApp)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            fmMainFormApp.BtnOpenBooks.ForeColor = Color.PaleGreen;

            fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.BtnOpenBooks, "выбрать литературу...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterBtnUserProfile(FmMainFormApp fmMainFormApp)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            fmMainFormApp.BtnUserProfile.ForeColor = Color.PaleGreen;

            fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.BtnUserProfile, "перейти в свой профиль...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterBtnExitApp(FmMainFormApp fmMainFormApp)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            fmMainFormApp.BtnExitApp.ForeColor = Color.PaleGreen;

            fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.BtnExitApp, "выйти с программы...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterBtnShowSub(FmMainFormApp fmMainFormApp)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            fmMainFormApp.BtnShowSub.ForeColor = Color.PaleGreen;

            fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.BtnShowSub, "просмотреть доступные подписки...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterBtnSettings(FmMainFormApp fmMainFormApp)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            fmMainFormApp.BtnSettings.ForeColor = Color.PaleGreen;

            fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.BtnSettings, "настройки приложения...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterBtnReturnBack(FmMainFormApp fmMainFormApp)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

            fmMainFormApp.BtnReturnBack.ForeColor = Color.PaleGreen;

            fmMainFormApp.ToolTipHelpUser.SetToolTip(fmMainFormApp.BtnReturnBack, "вернуться к стартовой форме...");
        } // Вызов анимации для компонента если на него наведен курсор мыши 





        // Часть 2 - Реализация методов для работы с данными пользователей.

        public async static void CallUpdateDataUser()
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sGetBalance;

                string sQuery = "SELECT Баланс FROM `DB_online_library`.`BankDetails` WHERE `PK_номер_карты` = @PK_номер_карты";

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);
                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            sGetBalance = dr["Баланс"].ToString();

                            CustomClass.sBalance = sGetBalance;
                        }
                    }
                }
            }

            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sFKSubscription;

                string sQuery = "SELECT * FROM Users WHERE PK_Зачётка = @PK_Зачётка";

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PK_Зачётка", CustomClass.sNumberGradebook);
                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            sFKSubscription = dr["FK_Подписка"].ToString();

                            CustomClass.sSubscriptionNewUser = sFKSubscription;

                        }
                    }
                }
            }

            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sGetFullNameSub;

                string sQuery = "SELECT `Наименование` FROM `DB_online_library`.`Subscription` WHERE `PK_подписки` = @PK_подписки";

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@PK_подписки", CustomClass.sSubscriptionNewUser);
                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            sGetFullNameSub = dr["Наименование"].ToString();
                            CustomClass.sActiveSub = sGetFullNameSub;
                        }
                    }
                }
            }
        } /// Основной метод. Реализация обновления данных пользователя. Если пользователь будет взаимодействовать с компонентами формы или самой формой (например, передвинет ее) то форма обновит свое состояние,
        /// пошлет запрос на обновление к БД, тем самым выведя актуальную информацию о статусе аккаунта на данный момент времени. 

        public static void CallFormAvailableSub(FmMainFormApp fmMainFormApp)
        {
            int iParentX, iParentY;

            if (CustomClass.sSubscriptionNewUser == "")
            {
                CustomClass.Alert("Оформите подписку перед тем как выбрать книгу!", Form_Alert.enmType.Error);
            }
            else
            {
                Form modalBackground = new Form();
                using (Form FormGenreBook = new FmFormGenreBook())
                {

                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = .50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = fmMainFormApp.Size;
                    modalBackground.Location = fmMainFormApp.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();

                    iParentX = fmMainFormApp.Location.X;
                    iParentY = fmMainFormApp.Location.Y;

                    FormGenreBook.ShowDialog();
                    modalBackground.Dispose();
                }
            }
        }/// Вызов окна оформления подписки 

        public static void CallFormUserProfile(FmMainFormApp fmMainFormApp)
        {
            int iParentX, iParentY;

            Form modalBackground = new Form();
            using (FmUserInfoForm user_info_Form = new FmUserInfoForm())
            {

                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmMainFormApp.Size;
                modalBackground.Location = fmMainFormApp.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                iParentX = fmMainFormApp.Location.X;
                iParentY = fmMainFormApp.Location.Y;

                user_info_Form.ShowDialog();
                modalBackground.Dispose();

            }
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } /// Вызов формы информации о профиле пользователя

        public static void CallFormExitApplication(FmMainFormApp fmMainFormApp)
        {
            int iParentX, iParentY;

            CustomClass.bUserWantCloseApp = true;
            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Выход из приложения...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Вы уверены что хотите выйти?.";
                FrmModalForm.FRM_Btn_Cancel.Text = "Назад";
                FrmModalForm.FRM_Btn_Exit_App.Text = "Выйти";
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = true;
                FrmModalForm.FRM_Btn_OK.Visible = false;
                FrmModalForm.FRM_Btn_Exit_App.Visible = true;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.ExitAppGif;
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmMainFormApp.Size;
                modalBackground.Location = fmMainFormApp.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                iParentX = fmMainFormApp.Location.X;
                iParentY = fmMainFormApp.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
            if (CustomClass.bUserWantCloseApp)
            {
                CustomClass.CallAnimationCloseForm(fmMainFormApp);
                Application.Exit();
            }

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } /// Вызов формы выхода с программы

        public static void GetCheckSubscriptionUser(FmMainFormApp fmMainFormApp)
        {
            int iParentX, iParentY;
            try
            {
                if (CustomClass.sSubscriptionNewUser == "")
                {
                    Form modalBackground = new Form();
                    using (FmFormSubcription frmSub = new FmFormSubcription())
                    {

                        modalBackground.StartPosition = FormStartPosition.Manual;
                        modalBackground.FormBorderStyle = FormBorderStyle.None;
                        modalBackground.Opacity = .50d;
                        modalBackground.BackColor = Color.Black;
                        modalBackground.Size = fmMainFormApp.Size;
                        modalBackground.Location = fmMainFormApp.Location;
                        modalBackground.ShowInTaskbar = false;
                        modalBackground.Show();

                        iParentX = fmMainFormApp.Location.X;
                        iParentY = fmMainFormApp.Location.Y;

                        frmSub.ShowDialog();
                        modalBackground.Dispose();

                    }
                }
                else
                {
                    CustomClass.Alert("У вас уже есть оформленная подписка - " + string.Format("({0})", CustomClass.sActiveSub), Form_Alert.enmType.Warning);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                fmMainFormApp.Close();
            }
        } /// Реализация логики проверки оформленности у пользователя подписки

        public static void CallFormSettingsApplication(FmMainFormApp fmMainFormApp)
        {
            int iParentX, iParentY;

            Form modalBackground = new Form();
            using (FmAppOptionsForm app_options_Form = new FmAppOptionsForm())
            {

                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmMainFormApp.Size;
                modalBackground.Location = fmMainFormApp.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                iParentX = fmMainFormApp.Location.X;
                iParentY = fmMainFormApp.Location.Y;

                app_options_Form.ShowDialog();
                modalBackground.Dispose();
            }
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } /// Вызов формы настроек приложения

        public static void CallFormRestartApplication(FmMainFormApp fmMainFormApp)
        {
            int iParentX, iParentY;

            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());

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
                    FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                    FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                    FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                    FrmModalForm.FRM_modalForm_logo.Visible = false;
                    FrmModalForm.FRM_Btn_OK.Visible = false;
                    FrmModalForm.FRM_Btn_Exit_App.Visible = false;
                    FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                    FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.GifBackForm;
                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = .50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = fmMainFormApp.Size;
                    modalBackground.Location = fmMainFormApp.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();

                    iParentX = fmMainFormApp.Location.X;
                    iParentY = fmMainFormApp.Location.Y;

                    modal.ShowDialog();
                    modalBackground.Dispose();
                }
                if (CustomClass.bUserWantResApp) CustomClass.CallAnimationCloseForm(fmMainFormApp);
            }

            catch
            {
                CustomClass.Alert("Критическая ошибка в системе!", Form_Alert.enmType.Warning);
            }

            if ((CustomClass.bUserWantSub && CustomClass.bWantSubToMonth) || (CustomClass.bUserWantSub && CustomClass.bWantSubArtistic) || (CustomClass.bUserWantSub && CustomClass.bWantSubScientific))
            {
                CustomClass.CallAnimationCloseForm(fmMainFormApp);
                Application.Restart();
            }
        } // Вызов формы возврата к стартовому окну приложения

    } 

}
