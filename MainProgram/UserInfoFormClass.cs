
/// <summary>
//Название файла - UserInfoFormClass.cs.
/// !--------------------------------Описание---------------------------!:
// Класс UserInfoFormClass.cs - выводит всю информацию о текущем пользователе. Файл поделен на две части:
// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
// Часть 2 - Работа с БД и описание логики валидации данных 

/// <summary>
/// <param name="FmUserInfoForm"></param>
/// 
using System.Drawing;
using CustomLibraryClass;


namespace online_library_for_educ_inst
{
    public class UserInfoFormClass
    {
        public static void GetDataUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.LblRecordBook.Text = CustomClass.sNumberGradebook.ToString();
            fmUserInfoForm.LblNickName.Text = CustomClass.sNickNameNewUser.ToString();
            fmUserInfoForm.LblSexUser.Text = CustomClass.sSexNewUser.ToString();

            fmUserInfoForm.LblBankDetails.Text = CustomClass.sBankDetails.ToString();
            fmUserInfoForm.LblCVVCode.Text = CustomClass.sCVV.ToString();
            fmUserInfoForm.LblBalanceUser.Text = CustomClass.sBalance.ToString();

            if (CustomClass.sSexNewUser == "Женщина")
                fmUserInfoForm.PictUserLogo.Image = Properties.Resources.ShowFemaleProfile_128X128;

            if (CustomClass.sSexNewUser == "Мужчина")
                fmUserInfoForm.PictUserLogo.Image = Properties.Resources.ShowMaleProfile128X128;
        } /// Основной метод. Получает данные о конкретом пользователе, используя заранее заготовленные поля, которые хранят в себе результаты выборки

        public static void GetLowerComponentTile(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.LowerComponentTile.Text = "Данные профиля: " + CustomClass.sNickNameNewUser;
        } /// Вывод краткой информации о профиле в самом нижнем компоненте формы

        public static void CallOnMouseEnterPictRecordBook(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.ToolTipHelpUser.SetToolTip(fmUserInfoForm.PictRecordBook, "номер зачётной книжки...");
            fmUserInfoForm.PictRecordBook.Image = Properties.Resources.PictRegRecordBookCursored;
            fmUserInfoForm.LblRecordBook.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictRecordBook(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictRecordBook.Image = Properties.Resources.PictRegRecordBook;
            fmUserInfoForm.LblRecordBook.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterLblRecordBook(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictRecordBook.Image = Properties.Resources.PictRegRecordBookCursored;
            fmUserInfoForm.LblRecordBook.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveLblRecordBook(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictRecordBook.Image = Properties.Resources.PictRegRecordBook;
            fmUserInfoForm.LblRecordBook.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictNickname(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.ToolTipHelpUser.SetToolTip(fmUserInfoForm.PictNickname, "ваш никнейм в приложении...");
            fmUserInfoForm.PictNickname.Image = Properties.Resources.PictRegNickNameCursored;
            fmUserInfoForm.LblNickName.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictNickname(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictNickname.Image = Properties.Resources.PictRegNickName;
            fmUserInfoForm.LblNickName.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterLblNickName(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictNickname.Image = Properties.Resources.PictRegNickNameCursored;
            fmUserInfoForm.LblNickName.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveLblNickName(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictNickname.Image = Properties.Resources.PictRegNickName;
            fmUserInfoForm.LblNickName.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictSexUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.ToolTipHelpUser.SetToolTip(fmUserInfoForm.PictSexUser, "ваша гендерная принадлежность... ");
            fmUserInfoForm.PictSexUser.Image = Properties.Resources.PictRegSexCursored;
            fmUserInfoForm.LblSexUser.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictSexUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictSexUser.Image = Properties.Resources.PictRegSex;
            fmUserInfoForm.LblSexUser.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterLblSexUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictSexUser.Image = Properties.Resources.PictRegSexCursored;
            fmUserInfoForm.LblSexUser.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveLblSexUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictSexUser.Image = Properties.Resources.PictRegSex;
            fmUserInfoForm.LblSexUser.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictBankDetails(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.ToolTipHelpUser.SetToolTip(fmUserInfoForm.PictBankDetails, "номер вашей банковской карты...");
            fmUserInfoForm.PictBankDetails.Image = Properties.Resources.BankDetailsCursored;
            fmUserInfoForm.LblBankDetails.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictBankDetails(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictBankDetails.Image = Properties.Resources.BankDetails;
            fmUserInfoForm.LblBankDetails.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterLblBankDetails(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictBankDetails.Image = Properties.Resources.BankDetailsCursored;
            fmUserInfoForm.LblBankDetails.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveLblBankDetails(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictBankDetails.Image = Properties.Resources.BankDetails;
            fmUserInfoForm.LblBankDetails.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictCVVCode(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.ToolTipHelpUser.SetToolTip(fmUserInfoForm.PictCVVCode, "CVV-код карты...");
            fmUserInfoForm.PictCVVCode.Image = Properties.Resources.CVVCodeCursored;
            fmUserInfoForm.LblCVVCode.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictCVVCode(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictCVVCode.Image = Properties.Resources.CVVCode;
            fmUserInfoForm.LblCVVCode.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterLblCVVCode(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictCVVCode.Image = Properties.Resources.CVVCodeCursored;
            fmUserInfoForm.LblCVVCode.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveLblCVVCode(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictCVVCode.Image = Properties.Resources.CVVCode;
            fmUserInfoForm.LblCVVCode.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictBalanceUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.ToolTipHelpUser.SetToolTip(fmUserInfoForm.PictBalanceUser, "баланс карты...");
            fmUserInfoForm.PictBalanceUser.Image = Properties.Resources.BalanceUserCursored;
            fmUserInfoForm.PictRubSign.Image = Properties.Resources.RubSignCursored;
            fmUserInfoForm.LblBalanceUser.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeavePictBalanceUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictBalanceUser.Image = Properties.Resources.BalanceUser;
            fmUserInfoForm.PictRubSign.Image = Properties.Resources.RubSign;
            fmUserInfoForm.LblBalanceUser.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterLblBalanceUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictBalanceUser.Image = Properties.Resources.BalanceUserCursored;
            fmUserInfoForm.PictRubSign.Image = Properties.Resources.RubSignCursored;
            fmUserInfoForm.LblBalanceUser.ForeColor = Color.ForestGreen;
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseLeaveLblBalanceUser(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.PictBalanceUser.Image = Properties.Resources.BalanceUser;
            fmUserInfoForm.PictRubSign.Image = Properties.Resources.RubSign;
            fmUserInfoForm.LblBalanceUser.ForeColor = Color.MidnightBlue;
        } // Вызов анимации для компонента если курсор убран с области компонента

        public static void CallOnMouseEnterPictRubSign(FmUserInfoForm fmUserInfoForm)
        {
            fmUserInfoForm.ToolTipHelpUser.SetToolTip(fmUserInfoForm.PictRubSign, "валюта...");
            fmUserInfoForm.PictRubSign.Image = Properties.Resources.RubSignCursored;
        }     // Вызов анимации для компонента если на него наведен курсор мыши
    }
}
