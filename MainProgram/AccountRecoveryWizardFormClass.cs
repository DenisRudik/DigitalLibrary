/// <summary>
//Название файла - AccountRecoveryWizardFormClass.cs.
/// !--------------------------------Описание---------------------------!:
// Класс описующий принцип подбора забытого пользователем пароля от аккаунта.
// Файл поделен на две части:
// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
// Часть 2 - Программная логика заданных компонентов и последующая их обработка

/// <summary>
/// <param name="fmPasswordRecoveryAssistantForm"></param>
/// 


using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using MySqlConnector;

namespace online_library_for_educ_inst
{
    public class AccountRecoveryWizardFormClass
    {   
        // Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем

        public static void CallPromptText(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            fmPasswordRecoveryAssistantForm.TxtRecordBook.Text = "Prompt";

            fmPasswordRecoveryAssistantForm.TxtRecordBook.Clear();

            fmPasswordRecoveryAssistantForm.TxtRecoveryCode.Text = "Prompt";

            fmPasswordRecoveryAssistantForm.TxtRecoveryCode.Clear();
        } /// Присвоение компонентам TextBox "подсказок" для улучшения пользовательского опыта в использовании формы

        public static void CallOnMouseEnterPictTxtRecordBook(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmPasswordRecoveryAssistantForm.PictTxtRecordBook.Image = Properties.Resources.PictRegRecordBook;
            fmPasswordRecoveryAssistantForm.ToolTipHelpUser.SetToolTip(fmPasswordRecoveryAssistantForm.PictTxtRecordBook, "Введите номер своей зачётки...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictRecoveryCode(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmPasswordRecoveryAssistantForm.PictRecoveryCode.Image = Properties.Resources.PictRegSecretPass;
            fmPasswordRecoveryAssistantForm.ToolTipHelpUser.SetToolTip(fmPasswordRecoveryAssistantForm.PictRecoveryCode, "Введите секретное слово которое вы задавали при регистрации аккаунта...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterPictEyeRecoveryCodeShow(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            fmPasswordRecoveryAssistantForm.TxtRecoveryCode.PasswordChar = '\0';
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmPasswordRecoveryAssistantForm.PictEyeRecoveryCodeShow.Image = Properties.Resources.PictRegHidePass;
            fmPasswordRecoveryAssistantForm.ToolTipHelpUser.SetToolTip(fmPasswordRecoveryAssistantForm.PictEyeRecoveryCodeShow, "Скрыть пароль...");
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEnterLblCloseRecoveryForm(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmPasswordRecoveryAssistantForm.LblCloseRecoveryForm.ForeColor = Color.FromArgb(172, 43, 244);
        } // Вызов анимации для компонента если на него наведен курсор мыши









        // Часть 2 - Программная логика заданных компонентов и последующая их обработка

        public static void GetCheckNullTxtBox(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            if (string.IsNullOrEmpty(fmPasswordRecoveryAssistantForm.TxtRecordBook.Text) || string.IsNullOrEmpty(fmPasswordRecoveryAssistantForm.TxtRecoveryCode.Text))
            {
                CustomClass.Alert("Не заполнены необходимые данные для поиска аккаунта!", Form_Alert.enmType.Error);
            }
        } /// Метод для проверки заполненности всех компонентов на форме данными для нахождения аккаунта

        public static void GetCheckNumberCharacters(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            string sNumberDigit = Convert.ToString(fmPasswordRecoveryAssistantForm.TxtRecordBook.Text); // подчсчёт кол-ва символов из TxtPass.Text 

            if (sNumberDigit.Length < CustomClass.COUNT_DIGIT_FOR_DOCUMENT)
            {
                fmPasswordRecoveryAssistantForm.TxtRecordBook.Text = null;
                CustomClass.Alert("Номер студенческого билета не может быть меньше 7 цифр!", Form_Alert.enmType.Error);
            }
        } /// Реализация подсчета количества символов в номере студенческого билета

        public static string GetSHA256Hash(string enteredPasswordHash) /// Метод для шифровки введеного пароля пользователем в хеш-значение
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
        }

        public static void GetPasteNumberDocument(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            fmPasswordRecoveryAssistantForm.TxtRecordBook.Text = CustomClass.sBufferNumberDocumentForRecoveryAssistant;

            if (CustomClass.isShowMessageRecoveryAssistantForm)
            {
                CustomClass.Alert("Номер зачётной книжки автоматическии вставлен!", Form_Alert.enmType.Info);
            }
        } /// Метод для автоматической вставки номера зачетной книжки в соответсвующий компонент

        public async static Task GetCheckDataUser(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
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
                        cmd.Parameters.AddWithValue("@PK_Зачётка", fmPasswordRecoveryAssistantForm.TxtRecordBook.Text);
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

                string sRecordNumText = fmPasswordRecoveryAssistantForm.TxtRecordBook.Text;
                string sHashRecoveryCodeFromTxt = AccountRecoveryWizardFormClass.GetSHA256Hash(fmPasswordRecoveryAssistantForm.TxtRecoveryCode.Text);

                if (fmPasswordRecoveryAssistantForm.TxtRecordBook.Text != "")
                {
                    if (CustomClass.sRecoveryCode != sHashRecoveryCodeFromTxt)
                    {
                        CustomClass.Alert("Не верный секретный пароль для данного номера зачётки!Учтите регистр пароля", Form_Alert.enmType.Error);
                        fmPasswordRecoveryAssistantForm.TxtRecoveryCode.Text = null;
                    }
                    if (sHashRecoveryCodeFromTxt == null)
                        CustomClass.Alert("Ошибка на стороне сервера,секретное слово правильно,примите его!.", Form_Alert.enmType.Info);
                    else if (fmPasswordRecoveryAssistantForm.TxtRecordBook.Text != "" && fmPasswordRecoveryAssistantForm.TxtRecoveryCode.Text != "")
                    {
                        if (MessageBox.Show("Мастер восстановления аккаунтов нашёл учётную запись со следующим номером зачетной книжки: " + sRecordNumText + " и никнеймом - " + CustomClass.sNickNameNewUser + ", это ваш аккаунт? ",
                            "Мастер восстановления аккаунтов", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {

                            CustomClass.isCompleteAuthorization = true; /// если поле true, в форме Registation_Form при вызове 
                                                                        /// события Load() вызываем метод Dispose(),который будет удалять эту форму тем самым не создавая новый экземпляр формы

                            CustomClass.CallAnimationCloseForm(fmPasswordRecoveryAssistantForm);
                            CustomClass.Alert("Авторизация прошла успешно.Подождите,осуществляется вход в аккаунт...", Form_Alert.enmType.Success);
                            Form Load_account_Form = new FmLoadAccountForm();
                            Load_account_Form.Show();
                        }
                    }
                }
            }
            catch (MySqlException)
            {
                CustomClass.Alert("Возникла ошибка при попытке соединения с сервером!.Проверьте работу OsPanel", Form_Alert.enmType.Warning);
            }
        } /// Реализация алгоритма нахождения забытого пароля

        public async static Task GetCheckPrimaryKeyUser(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand sql = new MySqlCommand("SELECT * FROM Users WHERE Pk_Зачётка = @PK_Зачётка", conn);
                sql.Parameters.AddWithValue("@PK_Зачётка", fmPasswordRecoveryAssistantForm.TxtRecordBook.Text);

                using (MySqlDataReader reader = await sql.ExecuteReaderAsync())
                {
                    if (!await reader.ReadAsync() && fmPasswordRecoveryAssistantForm.TxtRecordBook.Text != "")
                    {
                        CustomClass.Alert("Пользователь с таким номером зачётки не найден!", Form_Alert.enmType.Error);
                    }
                }

            }
        } /// Метод для проверки существующего в системе пользователя с данным номером зачётки

        public static void CallFreeMemoryVoid(FmPasswordRecoveryAssistantForm fmPasswordRecoveryAssistantForm)
        {
            CustomClass.sBufferNumberDocumentForRecoveryAssistant = null;
            CustomClass.isShowMessageRecoveryAssistantForm = false;
            GC.Collect();
            fmPasswordRecoveryAssistantForm.Dispose();
        } /// Метод для освобождения памяти занимаемой формой  
    }
}
