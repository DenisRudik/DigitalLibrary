/// <summary>
/// Название файла - FormGenreBookClass.cs.
/// !--------------------------------Описание---------------------------!:
/// Класс FormGenreBookClass описует последующие действия пользователя после оформления подписки, иными словами, форма для выбора литературы в системе
/// Файл делится на две части:
/// Часть 1 - Описание поведения компонентов на форме и то как с ними взаимодействует пользователь (различные анимации появления, передвижения объектов)
/// Часть 2 - Описание логики данных компонентов
/// </summary>
/// <param name="fmFormGenreBook"></param>
/// 


using System.Drawing;
using System.Threading.Tasks;
using CustomAlertBoxDemo;
using CustomLibraryClass;
using MySqlConnector;

namespace online_library_for_educ_inst
{
    public class FormGenreBookClass
    {
        
        /// Часть 1 - Описание поведения компонентов на форме и то как с ними взаимодействует пользователь (различные анимации появления, передвижения объектов) 


        public static void SetStyleForm(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.Style = MetroFramework.MetroColorStyle.Blue;
            fmFormGenreBook.Theme = MetroFramework.MetroThemeStyle.Dark;
        } /// Метод который задает стили для формы

        public static void ShowComponentTile(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.TopComponentTile.Text = "Цифровая настольная библиотека, " + "активная подписка " + string.Format("({0})", CustomClass.sActiveSub);
            fmFormGenreBook.LowerComponentTile.Text = "Аккаунт: " + CustomClass.sNickNameNewUser;
        } /// Вывод краткой информации об аккаунте и активной подписки

        public static void LoadCurrentSubscriptionPicture(FmFormGenreBook fmFormGenreBook)
        {
            if (CustomClass.sSubscriptionNewUser == "1")
                fmFormGenreBook.PictSub.Image = Properties.Resources.DigitalLibrary;

            if (CustomClass.sSubscriptionNewUser == "2")
                fmFormGenreBook.PictSub.Image = Properties.Resources.BookLove;

            if (CustomClass.sSubscriptionNewUser == "3")
                fmFormGenreBook.PictSub.Image = Properties.Resources.BookMap;
        } /// Загрузка иконки выбранной подписки в главном меню приложения

        public static void LoadLblMessage(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblTopText.Text = CustomClass.sNickNameNewUser + ", выбери необходимый жанр литературы...";
        } /// Вывод текста на форме для пользователя

        public static void GetComponentsForm(FmFormGenreBook fmFormGenreBook)
        {
            if (CustomClass.sSubscriptionNewUser == "1")
                CallShowFieldsForSubOnMonth(fmFormGenreBook);

            if (CustomClass.sSubscriptionNewUser == "2")
                CallHideFieldsForArtisticSub(fmFormGenreBook);

            if (CustomClass.sSubscriptionNewUser == "3")
                CallHideFieldsForScientificSub(fmFormGenreBook);
        } /// Метод, определяющий какие компоненты скрыть от пользователя в зависимости от оформленной подписки

        public static void CallShowFieldsForSubOnMonth(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblTextScientificSub.Visible = true;
            fmFormGenreBook.LblForBooks.Visible = true;
            fmFormGenreBook.mComBoxGenreBooks.Visible = true;
            fmFormGenreBook.LblForArticle.Visible = true;
            fmFormGenreBook.mComBoxGenreArticle.Visible = true;
            fmFormGenreBook.PictSeparator.Visible = true;

            fmFormGenreBook.LblTextArtisticSub.Visible = true;
            fmFormGenreBook.LblForNovel.Visible = true;
            fmFormGenreBook.mComBoxGenreNovel.Visible = true;
            fmFormGenreBook.LblForStory.Visible = true;
            fmFormGenreBook.mComBoxGenreStory.Visible = true;
            fmFormGenreBook.LblForPoem.Visible = true;
            fmFormGenreBook.mComBoxGenrePoem.Visible = true;
            fmFormGenreBook.LblForHorrors.Visible = true;
            fmFormGenreBook.mComBoxGenreHorrors.Visible = true;
            fmFormGenreBook.PictSeparator.Visible = true;
        } /// Скрыть компоненты если оформлена подписка на месяц

        public static void CallHideFieldsForArtisticSub(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblTextScientificSub.Visible = false;
            fmFormGenreBook.LblForBooks.Visible = false;
            fmFormGenreBook.mComBoxGenreBooks.Visible = false;
            fmFormGenreBook.LblForArticle.Visible = false;
            fmFormGenreBook.mComBoxGenreArticle.Visible = false;
            fmFormGenreBook.PictSeparator.Visible = false;
        } /// Скрыть компоненты если оформлена подписка на художественную литературу

        public static void CallHideFieldsForScientificSub(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblTextArtisticSub.Visible = false;
            fmFormGenreBook.LblForNovel.Visible = false;
            fmFormGenreBook.mComBoxGenreNovel.Visible = false;
            fmFormGenreBook.LblForStory.Visible = false;
            fmFormGenreBook.mComBoxGenreStory.Visible = false;
            fmFormGenreBook.LblForPoem.Visible = false;
            fmFormGenreBook.mComBoxGenrePoem.Visible = false;
            fmFormGenreBook.LblForHorrors.Visible = false;
            fmFormGenreBook.mComBoxGenreHorrors.Visible = false;
            fmFormGenreBook.PictSeparator.Visible = false;
        } /// Скрыть компоненты если оформлена подписка на научную литературу

        public static void CallOnMouseEnterPictSub(FmFormGenreBook fmFormGenreBook)
        {
            if (CustomClass.sSubscriptionNewUser == "1")
                fmFormGenreBook.ToolTipHelpUser.SetToolTip(fmFormGenreBook.PictSub, "Действующая подписка на этом аккаунте - " + string.Format("({0})", "Подписка на месяц"));

            if (CustomClass.sSubscriptionNewUser == "2")
                fmFormGenreBook.ToolTipHelpUser.SetToolTip(fmFormGenreBook.PictSub, "Действующая подписка на этом аккаунте - " + string.Format("({0})", "Художественная литература"));

            if (CustomClass.sSubscriptionNewUser == "3")
                fmFormGenreBook.ToolTipHelpUser.SetToolTip(fmFormGenreBook.PictSub, "Действующая подписка на этом аккаунте - " + string.Format("({0})", "Учебная литература"));
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEntermComBoxGenreNovel(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblForNovel.ForeColor = Color.Chartreuse;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEntermComBoxGenrePoem(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblForPoem.ForeColor = Color.Chartreuse;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEntermComBoxGenreStory(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblForStory.ForeColor = Color.Chartreuse;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEntermComBoxGenreHorrors(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblForHorrors.ForeColor = Color.Chartreuse;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEntermComBoxGenreBooks(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblForBooks.ForeColor = Color.Chartreuse;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } // Вызов анимации для компонента если на него наведен курсор мыши

        public static void CallOnMouseEntermComBoxGenreArticle(FmFormGenreBook fmFormGenreBook)
        {
            fmFormGenreBook.LblForArticle.ForeColor = Color.Chartreuse;
            CustomClass.PlaySoundEffect(Form_Alert.enmNamesOfSoundProject.SoundCursor.ToString());
        } // Вызов анимации для компонента если на него наведен курсор мыши









        /// Часть 2 - Описание логики данных компонентов

        public static async Task GetDataGenre(FmFormGenreBook fmFormGenreBook) 
        {
            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand query = conn.CreateCommand();

                query.CommandText = "SELECT `Название` FROM NameBook WHERE `PK_Номер_книги` IN (1,2)";

                using (MySqlDataReader reader = await query.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        fmFormGenreBook.mComBoxGenreNovel.Items.Add(reader["Название"]).ToString();
                    }
                }
                await query.ExecuteNonQueryAsync();
            }

            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand query = conn.CreateCommand();

                query.CommandText = "SELECT `Название` FROM NameBook WHERE `PK_Номер_книги` IN (3,4)";

                using (MySqlDataReader reader = await query.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        fmFormGenreBook.mComBoxGenreStory.Items.Add(reader["Название"]).ToString();
                    }
                }
                await query.ExecuteNonQueryAsync();
            }

            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand query = conn.CreateCommand();

                query.CommandText = "SELECT `Название` FROM NameBook WHERE `PK_Номер_книги` IN (9,10)";

                using (MySqlDataReader reader = await query.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        fmFormGenreBook.mComBoxGenrePoem.Items.Add(reader["Название"]).ToString();
                    }
                }
                await query.ExecuteNonQueryAsync();
            }

            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand query = conn.CreateCommand();

                query.CommandText = "SELECT `Название` FROM NameBook WHERE `PK_Номер_книги` IN (11,12)";

                using (MySqlDataReader reader = await query.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        fmFormGenreBook.mComBoxGenreHorrors.Items.Add(reader["Название"]).ToString();
                    }
                }
                await query.ExecuteNonQueryAsync();
            }

            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand query = conn.CreateCommand();

                query.CommandText = "SELECT `Название` FROM NameBook WHERE `PK_Номер_книги` IN (5,6)";

                using (MySqlDataReader reader = await query.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        fmFormGenreBook.mComBoxGenreBooks.Items.Add(reader["Название"]).ToString();
                    }
                }
                await query.ExecuteNonQueryAsync();
            }

            using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
            {
                await conn.OpenAsync();

                MySqlCommand query = conn.CreateCommand();

                query.CommandText = "SELECT `Название` FROM NameBook WHERE `PK_Номер_книги` IN (7,8)";

                using (MySqlDataReader reader = await query.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        fmFormGenreBook.mComBoxGenreArticle.Items.Add(reader["Название"]).ToString();
                    }
                }
                await query.ExecuteNonQueryAsync();
            }
        } /// Получения информации из локальной БД об наименование каждой книги и последующей записи в пользовательский компонент

        public static async Task GetNovelBooks(FmFormGenreBook fmFormGenreBook) 
        {
            if (fmFormGenreBook.mComBoxGenreNovel.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '978-0-06-112008-4');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Властелин_колец.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Властелин колец ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }

            if (fmFormGenreBook.mComBoxGenreNovel.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '978-0-7432-6049-6');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Три_мушкетера.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Три мушкетера ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }
        } /// Осуществеление записи в базу данных конкретной книги в жанре "роман" которую выбрал пользователь для чтения. В дальнейшем это информация отображается в личном кабинете

        public static async Task GetPoemBooks(FmFormGenreBook fmFormGenreBook)
        {
            if (fmFormGenreBook.mComBoxGenrePoem.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '222-3-4444-555-666-77');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Мертвые_души.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Мертвые души ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }

            if (fmFormGenreBook.mComBoxGenrePoem.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '656-235-235-789-45');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Руслан_и_людмила.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Руслан и Людмила ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }
        } /// Осуществеление записи в базу данных конкретной книги в жанре "поэма" которую выбрал пользователь для чтения. В дальнейшем это информация отображается в личном кабинете

        public static async Task GetStoryBooks(FmFormGenreBook fmFormGenreBook)
        {
            if (fmFormGenreBook.mComBoxGenreStory.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '978-0-306-40615-7');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Хоббит.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Хоббит ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }

            if (fmFormGenreBook.mComBoxGenreStory.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '978-0-8129-7008-2');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Гарри_поттер.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Гарри Поттер ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }
        } /// Осуществеление записи в базу данных конкретной книги в жанре "фэнтези" которую выбрал пользователь для чтения. В дальнейшем это информация отображается в личном кабинете

        public static async Task GetHorrorBooks(FmFormGenreBook fmFormGenreBook)
        {
            if (fmFormGenreBook.mComBoxGenreHorrors.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '999-888-777-666-555');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Оно.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Оно ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }

            if (fmFormGenreBook.mComBoxGenreHorrors.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '8968-5747-48458-458');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Сияние.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Сияние ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }
        } /// Осуществеление записи в базу данных конкретной книги в жанре "ужасы" которую выбрал пользователь для чтения. В дальнейшем это информация отображается в личном кабинете

        public static async Task GetScientificBooks(FmFormGenreBook fmFormGenreBook)
        {
            if (fmFormGenreBook.mComBoxGenreBooks.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '978-3-16-148410-0');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "Python.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", "Основы языка Python ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }

            if (fmFormGenreBook.mComBoxGenreBooks.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '978-0-307-38706-0');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "С++.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", "Основы языка С++ ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }
        } /// Осуществеление записи в базу данных конкретной книги в жанре "научная литература" которую выбрал пользователь для чтения. В дальнейшем это информация отображается в личном кабинете

        public static async Task GetScientificArticles(FmFormGenreBook fmFormGenreBook)
        {
            if (fmFormGenreBook.mComBoxGenreArticle.SelectedIndex == 0)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '979-0-8888-99-88');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "С#.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", "Основы языка С# ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }

            if (fmFormGenreBook.mComBoxGenreArticle.SelectedIndex == 1)
            {
                using (MySqlConnection conn = new MySqlConnection(CustomClass.sConnStrToDB))
                {
                    await conn.OpenAsync();
                    MySqlCommand comm = conn.CreateCommand();
                    comm.CommandText = "INSERT INTO `Orders` (`FK_Зачётки`, `FK_Книги`) VALUES (@FK_Зачётки, '111-2-33333-444-55');";
                    comm.Parameters.AddWithValue("@FK_Зачётки", CustomClass.sNumberGradebook);

                    await comm.ExecuteNonQueryAsync();
                }

                string path = CustomClass.fullPathToBook + "ООП.pdf";
                System.Diagnostics.Process.Start(path);
                CustomClass.Alert("Файл " + string.Format("({0})", " Основы ООП ") + " открыт для чтения и скачивания!", Form_Alert.enmType.Success);
            }
        } /// Осуществеление записи в базу данных конкретной книги в жанре "научная статья" которую выбрал пользователь для чтения. В дальнейшем это информация отображается в личном кабинете


    }
}
