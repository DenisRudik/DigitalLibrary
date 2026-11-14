using System;
using System.Windows.Forms;

namespace online_library_for_educ_inst
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FmLoadingForm());

            if (CustomClass.isOpenedChooseRoleForm)
            {
                Application.Run(new FmChooseRoleForm());
            }

            if (CustomClass.isOpenedWelcomeForm)
            {
                Application.Run(new FmWelcomeForm());
            }

            if (CustomClass.isOpenedFormRegistration)
            {
                Application.Run(new FmRegistrationForm());
            }
            
            if (CustomClass.isCompleteAuthorization)
            {
                Application.Run(new FmLoadAccountForm());
            }

            if(CustomClass.isLoadAccount)
            {
                Application.Run(new FmMainFormApp());
                
            }

            
           
        }
    }
}
