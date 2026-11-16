
/// <summary>
//Название файла - CustomClass.cs.
/// !--------------------------------Описание---------------------------!:
/// Класс, предназначенный для обращение к полям, процедурам из проектов, которые находятся в одном решении.
/// В этом файле описывается существенная часть программной логики приложения "Digital Desktop Library".
/// <summary>
/// <param name="CustomClass.cs"></param>
/// 
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;




    public class CustomClass
    {


        public static bool isOpenedChooseRoleForm = false; /// поле для проверки открытости формы choose_role_form

        public static bool isOpenedWelcomeForm = false; /// поле, которое определяет, открыта ли приветстенная форма

        public static bool isOpenedFormPassword = false; /// поле, которое проверяет, открыта ли форма для ввода пароля

        public static bool isOpenedFormRegistration = false; /// поле, которое проверяет, открыта ли форма регестрации

        public static bool isRegistrationIsBeingCompleted = false; ///поле, которое определяет,был ли завершен процесс регестрации

        public static bool isBtnOkClicked = false; ///поле, которое определяет, была ли нажата кнопка в modalForm. Требуется для 
                                                    /// проверки сложного условия и вызова InsertNewUser() в MyClass

        public static bool isOpenedFormAuthorization = false; /// поле, которое определяет, открыта ли форма авторизации, 
                                                                  ///через форму Registration_Form. Это поле требуется для того,
                                                                  /// чтобы не создавать при вызове класса формы, 
                                                                  /// экземпляр новой формы, тем самым экономя память.

        public static bool isShowMessageRecoveryAssistantForm = false; /// поле, которое определяет, в какой момент вывести сообщение 
                                                                          /// пользователю о том, что номер зачётки автоматически вставлен
                                                                          /// мастером восстановления паролей

        public static bool isShowMessageRecoveredPassword = false; /// поле, которое определяет, в какой момент вывести сообщение о 
                                                                     /// восстановленом пароле
                                                                     /// 
        public static bool isCompleteAuthorization = false; /// поле, определяющая, завершилась ли авторизация пользователя успешно

        public static bool isLoadAccount = false; /// поле, определяющая завершилась ли загрузка аккаунта нового пользователя

        public static bool isLoadAdminRole = false; /// поле, которое определяет, выбрал ли пользователь роль администратора

        public static bool bUserWantCloseApp = false; //поле, определяющая, в какой момент времени вывести форму выхода с программы

        public static bool bUserWantResApp = false; // поле, определяющая, в какой момент времени перезагрузить приложение

        public static bool bBtnGoToAuthorizationFormClicked = false; /// поле, для проверки нажатости кнопки авторизоваться
                                                                     /// на форме Welcome_Form  

        public static bool bUserWantSub = false; /// поле, для проверки оформления подписки пользователем

        public static bool bWantSubToMonth = false; /// поле, определяющая что пользоватлеь хочет оформить подписку на месяц

        public static bool bWantSubArtistic = false; /// поле, определяющая что пользоватлеь хочет оформить подписку на художественную литературу

        public static bool bWantSubScientific = false; /// поле, определяющая что пользоватлеь хочет оформить подписку на научную литературу

        public static bool bSidebarStretch; /// поле, которое опредяет, когда именно открывать/скрывать боковое меню приложения

        public static bool bActivateAnimation; /// булево поле, которое определяет запускать анимацию открытия боковой панели "true" или нет "false"

        public static string sConnStrToDB = "server=localhost;user=root;database=DB_online_library;password=;"; /// строка подлкючения к БД MySQL

        public static string sPasswordForAdmin = "IDC"; /// пароль для доступа к форме сотрудника

        public static string sBufferNumberDocumentForRecoveryAssistant = null; /// поле для хранения номера зачётной книги с формы 
                                                                                    ///Authorization_Form. Данное поле используется как некий буфер, и при появлении мастера восстановления паролей,
                                                                                    /// компонент txt_user_number_document присвоит себе это значение.

        public static string sBufferRecoveredPassword = null;/// поле для хранения восстановленного пароля через мастер восстановления паролей. 
                                                               ///Данное поле используется как некий буфер, которое передаёт своё значение
                                                               ///методу процедуре Alert, объявленгого в этом классе 

        public static string sNumberGradebook = null; /// поле, которое хранит номёр зачётной книги читателя,который успешно авторизовался.
                                                         /// В БД данное поле является PK (Primary Key) для таблицы "читалель".

        public static string sNickNameNewUser = null; /// поле, которое хранит никнейм нового авторизированного читателя

        public static string sPasswordNewUser = null; /// поле, которое хранит пароль нового авторизированного читателя

        public static string sRecoveryCode = null; /// поле, которое хранит код восстановления нового авторизированного читателя

        public static string sSexNewUser = null; /// поле, которое хранит пол нового авторизированного читателя

        public static string sSubscriptionNewUser = null; /// поле, которое хранит информацию о подписке нового авторизированного читателя

        public static string sBankDetails = null; /// поле, которое хранит информацию о банковских данных нового авторизированного читателя

        public static string sCVV = null; /// поле, для хранения CVV-кода подлинности банковской карты текущего пользователя

        public static string sBalance = null; /// поле, для хранения актуального значения баланса текущего пользователя

        public static string sPathToFileLic = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + Path.DirectorySeparatorChar + "README.txt"; /// поле для хранения пути к файлу с лиценизонным соглашением

        public static string sSysUserName = Environment.UserName; /// системное имя пользователя

        public static string sPathProject = Directory.GetCurrentDirectory(); // поле, для получения информации о директории, в котором находится файл .exe


        public static string sFullPathToMaterials = Directory.GetParent(FormUsrAlert.pathProject).Parent.FullName + Path.DirectorySeparatorChar + "materials" +
                              Path.DirectorySeparatorChar; // поле для получения доступа к файлам из папки Materials

        public static string sResultValueComboboxMcombxSelectGenreBook = null; /// поле, для конвертации значения полученого из поля 
                                                                               /// object в string. Требуется для построения запросов
                                                                               /// на выборку

        public static string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*"; // символы для генерации пароля

        public static string fullPathToBook = Directory.GetParent(FormUsrAlert.pathProject).Parent.FullName + Path.DirectorySeparatorChar + "materials" +
                      Path.DirectorySeparatorChar + "Books" + Path.DirectorySeparatorChar;  // поле для получения доступа к файлам из папки Books

        public static string sNameBook = null;  /// поле, для хранения наименования выбранной литературы

        public static string sPKBook = null; /// поле, для хранения PK_литературы

        public static string sChooseBook = null; /// поле, для запроса на выборку

        public static string sActiveSub = null; /// наименование активной подписки пользователя

        public static string sNameSub; /// поля для выборки данных по подпискам

        public static string sTextSub; /// поля для выборки данных по подпискам

        public static string sCostSub; /// поля для выборки данных по подпискам

        public static string sPkSub; /// первичный ключ подписки

        public const int COUNT_DIGIT_NUMBER_CARD = 16; /// количество цифр у номера банковской карты

        public const int COUNT_DIGIT_FOR_DOCUMENT = 7; /// количество возможных цифр в зачётной книге

        public const int COUNT_INCORRECT_ATTEMPTS = 5; /// количество попыток на правильный ввод пароля для аккаунта

        public const int COUNT_DIGIT_CVV_CODE = 3; /// количество возможных цифр у CVV кода

        public const int TIME_TO_DRAWING = 50; /// время в миллисекундах для анимации прорисовки текста 

        public const int MAX_PASSWORD_LENGTH = 10; /// максимальное количество символов для генерации пароля

        public const int MAX_UNIT_OPACITY = 10; /// количество единиц прозрачности формы

        public const int MAX_NUMBER_CHARACTERS = 25; /// Максимальное количество символов, которое может задать пользователь при вводе нового никнейма

        public const int FULL_OPACITY = 1; /// 1 = 100 единицы прозрачности формы. 100 значит форма не прозрачна

        public const int AMOUNT_PICTURES = 21; /// количество различных иконок которые можно встретить в приветственном меню 

        public static int iCountWrongPassword = 0; /// переменная для подсчета количество допущенных ошибок при вводе пароля от аккаунта

        public static int iBalance = 0; /// изначальный баланс пользователя при регистрации

        public const double UNIT_TRANSPARENCY = 0.1; /// одна десятая единица прозрачности формы, нужна для инкрементации в теле цикла for

        private static SoundPlayer soundPlayer; /// поле для воспроизведение звуковых эффектов. Определена в директиве 
                                                ///System.Media   

        public static string[] sMeaningfulWords = { "Шепот", "Мелодия", "Путешествие", "Вдохновение", "Сияние", "Легкость", "Искра", "Оазис", 
                                                    "Приключение", "Радость", "Бриз", "Волшебство","Хрусталь", "Тайна","Лазурь", "Рассвет",
                                                     "Сказка", "Мироздание","Аромат", "Эхо", "Авиатор", "Верблюд", "Галактика","Искра",
                                                      "Небула", "Тигр", "Улитка", "Лимонад", "Пират", "Футбол", "Программирование","Скоросшиватель",
                                                        "Диагноз","Загадочный","Размахивать","Обмериться","Елочка","Фактура","Телятник",
                                                        "Коллаж","Заречье","Напудриться","Раздать","Смеяться","Уясниться","Щебень","Функционировать",
                                                            "Треск","Ствол","Доносить","Прислонить"}; ///// набор секретных слов 

        public static object objValueComboboxMcombxSelectGenreBook; /// поле, для хранение выбранного жанра пользователем из компонента

        

        public enum enmTimeToClose 
        {
            Form = 20,
            UpLoadingAccount = 50,
            LoadingBar = 100        
        } /// время в миллисекундах до приостановки потока

        public struct TransparencyUnitsToForm
        {
            public const double ChooseRoleForm = .02;
            public const double WelcomeForm = .02;
            public const double PasswordRecoveryAssistantForm = .05;
            public const double RegistrationForm = .07;
            public const double AuthorizationForm = .07;          
        } /// структура определяющая время для анимации открытия различных форм в системе

        private static SoundPlayer SoundPlayer
        {
            get
            {
                return soundPlayer;

            }

            set
            {
                soundPlayer = value;
                SoundPlayer.Play();
            }
        }
    /// <summary>
    /// Рисует фон формы: градиент, два световых пятна и три полупрозрачные волны.
    /// </summary>
    /// <returns>
    /// Готовый <see cref="Bitmap"/> или <c>null</c>, если ширина или высота меньше 1.
    /// Вызывающий код должен сам освободить его через <c>Dispose()</c>.
    /// WclientSize - высота формы клиента
    /// hClientSize - ширина формы клиента
    /// rIn - Первый параметр для начального градиента
    /// gIn - Второй параметр для начального градиента
    /// bIn - Третий параметр для начального градиента
    /// 
    /// rOut - Первый параметр для конечного градиента
    /// gOut - Второй параметр для конечного градиента
    /// bOut - Третий параметр для конечного градиента
    /// 
    /// 
    /// </returns>
    /// 
    public static Bitmap BuildBackgroundWin(int wClientSize, int hClientSize,
                                            int rIn, int gIn, int bIn, int rOut, int gOut, int bOut)

    {

        if (wClientSize < 1 || hClientSize < 1) return null;

        var bmp = new Bitmap(wClientSize, hClientSize);
        var g = Graphics.FromImage(bmp);


        g.SmoothingMode = SmoothingMode.AntiAlias;
        var rect = new Rectangle(0, 0, wClientSize, hClientSize);

        // 1. Основной градиент: тёмно-синий -> насыщенный голубой
        using (var br = new LinearGradientBrush(rect,
            Color.FromArgb(rIn, gIn, bIn), Color.FromArgb(rOut, gOut, bOut), 35f))
            g.FillRectangle(br, rect);

        // 2. Мягкое свечение в правом верхнем углу
        DrawGlow(g, new PointF(wClientSize * 0.85f, hClientSize * 0.15f), wClientSize * 0.45f, Color.FromArgb(90, 80, 200, 255));
        // и слева снизу
        DrawGlow(g, new PointF(wClientSize * 0.10f, hClientSize * 0.90f), wClientSize * 0.40f, Color.FromArgb(70, 120, 90, 255));

        // 3. Полупрозрачные волны
        DrawWave(g, wClientSize, hClientSize, 0.62f, 0.08f, Color.FromArgb(40, 255, 255, 255));
        DrawWave(g, wClientSize, hClientSize, 0.75f, 0.06f, Color.FromArgb(30, 0, 40, 120));
        DrawWave(g, wClientSize, hClientSize, 0.88f, 0.05f, Color.FromArgb(35, 0, 174, 221));

        return bmp;
    } 

    private static void DrawGlow(Graphics g, PointF c, float r, Color color)
    {
        var path = new GraphicsPath();
        path.AddEllipse(c.X - r, c.Y - r, r * 2, r * 2);
        var pg = new PathGradientBrush(path)
        {
            CenterColor = color,
            SurroundColors = new[] { Color.FromArgb(0, color) }
        };
        g.FillPath(pg, path);
    }
    // метод отрисовки свечения у заднего фона  


    private static void DrawWave(Graphics g, int w, int h, float yRel, float ampRel, Color color)
    {
        float y = h * yRel, a = h * ampRel;
        var path = new GraphicsPath();
        path.AddBezier(0, y, w * 0.25f, y - a * 2, w * 0.45f, y + a * 2, w * 0.60f, y);
        path.AddBezier(w * 0.60f, y, w * 0.78f, y - a * 1.5f, w * 0.90f, y + a, w, y - a * 0.5f);
        path.AddLine(w, y - a * 0.5f, w, h);
        path.AddLine(w, h, 0, h);
        path.CloseFigure();
        var br = new SolidBrush(color);
        g.FillPath(br, path);
    }
    // метод отрисовки волн заднего фона


    /// <summary>
    /// Форма оповещения для пользователя
    /// </summary>
    /// <returns>
    /// Аргументы метода:
    /// sMsg - сообщение, необходимое для отображения пользователю
    /// enmFormUsrAlert.enmType.type - статус окна оповещения  ("успешно - success", "внимание - warning", "критическая ошибка - critical")
    /// </returns>
    /// 

    public static void Alert(string msg, FormUsrAlert.enmType type) /// обязательный метод для создания кастомного AlertBox.
                                                                      /// Наследуется от родительского класса Control 
        {
            FormUsrAlert frm = new FormUsrAlert();
            frm.showAlert(msg, type);

        }
    /// <summary>
    /// метод для принудительного ввода кириллицы
    /// </summary>
    ///
    /// <returns>
    ///  Аргумент метода: e - Событие для нажатой клавиши
    /// </returns>

    public static void OnlyRussian(KeyPressEventArgs e) 
        {
            char k = e.KeyChar;
            if ((k < 'А' || k > 'я') && k != '\b' && k != 45)
            {
                e.Handled = true;
            }
        }
    /// <summary>
    /// метод для принудительного ввода цифр
    /// </summary>
    /// 
    /// <returns>
    /// Аргумент метода: e - Событие для нажатой клавиши
    /// </returns>

    public static void OnlyNum(KeyPressEventArgs e) 
        {
            if (!((e.KeyChar >= (char)48 && e.KeyChar <= (char)57 || e.KeyChar == (char)32) || (e.KeyChar == (char)8)
                || (e.KeyChar == (char)45) || (e.KeyChar == (char)44)))
                e.Handled = true;
        }

    /// <summary>
    /// метод для отключения клавишы space
    /// </summary>
    /// <returns>
    /// Аргумент метода: e - Событие для нажатой клавиши
    /// </returns>

    public static void DisableSpace (KeyPressEventArgs e) 
        {
            if (char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

    /// <summary>
    /// метод для блокировки ввода любых символов
    /// </summary>>
    /// <returns>
    /// Аргумент метода: e - Событие для нажатой клавиши
    /// </returns>


    public static void DisableSymbols(KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

    /// <summary>
    /// Вызов окна восстановления пароля для аккаунта 
    /// </summary>
    /// <returns>
    /// 
    /// </returns>>

    public static void ShowRecoveryPasswordForUser() 
        {
            Alert("Ваш восстановленный пароль : " + sBufferRecoveredPassword + " введите его!", FormUsrAlert.enmType.Info);
        }

    /// <summary>
    ///  Метод для проигрывания различных звуковых эффектов в завимости от такого, какого рода ошибку выдала система.
    ///  
    /// </summary>
    /// <returns>
    /// Аргумент метода: sNameSound  - наименование файла .wav в локальном корне проекта
    /// </returns>>
    /// 
    public static void PlaySoundEffect(string sNameSound)
        {
            SoundPlayer = new SoundPlayer(FormUsrAlert.fullPathToSound + sNameSound + ".wav");
        }
    /// <summary>
    ///  Метод для придания формам "округленности" по углам
    ///  
    /// </summary>
    /// <returns>
    /// Аргумент метода: sNameForm  - ссылка на конкретную форму в проекте (оператор this)
    /// </returns>>
    /// 

    public static void GetRoundedShapeForm(Form sNameForm)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20;
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(sNameForm.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(sNameForm.Width - radius * 2, sNameForm.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, sNameForm.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            sNameForm.Region = new Region(path);
        }

    /// <summary>
    ///  Реализация анимации закрытия формы 
    ///  
    /// </summary>
    /// <returns>
    /// Аргумент метода: sNameForm  - ссылка на конкретную форму в проекте (оператор this)
    /// </returns>>
    /// 

    public static void CallAnimationCloseForm(Form sNameForm)
        {
            for (int i = 0; i < MAX_UNIT_OPACITY; i++)
            {
                Thread.Sleep((int)enmTimeToClose.Form);
                sNameForm.Opacity -= UNIT_TRANSPARENCY;
            }
            sNameForm.Close();
        }

    /// <summary>
    /// Реализация анимации появления формы  
    ///  
    /// </summary>
    /// <returns>
    /// Аргументы метода: sNameForm  - ссылка на конкретную форму в проекте (оператор this)
    ///                   sNameTimerComponent - ссылка на компонент класса Timer к которому привязывается время анимации
    /// </returns>>
    /// 

    public static void CallAnimationAppearanceForm(Form sNameForm, System.Windows.Forms.Timer sNameTimerComponent)
        {
            if (sNameForm.Opacity >= FULL_OPACITY)
                sNameTimerComponent.Stop();
            else sNameForm.Opacity += UNIT_TRANSPARENCY;
        }

    /// <summary>
    ///  Асинхронный метода для подлючения к локальной БД 
    ///  
    /// </summary>
    /// <returns>
    /// Аргументы метода: sConnectionString  - строка подлкючения к БД MySQL (описана в CustomClass)
    ///                   bOpenConnToDb - булева переменная для запуска соединения с БД
    ///                   
    /// </returns>>
    /// 

    public async static Task GetConnToDBAsync(string ConnectionString, bool bOpenConnToDb)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    await conn.OpenAsync();

                    Alert("Соединение с сервером установлено!", FormUsrAlert.enmType.Info);

                    if (!bOpenConnToDb)
                    {
                        conn.Close();
                    }
                }
            }
            catch (MySqlException)
            {
                Alert("Возникла ошибка при попытке соединения с сервером!.Проверьте работу OsPanel", FormUsrAlert.enmType.Error);
            }
        } 
    }


