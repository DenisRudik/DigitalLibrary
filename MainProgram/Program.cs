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

            if (CustomLibraryClass.CustomClass.isOpenedChooseRoleForm)
            {
                Application.Run(new FmChooseRoleForm());
            }

            if (CustomLibraryClass.CustomClass.isOpenedWelcomeForm)
            {
                Application.Run(new FmWelcomeForm());
            }

            if (CustomLibraryClass.CustomClass.isOpenedFormRegistration)
            {
                Application.Run(new FmRegistrationForm());
            }
            
            if (CustomLibraryClass.CustomClass.isCompleteAuthorization)
            {
                Application.Run(new FmLoadAccountForm());
            }

            if(CustomLibraryClass.CustomClass.isLoadAccount)
            {
                Application.Run(new FmMainFormApp());
                
            }

            
           
        }
    }
}
