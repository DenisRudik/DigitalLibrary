/// <summary>
//Название файла - FormSubscrtiptionClass.cs.
/// !--------------------------------Описание---------------------------!:
// Класс FormSubscrtiptionClass описующий принцип работы формы для подбора подписки в системе.
// Файл поделен на две части:
// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
// Часть 2 - Программная логика заданных компонентов и последующая их обработка
/// <summary>
/// <param name="FmFormSubcription"></param>
/// 


using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using MySqlConnector;
using modal;
using yt_DesignUI;


namespace online_library_for_educ_inst
{
    public class FormSubscriptionClass
    { 
        // Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем

        public static void GetComponentTile(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.LowerComponentTile.Text = "список подписок для аккаунта: " + CustomClass.sNickNameNewUser;
            fmFormSubcription.TopComponentTile.Text = "Цифровая настольная библиотека " + string.Format("({0})", " Баланс аккаунта: " + CustomClass.sBalance + " руб. ");
        } /// Метод для вывода краткого сообщения о статусе баланса пользователя и другой информации

        public static void GetTopMessage(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.LblTopText.Text = CustomClass.sNickNameNewUser + " ,выбери подписку на сервис и окунись в просторы цифровой литературы:";
        } /// Вывод основного текста для формы

        public static async void CallAnimatedDrawText(FmFormSubcription fmFormSubcription)
        {
            byte shateOfRed = 12;
            byte shateOfGreen = 12;
            byte shateOfBlue = 121;
            byte desiredShateColor = 245;

            for (byte r = shateOfRed, g = shateOfGreen, b = shateOfBlue; r <= desiredShateColor & g <= desiredShateColor & b <= desiredShateColor; r += 5, g += 5, b += 5)
            {
                await Task.Delay(CustomClass.TIME_TO_DRAWING);
                fmFormSubcription.LblTopText.ForeColor = Color.FromArgb(r, g, b);
            }
        } /// Метод для реализации эффекта "плавного" появления текста на форме (анимация)

        public static void CallOnMouseEnterEgoldsCard1(FmFormSubcription fmFormSubcription)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmFormSubcription.egoldsCard1.ForeColor = Color.Lime;
            fmFormSubcription.egoldsCard1.ForeColorHeader = Color.Lime;
            fmFormSubcription.IcoFofEgolds1.Visible = false;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveEgoldsCard1(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.egoldsCard1.ForeColor = Color.MidnightBlue;
            fmFormSubcription.egoldsCard1.ForeColorHeader = Color.FromArgb(0, 174, 219);
            fmFormSubcription.IcoFofEgolds1.Visible = true;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterEgoldsCard2(FmFormSubcription fmFormSubcription)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmFormSubcription.egoldsCard2.ForeColor = Color.Lime;
            fmFormSubcription.egoldsCard2.ForeColorHeader = Color.Lime;
            fmFormSubcription.IcoFofEgolds2.Visible = false;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveEgoldsCard2(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.egoldsCard2.ForeColor = Color.MidnightBlue;
            fmFormSubcription.egoldsCard2.ForeColorHeader = Color.FromArgb(0, 174, 219);
            fmFormSubcription.IcoFofEgolds2.Visible = true;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterEgoldsCard3(FmFormSubcription fmFormSubcription)
        {
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
            fmFormSubcription.egoldsCard3.ForeColor = Color.Lime;
            fmFormSubcription.egoldsCard3.ForeColorHeader = Color.Lime;
            fmFormSubcription.IcoFofEgolds3.Visible = false;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveEgoldsCard3(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.egoldsCard3.ForeColor = Color.MidnightBlue;
            fmFormSubcription.egoldsCard3.ForeColorHeader = Color.FromArgb(0, 174, 219);
            fmFormSubcription.IcoFofEgolds3.Visible = true;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictBuySubEgolds1(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.ToolTipHelpUser.SetToolTip(fmFormSubcription.PictBuySubEgolds1, "оформить подписку - " + fmFormSubcription.egoldsCard1.TextHeader);
            fmFormSubcription.PictBuySubEgolds1.Image = Properties.Resources.BuySubCursored;
            fmFormSubcription.egoldsCard1.ForeColor = Color.Lime;
            fmFormSubcription.egoldsCard1.ForeColorHeader = Color.Lime;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictBuySubEgolds1(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.PictBuySubEgolds1.Image = Properties.Resources.BuySub;
            fmFormSubcription.egoldsCard1.ForeColor = Color.MidnightBlue;
            fmFormSubcription.egoldsCard1.ForeColorHeader = Color.FromArgb(0, 174, 219);
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictBuySubEgolds2(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.ToolTipHelpUser.SetToolTip(fmFormSubcription.PictBuySubEgolds2, "оформить подписку - " + fmFormSubcription.egoldsCard2.TextHeader);
            fmFormSubcription.PictBuySubEgolds2.Image = Properties.Resources.BuySubCursored;
            fmFormSubcription.egoldsCard2.ForeColor = Color.Lime;
            fmFormSubcription.egoldsCard2.ForeColorHeader = Color.Lime;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictBuySubEgolds2(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.PictBuySubEgolds2.Image = Properties.Resources.BuySub;
            fmFormSubcription.egoldsCard2.ForeColor = Color.MidnightBlue;
            fmFormSubcription.egoldsCard2.ForeColorHeader = Color.FromArgb(0, 174, 219);
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictBuySubEgolds3(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.ToolTipHelpUser.SetToolTip(fmFormSubcription.PictBuySubEgolds3, "оформить подписку - " + fmFormSubcription.egoldsCard3.TextHeader);
            fmFormSubcription.PictBuySubEgolds3.Image = Properties.Resources.BuySubCursored;
            fmFormSubcription.egoldsCard3.ForeColor = Color.Lime;
            fmFormSubcription.egoldsCard3.ForeColorHeader = Color.Lime;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictBuySubEgolds3(FmFormSubcription fmFormSubcription)
        {
            fmFormSubcription.PictBuySubEgolds3.Image = Properties.Resources.BuySub;
            fmFormSubcription.egoldsCard3.ForeColor = Color.MidnightBlue;
            fmFormSubcription.egoldsCard3.ForeColorHeader = Color.FromArgb(0, 174, 219);
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallFormConfirmSubcrtiptionOnMonth(FmFormSubcription fmFormSubcription)
        {
            int iParentX, iParentY;

            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                CustomClass.bWantSubToMonth = true;
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Подтверждение оплаты...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Вы уверены что хотите оформить подписку, " + string.Format("({0})", fmFormSubcription.egoldsCard1.TextHeader) +
                                                                   "? " + "Учтите, что подписка \n оформляется только один раз.";
                FrmModalForm.FRM_Btn_Cancel.Text = "Назад";
                FrmModalForm.FRM_Btn_Exit_App.Text = "Оплатить";
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = true;
                FrmModalForm.FRM_modalForm_logo.Image = online_library_for_educ_inst.Properties.Resources.DigitalLibrary;
                FrmModalForm.FRM_Btn_Buy_Sub.Visible = true;
                FrmModalForm.FRM_Btn_OK.Visible = false;
                FrmModalForm.FRM_Btn_Exit_App.Visible = false;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = online_library_for_educ_inst.Properties.Resources.GifBuySub;
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmFormSubcription.Size;
                modalBackground.Location = fmFormSubcription.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                iParentX = fmFormSubcription.Location.X;
                iParentY = fmFormSubcription.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        } /// Вызов формы подтверждения оплаты для подписки на месяц

        public static void CallFormConfirmArtisticSubcrtiption(FmFormSubcription fmFormSubcription)
        {
            int iParentX, iParentY;

            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                CustomClass.bWantSubArtistic = true;
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Подтверждение оплаты...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Вы уверены что хотите оформить подписку, " + fmFormSubcription.egoldsCard2.TextHeader +
                                                                   "? " + "\nУчтите, что подписка  оформляется только один раз.";
                FrmModalForm.FRM_Btn_Cancel.Text = "Назад";
                FrmModalForm.FRM_Btn_Exit_App.Text = "Оплатить";
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = true;
                FrmModalForm.FRM_modalForm_logo.Image = online_library_for_educ_inst.Properties.Resources.BookLove;
                FrmModalForm.FRM_Btn_OK.Visible = false;
                FrmModalForm.FRM_Btn_Exit_App.Visible = true;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = online_library_for_educ_inst.Properties.Resources.GifBuySub;
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmFormSubcription.Size;
                modalBackground.Location = fmFormSubcription.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                iParentX = fmFormSubcription.Location.X;
                iParentY = fmFormSubcription.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        } /// Вызов формы подтверждения оплаты для подписки на художественную литературу

        public static void CallFormConfirmScientificSubcrtiption(FmFormSubcription fmFormSubcription)
        {
            int iParentX, iParentY;

            Form modalBackground = new Form();
            using (FrmModalForm modal = new FrmModalForm())
            {
                CustomClass.bWantSubScientific = true;
                FrmModalForm.FRM_modalForm_lbl_msg_for_user.Text = "Подтверждение оплаты...";
                FrmModalForm.FRM_modalForm_lbl_text_message.Text = "Вы уверены что хотите оформить подписку, " + fmFormSubcription.egoldsCard3.TextHeader +
                                                                   "? " + "\n Учтите, что подписка  оформляется только один раз.";
                FrmModalForm.FRM_Btn_Cancel.Text = "Назад";
                FrmModalForm.FRM_Btn_Exit_App.Text = "Оплатить";
                FrmModalForm.FRM_modalForm_richtxt_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_mchckbox_confirm_read_license_agreement.Visible = false;
                FrmModalForm.FRM_modalForm_logo.Visible = true;
                FrmModalForm.FRM_modalForm_logo.Image = online_library_for_educ_inst.Properties.Resources.BookMap;
                FrmModalForm.FRM_Btn_OK.Visible = false;
                FrmModalForm.FRM_Btn_Exit_App.Visible = true;
                FrmModalForm.FRM_Btn_Res_App.Visible = false;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Visible = true;
                FrmModalForm.FRM_modalForm_PictLogo_Form.Image = online_library_for_educ_inst.Properties.Resources.GifBuySub;
                modalBackground.StartPosition = FormStartPosition.Manual;
                modalBackground.FormBorderStyle = FormBorderStyle.None;
                modalBackground.Opacity = .50d;
                modalBackground.BackColor = Color.Black;
                modalBackground.Size = fmFormSubcription.Size;
                modalBackground.Location = fmFormSubcription.Location;
                modalBackground.ShowInTaskbar = false;
                modalBackground.Show();

                iParentX = fmFormSubcription.Location.X;
                iParentY = fmFormSubcription.Location.Y;

                modal.ShowDialog();
                modalBackground.Dispose();
            }
        } /// Вызов формы подтверждения оплаты для подписки на научную литературу








        // Часть 2 - Программная логика заданных компонентов и последующая их обработка

        public static async Task GetDataSubscription(FmFormSubcription fmFormSubcription)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();


                string sQuery = "SELECT * FROM `Subscription` WHERE PK_подписки = 1";

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            CustomClass.sNameSub = dr["Наименование"].ToString();
                            CustomClass.sTextSub = dr["Описание"].ToString();
                            CustomClass.sCostSub = dr["Цена"].ToString();

                            fmFormSubcription.egoldsCard1.Text = CustomClass.sCostSub + " руб.";
                            fmFormSubcription.egoldsCard1.TextHeader = CustomClass.sNameSub;
                            fmFormSubcription.egoldsCard1.TextDescrition = CustomClass.sTextSub;
                        }
                    }
                }

                string sNewQuery = "SELECT * FROM `Subscription` WHERE PK_подписки = 2";

                using (MySqlCommand cmd = new MySqlCommand(sNewQuery, conn))
                {
                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            CustomClass.sNameSub = dr["Наименование"].ToString();
                            CustomClass.sTextSub = dr["Описание"].ToString();
                            CustomClass.sCostSub = dr["Цена"].ToString();

                            fmFormSubcription.egoldsCard2.Text = CustomClass.sCostSub + " руб.";
                            fmFormSubcription.egoldsCard2.TextHeader = CustomClass.sNameSub;
                            fmFormSubcription.egoldsCard2.TextDescrition = CustomClass.sTextSub;

                        }
                    }
                }

                string sThirdQuery = "SELECT * FROM `Subscription` WHERE PK_подписки = 3";

                using (MySqlCommand cmd = new MySqlCommand(sThirdQuery, conn))
                {
                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            CustomClass.sNameSub = dr["Наименование"].ToString();
                            CustomClass.sTextSub = dr["Описание"].ToString();
                            CustomClass.sCostSub = dr["Цена"].ToString();

                            fmFormSubcription.egoldsCard3.Text = CustomClass.sCostSub + " руб.";
                            fmFormSubcription.egoldsCard3.TextHeader = CustomClass.sNameSub;
                            fmFormSubcription.egoldsCard3.TextDescrition = CustomClass.sTextSub;
                        }
                    }
                }
            }
        } /// Метод, реализующий запрос к локальной БД и осуществляющий выборку необходимых данных для компонентов на форме

        public static async Task GetUpdateBankData()
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
        } /// Метод для выборки актульной информации о балансе "конкретного" пользователя в системе

        public static async Task GetUpdateSubscriptionData()
        {
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
        } /// Метод для получения статуса об уже имеющейся или не имеющейся подписки у пользователя

        public async static Task GetQueryUpdateSubscriptionOnMonth(FmFormSubcription fmFormSubcription)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sGetPK;
                int iUpdateBalance = 0;

                // Получаем PK подписки
                string sQuery = "SELECT PK_подписки FROM Subscription WHERE Наименование = @Наименование";
                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Наименование", fmFormSubcription.egoldsCard1.TextHeader);
                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            sGetPK = dr["PK_подписки"].ToString();
                            CustomClass.sPkSub = sGetPK;
                            CustomClass.sActiveSub = fmFormSubcription.egoldsCard1.TextHeader;
                        }
                    }
                }

                // Обновляем пользователя с новой подпиской
                MySqlCommand updateUserSubCmd = new MySqlCommand("UPDATE Users SET FK_Подписка = @FK_Подписка, Дата_оформления = @Дата_оформления, Дата_окончания = @Дата_окончания WHERE PK_Зачётка = @PK_Зачётка", conn);
                updateUserSubCmd.Parameters.AddWithValue("@FK_Подписка", CustomClass.sPkSub);
                updateUserSubCmd.Parameters.AddWithValue("@Дата_оформления", DateTime.Now);
                updateUserSubCmd.Parameters.AddWithValue("@Дата_окончания", DateTime.Now.AddMonths(1));
                updateUserSubCmd.Parameters.AddWithValue("@PK_Зачётка", CustomClass.sNumberGradebook);
                await updateUserSubCmd.ExecuteNonQueryAsync();

                // Обновляем баланс
                MySqlCommand balanceCmd = new MySqlCommand("SELECT (SELECT Баланс FROM BankDetails WHERE PK_номер_карты = @PK_номер_карты) - (SELECT Цена FROM Subscription WHERE PK_подписки = @PK_подписки) AS Баланс", conn);
                balanceCmd.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);
                balanceCmd.Parameters.AddWithValue("@PK_подписки", CustomClass.sPkSub);

                using (MySqlDataReader dr = await balanceCmd.ExecuteReaderAsync())
                {
                    if (dr.Read())
                    {
                        iUpdateBalance = dr.GetInt32("Баланс");
                        iUpdateBalance = Math.Max(iUpdateBalance, 0); // Убедимся, что баланс не отрицательный
                    }
                }

                // Обновляем баланс в BankDetails
                MySqlCommand updateBalanceCmd = new MySqlCommand("UPDATE BankDetails SET Баланс = @Баланс WHERE PK_номер_карты = @PK_номер_карты", conn);
                updateBalanceCmd.Parameters.AddWithValue("@Баланс", iUpdateBalance);
                updateBalanceCmd.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);

                await updateBalanceCmd.ExecuteNonQueryAsync();
            }

            CustomClass.Alert("Подписка " + string.Format("({0})", CustomClass.sActiveSub) + " успешно оформлена", Form_Alert.enmType.Success);
        } /// Логика обновления данных пользователя при оформлении подписки на месяц

        public async static Task GetQueryUpdateArtisticSubscription(FmFormSubcription fmFormSubcription) 
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sGetPK;
                int iUpdateBalance = 0;

                // Получаем PK подписки и обновляем пользователя
                string sQuery = @"
            SELECT 
                PK_подписки, 
                (SELECT Баланс FROM BankDetails WHERE PK_номер_карты = @PK_номер_карты) - 
                (SELECT Цена FROM Subscription WHERE Наименование = @Наименование) AS Баланс 
            FROM Subscription 
            WHERE Наименование = @Наименование";

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Наименование", fmFormSubcription.egoldsCard2.TextHeader);
                    cmd.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);

                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            sGetPK = dr["PK_подписки"].ToString();
                            CustomClass.sActiveSub = fmFormSubcription.egoldsCard2.TextHeader;
                            CustomClass.sPkSub = sGetPK;

                            // Получаем баланс
                            iUpdateBalance = dr.IsDBNull(dr.GetOrdinal("Баланс")) ? 0 : dr.GetInt32(dr.GetOrdinal("Баланс"));
                            iUpdateBalance = Math.Max(iUpdateBalance, 0); // Убедимся, что баланс не отрицательный
                        }
                    }
                }

                // Обновляем пользователя с новой подпиской и датами
                string updateUserQuery = @"
            UPDATE Users 
            SET 
                FK_Подписка = @FK_Подписка, 
                Дата_оформления = @Дата_оформления, 
                Дата_окончания = @Дата_окончания 
            WHERE 
                PK_Зачётка = @PK_Зачётка";

                using (MySqlCommand updateUserCmd = new MySqlCommand(updateUserQuery, conn))
                {
                    updateUserCmd.Parameters.AddWithValue("@FK_Подписка", CustomClass.sPkSub);
                    updateUserCmd.Parameters.AddWithValue("@Дата_оформления", DateTime.Now);
                    updateUserCmd.Parameters.AddWithValue("@Дата_окончания", DateTime.Now.AddMonths(1));
                    updateUserCmd.Parameters.AddWithValue("@PK_Зачётка", CustomClass.sNumberGradebook);

                    await updateUserCmd.ExecuteNonQueryAsync();
                }

                // Обновляем баланс в BankDetails
                string updateBalanceQuery = "UPDATE BankDetails SET Баланс = @Баланс WHERE PK_номер_карты = @PK_номер_карты";
                using (MySqlCommand updateBalanceCmd = new MySqlCommand(updateBalanceQuery, conn))
                {
                    updateBalanceCmd.Parameters.AddWithValue("@Баланс", iUpdateBalance);
                    updateBalanceCmd.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);

                    await updateBalanceCmd.ExecuteNonQueryAsync();
                }
            }

            CustomClass.Alert("Подписка " + string.Format("({0})", CustomClass.sActiveSub) + " успешно оформлена", Form_Alert.enmType.Success);
        } /// Логика обновления данных пользователя при оформлении подписки на художественную литературу

        public async static Task GetQueryUpdateScientificSubscription(FmFormSubcription fmFormSubcription)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sGetPK;
                int iUpdateBalance = 0;

                // Получаем PK подписки и обновляем пользователя
                string sQuery = @"
            SELECT 
                PK_подписки, 
                (SELECT Баланс FROM BankDetails WHERE PK_номер_карты = @PK_номер_карты) - 
                (SELECT Цена FROM Subscription WHERE Наименование = @Наименование) AS Баланс 
            FROM Subscription 
            WHERE Наименование = @Наименование";

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Наименование", fmFormSubcription.egoldsCard3.TextHeader);
                    cmd.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);

                    using (MySqlDataReader dr = await cmd.ExecuteReaderAsync())
                    {
                        if (await dr.ReadAsync())
                        {
                            sGetPK = dr["PK_подписки"].ToString();
                            CustomClass.sActiveSub = fmFormSubcription.egoldsCard3.TextHeader;
                            CustomClass.sPkSub = sGetPK;

                            // Получаем баланс
                            iUpdateBalance = dr.IsDBNull(dr.GetOrdinal("Баланс")) ? 0 : dr.GetInt32(dr.GetOrdinal("Баланс"));
                            iUpdateBalance = Math.Max(iUpdateBalance, 0); // Убедимся, что баланс не отрицательный
                        }
                    }
                }

                // Обновляем данные пользователя
                string updateUserQuery = @"
            UPDATE Users 
            SET 
                FK_Подписка = @FK_Подписка, 
                Дата_оформления = @Дата_оформления, 
                Дата_окончания = @Дата_окончания 
            WHERE 
                PK_Зачётка = @PK_Зачётка";

                using (MySqlCommand updateUserCmd = new MySqlCommand(updateUserQuery, conn))
                {
                    updateUserCmd.Parameters.AddWithValue("@FK_Подписка", CustomClass.sPkSub);
                    updateUserCmd.Parameters.AddWithValue("@Дата_оформления", DateTime.Now);
                    updateUserCmd.Parameters.AddWithValue("@Дата_окончания", DateTime.Now.AddMonths(1));
                    updateUserCmd.Parameters.AddWithValue("@PK_Зачётка", CustomClass.sNumberGradebook);

                    await updateUserCmd.ExecuteNonQueryAsync();
                }

                // Обновляем баланс в BankDetails
                string updateBalanceQuery = "UPDATE BankDetails SET Баланс = @Баланс WHERE PK_номер_карты = @PK_номер_карты";
                using (MySqlCommand updateBalanceCmd = new MySqlCommand(updateBalanceQuery, conn))
                {
                    updateBalanceCmd.Parameters.AddWithValue("@Баланс", iUpdateBalance);
                    updateBalanceCmd.Parameters.AddWithValue("@PK_номер_карты", CustomClass.sBankDetails);

                    await updateBalanceCmd.ExecuteNonQueryAsync();
                }
            }

            CustomClass.Alert("Подписка " + string.Format("({0})", CustomClass.sActiveSub) + " успешно оформлена", Form_Alert.enmType.Success);
        } /// Логика обновления данных пользователя при оформлении подписки на научную литературу

        public async static Task GetBuySubcriptionOnMonth(FmFormSubcription fmFormSubcription)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sQuery = "SELECT Цена FROM Subscription WHERE PK_подписки = 1";
                decimal subscriptionCost;

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    // Получаем цену подписки
                    object result = await cmd.ExecuteScalarAsync();
                    if (result != null && decimal.TryParse(result.ToString(), out subscriptionCost))
                    {
                        // Удаляем последние три символа и преобразуем в decimal
                        decimal balance = Convert.ToDecimal(CustomClass.sBalance.Substring(0, CustomClass.sBalance.Length - 3));
                        decimal modifiedCost = subscriptionCost; // У нас уже есть цена в виде decimal

                        // Проверяем баланс
                        if (balance < modifiedCost)
                        {
                            CustomClass.Alert("Недостаточно средств на балансе...", Form_Alert.enmType.Error);
                        }
                        else
                        {
                            FormSubscriptionClass.CallFormConfirmSubcrtiptionOnMonth(fmFormSubcription);
                        }
                    }
                    else
                    {
                        CustomClass.Alert("Не удалось получить стоимость подписки.", Form_Alert.enmType.Error);
                    }
                }
            }
        } /// Проверка на возможность оформлении подписки на месяц в системе

        public async static Task GetBuyArtisticSubcription(FmFormSubcription fmFormSubcription)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sQuery = "SELECT Цена FROM Subscription WHERE PK_подписки = 2";
                decimal subscriptionCost;

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    object result = await cmd.ExecuteScalarAsync();
                    if (result != null && decimal.TryParse(result.ToString(), out subscriptionCost))
                    {
                        // Удаляем последние три символа и преобразуем в decimal
                        decimal balance = Convert.ToDecimal(CustomClass.sBalance.Substring(0, CustomClass.sBalance.Length - 3));
                        decimal modifiedCost = subscriptionCost; // У нас уже есть цена в виде decimal

                        // Проверяем баланс
                        if (balance < modifiedCost)
                        {
                            CustomClass.Alert("Недостаточно средств на балансе...", Form_Alert.enmType.Error);
                        }
                        else
                        {
                            FormSubscriptionClass.CallFormConfirmArtisticSubcrtiption(fmFormSubcription);
                        }
                    }
                    else
                    {
                        CustomClass.Alert("Не удалось получить стоимость подписки.", Form_Alert.enmType.Error);
                    }
                }
            }
        } /// Проверка на возможность оформлении подписки на художественную литературу в системе

        public async static Task GetBuyScientificSubcription(FmFormSubcription fmFormSubcription)
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                string sQuery = "SELECT Цена FROM Subscription WHERE PK_подписки = 3";
                decimal subscriptionCost = 0;

                using (MySqlCommand cmd = new MySqlCommand(sQuery, conn))
                {
                    object result = await cmd.ExecuteScalarAsync();
                    if (result != null && decimal.TryParse(result.ToString(), out subscriptionCost))
                    {
                        // Удаляем последние три символа и преобразуем в decimal
                        decimal balance;
                        if (!decimal.TryParse(CustomClass.sBalance.Substring(0, CustomClass.sBalance.Length - 3), out balance))
                        {
                            CustomClass.Alert("Ошибка при чтении баланса.", Form_Alert.enmType.Error);
                            return;
                        }

                        // Проверяем баланс
                        if (balance < subscriptionCost)
                        {
                            CustomClass.Alert("Недостаточно средств на балансе...", Form_Alert.enmType.Error);
                        }
                        else
                        {
                            FormSubscriptionClass.CallFormConfirmScientificSubcrtiption(fmFormSubcription);
                        }
                    }
                    else
                    {
                        CustomClass.Alert("Не удалось получить стоимость подписки.", Form_Alert.enmType.Error);
                    }
                }
            }
        } /// Проверка на возможность оформлении подписки на научную литературу в системе

        public async static Task GetUserAction(FmFormSubcription fmFormSubcription) 
        {
            await GetUpdateBankData();
            await GetUpdateSubscriptionData();

            GetComponentTile(fmFormSubcription);

            if (CustomClass.bUserWantSub && CustomClass.bWantSubToMonth)
            {
                await GetQueryUpdateSubscriptionOnMonth(fmFormSubcription);
                CustomClass.CallAnimationCloseForm(fmFormSubcription);
            }

            if (CustomClass.bUserWantSub && CustomClass.bWantSubArtistic)
            {
                await GetQueryUpdateArtisticSubscription(fmFormSubcription);
                CustomClass.CallAnimationCloseForm(fmFormSubcription);
            }

            if (CustomClass.bUserWantSub && CustomClass.bWantSubScientific)
            {
                await GetQueryUpdateScientificSubscription(fmFormSubcription);
                CustomClass.CallAnimationCloseForm(fmFormSubcription);
            }
        } /// Описания логики в случае выбранных ранее действий
    }
}
