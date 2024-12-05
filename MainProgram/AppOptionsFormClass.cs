/// <summary>
//Название файла - AppOptionsFormClass.cs.
/// !--------------------------------Описание---------------------------!:
// Класс AppOptionsFormClass, описущий различные вариации настроек приложения на клиентском уровне
// Файл поделен на две части:
// Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем
// Часть 2 - Программная логика заданных компонентов и последующая их обработка

/// <summary>
/// <param name="FmAppOptionsForm"></param>
///


using WMPLib;
using CustomAlertBoxDemo;
using CustomLibraryClass;

namespace online_library_for_educ_inst
{
    public class AppOptionsFormClass
    {
        internal static WindowsMediaPlayer WMP;

        // Часть 1 - Описание поведения компонентов при их наведении и потери фокуса пользователем

        public static void CallShowNotificationMessage(FmAppOptionsForm fmAppOptionsForm)
        {
            CustomClass.Alert("Настройки приложения", Form_Alert.enmType.Warning);
        }



        // Часть 2 - Программная логика заданных компонентов и последующая их обработка

        public static void GetOffOrOnSound(FmAppOptionsForm fmAppOptionsForm)
        {
            WMP = new WindowsMediaPlayer();

            if (fmAppOptionsForm.MToggleSoundOptions.Checked)
            {
                WMP.settings.volume = 50;
                CustomClass.Alert("Звуковые эффекты включены!", Form_Alert.enmType.Info);

                fmAppOptionsForm.LblMessageForSound.Text = "Выключить звуковые эффекты";
            }
            else
            {
                WMP.settings.volume = 0;
                CustomClass.Alert("Звуковые эффекты выключены!", Form_Alert.enmType.Info);
                fmAppOptionsForm.LblMessageForSound.Text = "Включить звуковые эффекты";
            }
        }
    }
}
