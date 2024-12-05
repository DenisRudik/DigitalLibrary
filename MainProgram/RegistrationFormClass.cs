
/// <summary>
//Название файла - RegistrationFormClass.cs.
/// !--------------------------------Описание---------------------------!:
// В этом файле описывается вся бэкенд составляющая формы "Registration Form". Файл поделен на две части:
// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
// Часть 2 - Работа с БД и описание логики валидации данных 

/// <summary>
/// <param name="fmRegistrationForm"></param>



using System;
using System.IO;
using System.Security.Cryptography;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using modal;
using MySqlConnector;




namespace online_library_for_educ_inst
{
    public class RegistrationFormClass
    {
       

        /// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
        public static void IsOpenedFormRegistration(FmRegistrationForm fmRegistrationForm)
        {
            if (CustomClass.isOpenedFormRegistration)
            {
                FmChooseRoleForm.FRM_Choose_role_Form_Instanse.Dispose();
                CustomClass.isOpenedChooseRoleForm = false;
                CustomClass.isOpenedWelcomeForm = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Checked = false;
            }
        } /// Проверка на отркытость текущей формы

        public static void ActivatedTransparentComponent(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.PictTopLogo.BackColor = Color.Transparent;

            fmRegistrationForm.LblTopMessage.BackColor = Color.Transparent;

            fmRegistrationForm.PictTxtRecordBook.BackColor = Color.Transparent;

            fmRegistrationForm.PictNickname.BackColor = Color.Transparent;

            fmRegistrationForm.PictTxtPass.BackColor = Color.Transparent;

            fmRegistrationForm.PictRecoveryCode.BackColor = Color.Transparent;

            fmRegistrationForm.PictSex.BackColor = Color.Transparent;
        } /// Активация у компонентов на форме эффекта прозрачности

        public async static Task CallAnimatedDrawText(FmRegistrationForm fmRegistrationForm)
        {
            byte shateOfRed = 75;
            byte shateOfGreen = 0;
            byte shateOfBlue = 130;
            byte desiredShateColor = 254;

            for (byte r = shateOfRed, g = shateOfGreen, b = shateOfBlue; r <= desiredShateColor & g <= desiredShateColor & b <= desiredShateColor; r += 12, g += 8, b += 7)
            {
                await Task.Delay(CustomClass.TIME_TO_DRAWING);
                fmRegistrationForm.LblTopMessage.ForeColor = Color.FromArgb(r, g, b);
                fmRegistrationForm.LblHaveAccount.ForeColor = Color.FromArgb(r, g, b);
                fmRegistrationForm.LblSex.ForeColor = Color.FromArgb(r, g, b);

            }
        } /// Реализация анимации плавного появления текста на форме

        public static void CallPromptText(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtRecordBook.Text = "Prompt";

            fmRegistrationForm.TxtRecordBook.Clear();

            fmRegistrationForm.TxtNickName.Text = "Prompt";

            fmRegistrationForm.TxtNickName.Clear();

            fmRegistrationForm.TxtPass.Text = "Prompt";

            fmRegistrationForm.TxtPass.Clear();

            fmRegistrationForm.TxtRecoveryCode.Text = "Prompt";

            fmRegistrationForm.TxtRecoveryCode.Clear();

            fmRegistrationForm.McBoxSex.SelectedIndex = 0;
        } /// Присвоение компонентам TextBox "подсказок" для улучшения пользовательского опыта в использовании формы

        public static void CallPasswordChar(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtPass.PasswordChar = '*';

            fmRegistrationForm.TxtRecoveryCode.PasswordChar = '*';
        } /// Вызов маски ввода для тех компонентов в которых присутствуют личные данные пользователей

        public static void CallOnMouseEnterRecordBook(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictTxtRecordBook.Image = Properties.Resources.PictRegRecordBookCursored;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictTxtRecordBook, "Введите номер своей зачётки...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictNickname(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictNickname.Image = Properties.Resources.PictRegNickNameCursored;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictNickname, "Введите свой никнейм...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictTxtPass(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictTxtPass.Image = Properties.Resources.PictRegPassCursored;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictTxtPass, "Введите пароль для вашей учетной записи...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictRecoveryCode(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictRecoveryCode.Image = Properties.Resources.PictRegSecretPassCursored;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictRecoveryCode, "Введите секретное слово для восстановления пароля...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictSex(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictSex.Image = Properties.Resources.PictRegSexCursored;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictSex, "Выберите вашу гендерную принадлежность");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictEyePassToTxtPass(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtPass.PasswordChar = '\0';
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictEyePassToTxtPass.Image = Properties.Resources.PictRegHidePass;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictEyePassToTxtPass, "Скрыть пароль...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictToTxtSecretPass(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtRecoveryCode.PasswordChar = '\0';
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictToTxtSecretPass.Image = Properties.Resources.PictRegHidePass;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictToTxtSecretPass, "Скрыть секретное слово...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblGotoFormAuth(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.LblGotoFormAuth, "Перейти в форму авторизации");
            fmRegistrationForm.LblGotoFormAuth.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallAuthorizationForm(FmRegistrationForm fmRegistrationForm)
        {
            int parentX, parentY;
            fmRegistrationForm.LblGotoFormAuth.ForeColor = Color.White;
            CustomClass.isOpenedFormAuthorization = true;

            Form modalBackground = new Form();
            using (FmAuthorizationForm authorization_Form = new FmAuthorizationForm())
            {

                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmRegistrationForm.Size;
                modalBackground.Location = fmRegistrationForm.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();
                authorization_Form.Owner = modalBackground;

                parentX = fmRegistrationForm.Location.X;
                parentY = fmRegistrationForm.Location.Y;

                authorization_Form.ShowDialog();
                modalBackground.Dispose();
            }
        } // Вызов формы авторизации

        public static void CallStopAnimationTrashCan(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.PictDelTxtRecordBook.Image = Properties.Resources.TrashCan;
            fmRegistrationForm.PictDelTxtNickName.Image = Properties.Resources.TrashCan;
            fmRegistrationForm.PictDelTxtPass.Image = Properties.Resources.TrashCan;
            fmRegistrationForm.PictDelTxtRecoveryCode.Image = Properties.Resources.TrashCan;
        } // Остановка анимации "танцующего" мусорного ведра

        public static void CallOnMouseEnterPictDelTxtRecordBook(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictDelTxtRecordBook.Image = Properties.Resources.TrashCanGif;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictDelTxtRecordBook, "Удалить данные с поля зачётки");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictDelTxtNickName(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictDelTxtNickName.Image = Properties.Resources.TrashCanGif;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictDelTxtNickName, "Удалить данные с поля никнейма");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallDeleteDataTxtNickName(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtNickName.Text = null;
            CustomClass.Alert("Данные о никнейме успешно удалены!", Form_Alert.enmType.Info);
        } // Удаление данных с поля для ввода никнейма

        public static void CallOnMouseEnterPictDelTxtPass(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictDelTxtPass.Image = Properties.Resources.TrashCanGif;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictDelTxtPass, "Удалить данные с поле пароля");
        }// Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallDeleteDataTxtPass(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtPass.Text = null;
            CustomClass.Alert("Данные о пароле успешно удалены!", Form_Alert.enmType.Info);
        } // Удаление данных с поля для ввода пароля

        public static void CallOnMouseEnterPictDelTxtRecoveryCode(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.PictDelTxtRecoveryCode.Image = Properties.Resources.TrashCanGif;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.PictDelTxtRecoveryCode, "Удалить данные с поля секретного слова");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallDeleteDataTxtRecoveryCode(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtRecoveryCode.Text = null;
            CustomClass.Alert("Данные о секретном слове успешно удалены!", Form_Alert.enmType.Info);
        } // Удаление данных с поля ввода секретного слова

        public static void CallAcceptNullTxtBox(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.TxtRecordBook.Text = null;
            fmRegistrationForm.TxtNickName.Text = null;
            fmRegistrationForm.TxtPass.Text = null;
            fmRegistrationForm.TxtRecoveryCode.Text = null;
        } // Метод для удаления всех данных введеных пользователем с компонентов при неудачной попытке регистрации

        public static void CallOnMouseLeaveMcHcKAgreeRules(FmRegistrationForm fmRegistrationForm)
        {
            fmRegistrationForm.McHcKAgreeRules.ForeColor = Color.FromArgb(255, 255, 255);

            if (fmRegistrationForm.McHcKAgreeRules.Checked)
            {
                fmRegistrationForm.McHcKAgreeRules.ForeColor = Color.ForestGreen;
            }
            else
            {
                fmRegistrationForm.McHcKAgreeRules.ForeColor = Color.FromArgb(255, 255, 255);
            }
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblGotoWelcomeForm(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString()); CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.LblGotoWelcomeForm, "Выйти с формы регистрации");
            fmRegistrationForm.LblGotoWelcomeForm.ForeColor = Color.Red;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblGeneratePas(FmRegistrationForm fmRegistrationForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.LblGeneratePas.ForeColor = Color.DarkTurquoise;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.LblGeneratePas, "Сгенерировать уникальный пароль для вашего аккаунта...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblGenerateSecretPass(FmRegistrationForm fmRegistrationForm) // Вызов анимации для компонента если на него наведен курсор мыши
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmRegistrationForm.LblGenerateSecretPass.ForeColor = Color.DarkTurquoise;
            fmRegistrationForm.ToolTipHelpUser.SetToolTip(fmRegistrationForm.LblGenerateSecretPass, "Сгенерировать секретное слово для вашего аккаунта...");
        }








        // Часть 2 - Работа с БД и описание логики валидации данных 

        #region /// description of required fields
        public static Random random = new Random();
        public static StringBuilder stringBuilder = new StringBuilder();
        #endregion 

        public static void GetGenerateNumberCard()
        {
            string sSpace = " ";

            stringBuilder = new StringBuilder();
            random = new Random();

            for (int i = 0; i < CustomClass.COUNT_DIGIT_NUMBER_CARD; i++)
            {
                int randomNumber = random.Next(9);
                stringBuilder.Append(randomNumber);

                if (i == 3 || i == 7 || i == 11) /// разделение 16 значной строки на 4 равные части
                    stringBuilder.Append(sSpace);
            }
            CustomClass.sBankDetails = stringBuilder.ToString();
        } // Метод для генерации рандомного номера банковской карты

        public static void GetGenerateCVVCode()
        {
            stringBuilder = new StringBuilder();
            random = new Random();

            for (int i = 0; i < CustomClass.COUNT_DIGIT_CVV_CODE; i++)
            {
                int randomNumber = random.Next(9);
                stringBuilder.Append(randomNumber);
            }

            CustomClass.sCVV = stringBuilder.ToString();
        } // Метод для генерации рандомного CVV-кода банковской карты

        public static void GetGenerateBalance()
        {
            random = new Random();

            CustomClass.iBalance = random.Next(1000, 9990);
        } // Метод для генерации денежный средств для банковской карты пользователя

        public static string GetGeneratePassword(int length)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(CustomClass.validChars.Length);
                sb.Append(CustomClass.validChars[index]);
            }
            return sb.ToString();
        } // Реализация генерации рандомного криптографически стойкого пароля. Параметром функции задается длина самого пароля

        public static string GetGenerateMeaningfulWord()
        {
            int index = random.Next(CustomClass.sMeaningfulWords.Length);
            return CustomClass.sMeaningfulWords[index];
        } // Метод для генерации секретного слова в случае восстановления аккаунта

        public static string CallHashPassword(string password) /// Метод для преобразования исходного пароля в хэш-значение
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
        public static async Task GetDeleteUnrelatedStrings()
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand cmd = conn.CreateCommand();

                cmd.CommandText = "DELETE FROM BankDetails WHERE PK_номер_карты NOT IN (SELECT Users.FK_Банк_данные FROM Users)";

                await cmd.ExecuteNonQueryAsync();
            }
        } /// Метод для удаления возможных "аномальных" записей с БД

        public static async Task CallInsertBankDetails() //// Генерация банковских данных для нового пользователя (номер карты, CVV, баланс) на основе выше указанных методов
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();
                MySqlCommand comm = conn.CreateCommand();
                comm.CommandText = "INSERT INTO BankDetails (`PK_номер_карты`, `CVV`, `Баланс`) VALUES(@PK_номер_карты, @CVV, @Баланс)";
                comm.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);
                comm.Parameters.AddWithValue("@CVV", CustomClass.sCVV);
                comm.Parameters.AddWithValue("@Баланс", CustomClass.iBalance);

                await comm.ExecuteNonQueryAsync();
            }
        }

        public static async Task CallUpdateBankDetails(FmRegistrationForm fmRegistrationForm) /// Обновление внешнего поля в таблице Users
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {

                await conn.OpenAsync();

                MySqlCommand query = conn.CreateCommand();

                query.CommandText = "UPDATE `Users` SET `FK_Банк_данные` = @FK_Банк_данные WHERE `Users`.`PK_Зачётка` = @PK_Зачётка;";

                query.Parameters.AddWithValue("@PK_Зачётка", fmRegistrationForm.TxtRecordBook.Text);
                query.Parameters.AddWithValue("@FK_Банк_данные", CustomClass.sBankDetails);

                await query.ExecuteNonQueryAsync();
            }
        }

        public static async Task CallQueryInsertNewUserAsync(FmRegistrationForm fmRegistrationForm, MetroFramework.Controls.MetroComboBox metroComboBox) /// Вставка нового пользователя в БД
        {
            object objValueMcboxSelectSexUser = metroComboBox.SelectedItem;
            string sResultValueMcboxSelectSexUser = objValueMcboxSelectSexUser.ToString();
            string sPassword = fmRegistrationForm.TxtPass.Text;
            string sRecoveryCode = fmRegistrationForm.TxtRecoveryCode.Text;

            if (fmRegistrationForm.TxtRecordBook.Text != "" && fmRegistrationForm.TxtNickName.Text != "")
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO Users(PK_Зачётка,NickName,Пароль,Код_восстановления,Пол) VALUES " +
                        "(@PK_Зачётка, @NickName, @Пароль, @Код_восстановления, @Пол)";
                    comm.Parameters.AddWithValue("@PK_Зачётка", fmRegistrationForm.TxtRecordBook.Text);
                    comm.Parameters.AddWithValue("@NickName", fmRegistrationForm.TxtNickName.Text);
                    string sHashPassword = CallHashPassword(sPassword);
                    comm.Parameters.AddWithValue("@Пароль", sHashPassword);
                    string sHashRecoveryCode = CallHashPassword(sRecoveryCode);
                    comm.Parameters.AddWithValue("@Код_восстановления", sHashRecoveryCode);
                    comm.Parameters.AddWithValue("@Пол", sResultValueMcboxSelectSexUser);

                    await comm.ExecuteNonQueryAsync();
                }

                CustomClass.Alert(" Читатель с НикНеймом: " + fmRegistrationForm.TxtNickName.Text + " успешно зарегестрирован! ", Form_Alert.enmType.Success);
            }
            else
            {
                CustomClass.Alert("Не заполнены необходимые данные для регистрации!", Form_Alert.enmType.Warning);
            }
        }

        public static async Task GetCheckForDuplicateRecordAsync(FmRegistrationForm fmRegistrationForm, bool bAcceptRegUser)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand pk_cmd = new MySqlCommand("SELECT * FROM Users WHERE Pk_Зачётка = @PK_Зачётка", conn);
                pk_cmd.Parameters.AddWithValue("@PK_Зачётка", fmRegistrationForm.TxtRecordBook.Text);

                using (MySqlDataReader reader = await pk_cmd.ExecuteReaderAsync())
                {
                    if (await reader.ReadAsync())
                    {
                        CustomClass.Alert("Читатель с данным номером зачётки уже зарегистрирован!", Form_Alert.enmType.Info);
                        fmRegistrationForm.TxtRecordBook.Text = null;
                        bAcceptRegUser = false;
                    }
                }

                MySqlCommand nickname_cmd = new MySqlCommand("SELECT * FROM Users WHERE NickName = @NickName", conn);
                nickname_cmd.Parameters.AddWithValue("@NickName", fmRegistrationForm.TxtNickName.Text);

                using (MySqlDataReader new_reader = await nickname_cmd.ExecuteReaderAsync())
                {
                    if (await new_reader.ReadAsync())
                    {
                        CustomClass.Alert("Читатель с таким никнеймом уже зарегистрирован!", Form_Alert.enmType.Info);
                        fmRegistrationForm.TxtNickName.Text = null;
                        bAcceptRegUser = false;
                    }
                }
            }
        } /// Асинхронный метод для проверки уже существующего номера зачетной книжки в системе

        public static void GetCheckNumberCharacters(FmRegistrationForm fmRegistrationForm, bool bAcceptRegUser)
        {
            string sNumberDigit = Convert.ToString(fmRegistrationForm.TxtRecordBook.Text); // подчсчёт кол-ва символов из TxtPass.Text 

            if (sNumberDigit.Length < CustomClass.COUNT_DIGIT_FOR_DOCUMENT)
            {
                fmRegistrationForm.TxtRecordBook.Text = null;
                CustomClass.Alert("Номер студенческого билета не может быть меньше 7 цифр!", Form_Alert.enmType.Error);
                bAcceptRegUser = false;
            }
        } /// Реализация проверки на количество введеных символов номера зачетки

        public static void GetCheckNullTxtBox(FmRegistrationForm fmRegistrationForm, bool bAcceptRegUser) 
        {
            if (string.IsNullOrEmpty(fmRegistrationForm.TxtRecordBook.Text) || string.IsNullOrEmpty(fmRegistrationForm.TxtNickName.Text) ||
                string.IsNullOrEmpty(fmRegistrationForm.TxtPass.Text) || string.IsNullOrEmpty(fmRegistrationForm.TxtRecoveryCode.Text))
            {
                CustomClass.Alert("Не заполнены необходимые данные для регистрации!", Form_Alert.enmType.Error);
                CallAcceptNullTxtBox(fmRegistrationForm);
            }
            else
                bAcceptRegUser = true;
        }/// Проверка на заполненость всех компонентов для ввода данных

        public static async void InsertUserToDB(FmRegistrationForm fmRegistrationForm, bool bAcceptRegUser)
        {
            int parentX, parentY;

            try
            {
                if ((fmRegistrationForm.TxtRecordBook.Text != "") && (fmRegistrationForm.TxtNickName.Text != "") && (fmRegistrationForm.TxtPass.Text != "") && (fmRegistrationForm.McBoxSex.SelectedIndex != -1)
               && (fmRegistrationForm.McHcKAgreeRules.Checked == false))
                {
                    CustomClass.Alert("Пожалуйста,подтвердите что вы ознакомились с условиями программы", Form_Alert.enmType.Info);
                }
                else if ((fmRegistrationForm.TxtRecordBook.Text != "") && (fmRegistrationForm.TxtNickName.Text != "") && (fmRegistrationForm.TxtPass.Text != "") && (fmRegistrationForm.McBoxSex.SelectedIndex != -1)
                   && fmRegistrationForm.McHcKAgreeRules.Checked)
                {

                    Form modalBackground = new Form();
                    using (FrmModalForm modal = new FrmModalForm())
                    {
                        FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Завершение регистрации...";
                        FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Для завершения регистрации, пожалуйста ознакомтись с лицензионным соглашением ";
                        FrmModalForm.FRM_Btn_Buy_Sub.Visible = false;
                        FrmModalForm.FRM_modalForm_logo.Visible = false;
                        FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                        FrmModalForm.FRM_modalForm_PictLogo_Form.Image = Properties.Resources.DocGif;
                        FrmModalForm.FRM_Btn_Res_App.Visible = false;
                        FrmModalForm.FRM_Btn_Exit_App.Visible = false;
                        CustomClass.isBtnOkClicked = false;
                        FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Checked = false;
                        modalBackground.StartPosition = FormStartPosition.Manual;
                        modalBackground.FormBorderStyle = FormBorderStyle.None;
                        modalBackground.Opacity = .50;
                        {

                            modalBackground.BackColor = Color.Black;
                            modalBackground.Size = fmRegistrationForm.Size;
                            modalBackground.Location = fmRegistrationForm.Location;
                            modalBackground.ShowInTaskbar = false;
                            modalBackground.Show();
                            modal.Owner = modalBackground;

                            parentX = fmRegistrationForm.Location.X;
                            parentY = fmRegistrationForm.Location.Y;

                            modal.ShowDialog();
                            modalBackground.Dispose();
                        }
                    }
                    if (FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Checked &&
                                                                                    CustomClass.isBtnOkClicked)
                    {
                        if (fmRegistrationForm.TxtRecordBook.Text != "" && fmRegistrationForm.TxtNickName.Text != "")
                        {
                            bAcceptRegUser = true;

                            if (bAcceptRegUser)
                            {
                                GetGenerateNumberCard();

                                GetGenerateCVVCode();

                                GetGenerateBalance();

                                GetCheckNullTxtBox(fmRegistrationForm, true);

                                await CallInsertBankDetails();

                                await GetCheckForDuplicateRecordAsync(fmRegistrationForm, false);

                                await CallQueryInsertNewUserAsync(fmRegistrationForm, fmRegistrationForm.McBoxSex);

                                await CallUpdateBankDetails(fmRegistrationForm);

                                CallAcceptNullTxtBox(fmRegistrationForm);

                                CustomClass.CallAnimationCloseForm(fmRegistrationForm);

                                await GetDeleteUnrelatedStrings();

                                fmRegistrationForm.Close();

                            }
                        }
                        else
                        {
                            CustomClass.Alert("Не заполнены необходимые данные для регистрации!", Form_Alert.enmType.Error);
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                CustomClass.Alert("Возникла ошибка при попытке соединения с сервером!.Проверьте работу OsPanel", Form_Alert.enmType.Error);
            }
        } /// Реализация асинхронного метода для подготовки вставки данных в базу данных с последующей валидацией 

        public static void GetConfirmInsertQuery(FmRegistrationForm fmRegistrationForm)
        {
            Task task = GetCheckForDuplicateRecordAsync(fmRegistrationForm, true);

            GetCheckNumberCharacters(fmRegistrationForm, true);

            GetCheckNullTxtBox(fmRegistrationForm, true);

            InsertUserToDB(fmRegistrationForm, true);

        } /// Окончательная проверка данных на валидность и допуск к созданию новой записи в базе данных

        public static void GetPasswordEntryBan(FmRegistrationForm fmRegistrationForm) /// Меняет символ пробела на тире
        {
            fmRegistrationForm.TxtRecordBook.Text = Regex.Replace(fmRegistrationForm.TxtRecordBook.Text, @"\s+", ""); 
        }

        public static void GetDisabledCharacters(KeyPressEventArgs e) /// Метод для запрета ввода пробелов и любых символов в поле ввода зачетного номера студента
        {
            CustomClass.OnlyNum(e);
            CustomClass.DisableSpace(e);
            CustomClass.DisableSymbols(e);
        }

        public static void GetCheckingObsceneWords(FmRegistrationForm fmRegistrationForm) /// Метод для валидации данных на наличие нецензурных слов
        {
            string[] sLines = File.ReadAllLines(CustomClass.sFullPathToMaterials + "BadWords.txt");

            string sValueTxtNickName = fmRegistrationForm.TxtNickName.Text;

            foreach (string sLine in sLines)
            {
                if (sLine == fmRegistrationForm.TxtNickName.Text)
                {
                    CustomClass.Alert("В поле никнейма недопустимы нецензурные слова!", Form_Alert.enmType.Error);
                    fmRegistrationForm.TxtNickName.Text = null;
                    return;
                }
            }
        } 

        public static void CheckInputLength(FmRegistrationForm fmRegistrationForm)
        {
            if (fmRegistrationForm.TxtNickName.Text.Length > CustomClass.MAX_NUMBER_CHARACTERS)
            {
                CustomClass.Alert("Введенное значение превысило допустимый размер. Строка укорочена до 25 символов", Form_Alert.enmType.Info);
                fmRegistrationForm.TxtNickName.Text = fmRegistrationForm.TxtNickName.Text.Substring(0, 25); 
            }
        } /// Метод для корректировки длины никнейма

        public static void GetGenerateRandomPassword(FmRegistrationForm fmRegistrationForm) 
                                                                                            
        {
            string password = GetGeneratePassword(CustomClass.MAX_PASSWORD_LENGTH);
            fmRegistrationForm.TxtPass.Text = password;
            CustomClass.Alert("Пароль успешно сгенерирован!", Form_Alert.enmType.Success);
        } /// Вызов метода GetGeneratePassword который возращает криптографическии стойкий пароль пользователю 
          /// и вставляет его в компонет TextBox

        public static void GetGenerateSecretWord(FmRegistrationForm fmRegistrationForm) 
        {                                                                               
            string smeaningfulWord = GetGenerateMeaningfulWord();
            fmRegistrationForm.TxtRecoveryCode.Text = smeaningfulWord;
            CustomClass.Alert("Подобрано секретное слово для ваша аккаунта!", Form_Alert.enmType.Success);
        } /// Вызов метода GetGenerateMeaningfulWord который возращает секретное слово для возможности восстановления аккаунта 
          /// и вставляет его в компонет TextBox

        public static void CallFreeMemoryVoid(FmRegistrationForm fmRegistrationForm) 
        {
            GC.Collect();
            fmRegistrationForm. Dispose();
        } /// Метод для освобождения памяти занимаемой формой  
    }
}
