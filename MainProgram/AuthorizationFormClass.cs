/// <summary>
//Название файла - AuthorizationFormClass.cs.
/// !--------------------------------Описание---------------------------!:
// Класс описуемый программную логику формы авторизации существующих пользователей в системе.Файл поделен на две части:
// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
// Часть 2 - Работа с БД описание логики выборки и проверки данных на принадлежность к конретному пользователю системы  

/// <summary>
/// <param name="fmAuthorizationForm"></param>


using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;
using MySqlConnector;
using CustomAlertBoxDemo;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{
    public class AuthorizationFormClass
    {
        // Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем

        public static void CallPasswordChar(FmAuthorizationForm fmAuthorizationForm)
        {
            fmAuthorizationForm.TxtPass.PasswordChar = '*';
            fmAuthorizationForm.TxtConfirmPass.PasswordChar = '*';
        } /// Вызов маски ввода для тех компонентов в которых присутствуют личные данные пользователей

        public static void ActivatedTransparentComponent(FmAuthorizationForm fmAuthorizationForm)
        {
            fmAuthorizationForm.LblTopMessage.BackColor = Color.Transparent;

            fmAuthorizationForm.PictTopLogo.BackColor = Color.Transparent;

            fmAuthorizationForm.PictTxtRecordBook.BackColor = Color.Transparent;

            fmAuthorizationForm.PictTxtPass.BackColor = Color.Transparent;

            fmAuthorizationForm.PictConfirmPass.BackColor = Color.Transparent;

            fmAuthorizationForm.LblGotoReg.BackColor = Color.Transparent;

            fmAuthorizationForm.LblGotoLostAcc.BackColor = Color.Transparent;

            fmAuthorizationForm.LblGotoWelcomeForm.BackColor = Color.Transparent;
        } /// Активация у компонентов на форме эффекта прозрачности

        public static void CallPromptText(FmAuthorizationForm fmAuthorizationForm)
        {
            fmAuthorizationForm.TxtRecordBook.Text = "Prompt";

            fmAuthorizationForm.TxtRecordBook.Clear();

            fmAuthorizationForm.TxtPass.Text = "Prompt";

            fmAuthorizationForm.TxtPass.Clear();

            fmAuthorizationForm.TxtConfirmPass.Text = "Prompt";

            fmAuthorizationForm.TxtConfirmPass.Clear();
        } /// Присвоение компонентам TextBox "подсказок" для улучшения пользовательского опыта в использовании формы

        public async static Task CallAnimatedDrawText(FmAuthorizationForm fmAuthorizationForm)
        {
            byte shateOfRed = 20;
            byte shateOfGreen = 25;
            byte shateOfBlue = 100;
            byte desiredShateColor = 250;

            for (byte r = shateOfRed, g = shateOfGreen, b = shateOfBlue; r <= desiredShateColor & g <= desiredShateColor & b <= desiredShateColor; r += 5, g += 5, b += 5)
            {
                if (r == 250 || g == 250 || b == 250) break;
                else
                {
                    await Task.Delay(CustomClass.TIME_TO_DRAWING);
                    fmAuthorizationForm.LblTopMessage.ForeColor = Color.FromArgb(r, g, b);
                }

            }
        } /// Реализация анимации плавного появления текста на форме

        public static void CallOnMouseEnterPictTxtRecordBook(FmAuthorizationForm fmAuthorizationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.PictTxtRecordBook.Image = Properties.Resources.PictRegRecordBook;
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.PictTxtRecordBook, "Введите номер своей зачётки...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictTxtPass(FmAuthorizationForm fmAuthorizationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.PictTxtPass.Image = Properties.Resources.PictRegPass;
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.PictTxtPass, "Введите пароль от учётной записи...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictConfirmPass(FmAuthorizationForm fmAuthorizationForm) 
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.PictConfirmPass.Image = Properties.Resources.PictRegPass;
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.PictConfirmPass, "Повторите пароль...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictEyePassToTxtPass(FmAuthorizationForm fmAuthorizationForm)
        {
            fmAuthorizationForm.TxtPass.PasswordChar = '\0';
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.PictEyePassToTxtPass.Image = Properties.Resources.PictAuthHidePass;
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.PictEyePassToTxtPass, "Скрыть пароль...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictTxtConfirmPass(FmAuthorizationForm fmAuthorizationForm)
        {
            fmAuthorizationForm.TxtConfirmPass.PasswordChar = '\0';
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.PictTxtConfirmPass.Image = Properties.Resources.PictAuthHidePass;
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.PictTxtConfirmPass, "Скрыть пароль...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblGotoWelcomeForm(FmAuthorizationForm fmAuthorizationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.LblGotoWelcomeForm, "Выйти с формы авторизации");
            fmAuthorizationForm.LblGotoWelcomeForm.ForeColor = Color.FromArgb(20, 144, 27);
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblGotoReg(FmAuthorizationForm fmAuthorizationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.LblGotoReg, "Перейти к форме регистрации");
            fmAuthorizationForm.LblGotoReg.ForeColor = Color.FromArgb(20, 144, 27);
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblGotoLostAcc(FmAuthorizationForm fmAuthorizationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.LblGotoLostAcc, "Перейти к мастеру восстановления аккаунтов");
            fmAuthorizationForm.LblGotoLostAcc.ForeColor = Color.FromArgb(20, 144, 27);
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictDelTxtRecordBook(FmAuthorizationForm fmAuthorizationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmAuthorizationForm.PictDelTxtRecordBook.Image = Properties.Resources.TrashCanGifAuth;
            fmAuthorizationForm.ToolTipHelpUser.SetToolTip(fmAuthorizationForm.PictDelTxtRecordBook, "Удалить данные с поля зачётки");
        } // Вызов анимации для компонента если на него наведен курсор мыши







        // Часть 2 - Работа с БД описание логики выборки и проверки данных на принадлежность к конретному пользователю системы  

        

        public static void GetRegistrationForm(FmAuthorizationForm fmAuthorizationForm)
        {
            int parentX, parentY;

            if (CustomClass.isOpenedFormAuthorization)
            {
                CustomClass.Alert("Форма регистрации уже открыта", Form_Alert.enmType.Info);
                fmAuthorizationForm.Close();
            }

            if (CustomClass.bBtnGoToAuthorizationFormClicked)
            {
                Form modalBackground = new Form();
                using (FmRegistrationForm registration_From = new FmRegistrationForm())
                {

                    modalBackground.StartPosition = FormStartPosition.Manual;
                    modalBackground.FormBorderStyle = FormBorderStyle.None;
                    modalBackground.Opacity = .50d;
                    modalBackground.BackColor = Color.Black;
                    modalBackground.Size = fmAuthorizationForm.Size;
                    modalBackground.Location = fmAuthorizationForm.Location;
                    modalBackground.ShowInTaskbar = false;
                    modalBackground.Show();
                    registration_From.Owner = modalBackground;

                    parentX = fmAuthorizationForm.Location.X;
                    parentY = fmAuthorizationForm.Location.Y;

                    registration_From.ShowDialog();
                    modalBackground.Dispose();
                }
                CustomClass.bBtnGoToAuthorizationFormClicked = false;
            }
        } /// Вызов формы регистрации внутри формы авторизации

        public static void GetLostAccountForm(FmAuthorizationForm fmAuthorizationForm)
        {
            int parentX, parentY;

            fmAuthorizationForm.LblGotoLostAcc.ForeColor = Color.FromArgb(20, 144, 27);

            Form modalBackground = new Form();
            using (FmPasswordRecoveryAssistantForm password_Recovery_assistant_Form = new FmPasswordRecoveryAssistantForm())
            {

                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmAuthorizationForm.Size;
                modalBackground.Location = fmAuthorizationForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                password_Recovery_assistant_Form.Owner = modalBackground;

                parentX = fmAuthorizationForm.Location.X;
                parentY = fmAuthorizationForm.Location.Y;

                password_Recovery_assistant_Form.ShowDialog();
                modalBackground.Dispose();
            }
        } /// Вызов формы восстановления аккаунта 

        public static void GetDeleteDataTxtRecordBook(FmAuthorizationForm fmAuthorizationForm)
        {
            fmAuthorizationForm.TxtRecordBook.Text = null;
            CustomClass.Alert("Данные о зачётки успешно удалены!", Form_Alert.enmType.Info);
        } /// Реализация удаления данных с компонента номера зачетной книжки пользователя

        public static void CallPasswordRecoveryAssistantForm(FmAuthorizationForm fmAuthorizationForm)
        {

            if (CustomClass.iCountWrongPassword == CustomClass.COUNT_INCORRECT_ATTEMPTS)
            {
                if (MessageBox.Show("Система обнаружила частый некорректный ввод пароля для аккаунта с данным номером зачётки. Желаете восстановить пароль?", "Внимание!",
                MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CustomClass.sBufferNumberDocumentForRecoveryAssistant = fmAuthorizationForm.TxtRecordBook.Text;

                    CustomClass.isShowMessageRecoveryAssistantForm = true;

                    GetLostAccountForm(fmAuthorizationForm);
                }
                CustomClass.iCountWrongPassword = 0;
            }
        } /// Описание логики вызова формы восстановления аккаунта

        public static string GetSHA256Hash(string enteredPasswordHash)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(enteredPasswordHash));
                StringBuilder builder = new StringBuilder();

                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        } /// Метод для шифровки введеного пароля пользователем в хеш-значение

        public static async Task GetCheckData(FmAuthorizationForm fmAuthorizationForm)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();

                    string sGetPK, sGetNick, sGetUserPass, sRecoveryCode, sSex, sFKSubscription, sBankDetail;

                    string sQuery = "SELECT * FROM Users WHERE PK_Зачётка = @PK_Зачётка";

                    using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@PK_Зачётка", fmAuthorizationForm.TxtRecordBook.Text);
                        using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                        {
                            while (await dr.ReadAsync())
                            {
                                sGetPK = dr["PK_Зачётка"].ToString();
                                sGetNick = dr["NickName"].ToString();
                                sGetUserPass = dr["Пароль"].ToString();
                                sRecoveryCode = dr["Код_восстановления"].ToString();
                                sSex = dr["Пол"].ToString();
                                sFKSubscription = dr["FK_Подписка"].ToString();
                                sBankDetail = dr["FK_Банк_данные"].ToString();

                                CustomClass.sNumberGradebook = sGetPK;
                                CustomClass.sNickNameNewUser = sGetNick;
                                CustomClass.sPasswordNewUser = sGetUserPass;
                                CustomClass.sRecoveryCode = sRecoveryCode;
                                CustomClass.sSexNewUser = sSex;
                                CustomClass.sSubscriptionNewUser = sFKSubscription;
                                CustomClass.sBankDetails = sBankDetail;

                            }
                        }

                        string sGetCvv, sGetBalance;

                        string sGetDataBalanceQuery = "SELECT * FROM `DB_online_library`.`BankDetails` WHERE PK_номер_карты = @PK_номер_карты";

                        using (MySqlCommand comm = new MySqlCommand(sGetDataBalanceQuery, conn))
                        {
                            comm.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);
                            using (MySqlDataReader dr = await comm.ExecuteReaderAsync())
                            {
                                while (await dr.ReadAsync())
                                {
                                    sGetCvv = dr["CVV"].ToString();
                                    sGetBalance = dr["Баланс"].ToString();

                                    CustomClass.sCVV = sGetCvv;
                                    CustomClass.sBalance = sGetBalance;

                                }

                            }
                        }
                    }
                }
                string sPasswordFromTxt = GetSHA256Hash(fmAuthorizationForm.TxtPass.Text);

                string sConfPass = GetSHA256Hash(fmAuthorizationForm.TxtConfirmPass.Text);
                if ((fmAuthorizationForm.TxtRecordBook.Text != "") && (fmAuthorizationForm.TxtPass.Text != "")
                                               && (fmAuthorizationForm.TxtConfirmPass.Text != ""))
                {
                    string sPasswordHashFromDB = CustomClass.sPasswordNewUser;
                    if (sPasswordFromTxt != sPasswordHashFromDB)
                    {
                        CustomClass.Alert("Не верный пароль для данного номера зачётки!.Учтите его регистр", Form_Alert.enmType.Info);
                        CustomClass.iCountWrongPassword += 1;
                    }
                    else if (sPasswordFromTxt == sPasswordHashFromDB && sConfPass == sPasswordHashFromDB)
                    {
                        CustomClass.isCompleteAuthorization = true; /// если поле true, в форме Registation_Form при вызове 
                                                                    /// события Load() вызываем метод Dispose(),который будет удалять эту форму тем самым не создавая новый экземпляр формы

                        CustomClass.CallAnimationCloseForm(fmAuthorizationForm);
                        CustomClass.Alert("Авторизация прошла успешно.Подождите,осуществляется вход в аккаунт...", Form_Alert.enmType.Success);
                        Form Load_account_Form = new FmLoadAccountForm();
                        Load_account_Form.Show();
                    }
                }
            }
            catch (MySqlException)
            {
                CustomClass.Alert("Возникла ошибка при попытке соединения с сервером!.Проверьте работу OsPanel", Form_Alert.enmType.Error);
            }
        } /// Реализация основного метода авторизации данных пользователя. Запускается процесс асинхронной выборки с БД и осуществляется ряд валидационных алгоритмов над этими данными
          /// В случае правильно введеных данных, происходит процесс передачи записи в загрузочную форму аккаунта пользователя и загрузки основного окна программы

        public static async Task GetCheckPrimaryKeyUser(FmAuthorizationForm fmAuthorizationForm)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand sql = new MySqlCommand("SELECT * FROM Users WHERE Pk_Зачётка = @PK_Зачётка", conn);
                sql.Parameters.AddWithValue("@PK_Зачётка", fmAuthorizationForm.TxtRecordBook.Text);

                using (MySqlDataReader reader = await sql.ExecuteReaderAsync())
                {
                    if (!await reader.ReadAsync() && fmAuthorizationForm.TxtRecordBook.Text != "")
                    {
                        CustomClass.Alert("Пользователь с таким номером зачётки не найден!", Form_Alert.enmType.Error);
                    }
                }

            }
        } /// Описание метода нахождения не существующего пользователя по номеру его зачетной книжки

        public static void GetCheckNumberCharacters(FmAuthorizationForm fmAuthorizationForm)
        {
            string sNumberDigit = Convert.ToString(fmAuthorizationForm.TxtRecordBook.Text); // подчсчёт кол-ва символов из TxtPass.Text 

            if (sNumberDigit.Length < CustomClass.COUNT_DIGIT_FOR_DOCUMENT)
            {
                fmAuthorizationForm.TxtRecordBook.Text = null;
                CustomClass.Alert("Номер студенческого билета не может быть меньше 7 цифр!", Form_Alert.enmType.Error);
            }
        } /// Реализация проверки на количество введеных символов номера зачетки

        public static void GetComparisonPass(FmAuthorizationForm fmAuthorizationForm)
        {
            string sPass, sConfirmPass;

            sPass = fmAuthorizationForm.TxtPass.Text;
            sConfirmPass = fmAuthorizationForm.TxtConfirmPass.Text;

            if (sPass != sConfirmPass)
                CustomClass.Alert("Пароли не совпадают!.Проверьте корректность ввода.", Form_Alert.enmType.Error);
        } /// Метод для сравнения паролей на корректность, если пользователь ввел его неправильно со второго раза

        public static void GetCheckNullTxtBox(FmAuthorizationForm fmAuthorizationForm)
        {
            if (string.IsNullOrEmpty(fmAuthorizationForm.TxtRecordBook.Text) || string.IsNullOrEmpty(fmAuthorizationForm.TxtConfirmPass.Text) ||
                string.IsNullOrEmpty(fmAuthorizationForm.TxtPass.Text))
            {
                CustomClass.Alert("Не заполнены необходимые данные для регистрации!", Form_Alert.enmType.Error);
            }
        } /// Проверка на заполненость всех компонентов для ввода данных

        public static void GetDisabledCharacters(KeyPressEventArgs e)
        {
            CustomClass.OnlyNum(e);
            CustomClass.DisableSpace(e);
            CustomClass.DisableSymbols(e);
        } /// Метод для запрета ввода пробелов и любых символов в поле ввода зачетного номера студента

        public static void GetRecoveredPassword(FmAuthorizationForm fmAuthorizationForm)
        {
            CustomClass.ShowRecoveryPasswordForUser();
            fmAuthorizationForm.TxtPass.Text = CustomClass.sBufferRecoveredPassword;
            fmAuthorizationForm.TxtConfirmPass.Text = CustomClass.sBufferRecoveredPassword;
        } /// Реализация вставки из буфера обмена в текстовый компонент найденого пароля от забытого аккаунта пользователя при помощи
          /// формы восстановления аккаунтов

        public static void CallFreeMemoryVoid(FmAuthorizationForm fmAuthorizationForm)
        {
            GC.Collect();
            fmAuthorizationForm.Dispose();
        } /// Метод для освобождения памяти занимаемой формой  

    }
}
