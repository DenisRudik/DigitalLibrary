using System;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;
using CustomLibraryClass;
using modal;
using CustomAlertBoxDemo;
using System.Threading;
using System.Drawing.Drawing2D;
using System.Drawing;

namespace online_library_for_educ_inst
{
    public partial class FrmPass : MetroFramework.Forms.MetroForm
    {
        public static FrmPass FRM_Password_Form_Instance;
        public MetroFramework.Controls.MetroTextBox FRM_Password_Form_pswrd_txtbox;
        public MetroFramework.Controls.MetroButton FRM_Btn_ok;
        public FrmPass()
        {
            InitializeComponent();

            #region /// options for Password_Form
            FRM_Password_Form_Instance = this;
            FRM_Password_Form_pswrd_txtbox = TxtPass;
            FRM_Btn_ok = BtnOK;
            StartPosition = FormStartPosition.CenterScreen;
            Theme = MetroFramework.MetroThemeStyle.Dark;
            Style = MetroFramework.MetroColorStyle.Blue;
            #endregion
        }

        private void FrmPass_Load(object sender, EventArgs e)
        {
            GetRoundedShape();
        }

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

        private void CheckNullTxtBox()
        {
            if (string.IsNullOrEmpty(TxtPass.Text))
            {
                CustomClass.Alert("Не заполнены необходимые данные!", Form_Alert.enmType.Error);
            }
        }

        private void CheckData()
        {
            string sPasswordFromTxt = GetSHA256Hash(TxtPass.Text);
            string sPasswordHashFromDB = CustomClass.sPasswordNewUser;

            if (TxtPass.Text != "")
            {
                if (sPasswordFromTxt != sPasswordHashFromDB)
                {
                    CustomClass.Alert("Не верный пароль для данного номера зачётки!.Учтите его регистр", Form_Alert.enmType.Info);
                }
                else if (sPasswordFromTxt == sPasswordHashFromDB)
                {
                    AnimationClosingForm();
                    CustomClass.bUserWantSub = true;
                }
            }
        }

        private void AnimationClosingForm()
        {
            for (int i = 0; i < CustomClass.MAX_UNIT_OPACITY; i++)
            {
                Thread.Sleep(((int)CustomClass.enmTimeToClose.Form));
                Opacity -= CustomClass.UNIT_TRANSPARENCY;
            }
            Close();

        }

        private void AnimationAppearanceForm()
        {
            if (Opacity >= CustomClass.FULL_OPACITY)
                TimerToAnimationForm.Stop();
            else Opacity += CustomClass.TransparencyUnitsToForm.AuthorizationForm;
        }

        private void GetRoundedShape()
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - radius * 2, this.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            this.Region = new Region(path);
        }



        private void BtnOK_Click(object sender, EventArgs e)
        {
            CheckData();

            CheckNullTxtBox();

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            AnimationClosingForm();   
        }

        private void Form_password_FormClosing(object sender, FormClosingEventArgs e)
        {
           CustomClass.isOpenedFormPassword = false;
            
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            CustomClass.DisableSpace(e);
        }

        private void TimerToAnimationForm_Tick(object sender, EventArgs e)
        {
            AnimationAppearanceForm();
        }

       
    }
}
