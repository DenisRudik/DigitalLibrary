
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using CustomAlertBoxDemo.Properties;

namespace CustomAlertBoxDemo
{
    public partial class Form_Alert : Form
    {
        private static SoundPlayer soundPlayer; /// поле для воспроизведение звуковых эффектов. Определена в директиве 
                                                ///System.Media  

        public static string pathProject = Directory.GetCurrentDirectory(); // поле, для получения информации о директории, в котором находится файл .exe


        public static string fullPathToSound = Directory.GetParent(pathProject).Parent.FullName + Path.DirectorySeparatorChar + "materials" +
                              Path.DirectorySeparatorChar + "Sound" + Path.DirectorySeparatorChar;  // поле для получения доступа к файлам из папки Sound

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

        public Form_Alert()
        {
            InitializeComponent();
        }

       public enum enmNamesOfSoundProject
        {
            Sound_Attention,
            Sound_Confirmed,
            Sound_Critical_Error,
            Sound_Critical_Error_2,
            Sound_For_Message_Box,
            SoundFormOpen,
            SoundClicked,
            SoundStartApp,
            SoundClose,
            SoundCursor 
        } /// тип, для перечисления различных звуков эффектов в системе

        public enum enmAction
        {
            wait,
            start,
            close
        } /// тип, перечисляющий различные состояния формы сообщения

        public enum enmType
        {
            Success,
            Warning,
            Error,
            Info
        }///тип, перечисляющий виды сообщений для пользователя


        private Form_Alert.enmAction action;

        private int x, y;
        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {
                case enmAction.wait:
                    timer1.Interval = 1500;
                    action = enmAction.close;
                    break;
                case enmAction.start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            action = enmAction.wait;
                        }
                    }
                    break;
                case enmAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;

                    this.Left -= 3;
                    if (Opacity == 0.0)
                    {
                        Close();
                    }
                    break;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enmAction.close;
        }

        public void showAlert(string msg, enmType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[fname];

                if (frm == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 10;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }
            this.x = Screen.PrimaryScreen.WorkingArea.Width - Width - 5;

            switch(type)
            {
                case enmType.Success:
                    Text = "Успешно!";
                    this.pictureBox1.Image = Resources.success;
                    this.BackColor = SystemColors.Highlight;
                    SoundPlayer = new SoundPlayer(fullPathToSound + enmNamesOfSoundProject.Sound_Confirmed + ".wav");

                    break;
                case enmType.Error:
                    Text = "Критическая ошибка!";
                    this.pictureBox1.Image = Resources.error;
                    this.BackColor = Color.DarkRed;
                    SoundPlayer = new SoundPlayer(fullPathToSound + enmNamesOfSoundProject.Sound_Critical_Error_2 + ".wav");
                    break;
                case enmType.Info:
                    Text = "Информация";
                    this.pictureBox1.Image = Resources.info;
                    this.BackColor = Color.RoyalBlue;
                    SoundPlayer = new SoundPlayer(fullPathToSound + enmNamesOfSoundProject.Sound_Attention + ".wav");
                    break;
                case enmType.Warning:
                    Text = "Внимание!";
                    this.pictureBox1.Image = Resources.warning;
                    this.BackColor = Color.DarkOrange;
                    SoundPlayer = new SoundPlayer(fullPathToSound + enmNamesOfSoundProject.Sound_For_Message_Box + ".wav");
                    break; 
            }
           

            this.lblMsg.Text = msg;

            this.Show();
            this.action = enmAction.start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }
    }
}
